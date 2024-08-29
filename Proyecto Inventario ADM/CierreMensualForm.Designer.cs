using System;

namespace ProyectoInventarioADM
{
    partial class CierreMensualForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBoxProceso;
        private System.Windows.Forms.Button btnEjecutarProceso;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBoxProceso = new System.Windows.Forms.GroupBox();
            this.btnEjecutarProceso = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.columnaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtitulo2 = new System.Windows.Forms.Label();
            this.groupBoxProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(292, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CIERRE DE MES";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(17, 28);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(79, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "FONDECO IFD";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(620, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "SSEJAS";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(620, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "25/08/2024";
            // 
            // groupBoxProceso
            // 
            this.groupBoxProceso.Controls.Add(this.btnEjecutarProceso);
            this.groupBoxProceso.Location = new System.Drawing.Point(20, 162);
            this.groupBoxProceso.Name = "groupBoxProceso";
            this.groupBoxProceso.Size = new System.Drawing.Size(200, 100);
            this.groupBoxProceso.TabIndex = 4;
            this.groupBoxProceso.TabStop = false;
            this.groupBoxProceso.Text = "Cierre de Mes";
            // 
            // btnEjecutarProceso
            // 
            this.btnEjecutarProceso.Location = new System.Drawing.Point(20, 30);
            this.btnEjecutarProceso.Name = "btnEjecutarProceso";
            this.btnEjecutarProceso.Size = new System.Drawing.Size(150, 40);
            this.btnEjecutarProceso.TabIndex = 0;
            this.btnEjecutarProceso.Text = "Ejecutar Proceso";
            this.btnEjecutarProceso.UseVisualStyleBackColor = true;
            this.btnEjecutarProceso.Click += new System.EventHandler(this.btnEjecutarProceso_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaItem,
            this.columnaEstado});
            this.dataGridViewItems.Location = new System.Drawing.Point(250, 80);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(460, 300);
            this.dataGridViewItems.TabIndex = 5;
            // 
            // columnaItem
            // 
            this.columnaItem.HeaderText = "Item";
            this.columnaItem.Name = "columnaItem";
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            // 
            // lblSubtitulo2
            // 
            this.lblSubtitulo2.AutoSize = true;
            this.lblSubtitulo2.Location = new System.Drawing.Point(17, 50);
            this.lblSubtitulo2.Name = "lblSubtitulo2";
            this.lblSubtitulo2.Size = new System.Drawing.Size(174, 13);
            this.lblSubtitulo2.TabIndex = 6;
            this.lblSubtitulo2.Text = "OFICINA CENTRAL SANTA CRUZ";
            // 
            // CierreMensualForm
            // 
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.lblSubtitulo2);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.groupBoxProceso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CierreMensualForm";
            this.Text = "Cierre de Mes";
            this.groupBoxProceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSubtitulo2;
    }
}
