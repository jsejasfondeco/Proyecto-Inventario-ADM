namespace ProyectoInventarioADM
{
    partial class RegistrarSaldoAnteriorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbNombreItem;
        private System.Windows.Forms.NumericUpDown numSaldoAnterior;
        private System.Windows.Forms.NumericUpDown numCostoAnterior;
        private System.Windows.Forms.Label lblTotalBsAnterior;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblSaldoAnterior;
        private System.Windows.Forms.Label lblCostoAnterior;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistro;

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
            this.cmbNombreItem = new System.Windows.Forms.ComboBox();
            this.numSaldoAnterior = new System.Windows.Forms.NumericUpDown();
            this.numCostoAnterior = new System.Windows.Forms.NumericUpDown();
            this.lblTotalBsAnterior = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.lblSaldoAnterior = new System.Windows.Forms.Label();
            this.lblCostoAnterior = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoAnterior)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNombreItem
            // 
            this.cmbNombreItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreItem.FormattingEnabled = true;
            this.cmbNombreItem.Location = new System.Drawing.Point(118, 12);
            this.cmbNombreItem.Name = "cmbNombreItem";
            this.cmbNombreItem.Size = new System.Drawing.Size(200, 21);
            this.cmbNombreItem.TabIndex = 0;
            // 
            // numSaldoAnterior
            // 
            this.numSaldoAnterior.Location = new System.Drawing.Point(118, 39);
            this.numSaldoAnterior.Name = "numSaldoAnterior";
            this.numSaldoAnterior.Size = new System.Drawing.Size(200, 20);
            this.numSaldoAnterior.TabIndex = 1;
            // 
            // numCostoAnterior
            // 
            this.numCostoAnterior.DecimalPlaces = 2;
            this.numCostoAnterior.Location = new System.Drawing.Point(118, 65);
            this.numCostoAnterior.Name = "numCostoAnterior";
            this.numCostoAnterior.Size = new System.Drawing.Size(200, 20);
            this.numCostoAnterior.TabIndex = 2;
            this.numCostoAnterior.ValueChanged += new System.EventHandler(this.NumCostoAnterior_ValueChanged);
            // 
            // lblTotalBsAnterior
            // 
            this.lblTotalBsAnterior.AutoSize = true;
            this.lblTotalBsAnterior.Location = new System.Drawing.Point(118, 88);
            this.lblTotalBsAnterior.Name = "lblTotalBsAnterior";
            this.lblTotalBsAnterior.Size = new System.Drawing.Size(89, 13);
            this.lblTotalBsAnterior.TabIndex = 3;
            this.lblTotalBsAnterior.Text = "Total Bs Anterior:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(118, 137);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(12, 15);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(67, 13);
            this.lblNombreItem.TabIndex = 5;
            this.lblNombreItem.Text = "Nombre del ítem:";
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.Location = new System.Drawing.Point(12, 41);
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(72, 13);
            this.lblSaldoAnterior.TabIndex = 6;
            this.lblSaldoAnterior.Text = "Saldo Anterior:";
            // 
            // lblCostoAnterior
            // 
            this.lblCostoAnterior.AutoSize = true;
            this.lblCostoAnterior.Location = new System.Drawing.Point(12, 67);
            this.lblCostoAnterior.Name = "lblCostoAnterior";
            this.lblCostoAnterior.Size = new System.Drawing.Size(74, 13);
            this.lblCostoAnterior.TabIndex = 7;
            this.lblCostoAnterior.Text = "Costo Anterior:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(118, 111);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 8;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(12, 115);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(84, 13);
            this.lblFechaRegistro.TabIndex = 9;
            this.lblFechaRegistro.Text = "Fecha Registro:";
            // 
            // RegistrarSaldoAnteriorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 172);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.lblCostoAnterior);
            this.Controls.Add(this.lblSaldoAnterior);
            this.Controls.Add(this.lblNombreItem);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTotalBsAnterior);
            this.Controls.Add(this.numCostoAnterior);
            this.Controls.Add(this.numSaldoAnterior);
            this.Controls.Add(this.cmbNombreItem);
            this.Name = "RegistrarSaldoAnteriorForm";
            this.Text = "Registrar Saldo Anterior";
            this.Load += new System.EventHandler(this.RegistrarSaldoAnteriorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaldoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoAnterior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
