namespace Vistas.forms
{
    partial class FrmUsuarioEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioEliminar));
            this.lblTituloUser = new System.Windows.Forms.Label();
            this.lblEliminarUser = new System.Windows.Forms.Label();
            this.txtEliminarUser = new System.Windows.Forms.TextBox();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.dgwEliminarUser = new System.Windows.Forms.DataGridView();
            this.btnElimianrUser = new System.Windows.Forms.Button();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblNyAuser = new System.Windows.Forms.Label();
            this.lblRolUser = new System.Windows.Forms.Label();
            this.lblDatosUser = new System.Windows.Forms.Label();
            this.txtUserEliminar = new System.Windows.Forms.TextBox();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.txtRoleliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEliminarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloUser
            // 
            this.lblTituloUser.AutoSize = true;
            this.lblTituloUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUser.Location = new System.Drawing.Point(27, 21);
            this.lblTituloUser.Name = "lblTituloUser";
            this.lblTituloUser.Size = new System.Drawing.Size(170, 23);
            this.lblTituloUser.TabIndex = 0;
            this.lblTituloUser.Text = "Eliminar Usuario";
            // 
            // lblEliminarUser
            // 
            this.lblEliminarUser.AutoSize = true;
            this.lblEliminarUser.Location = new System.Drawing.Point(120, 71);
            this.lblEliminarUser.Name = "lblEliminarUser";
            this.lblEliminarUser.Size = new System.Drawing.Size(116, 17);
            this.lblEliminarUser.TabIndex = 1;
            this.lblEliminarUser.Text = "Ingrese Usuario: ";
            // 
            // txtEliminarUser
            // 
            this.txtEliminarUser.Location = new System.Drawing.Point(261, 69);
            this.txtEliminarUser.Name = "txtEliminarUser";
            this.txtEliminarUser.Size = new System.Drawing.Size(294, 22);
            this.txtEliminarUser.TabIndex = 2;
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.Location = new System.Drawing.Point(561, 65);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(129, 28);
            this.btnBuscarUser.TabIndex = 3;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // dgwEliminarUser
            // 
            this.dgwEliminarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEliminarUser.Location = new System.Drawing.Point(237, 120);
            this.dgwEliminarUser.Name = "dgwEliminarUser";
            this.dgwEliminarUser.Size = new System.Drawing.Size(453, 202);
            this.dgwEliminarUser.TabIndex = 4;
            // 
            // btnElimianrUser
            // 
            this.btnElimianrUser.Location = new System.Drawing.Point(31, 360);
            this.btnElimianrUser.Name = "btnElimianrUser";
            this.btnElimianrUser.Size = new System.Drawing.Size(121, 36);
            this.btnElimianrUser.TabIndex = 5;
            this.btnElimianrUser.Text = "Eliminar";
            this.btnElimianrUser.UseVisualStyleBackColor = true;
            this.btnElimianrUser.Click += new System.EventHandler(this.btnElimianrUser_Click);
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Location = new System.Drawing.Point(13, 156);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(65, 17);
            this.lblNombreUser.TabIndex = 6;
            this.lblNombreUser.Text = "Usuario: ";
            // 
            // lblNyAuser
            // 
            this.lblNyAuser.AutoSize = true;
            this.lblNyAuser.Location = new System.Drawing.Point(13, 210);
            this.lblNyAuser.Name = "lblNyAuser";
            this.lblNyAuser.Size = new System.Drawing.Size(125, 17);
            this.lblNyAuser.TabIndex = 7;
            this.lblNyAuser.Text = "Nombre Completo:";
            // 
            // lblRolUser
            // 
            this.lblRolUser.AutoSize = true;
            this.lblRolUser.Location = new System.Drawing.Point(13, 271);
            this.lblRolUser.Name = "lblRolUser";
            this.lblRolUser.Size = new System.Drawing.Size(33, 17);
            this.lblRolUser.TabIndex = 8;
            this.lblRolUser.Text = "Rol:";
            // 
            // lblDatosUser
            // 
            this.lblDatosUser.AutoSize = true;
            this.lblDatosUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosUser.Location = new System.Drawing.Point(12, 120);
            this.lblDatosUser.Name = "lblDatosUser";
            this.lblDatosUser.Size = new System.Drawing.Size(152, 20);
            this.lblDatosUser.TabIndex = 9;
            this.lblDatosUser.Text = "Datos De Usuario";
            // 
            // txtUserEliminar
            // 
            this.txtUserEliminar.Location = new System.Drawing.Point(16, 179);
            this.txtUserEliminar.Name = "txtUserEliminar";
            this.txtUserEliminar.ReadOnly = true;
            this.txtUserEliminar.Size = new System.Drawing.Size(147, 22);
            this.txtUserEliminar.TabIndex = 10;
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(15, 239);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.ReadOnly = true;
            this.txtNombreEliminar.Size = new System.Drawing.Size(147, 22);
            this.txtNombreEliminar.TabIndex = 11;
            // 
            // txtRoleliminar
            // 
            this.txtRoleliminar.Location = new System.Drawing.Point(15, 300);
            this.txtRoleliminar.Name = "txtRoleliminar";
            this.txtRoleliminar.ReadOnly = true;
            this.txtRoleliminar.Size = new System.Drawing.Size(147, 22);
            this.txtRoleliminar.TabIndex = 12;
            // 
            // FrmUsuarioEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 420);
            this.Controls.Add(this.txtRoleliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.txtUserEliminar);
            this.Controls.Add(this.lblDatosUser);
            this.Controls.Add(this.lblRolUser);
            this.Controls.Add(this.lblNyAuser);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.btnElimianrUser);
            this.Controls.Add(this.dgwEliminarUser);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.txtEliminarUser);
            this.Controls.Add(this.lblEliminarUser);
            this.Controls.Add(this.lblTituloUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioEliminar";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmEliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEliminarUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloUser;
        private System.Windows.Forms.Label lblEliminarUser;
        private System.Windows.Forms.TextBox txtEliminarUser;
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.DataGridView dgwEliminarUser;
        private System.Windows.Forms.Button btnElimianrUser;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblNyAuser;
        private System.Windows.Forms.Label lblRolUser;
        private System.Windows.Forms.Label lblDatosUser;
        private System.Windows.Forms.TextBox txtUserEliminar;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.TextBox txtRoleliminar;
    }
}