namespace ProyectoInventarioADM
{
    partial class HistorialTransaccionesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewTransacciones;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipo;
        private System.Windows.Forms.ComboBox comboBoxFiltroItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblMotivoBaja;

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
            this.listViewTransacciones = new System.Windows.Forms.ListView();
            this.comboBoxFiltroTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltroItem = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lblMotivoBaja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewTransacciones
            // 
            this.listViewTransacciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewTransacciones.FullRowSelect = true;
            this.listViewTransacciones.GridLines = true;
            this.listViewTransacciones.HideSelection = false;
            this.listViewTransacciones.Location = new System.Drawing.Point(12, 39);
            this.listViewTransacciones.Name = "listViewTransacciones";
            this.listViewTransacciones.Size = new System.Drawing.Size(600, 426);
            this.listViewTransacciones.TabIndex = 0;
            this.listViewTransacciones.UseCompatibleStateImageBehavior = false;
            this.listViewTransacciones.View = System.Windows.Forms.View.Details;
            this.listViewTransacciones.SelectedIndexChanged += new System.EventHandler(this.listViewTransacciones_SelectedIndexChanged);
            // 
            // comboBoxFiltroTipo
            // 
            this.comboBoxFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroTipo.FormattingEnabled = true;
            this.comboBoxFiltroTipo.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            this.comboBoxFiltroTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroTipo.TabIndex = 1;
            this.comboBoxFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroTipo_SelectedIndexChanged);
            // 
            // comboBoxFiltroItem
            // 
            this.comboBoxFiltroItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroItem.FormattingEnabled = true;
            this.comboBoxFiltroItem.Location = new System.Drawing.Point(150, 12);
            this.comboBoxFiltroItem.Name = "comboBoxFiltroItem";
            this.comboBoxFiltroItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroItem.TabIndex = 2;
            this.comboBoxFiltroItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroItem_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre del Ítem";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio Unitario";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha Registro Item / Motivo Baja";
            this.columnHeader6.Width = 160;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.lblMotivoBaja);
            this.panelDetalles.Location = new System.Drawing.Point(12, 470);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(600, 60);
            this.panelDetalles.TabIndex = 3;
            this.panelDetalles.Visible = false;
            // 
            // lblMotivoBaja
            // 
            this.lblMotivoBaja.AutoSize = true;
            this.lblMotivoBaja.Location = new System.Drawing.Point(3, 9);
            this.lblMotivoBaja.Name = "lblMotivoBaja";
            this.lblMotivoBaja.Size = new System.Drawing.Size(80, 13);
            this.lblMotivoBaja.TabIndex = 0;
            this.lblMotivoBaja.Text = "Motivo de Baja:";
            // 
            // HistorialTransaccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 540);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.comboBoxFiltroItem);
            this.Controls.Add(this.comboBoxFiltroTipo);
            this.Controls.Add(this.listViewTransacciones);
            this.Name = "HistorialTransaccionesForm";
            this.Text = "Historial de Transacciones";
            this.ResumeLayout(false);

        }
    }
}
