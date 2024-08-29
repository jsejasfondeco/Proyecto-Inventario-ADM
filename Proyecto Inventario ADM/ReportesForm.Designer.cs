namespace ProyectoInventarioADM
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpFechaProceso;
        private System.Windows.Forms.NumericUpDown numTipoReporte;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuarioFecha;
        private System.Windows.Forms.Label lblFechaProceso;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label lblFondeco;
        private System.Windows.Forms.Label lblOficina;

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
            this.dtpFechaProceso = new System.Windows.Forms.DateTimePicker();
            this.numTipoReporte = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioFecha = new System.Windows.Forms.Label();
            this.lblFechaProceso = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.lblFondeco = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTipoReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaProceso
            // 
            this.dtpFechaProceso.Location = new System.Drawing.Point(130, 127);
            this.dtpFechaProceso.Name = "dtpFechaProceso";
            this.dtpFechaProceso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaProceso.TabIndex = 0;
            // 
            // numTipoReporte
            // 
            this.numTipoReporte.Location = new System.Drawing.Point(130, 157);
            this.numTipoReporte.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTipoReporte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTipoReporte.Name = "numTipoReporte";
            this.numTipoReporte.Size = new System.Drawing.Size(120, 20);
            this.numTipoReporte.TabIndex = 1;
            this.numTipoReporte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(130, 234);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(120, 23);
            this.btnGenerarReporte.TabIndex = 3;
            this.btnGenerarReporte.Text = "Generar";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(268, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(275, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA DE REPORTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioFecha
            // 
            this.lblUsuarioFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsuarioFecha.Location = new System.Drawing.Point(561, 25);
            this.lblUsuarioFecha.Name = "lblUsuarioFecha";
            this.lblUsuarioFecha.Size = new System.Drawing.Size(200, 30);
            this.lblUsuarioFecha.TabIndex = 1;
            this.lblUsuarioFecha.Text = "ssejas - 26/08/2024";
            this.lblUsuarioFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFechaProceso
            // 
            this.lblFechaProceso.Location = new System.Drawing.Point(30, 127);
            this.lblFechaProceso.Name = "lblFechaProceso";
            this.lblFechaProceso.Size = new System.Drawing.Size(100, 23);
            this.lblFechaProceso.TabIndex = 2;
            this.lblFechaProceso.Text = "Fecha Proceso";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Location = new System.Drawing.Point(30, 157);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(100, 44);
            this.lblTipoReporte.TabIndex = 3;
            this.lblTipoReporte.Text = "1= Detalle  2=Resumen";
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(30, 207);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(100, 23);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Location = new System.Drawing.Point(130, 204);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(200, 21);
            this.comboBoxItems.TabIndex = 2;
            // 
            // lblFondeco
            // 
            this.lblFondeco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFondeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFondeco.Location = new System.Drawing.Point(12, 25);
            this.lblFondeco.Name = "lblFondeco";
            this.lblFondeco.Size = new System.Drawing.Size(200, 20);
            this.lblFondeco.TabIndex = 5;
            this.lblFondeco.Text = "FONDECO IFD";
            // 
            // lblOficina
            // 
            this.lblOficina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOficina.Location = new System.Drawing.Point(12, 45);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(300, 20);
            this.lblOficina.TabIndex = 6;
            this.lblOficina.Text = "OFICINA CENTRAL SANTA CRUZ";
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 338);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuarioFecha);
            this.Controls.Add(this.lblFechaProceso);
            this.Controls.Add(this.lblTipoReporte);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.numTipoReporte);
            this.Controls.Add(this.dtpFechaProceso);
            this.Controls.Add(this.lblFondeco);
            this.Controls.Add(this.lblOficina);
            this.Name = "ReportesForm";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.numTipoReporte)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
