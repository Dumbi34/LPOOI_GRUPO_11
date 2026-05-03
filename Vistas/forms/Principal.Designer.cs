namespace Vistas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbSistema = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.msRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripTextBox();
            this.btnProducto = new System.Windows.Forms.ToolStripTextBox();
            this.btnObraSocial = new System.Windows.Forms.ToolStripTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.gbSistema.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbSistema
            // 
            this.gbSistema.Controls.Add(this.menuStrip2);
            this.gbSistema.Location = new System.Drawing.Point(10, 61);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Size = new System.Drawing.Size(587, 52);
            this.gbSistema.TabIndex = 1;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Menu";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRegistrar});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(581, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // msRegistrar
            // 
            this.msRegistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.btnProducto,
            this.btnObraSocial});
            this.msRegistrar.Name = "msRegistrar";
            this.msRegistrar.Size = new System.Drawing.Size(65, 20);
            this.msRegistrar.Text = "Registrar";
            // 
            // btnCliente
            // 
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 23);
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(100, 23);
            this.btnProducto.Text = "Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnObraSocial
            // 
            this.btnObraSocial.Name = "btnObraSocial";
            this.btnObraSocial.Size = new System.Drawing.Size(100, 23);
            this.btnObraSocial.Text = "Obra Social";
            this.btnObraSocial.Click += new System.EventHandler(this.btnObraSocial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(500, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // lblUserActive
            // 
            this.lblUserActive.AutoSize = true;
            this.lblUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserActive.Location = new System.Drawing.Point(42, 20);
            this.lblUserActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(36, 17);
            this.lblUserActive.TabIndex = 4;
            this.lblUserActive.Text = "user";
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Vistas.Properties.Resources.usuario21;
            this.pbUser.Location = new System.Drawing.Point(10, 11);
            this.pbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(32, 34);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 3;
            this.pbUser.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 392);
            this.Controls.Add(this.lblUserActive);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbSistema);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "G11- principal";
            this.gbSistema.ResumeLayout(false);
            this.gbSistema.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbSistema;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem msRegistrar;
        private System.Windows.Forms.ToolStripTextBox btnCliente;
        private System.Windows.Forms.ToolStripTextBox btnProducto;
        private System.Windows.Forms.ToolStripTextBox btnObraSocial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUserActive;
    }
}