using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class MainForm : Form
    {
        private readonly Inventario _inventario;
        private readonly int _usuarioID; // Variable para almacenar el usuarioID
        private RegistrarSaldoAnteriorForm _saldoAnteriorForm;

        public MainForm(int usuarioID)
        {
            InitializeComponent();
            _usuarioID = usuarioID; // Asignar usuarioID
            _inventario = new Inventario(); // Inicialización de inventario
            _saldoAnteriorForm = new RegistrarSaldoAnteriorForm(_inventario, _usuarioID); // Inicialización de la instancia del formulario de saldo anterior con usuarioID
            ConfigurarTreeView(); // Configurar el TreeView
        }

        private void ConfigurarTreeView()
        {
            treeView1.Nodes.Clear();

            // Crear el nodo principal "INVENTARIO"
            TreeNode nodoInventario = new TreeNode("INVENTARIO");

            // Crear el subnodo "Sistemas" dentro de "INVENTARIO"
            TreeNode nodoSistemas = new TreeNode("Sistemas");

            // Añadir los módulos a "Sistemas"
            nodoSistemas.Nodes.Add("Registrar Item Nuevo");
            nodoSistemas.Nodes.Add("Dar de Baja Item");
            nodoSistemas.Nodes.Add("Consultar Item");
            nodoSistemas.Nodes.Add("Registrar Consumo");
            nodoSistemas.Nodes.Add("Historial de Transacciones");
            nodoSistemas.Nodes.Add("Registrar Compra");
            nodoSistemas.Nodes.Add("Registrar Saldo Anterior"); // Nuevo nodo agregado

            // Añadir "Sistemas" a "INVENTARIO"
            nodoInventario.Nodes.Add(nodoSistemas);

            // Añadir "INVENTARIO" al TreeView
            treeView1.Nodes.Add(nodoInventario);
            treeView1.ExpandAll();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Registrar Item Nuevo":
                    RegistrarItemForm registrarForm = new RegistrarItemForm(_inventario, _usuarioID);
                    registrarForm.ShowDialog();
                    _saldoAnteriorForm.ActualizarComboBox(); // Actualiza el ComboBox después de agregar un nuevo ítem
                    break;

                case "Registrar Compra":
                    RegistroCompraForm compraForm = new RegistroCompraForm(_inventario, _usuarioID);
                    compraForm.ShowDialog();
                    break;

                case "Dar de Baja Item":
                    DarDeBajaItemForm darBajaForm = new DarDeBajaItemForm(_inventario, _usuarioID);
                    darBajaForm.ShowDialog();
                    break;

                case "Consultar Item":
                    ConsultarItemForm consultarForm = new ConsultarItemForm(_inventario, _usuarioID);
                    consultarForm.ShowDialog();
                    break;

                case "Registrar Consumo":
                    RegistrarConsumoForm consumoForm = new RegistrarConsumoForm(_inventario, _usuarioID);
                    consumoForm.ShowDialog();
                    break;

                case "Historial de Transacciones":
                    HistorialTransaccionesForm historialForm = new HistorialTransaccionesForm(_inventario, _usuarioID);
                    historialForm.ShowDialog();
                    break;

                case "Registrar Saldo Anterior":
                    _saldoAnteriorForm.ShowDialog(); // Mostrar la instancia existente del formulario
                    break;
            }
        }
    }
}

