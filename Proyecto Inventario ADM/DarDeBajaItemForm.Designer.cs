namespace ProyectoInventarioADM
{
    partial class DarDeBajaItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.TextBox txtMotivo;

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
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 12);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(260, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(12, 40);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(260, 20);
            this.txtMotivo.TabIndex = 1;
            this.txtMotivo.Text = "Ingrese el motivo para dar de baja...";
            this.txtMotivo.ForeColor = System.Drawing.Color.Gray;
            this.txtMotivo.Enter += new System.EventHandler(this.txtMotivo_Enter);
            this.txtMotivo.Leave += new System.EventHandler(this.txtMotivo_Leave);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.Location = new System.Drawing.Point(12, 66);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(260, 23);
            this.btnDarDeBaja.TabIndex = 2;
            this.btnDarDeBaja.Text = "Dar de Baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = true;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // DarDeBajaItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "DarDeBajaItemForm";
            this.Text = "Dar de Baja Item";
            this.Load += new System.EventHandler(this.DarDeBajaItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
