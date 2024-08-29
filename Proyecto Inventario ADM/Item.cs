using System;

namespace ProyectoInventarioADM
{
    [Serializable]
    public class Item
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }  // Refleja la cantidad total actual
        public decimal Precio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CantidadMesAnterior { get; set; }
        public decimal CostoCompraUnitarioMesAnterior { get; set; }
        public decimal TotalBsCompraMesAnterior { get; set; }
        public int TotalConsumo { get; set; }
        public int CompraMes { get; set; }
        public decimal TotalBs { get; set; }
        public int TotalProductoInventario { get; set; }

        // Propiedad para el Promedio Ponderado con set privado
        public decimal PromedioPonderado { get; private set; }

        public Item(string nombre, int cantidad, decimal precio, DateTime fechaRegistro)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            FechaRegistro = fechaRegistro != default ? fechaRegistro : DateTime.Now;
            InicializarValores();
        }

        private void InicializarValores()
        {
            CantidadMesAnterior = 0;
            CostoCompraUnitarioMesAnterior = 0;
            TotalBsCompraMesAnterior = 0;
            TotalConsumo = 0;
            CompraMes = 0;
            TotalProductoInventario = 0;
            TotalBs = 0;
            PromedioPonderado = 0;
        }

        // Método para actualizar el Promedio Ponderado
        public void ActualizarPromedioPonderado()
        {
            if (TotalProductoInventario > 0)
            {
                PromedioPonderado = Math.Round((TotalBsCompraMesAnterior + (CompraMes * Precio)) / TotalProductoInventario, 2);
            }
            else
            {
                PromedioPonderado = Precio; // Si no hay producto anterior, el precio del mes actual se usa como promedio
            }
        }

        // Método para calcular el Total Bs basado en el Promedio Ponderado y la Cantidad
        public void ActualizarTotalBs()
        {
            // Total Bs se calcula multiplicando la Cantidad actual por el Promedio Ponderado
            TotalBs = Math.Round(Cantidad * PromedioPonderado, 2);
        }
    }
}
