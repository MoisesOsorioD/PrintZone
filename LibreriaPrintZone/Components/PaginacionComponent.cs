using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone.Components
{
    public class PaginacionComponent
    {
        private readonly Panel _panel;

        private int _paginaActual = 1;

        private readonly int _registrosPorPagina;

        private const int _maximoNumerosPagina = 10;

        private int _totalPaginas;

        private List<Button> _botones =
            new List<Button>();

        private List<object> _registros =
            new List<object>();

        private Action<List<object>>? _mostrarRegistros;


        public PaginacionComponent(
            Panel panel,
            int registrosPorPagina = 10)
        {
            _panel = panel;

            _registrosPorPagina =
                registrosPorPagina;

            ConfigurarPanel();
        }


        private void ConfigurarPanel()
        {
            _panel.Height = 59;

            _panel.BackColor =
                Color.Transparent;

            _panel.Anchor =
                AnchorStyles.Left |
                AnchorStyles.Right |
                AnchorStyles.Bottom;

            // IMPORTANTE:
            // El panel debe permanecer visible
            // aunque solamente exista una página.

            _panel.Visible = true;
        }


        public int PaginaActual =>
            _paginaActual;


        public int TotalPaginas =>
            _totalPaginas;


        // =========================================================
        // CONFIGURAR REGISTROS
        // =========================================================

        public void Configurar<T>(
            List<T> registros,
            Action<List<T>> mostrarRegistros)
        {
            if (registros == null)
                registros =
                    new List<T>();


            _registros =
                registros
                    .Cast<object>()
                    .ToList();


            _mostrarRegistros =
                lista =>
                {
                    mostrarRegistros(
                        lista
                            .Cast<T>()
                            .ToList()
                    );
                };


            _paginaActual = 1;


            CalcularTotalPaginas();


            MostrarPaginaActual();
        }


        // =========================================================
        // CALCULAR TOTAL DE PÁGINAS
        // =========================================================

        private void CalcularTotalPaginas()
        {
            _totalPaginas =
                (int)Math.Ceiling(
                    _registros.Count /
                    (double)_registrosPorPagina
                );


            // Aunque haya menos de una página
            // siempre tendremos al menos la página 1.

            if (_totalPaginas == 0)
                _totalPaginas = 1;
        }


        // =========================================================
        // MOSTRAR PÁGINA ACTUAL
        // =========================================================

        private void MostrarPaginaActual()
        {
            if (_totalPaginas == 0)
            {
                _paginaActual = 1;

                _mostrarRegistros?.Invoke(
                    new List<object>()
                );

                CrearBotonesPaginacion();

                return;
            }


            if (_paginaActual > _totalPaginas)
                _paginaActual =
                    _totalPaginas;


            int registrosASaltar =
                (_paginaActual - 1) *
                _registrosPorPagina;


            List<object> registrosPagina =
                _registros
                    .Skip(registrosASaltar)
                    .Take(_registrosPorPagina)
                    .ToList();


            _mostrarRegistros?.Invoke(
                registrosPagina
            );


            CrearBotonesPaginacion();
        }


        // =========================================================
        // CREAR BOTONES DE PAGINACIÓN
        // =========================================================

        private void CrearBotonesPaginacion()
        {
            _panel.Controls.Clear();

            _botones.Clear();


            // =====================================================
            // AHORA LA PAGINACIÓN SE CREA SIEMPRE
            // =====================================================

            _panel.Visible = true;


            // =====================================================
            // BOTÓN ANTERIOR
            // =====================================================

            Button btnAnterior =
                CrearBoton("‹");


            btnAnterior.Enabled =
                _paginaActual > 1;


            btnAnterior.Click +=
                (sender, e) =>
                {
                    PaginaAnterior();
                };


            _botones.Add(
                btnAnterior
            );


            // =====================================================
            // NÚMEROS DE PÁGINA
            // =====================================================

            int primeraPagina =
                CalcularPrimeraPagina();


            int ultimaPagina =
                Math.Min(
                    primeraPagina +
                    _maximoNumerosPagina - 1,
                    _totalPaginas
                );


            for (
                int i = primeraPagina;
                i <= ultimaPagina;
                i++
            )
            {
                int numeroPagina = i;


                Button btnPagina =
                    CrearBoton(
                        numeroPagina.ToString()
                    );


                if (
                    numeroPagina ==
                    _paginaActual
                )
                {
                    btnPagina.BackColor =
                        Color.FromArgb(
                            36,
                            111,
                            219
                        );


                    btnPagina.ForeColor =
                        Color.White;
                }


                btnPagina.Click +=
                    (sender, e) =>
                    {
                        IrAPagina(
                            numeroPagina
                        );
                    };


                _botones.Add(
                    btnPagina
                );
            }


            // =====================================================
            // BOTÓN SIGUIENTE
            // =====================================================

            Button btnSiguiente =
                CrearBoton("›");


            btnSiguiente.Enabled =
                _paginaActual <
                _totalPaginas;


            btnSiguiente.Click +=
                (sender, e) =>
                {
                    PaginaSiguiente();
                };


            _botones.Add(
                btnSiguiente
            );


            // =====================================================
            // AGREGAR BOTONES AL PANEL
            // =====================================================

            foreach (
                Button boton
                in _botones
            )
            {
                _panel.Controls.Add(
                    boton
                );
            }


            CentrarBotones();
        }


        // =========================================================
        // CALCULAR PRIMERA PÁGINA
        // =========================================================

        private int CalcularPrimeraPagina()
        {
            if (
                _totalPaginas <=
                _maximoNumerosPagina
            )
            {
                return 1;
            }


            int mitad =
                _maximoNumerosPagina / 2;


            int primeraPagina =
                _paginaActual - mitad;


            if (primeraPagina < 1)
                primeraPagina = 1;


            int ultimaPagina =
                primeraPagina +
                _maximoNumerosPagina - 1;


            if (
                ultimaPagina >
                _totalPaginas
            )
            {
                primeraPagina =
                    _totalPaginas -
                    _maximoNumerosPagina +
                    1;
            }


            return primeraPagina;
        }


        // =========================================================
        // CREAR BOTÓN
        // =========================================================

        private Button CrearBoton(
            string texto)
        {
            Button boton =
                new Button();


            boton.Text =
                texto;


            boton.Width =
                40;


            boton.Height =
                34;


            boton.FlatStyle =
                FlatStyle.Flat;


            boton.FlatAppearance
                .BorderSize = 1;


            boton.FlatAppearance
                .BorderColor =
                Color.FromArgb(
                    201,
                    219,
                    238
                );


            boton.BackColor =
                Color.White;


            boton.ForeColor =
                Color.FromArgb(
                    16,
                    42,
                    82
                );


            boton.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular
                );


            boton.Cursor =
                Cursors.Hand;


            boton.TextAlign =
                ContentAlignment.MiddleCenter;


            return boton;
        }


        // =========================================================
        // CENTRAR BOTONES
        // =========================================================

        private void CentrarBotones()
        {
            if (
                _botones.Count == 0
            )
            {
                return;
            }


            int separacion = 8;


            int anchoTotal =
                _botones.Sum(
                    boton =>
                        boton.Width
                );


            anchoTotal +=
                (
                    _botones.Count - 1
                ) *
                separacion;


            int posicionX =
                (
                    _panel.ClientSize.Width -
                    anchoTotal
                ) / 2;


            if (posicionX < 0)
                posicionX = 0;


            int posicionY =
                (
                    _panel.ClientSize.Height -
                    34
                ) / 2;


            foreach (
                Button boton
                in _botones
            )
            {
                boton.Location =
                    new Point(
                        posicionX,
                        posicionY
                    );


                posicionX +=
                    boton.Width +
                    separacion;
            }
        }


        // =========================================================
        // IR A UNA PÁGINA
        // =========================================================

        private void IrAPagina(
            int numeroPagina)
        {
            if (
                numeroPagina < 1 ||
                numeroPagina > _totalPaginas
            )
            {
                return;
            }


            _paginaActual =
                numeroPagina;


            MostrarPaginaActual();
        }


        // =========================================================
        // PÁGINA ANTERIOR
        // =========================================================

        private void PaginaAnterior()
        {
            if (
                _paginaActual <= 1
            )
            {
                return;
            }


            _paginaActual--;


            MostrarPaginaActual();
        }


        // =========================================================
        // PÁGINA SIGUIENTE
        // =========================================================

        private void PaginaSiguiente()
        {
            if (
                _paginaActual >=
                _totalPaginas
            )
            {
                return;
            }


            _paginaActual++;


            MostrarPaginaActual();
        }


        // =========================================================
        // ACTUALIZAR REGISTROS
        // =========================================================

        public void Actualizar<T>(
            List<T> registros)
        {
            if (registros == null)
                registros =
                    new List<T>();


            _registros =
                registros
                    .Cast<object>()
                    .ToList();


            CalcularTotalPaginas();


            if (
                _totalPaginas == 0
            )
            {
                _paginaActual = 1;
            }
            else if (
                _paginaActual >
                _totalPaginas
            )
            {
                _paginaActual =
                    _totalPaginas;
            }


            MostrarPaginaActual();
        }
    }
}