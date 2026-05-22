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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbSistema = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultaUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.manuRegistrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrarOS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.pbSalida = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSistema.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).BeginInit();
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
            this.toolTip1.SetToolTip(this.menuStrip1, "Desea Cerrar Sesion?");
            // 
            // gbSistema
            // 
            this.gbSistema.Controls.Add(this.menuStrip2);
            this.gbSistema.Location = new System.Drawing.Point(10, 50);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Size = new System.Drawing.Size(587, 77);
            this.gbSistema.TabIndex = 1;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Menu";
            this.gbSistema.Enter += new System.EventHandler(this.gbSistema_Enter);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuVentas,
            this.menuCliente,
            this.menuOS,
            this.menuProducto,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(581, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrearUser,
            this.btnEliminarUser,
            this.btnConsultaUser,
            this.btnModificarUser});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(64, 20);
            this.menuUsuario.Text = "Usuarios";
            // 
            // btnCrearUser
            // 
            this.btnCrearUser.Name = "btnCrearUser";
            this.btnCrearUser.Size = new System.Drawing.Size(152, 22);
            this.btnCrearUser.Text = "Crear";
            this.btnCrearUser.Click += new System.EventHandler(this.btnCrearUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(152, 22);
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnConsultaUser
            // 
            this.btnConsultaUser.Name = "btnConsultaUser";
            this.btnConsultaUser.Size = new System.Drawing.Size(152, 22);
            this.btnConsultaUser.Text = "Consultar";
            this.btnConsultaUser.Click += new System.EventHandler(this.btnConsultaUser_Click);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(152, 22);
            this.btnModificarUser.Text = "Modificar";
            this.btnModificarUser.Click += new System.EventHandler(this.btnModificarUser_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(53, 20);
            this.menuVentas.Text = "Ventas";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuRegistrarCliente});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // manuRegistrarCliente
            // 
            this.manuRegistrarCliente.Name = "manuRegistrarCliente";
            this.manuRegistrarCliente.Size = new System.Drawing.Size(152, 22);
            this.manuRegistrarCliente.Text = "Registrar";
            this.manuRegistrarCliente.Click += new System.EventHandler(this.manuRegistrarCliente_Click);
            // 
            // menuOS
            // 
            this.menuOS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistrarOS});
            this.menuOS.Name = "menuOS";
            this.menuOS.Size = new System.Drawing.Size(76, 20);
            this.menuOS.Text = "ObraSocial";
            this.menuOS.Click += new System.EventHandler(this.menuOS_Click);
            // 
            // menuRegistrarOS
            // 
            this.menuRegistrarOS.Name = "menuRegistrarOS";
            this.menuRegistrarOS.Size = new System.Drawing.Size(152, 22);
            this.menuRegistrarOS.Text = "Registrar";
            // 
            // menuProducto
            // 
            this.menuProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistrarProducto});
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.Size = new System.Drawing.Size(68, 20);
            this.menuProducto.Text = "Producto";
            // 
            // menuRegistrarProducto
            // 
            this.menuRegistrarProducto.Name = "menuRegistrarProducto";
            this.menuRegistrarProducto.Size = new System.Drawing.Size(152, 22);
            this.menuRegistrarProducto.Text = "Registrar";
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
            // pbSalida
            // 
            this.pbSalida.Image = global::Vistas.Properties.Resources.salida;
            this.pbSalida.Location = new System.Drawing.Point(549, 11);
            this.pbSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSalida.Name = "pbSalida";
            this.pbSalida.Size = new System.Drawing.Size(33, 34);
            this.pbSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalida.TabIndex = 5;
            this.pbSalida.TabStop = false;
            this.toolTip2.SetToolTip(this.pbSalida, "Desea Cerrar Sesion?");
            this.pbSalida.Click += new System.EventHandler(this.pbSalida_Click);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem1.Text = "Listado de Ventas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 392);
            this.Controls.Add(this.pbSalida);
            this.Controls.Add(this.lblUserActive);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbSistema);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "G11- principal";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            this.gbSistema.ResumeLayout(false);
            this.gbSistema.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbSistema;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUserActive;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnCrearUser;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarUser;
        private System.Windows.Forms.ToolStripMenuItem btnConsultaUser;
        private System.Windows.Forms.ToolStripMenuItem btnModificarUser;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuOS;
        private System.Windows.Forms.ToolStripMenuItem menuProducto;
        private System.Windows.Forms.ToolStripMenuItem manuRegistrarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrarOS;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrarProducto;
        private System.Windows.Forms.PictureBox pbSalida;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}