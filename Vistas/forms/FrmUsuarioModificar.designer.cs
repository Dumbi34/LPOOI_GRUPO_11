namespace Vistas.forms
{
    partial class FrmUsuarioModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioModificar));
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblNombreUserBuscar = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.llblUser = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUsuarioMod = new System.Windows.Forms.TextBox();
            this.txtNombreAmodf = new System.Windows.Forms.TextBox();
            this.txtConntraModf = new System.Windows.Forms.TextBox();
            this.txtCorreoMdf = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.dgwUserMdf = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserMdf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(25, 22);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(183, 23);
            this.lblModificar.TabIndex = 0;
            this.lblModificar.Text = "Modificar Usuario";
            // 
            // lblNombreUserBuscar
            // 
            this.lblNombreUserBuscar.AutoSize = true;
            this.lblNombreUserBuscar.Location = new System.Drawing.Point(66, 79);
            this.lblNombreUserBuscar.Name = "lblNombreUserBuscar";
            this.lblNombreUserBuscar.Size = new System.Drawing.Size(139, 17);
            this.lblNombreUserBuscar.TabIndex = 1;
            this.lblNombreUserBuscar.Text = "Nombre de Usuario: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(66, 131);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(57, 20);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "Datos";
            // 
            // llblUser
            // 
            this.llblUser.AutoSize = true;
            this.llblUser.Location = new System.Drawing.Point(67, 170);
            this.llblUser.Name = "llblUser";
            this.llblUser.Size = new System.Drawing.Size(57, 17);
            this.llblUser.TabIndex = 3;
            this.llblUser.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(67, 303);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(81, 17);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "Contraseña";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(67, 233);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(123, 17);
            this.lblNombreApellido.TabIndex = 5;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(66, 372);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(117, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo(Opcional)";
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(243, 76);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(296, 22);
            this.txtBuscarUser.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(591, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtUsuarioMod
            // 
            this.txtUsuarioMod.Location = new System.Drawing.Point(70, 199);
            this.txtUsuarioMod.Name = "txtUsuarioMod";
            this.txtUsuarioMod.Size = new System.Drawing.Size(134, 22);
            this.txtUsuarioMod.TabIndex = 9;
            // 
            // txtNombreAmodf
            // 
            this.txtNombreAmodf.Location = new System.Drawing.Point(69, 263);
            this.txtNombreAmodf.Name = "txtNombreAmodf";
            this.txtNombreAmodf.Size = new System.Drawing.Size(134, 22);
            this.txtNombreAmodf.TabIndex = 10;
            // 
            // txtConntraModf
            // 
            this.txtConntraModf.Location = new System.Drawing.Point(69, 332);
            this.txtConntraModf.Name = "txtConntraModf";
            this.txtConntraModf.Size = new System.Drawing.Size(134, 22);
            this.txtConntraModf.TabIndex = 11;
            // 
            // txtCorreoMdf
            // 
            this.txtCorreoMdf.Location = new System.Drawing.Point(69, 404);
            this.txtCorreoMdf.Name = "txtCorreoMdf";
            this.txtCorreoMdf.Size = new System.Drawing.Size(134, 22);
            this.txtCorreoMdf.TabIndex = 12;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(67, 440);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 17);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(69, 460);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(138, 24);
            this.cmbRol.TabIndex = 14;
            // 
            // dgwUserMdf
            // 
            this.dgwUserMdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUserMdf.Location = new System.Drawing.Point(256, 173);
            this.dgwUserMdf.Name = "dgwUserMdf";
            this.dgwUserMdf.RowTemplate.Height = 24;
            this.dgwUserMdf.Size = new System.Drawing.Size(473, 267);
            this.dgwUserMdf.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(591, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 33);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmUsuarioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 561);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgwUserMdf);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtCorreoMdf);
            this.Controls.Add(this.txtConntraModf);
            this.Controls.Add(this.txtNombreAmodf);
            this.Controls.Add(this.txtUsuarioMod);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.llblUser);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblNombreUserBuscar);
            this.Controls.Add(this.lblModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioModificar";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserMdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblNombreUserBuscar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label llblUser;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuarioMod;
        private System.Windows.Forms.TextBox txtNombreAmodf;
        private System.Windows.Forms.TextBox txtConntraModf;
        private System.Windows.Forms.TextBox txtCorreoMdf;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.DataGridView dgwUserMdf;
        private System.Windows.Forms.Button btnGuardar;
    }
}