using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class ResumenReportForm : Form
    {
        public ResumenReportForm(Item item)
        {
            InitializeComponent();
            MostrarResumen(item);
        }

        private void MostrarResumen(Item item)
        {
            // Asegúrate de que el precio unitario esté correctamente calculado antes de mostrarlo
            item.ActualizarPromedioPonderado();  // Asegura que el precio esté actualizado antes de mostrar el reporte
            lblCantidad.Text = $"Cantidad: {item.Cantidad}";
            lblPrecioUnitario.Text = $"Precio Unitario: {item.Precio}";  // Mostrando el precio correcto
            lblTotalBs.Text = $"Total Bs: {item.TotalBs}";
        }
    }
}
