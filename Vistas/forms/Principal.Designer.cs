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
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultaUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbSistema
            // 
            this.gbSistema.Controls.Add(this.menuStrip2);
            this.gbSistema.Location = new System.Drawing.Point(13, 62);
            this.gbSistema.Margin = new System.Windows.Forms.Padding(4);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Padding = new System.Windows.Forms.Padding(4);
            this.gbSistema.Size = new System.Drawing.Size(783, 64);
            this.gbSistema.TabIndex = 1;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Menu";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRegistrar,
            this.usuariosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(4, 19);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(775, 28);
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
            this.msRegistrar.Size = new System.Drawing.Size(80, 24);
            this.msRegistrar.Text = "Registrar";
            // 
            // btnCliente
            // 
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 27);
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(100, 27);
            this.btnProducto.Text = "Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnObraSocial
            // 
            this.btnObraSocial.Name = "btnObraSocial";
            this.btnObraSocial.Size = new System.Drawing.Size(100, 27);
            this.btnObraSocial.Text = "Obra Social";
            this.btnObraSocial.Click += new System.EventHandler(this.btnObraSocial_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearUser,
            this.btnEliminarUser,
            this.btnConsultaUser,
            this.btnModificarUser});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // btnCrearUser
            // 
            this.btnCrearUser.Name = "btnCrearUser";
            this.btnCrearUser.Size = new System.Drawing.Size(152, 24);
            this.btnCrearUser.Text = "Crear";
            this.btnCrearUser.Click += new System.EventHandler(this.btnCrearUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(152, 24);
            this.btnEliminarUser.Text = "Eliminar";
            // 
            // btnConsultaUser
            // 
            this.btnConsultaUser.Name = "btnConsultaUser";
            this.btnConsultaUser.Size = new System.Drawing.Size(152, 24);
            this.btnConsultaUser.Text = "Consultar";
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(152, 24);
            this.btnModificarUser.Text = "Modificar";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(667, 423);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 44);
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
            this.lblUserActive.Location = new System.Drawing.Point(56, 25);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(42, 20);
            this.lblUserActive.TabIndex = 4;
            this.lblUserActive.Text = "user";
            // 
            // pbUser
            // 
            this.pbUser.Image = global::Vistas.Properties.Resources.usuario21;
            this.pbUser.Location = new System.Drawing.Point(13, 14);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(43, 42);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 3;
            this.pbUser.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 482);
            this.Controls.Add(this.lblUserActive);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbSistema);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrearUser;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarUser;
        private System.Windows.Forms.ToolStripMenuItem btnConsultaUser;
        private System.Windows.Forms.ToolStripMenuItem btnModificarUser;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}