using System;
using System.Configuration; // Asegúrate de tener esta referencia
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class LoginForm : Form
    {
        public int UsuarioID { get; private set; } // Para almacenar el ID del usuario autenticado

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del usuario y contraseña
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();

                // Cadena de conexión desde App.config
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Consulta para verificar las credenciales
                    string query = "SELECT UsuarioID FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasena = @Contrasena";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contraseña);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Usuario autenticado con éxito
                        UsuarioID = Convert.ToInt32(result); // Guardamos el ID del usuario
                        MainForm mainForm = new MainForm(UsuarioID); // Pasamos el ID al formulario principal
                        mainForm.Show();
                        this.Hide(); // Oculta el formulario de inicio de sesión
                    }
                    else
                    {
                        // Autenticación fallida
                        MessageBox.Show("Usuario o contraseña inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores al conectar a la base de datos
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

