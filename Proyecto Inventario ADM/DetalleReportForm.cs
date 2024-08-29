using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class DetalleReportForm : Form
    {
        public DetalleReportForm(Item item)
        {
            InitializeComponent();
            MostrarDetalles(item);
        }

        private void MostrarDetalles(Item item)
        {
            lblCompraMes.Text = $"Compra del Mes: {item.CompraMes}";
            lblPrecioCompraMes.Text = $"Precio Compra del Mes: {item.Precio}";
            lblTotalBsCompraMes.Text = $"Total Bs Compra del Mes: {item.TotalBs}";
        }
    }
}
