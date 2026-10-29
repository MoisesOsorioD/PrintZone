
using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;
using LibreriaPrintZone.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaPrintZone.Views
{
    public partial class frmProveedores : Form
    {
        private readonly ProveedoresController _controller;

        private readonly PaginacionComponent _paginacion;

        private readonly EntradasController _entradasController =
            new EntradasController();

        private List<Proveedore> _proveedores =
            new List<Proveedore>();

        private int _idProveedorSeleccionado = 0;


        public frmProveedores()
        {
            InitializeComponent();
            PanelRedondeado.Aplicar(panelPaginacion, 20);
            PanelRedondeado.Aplicar(panelCondicionesCompra, 20);
            PanelRedondeado.Aplicar(panelInformacionContacto, 20);
            PanelRedondeado.Aplicar(panelInformacionEmpresarial, 20);
            PanelRedondeado.Aplicar(panelProveedorConMas, 20);
            PanelRedondeado.Aplicar(panelProveedoresRegsitrados, 20);
            PanelRedondeado.Aplicar(panelProveedorReciente, 20);
            PanelRedondeado.Aplicar(panelTotalProveedores, 20);

            BotonRedondeado.Aplicar(btnLimpiar, 10);
            BotonRedondeado.Aplicar(btnGuardar, 10);
            BotonRedondeado.Aplicar(btnEliminar, 10);



            DataGridViewEstilo.Aplicar(dgvProveedores);

            _controller =
                new ProveedoresController();



            _paginacion =
                new PaginacionComponent(
                    panelPaginacion,
                    10
                );



            btnGuardar.Text =
                "Guardar";


            ConfigurarDataGridView();


            txtBuscar.TextChanged +=
                txtBuscar_TextChanged;


            dgvProveedores.CellClick +=
                dgvProveedores_CellClick;


            CargarProveedores();
        }



        private void ConfigurarDataGridView()
        {
            dgvProveedores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;


            dgvProveedores.MultiSelect =
                false;


            dgvProveedores.ReadOnly =
                true;


            dgvProveedores.AllowUserToAddRows =
                false;


            dgvProveedores.AllowUserToDeleteRows =
                false;


            dgvProveedores.AutoGenerateColumns =
                false;


            dgvProveedores.ClearSelection();
        }



        private void CargarProveedores()
        {
            try
            {
                _proveedores =
                    _controller.ObtenerProveedores();


                _paginacion.Configurar(
                    _proveedores,
                    MostrarProveedores
                );


                ActualizarTarjetas();


                _idProveedorSeleccionado =
                    0;


                btnGuardar.Text =
                    "Guardar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los proveedores.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void MostrarProveedores(
            List<Proveedore> proveedores)
        {
            dgvProveedores.Rows.Clear();


            foreach (
                Proveedore proveedor
                in proveedores
            )
            {
                int fila =
                    dgvProveedores.Rows.Add(
                        proveedor.NombreEmpresa,
                        proveedor.Direccion,
                        proveedor.Correo,
                        proveedor.Telefono,
                        proveedor.NombreAgente,
                        proveedor.TelefonoAgente,
                        proveedor.MontoMinimoCompra
                            .ToString("C2")
                    );


                dgvProveedores.Rows[fila].Tag =
                    proveedor.IdProveedor;
            }


            dgvProveedores.ClearSelection();
        }




        private void dgvProveedores_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow fila =
                dgvProveedores.Rows[
                    e.RowIndex
                ];


            if (fila.Tag == null)
                return;


            _idProveedorSeleccionado =
                Convert.ToInt32(
                    fila.Tag
                );




            btnGuardar.Text =
                "Actualizar";


            Proveedore? proveedor =
                _proveedores.FirstOrDefault(
                    p =>
                        p.IdProveedor ==
                        _idProveedorSeleccionado
                );


            if (proveedor == null)
                return;


            txtNombreEmpresa.Text =
                proveedor.NombreEmpresa;


            txtDireccion.Text =
                proveedor.Direccion;


            txtCorreo.Text =
                proveedor.Correo;


            txtTelefono.Text =
                proveedor.Telefono;


            txtNombreAgente.Text =
                proveedor.NombreAgente;


            txtTelefonoAgente.Text =
                proveedor.TelefonoAgente;


            txtMontoMinimoCompra.Text =
                proveedor.MontoMinimoCompra
                    .ToString("0.00");
        }



        private void txtBuscar_TextChanged(
            object? sender,
            EventArgs e)
        {
            string texto =
                txtBuscar.Text.Trim();


            if (
                string.IsNullOrWhiteSpace(
                    texto
                )
            )
            {
                _paginacion.Configurar(
                    _proveedores,
                    MostrarProveedores
                );


                return;
            }


            try
            {
                List<Proveedore> resultados =
                    _controller.BuscarProveedores(
                        texto
                    );




                _paginacion.Configurar(
                    resultados,
                    MostrarProveedores
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar los proveedores.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void btnGuardar_Click(
            object? sender,
            EventArgs e)
        {
            string nombreEmpresa =
                txtNombreEmpresa.Text.Trim();


            string direccion =
                txtDireccion.Text.Trim();


            string correo =
                txtCorreo.Text.Trim();


            string telefono =
                txtTelefono.Text.Trim();


            string nombreAgente =
                txtNombreAgente.Text.Trim();


            string telefonoAgente =
                txtTelefonoAgente.Text.Trim();




            if (
                string.IsNullOrWhiteSpace(
                    nombreEmpresa
                )
            )
            {
                MessageBox.Show(
                    "Ingrese el nombre de la empresa.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtNombreEmpresa.Focus();

                return;
            }




            if (
                !decimal.TryParse(
                    txtMontoMinimoCompra.Text.Trim(),
                    out decimal montoMinimoCompra
                )
            )
            {
                MessageBox.Show(
                    "Ingrese un monto mínimo de compra válido.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtMontoMinimoCompra.Focus();

                return;
            }


            if (
                montoMinimoCompra < 0
            )
            {
                MessageBox.Show(
                    "El monto mínimo de compra no puede ser negativo.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                txtMontoMinimoCompra.Focus();

                return;
            }




            try
            {
                if (
                    _idProveedorSeleccionado == 0
                )
                {
                    _controller.InsertarProveedor(
                        nombreEmpresa,
                        direccion,
                        correo,
                        telefono,
                        nombreAgente,
                        telefonoAgente,
                        montoMinimoCompra
                    );


                    MessageBox.Show(
                        "El proveedor se creó correctamente.",
                        "Proveedor creado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    _controller.ActualizarProveedor(
                        _idProveedorSeleccionado,
                        nombreEmpresa,
                        direccion,
                        correo,
                        telefono,
                        nombreAgente,
                        telefonoAgente,
                        montoMinimoCompra
                    );


                    MessageBox.Show(
                        "El proveedor se actualizó correctamente.",
                        "Proveedor actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }



                LimpiarFormulario();

                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el proveedor.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }




        private void btnLimpiar_Click(
            object? sender,
            EventArgs e)
        {
            LimpiarFormulario();
        }



        private void LimpiarFormulario()
        {
            txtNombreEmpresa.Clear();

            txtDireccion.Clear();

            txtCorreo.Clear();

            txtTelefono.Clear();

            txtNombreAgente.Clear();

            txtTelefonoAgente.Clear();

            txtMontoMinimoCompra.Clear();

            txtBuscar.Clear();


            _idProveedorSeleccionado =
                0;


            btnGuardar.Text =
                "Guardar";


            dgvProveedores.ClearSelection();


            txtNombreEmpresa.Focus();
        }




        private void btnEliminar_Click(
            object? sender,
            EventArgs e)
        {
            if (
                _idProveedorSeleccionado == 0
            )
            {
                MessageBox.Show(
                    "Seleccione un proveedor para eliminarlo.",
                    "Proveedor no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );


                return;
            }


            Proveedore? proveedor =
                _proveedores.FirstOrDefault(
                    p =>
                        p.IdProveedor ==
                        _idProveedorSeleccionado
                );


            string nombreProveedor =
                proveedor?.NombreEmpresa ??
                "este proveedor";


            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro que desea eliminar " +
                    nombreProveedor +
                    "?",
                    "Eliminar proveedor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


            if (
                resultado !=
                DialogResult.Yes
            )
            {
                return;
            }


            try
            {
                _controller.EliminarProveedor(
                    _idProveedorSeleccionado
                );


                MessageBox.Show(
                    "El proveedor se eliminó correctamente.",
                    "Proveedor eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                LimpiarFormulario();

                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se puede eliminar el proveedor porque " +
                    "tiene entradas de inventario asociadas.\n\n" +
                    ex.Message,
                    "No se puede eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }




        private void ActualizarTarjetas()
        {


            lblTotalProveedores.Text =
                _proveedores.Count.ToString();




            Proveedore? proveedorReciente =
                _proveedores
                    .OrderByDescending(
                        p => p.IdProveedor
                    )
                    .FirstOrDefault();


            if (proveedorReciente != null)
            {
                lblProveedorReciente.Text =
                    proveedorReciente.NombreEmpresa;


                lblProveedorRecienteDescripcion.Text =
                    "Último proveedor registrado";
            }
            else
            {
                lblProveedorReciente.Text =
                    "—";


                lblProveedorRecienteDescripcion.Text =
                    "No hay proveedores registrados";
            }



            try
            {
                List<EntradaListado> entradas =
                    _entradasController.ObtenerEntradas();


                var proveedorConMasUnidades =
                    entradas
                        .GroupBy(
                            e => new
                            {
                                e.id_proveedor,
                                e.nombre_empresa
                            }
                        )
                        .Select(
                            grupo => new
                            {
                                NombreEmpresa =
                                    grupo.Key.nombre_empresa,

                                TotalUnidades =
                                    grupo.Sum(
                                        entrada => entrada.cantidad
                                    )
                            }
                        )
                        .OrderByDescending(
                            grupo => grupo.TotalUnidades
                        )
                        .FirstOrDefault();


                if (proveedorConMasUnidades != null)
                {
                    lblProveedorMasProductos.Text =
                        proveedorConMasUnidades.NombreEmpresa;


                    lblCantidadProductosProveedor.Text =
                        proveedorConMasUnidades.TotalUnidades
                            .ToString("N0") +
                        " unidades ingresadas";
                }
                else
                {
                    lblProveedorMasProductos.Text =
                        "—";


                    lblCantidadProductosProveedor.Text =
                        "Sin entradas registradas";
                }
            }
            catch (Exception)
            {
                lblProveedorMasProductos.Text =
                    "—";


                lblCantidadProductosProveedor.Text =
                    "No se pudo cargar la información";
            }
        }
    }
}