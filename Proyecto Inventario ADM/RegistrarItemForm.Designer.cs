namespace ProyectoInventarioADM
{
    partial class RegistrarItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombreItem;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombreItem;

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
            this.txtNombreItem = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreItem
            // 
            this.txtNombreItem.Location = new System.Drawing.Point(221, 65);
            this.txtNombreItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreItem.Name = "txtNombreItem";
            this.txtNombreItem.Size = new System.Drawing.Size(193, 20);
            this.txtNombreItem.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(279, 100);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 24);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(128, 68);
            this.lblNombreItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(87, 13);
            this.lblNombreItem.TabIndex = 2;
            this.lblNombreItem.Text = "Nombre del Ítem:";
            // 
            // RegistrarItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 294);
            this.Controls.Add(this.lblNombreItem);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarItemForm";
            this.Text = "Registrar Item";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
