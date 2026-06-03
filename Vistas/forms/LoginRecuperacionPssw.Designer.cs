namespace Vistas.forms
{
    partial class LoginRecuperacionPssw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRecuperacionPssw));
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tbUsuario = new System.Windows.Forms.TabPage();
            this.btnEnviarUser = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRecuperacionUser = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TabPage();
            this.btnVerificarEnviar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbCambio = new System.Windows.Forms.TabPage();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblCambioPass = new System.Windows.Forms.Label();
            this.lblConfirmaPass = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbcGestion.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            this.tbCodigo.SuspendLayout();
            this.tbCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbUsuario);
            this.tbcGestion.Controls.Add(this.tbCodigo);
            this.tbcGestion.Controls.Add(this.tbCambio);
            this.tbcGestion.Location = new System.Drawing.Point(3, 1);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(304, 325);
            this.tbcGestion.TabIndex = 1;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Controls.Add(this.btnEnviarUser);
            this.tbUsuario.Controls.Add(this.txtUsuario);
            this.tbUsuario.Controls.Add(this.lblUsuario);
            this.tbUsuario.Controls.Add(this.lblRecuperacionUser);
            this.tbUsuario.Location = new System.Drawing.Point(4, 25);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(296, 296);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEnviarUser
            // 
            this.btnEnviarUser.Location = new System.Drawing.Point(91, 191);
            this.btnEnviarUser.Name = "btnEnviarUser";
            this.btnEnviarUser.Size = new System.Drawing.Size(91, 28);
            this.btnEnviarUser.TabIndex = 3;
            this.btnEnviarUser.Text = "Enviar";
            this.btnEnviarUser.UseVisualStyleBackColor = true;
            this.btnEnviarUser.Click += new System.EventHandler(this.btnEnviarUser_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(37, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(34, 93);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(132, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Ingrese un Usuario ";
            // 
            // lblRecuperacionUser
            // 
            this.lblRecuperacionUser.AutoSize = true;
            this.lblRecuperacionUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperacionUser.Location = new System.Drawing.Point(34, 46);
            this.lblRecuperacionUser.Name = "lblRecuperacionUser";
            this.lblRecuperacionUser.Size = new System.Drawing.Size(222, 17);
            this.lblRecuperacionUser.TabIndex = 0;
            this.lblRecuperacionUser.Text = "Recuperacion de Contraseña";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Controls.Add(this.btnVerificarEnviar);
            this.tbCodigo.Controls.Add(this.txtCodigo);
            this.tbCodigo.Controls.Add(this.lblIngreseCodigo);
            this.tbCodigo.Controls.Add(this.lblDescripcion);
            this.tbCodigo.Controls.Add(this.lblTitulo);
            this.tbCodigo.Location = new System.Drawing.Point(4, 25);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCodigo.Size = new System.Drawing.Size(296, 296);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Text = "Recuperacion";
            this.tbCodigo.UseVisualStyleBackColor = true;
            // 
            // btnVerificarEnviar
            // 
            this.btnVerificarEnviar.Location = new System.Drawing.Point(94, 207);
            this.btnVerificarEnviar.Name = "btnVerificarEnviar";
            this.btnVerificarEnviar.Size = new System.Drawing.Size(97, 31);
            this.btnVerificarEnviar.TabIndex = 4;
            this.btnVerificarEnviar.Text = "Enviar";
            this.btnVerificarEnviar.UseVisualStyleBackColor = true;
            this.btnVerificarEnviar.Click += new System.EventHandler(this.btnVerificarEnviar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(28, 160);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Location = new System.Drawing.Point(25, 125);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(105, 17);
            this.lblIngreseCodigo.TabIndex = 2;
            this.lblIngreseCodigo.Text = "Ingrese codigo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 64);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(260, 34);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Se le ah enviado un codigo a su correo.\r\nVerifique su gmail.\r\n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(80, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Verificar Codigo";
            // 
            // tbCambio
            // 
            this.tbCambio.Controls.Add(this.btnGuardar);
            this.tbCambio.Controls.Add(this.txtConfirmarPass);
            this.tbCambio.Controls.Add(this.txtNuevaPass);
            this.tbCambio.Controls.Add(this.lblConfirmaPass);
            this.tbCambio.Controls.Add(this.lblNuevaContraseña);
            this.tbCambio.Controls.Add(this.lblCambioPass);
            this.tbCambio.Location = new System.Drawing.Point(4, 25);
            this.tbCambio.Name = "tbCambio";
            this.tbCambio.Padding = new System.Windows.Forms.Padding(3);
            this.tbCambio.Size = new System.Drawing.Size(296, 296);
            this.tbCambio.TabIndex = 2;
            this.tbCambio.Text = "Cambio";
            this.tbCambio.UseVisualStyleBackColor = true;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(37, 77);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(173, 17);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Ingrese nueva contraseña";
            // 
            // lblCambioPass
            // 
            this.lblCambioPass.AutoSize = true;
            this.lblCambioPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioPass.Location = new System.Drawing.Point(37, 32);
            this.lblCambioPass.Name = "lblCambioPass";
            this.lblCambioPass.Size = new System.Drawing.Size(197, 20);
            this.lblCambioPass.TabIndex = 0;
            this.lblCambioPass.Text = "Cambio de Contraseña";
            // 
            // lblConfirmaPass
            // 
            this.lblConfirmaPass.AutoSize = true;
            this.lblConfirmaPass.Location = new System.Drawing.Point(37, 150);
            this.lblConfirmaPass.Name = "lblConfirmaPass";
            this.lblConfirmaPass.Size = new System.Drawing.Size(139, 17);
            this.lblConfirmaPass.TabIndex = 2;
            this.lblConfirmaPass.Text = "Confirme contraseña";
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Location = new System.Drawing.Point(40, 107);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(170, 22);
            this.txtNuevaPass.TabIndex = 3;
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Location = new System.Drawing.Point(40, 183);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(170, 22);
            this.txtConfirmarPass.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 27);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // LoginRecuperacionPssw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 338);
            this.Controls.Add(this.tbcGestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginRecuperacionPssw";
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.LoginRecuperacionPssw_Load);
            this.tbcGestion.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbUsuario.PerformLayout();
            this.tbCodigo.ResumeLayout(false);
            this.tbCodigo.PerformLayout();
            this.tbCambio.ResumeLayout(false);
            this.tbCambio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tbUsuario;
        private System.Windows.Forms.Button btnEnviarUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRecuperacionUser;
        private System.Windows.Forms.TabPage tbCodigo;
        private System.Windows.Forms.Button btnVerificarEnviar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblIngreseCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tbCambio;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblCambioPass;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Label lblConfirmaPass;

    }
}