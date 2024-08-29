using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class RegistroCompraForm : Form
    {
        private Inventario inventario;

        public RegistroCompraForm(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
            CargarItems(); // Cargamos los ítems en el ComboBox al inicializar el formulario
        }

        private void CargarItems()
        {
            // Cargamos todos los ítems en el ComboBox
            var items = inventario.ObtenerItems();
            foreach (var item in items)
            {
                cmbNombreItem.Items.Add(item.Nombre);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreItem = cmbNombreItem.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nombreItem))
            {
                MessageBox.Show("Por favor, seleccione un ítem.");
                return;
            }

            int cantidad = (int)numCantidad.Value;
            decimal precioUnitario = numPrecioUnitario.Value;
            DateTime fechaSeleccionada = dateTimePickerFecha.Value;

            Item item = inventario.ConsultarItem(nombreItem);

            if (item != null)
            {
                var nuevaTransaccion = new Transaccion(nombreItem, cantidad, precioUnitario, TipoTransaccion.Compra, fechaSeleccionada, item.FechaRegistro);
                inventario.RegistrarTransaccion(nuevaTransaccion);

                MessageBox.Show("Compra registrada exitosamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El ítem no existe en el inventario.");
            }
        }
    }
}

