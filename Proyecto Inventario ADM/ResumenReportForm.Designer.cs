namespace ProyectoInventarioADM
{
    partial class ResumenReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTotalBs;

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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTotalBs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 20);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(20, 60);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(83, 13);
            this.lblPrecioUnitario.TabIndex = 1;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblTotalBs
            // 
            this.lblTotalBs.AutoSize = true;
            this.lblTotalBs.Location = new System.Drawing.Point(20, 100);
            this.lblTotalBs.Name = "lblTotalBs";
            this.lblTotalBs.Size = new System.Drawing.Size(55, 13);
            this.lblTotalBs.TabIndex = 2;
            this.lblTotalBs.Text = "Total Bs:";
            // 
            // ResumenReportForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblTotalBs);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Name = "ResumenReportForm";
            this.Text = "Reporte Resumido";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
