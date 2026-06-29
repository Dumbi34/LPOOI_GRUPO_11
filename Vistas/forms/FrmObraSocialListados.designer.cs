namespace Vistas.forms
{
    partial class FrmObraSocialListados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObraSocialListados));
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblOSnombre = new System.Windows.Forms.Label();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadOS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(24, 26);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(212, 23);
            this.lblObraSocial.TabIndex = 0;
            this.lblObraSocial.Text = "Obra Social Listados";
            // 
            // lblOSnombre
            // 
            this.lblOSnombre.AutoSize = true;
            this.lblOSnombre.Location = new System.Drawing.Point(25, 81);
            this.lblOSnombre.Name = "lblOSnombre";
            this.lblOSnombre.Size = new System.Drawing.Size(66, 17);
            this.lblOSnombre.TabIndex = 1;
            this.lblOSnombre.Text = "Nombre: ";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(28, 114);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(160, 24);
            this.cmbObraSocial.TabIndex = 2;
            this.cmbObraSocial.SelectedIndexChanged += new System.EventHandler(this.cmbObraSocial_SelectedIndexChanged);
            // 
            // dgvOS
            // 
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Location = new System.Drawing.Point(270, 65);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.RowTemplate.Height = 24;
            this.dgvOS.Size = new System.Drawing.Size(384, 185);
            this.dgvOS.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(452, 277);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(151, 17);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de personas:";
            // 
            // txtCantidadOS
            // 
            this.txtCantidadOS.Location = new System.Drawing.Point(605, 274);
            this.txtCantidadOS.Name = "txtCantidadOS";
            this.txtCantidadOS.ReadOnly = true;
            this.txtCantidadOS.Size = new System.Drawing.Size(48, 22);
            this.txtCantidadOS.TabIndex = 5;
 
            // 
            // FrmObraSocialListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 307);
            this.Controls.Add(this.txtCantidadOS);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvOS);
            this.Controls.Add(this.cmbObraSocial);
            this.Controls.Add(this.lblOSnombre);
            this.Controls.Add(this.lblObraSocial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmObraSocialListados";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.FrmObraSocialListados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblOSnombre;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadOS;
    }
}