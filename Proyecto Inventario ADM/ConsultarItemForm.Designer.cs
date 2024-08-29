namespace ProyectoInventarioADM
{
    partial class ConsultarItemForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.colTotalConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitarioMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBsMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompraDelMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCompraDelMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBsCompraDelMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProductoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarPorFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(9, 10);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(190, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultar.Location = new System.Drawing.Point(202, 10);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(56, 20);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.AllowUserToAddRows = false;
            this.dataGridViewDetalles.AllowUserToDeleteRows = false;
            this.dataGridViewDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTotalConsumo,
            this.colCantidadMesAnterior,
            this.colPrecioUnitarioMesAnterior,
            this.colTotalBsMesAnterior,
            this.colCompraDelMes,
            this.colPrecioCompraDelMes,
            this.colTotalBsCompraDelMes,
            this.colTotalProductoInventario,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colTotalBs});
            this.dataGridViewDetalles.Location = new System.Drawing.Point(9, 34);
            this.dataGridViewDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.ReadOnly = true;
            this.dataGridViewDetalles.RowHeadersVisible = false;
            this.dataGridViewDetalles.RowHeadersWidth = 51;
            this.dataGridViewDetalles.RowTemplate.Height = 24;
            this.dataGridViewDetalles.Size = new System.Drawing.Size(1117, 360);
            this.dataGridViewDetalles.TabIndex = 2;
            // 
            // colTotalConsumo
            // 
            this.colTotalConsumo.HeaderText = "Total Consumo";
            this.colTotalConsumo.MinimumWidth = 6;
            this.colTotalConsumo.Name = "colTotalConsumo";
            this.colTotalConsumo.ReadOnly = true;
            // 
            // colCantidadMesAnterior
            // 
            this.colCantidadMesAnterior.HeaderText = "Cantidad Mes Anterior";
            this.colCantidadMesAnterior.MinimumWidth = 6;
            this.colCantidadMesAnterior.Name = "colCantidadMesAnterior";
            this.colCantidadMesAnterior.ReadOnly = true;
            // 
            // colPrecioUnitarioMesAnterior
            // 
            this.colPrecioUnitarioMesAnterior.HeaderText = "Precio Unitario Mes Anterior";
            this.colPrecioUnitarioMesAnterior.MinimumWidth = 6;
            this.colPrecioUnitarioMesAnterior.Name = "colPrecioUnitarioMesAnterior";
            this.colPrecioUnitarioMesAnterior.ReadOnly = true;
            // 
            // colTotalBsMesAnterior
            // 
            this.colTotalBsMesAnterior.HeaderText = "Total Bs Mes Anterior";
            this.colTotalBsMesAnterior.MinimumWidth = 6;
            this.colTotalBsMesAnterior.Name = "colTotalBsMesAnterior";
            this.colTotalBsMesAnterior.ReadOnly = true;
            // 
            // colCompraDelMes
            // 
            this.colCompraDelMes.HeaderText = "Compra del Mes";
            this.colCompraDelMes.MinimumWidth = 6;
            this.colCompraDelMes.Name = "colCompraDelMes";
            this.colCompraDelMes.ReadOnly = true;
            // 
            // colPrecioCompraDelMes
            // 
            this.colPrecioCompraDelMes.HeaderText = "Precio Compra del Mes";
            this.colPrecioCompraDelMes.MinimumWidth = 6;
            this.colPrecioCompraDelMes.Name = "colPrecioCompraDelMes";
            this.colPrecioCompraDelMes.ReadOnly = true;
            // 
            // colTotalBsCompraDelMes
            // 
            this.colTotalBsCompraDelMes.HeaderText = "Total Bs Compra del Mes";
            this.colTotalBsCompraDelMes.MinimumWidth = 6;
            this.colTotalBsCompraDelMes.Name = "colTotalBsCompraDelMes";
            this.colTotalBsCompraDelMes.ReadOnly = true;
            // 
            // colTotalProductoInventario
            // 
            this.colTotalProductoInventario.HeaderText = "Total Producto Inventario";
            this.colTotalProductoInventario.MinimumWidth = 6;
            this.colTotalProductoInventario.Name = "colTotalProductoInventario";
            this.colTotalProductoInventario.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.MinimumWidth = 6;
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colTotalBs
            // 
            this.colTotalBs.HeaderText = "Total Bs";
            this.colTotalBs.MinimumWidth = 6;
            this.colTotalBs.Name = "colTotalBs";
            this.colTotalBs.ReadOnly = true;
            // 
            // btnConsultarPorFecha
            // 
            this.btnConsultarPorFecha.Location = new System.Drawing.Point(270, 10);
            this.btnConsultarPorFecha.Name = "btnConsultarPorFecha";
            this.btnConsultarPorFecha.Size = new System.Drawing.Size(120, 23);
            this.btnConsultarPorFecha.TabIndex = 3;
            this.btnConsultarPorFecha.Text = "Consultas del Mes";
            this.btnConsultarPorFecha.UseVisualStyleBackColor = true;
            this.btnConsultarPorFecha.Click += new System.EventHandler(this.btnConsultarPorFecha_Click);
            // 
            // ConsultarItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 406);
            this.Controls.Add(this.btnConsultarPorFecha);
            this.Controls.Add(this.dataGridViewDetalles);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.comboBoxItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarItemForm";
            this.Text = "Consultar Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarPorFecha;
        private System.Windows.Forms.DataGridView dataGridViewDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitarioMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBsMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompraDelMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCompraDelMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBsCompraDelMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProductoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBs;
    }
}

