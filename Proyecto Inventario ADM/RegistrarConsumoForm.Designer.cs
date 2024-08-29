namespace ProyectoInventarioADM
{
    partial class RegistrarConsumoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.NumericUpDown numCantidad;
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
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker(); // Inicializar DateTimePicker
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(12, 15);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(83, 13);
            this.lblNombreItem.TabIndex = 0;
            this.lblNombreItem.Text = "Nombre del Ítem";
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
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(101, 12);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(171, 21);
            this.comboBoxItems.TabIndex = 2;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(101, 39);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(171, 20);
            this.numCantidad.TabIndex = 3;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(101, 65); // Ajusta la posición según sea necesario
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerFecha.TabIndex = 4; // Añadir el control al formulario
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 91);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistrarConsumoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreItem);
            this.Name = "RegistrarConsumoForm";
            this.Text = "Registrar Consumo";
            this.Load += new System.EventHandler(this.RegistrarConsumoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
