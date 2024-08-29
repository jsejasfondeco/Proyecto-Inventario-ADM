namespace ProyectoInventarioADM
{
    partial class DetalleReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCompraMes;
        private System.Windows.Forms.Label lblPrecioCompraMes;
        private System.Windows.Forms.Label lblTotalBsCompraMes;

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
            this.lblCompraMes = new System.Windows.Forms.Label();
            this.lblPrecioCompraMes = new System.Windows.Forms.Label();
            this.lblTotalBsCompraMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompraMes
            // 
            this.lblCompraMes.AutoSize = true;
            this.lblCompraMes.Location = new System.Drawing.Point(20, 20);
            this.lblCompraMes.Name = "lblCompraMes";
            this.lblCompraMes.Size = new System.Drawing.Size(100, 13);
            this.lblCompraMes.TabIndex = 0;
            this.lblCompraMes.Text = "Compra del Mes:";
            // 
            // lblPrecioCompraMes
            // 
            this.lblPrecioCompraMes.AutoSize = true;
            this.lblPrecioCompraMes.Location = new System.Drawing.Point(20, 60);
            this.lblPrecioCompraMes.Name = "lblPrecioCompraMes";
            this.lblPrecioCompraMes.Size = new System.Drawing.Size(105, 13);
            this.lblPrecioCompraMes.TabIndex = 1;
            this.lblPrecioCompraMes.Text = "Precio Compra Mes:";
            // 
            // lblTotalBsCompraMes
            // 
            this.lblTotalBsCompraMes.AutoSize = true;
            this.lblTotalBsCompraMes.Location = new System.Drawing.Point(20, 100);
            this.lblTotalBsCompraMes.Name = "lblTotalBsCompraMes";
            this.lblTotalBsCompraMes.Size = new System.Drawing.Size(128, 13);
            this.lblTotalBsCompraMes.TabIndex = 2;
            this.lblTotalBsCompraMes.Text = "Total Bs Compra Mes:";
            // 
            // DetalleReportForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblTotalBsCompraMes);
            this.Controls.Add(this.lblPrecioCompraMes);
            this.Controls.Add(this.lblCompraMes);
            this.Name = "DetalleReportForm";
            this.Text = "Reporte Detallado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
