using ProyectoInventarioADM;
using System;
using System.Windows.Forms;

namespace Proyecto_Inventario_ADM
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Inicia con el formulario de inicio de sesión
        }
    }
}

