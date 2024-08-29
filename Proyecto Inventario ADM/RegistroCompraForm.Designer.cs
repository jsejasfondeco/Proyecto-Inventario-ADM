namespace ProyectoInventarioADM
{
    partial class RegistroCompraForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.ComboBox cmbNombreItem;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPrecioUnitario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha; // Añadir DateTimePicker

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.cmbNombreItem = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker(); // Inicializar DateTimePicker
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(12, 15);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(83, 13);
            this.lblNombreItem.TabIndex = 0;
            this.lblNombreItem.Text = "Nombre del Item";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 67);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioUnitario.TabIndex = 2;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // cmbNombreItem
            // 
            this.cmbNombreItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreItem.FormattingEnabled = true;
            this.cmbNombreItem.Location = new System.Drawing.Point(101, 12);
            this.cmbNombreItem.Name = "cmbNombreItem";
            this.cmbNombreItem.Size = new System.Drawing.Size(171, 21);
            this.cmbNombreItem.TabIndex = 3;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(101, 39);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(171, 20);
            this.numCantidad.TabIndex = 4;
            // 
            // numPrecioUnitario
            // 
            this.numPrecioUnitario.Location = new System.Drawing.Point(101, 65);
            this.numPrecioUnitario.Name = "numPrecioUnitario";
            this.numPrecioUnitario.Size = new System.Drawing.Size(171, 20);
            this.numPrecioUnitario.TabIndex = 5;
            // Configuraciones adicionales para permitir decimales y un rango amplio
            this.numPrecioUnitario.DecimalPlaces = 2;
            this.numPrecioUnitario.Minimum = 0;
            this.numPrecioUnitario.Maximum = 1000000; // Un valor máximo suficientemente alto
            this.numPrecioUnitario.Increment = 0.01M; // Incrementos de centavos
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(101, 91); // Ajusta la posición según sea necesario
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerFecha.TabIndex = 6; // Añadir el control al formulario
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 117);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistroCompraForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.numPrecioUnitario);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cmbNombreItem);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreItem);
            this.Name = "RegistroCompraForm";
            this.Text = "Registro de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
