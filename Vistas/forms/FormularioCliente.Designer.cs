namespace Vistas
{
    partial class FormularioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.txtCuitOS = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.RegistroyGestion = new System.Windows.Forms.TabControl();
            this.Registrar_Cliente = new System.Windows.Forms.TabPage();
            this.btnListarPorApellido = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.TabPage();
            this.btnCambios = new System.Windows.Forms.Button();
            this.txtModApellido = new System.Windows.Forms.TextBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.txtModDni = new System.Windows.Forms.TextBox();
            this.txtModDireccion = new System.Windows.Forms.TextBox();
            this.txtModCarnet = new System.Windows.Forms.TextBox();
            this.txtModCuit = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.modcliente = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtBuscaDni = new System.Windows.Forms.TextBox();
            this.txtBuscaApe = new System.Windows.Forms.TextBox();
            this.Dni = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Gestion = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblModificarTitulo = new System.Windows.Forms.Label();
            this.RegistroyGestion.SuspendLayout();
            this.Registrar_Cliente.SuspendLayout();
            this.btnModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(227, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Cliente";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(32, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de Carnet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(32, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuit Obra Social:";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(348, 94);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(274, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(348, 139);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Location = new System.Drawing.Point(348, 182);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(274, 22);
            this.txtDNI.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(348, 222);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroCliente.Location = new System.Drawing.Point(348, 262);
            this.txtNroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(274, 22);
            this.txtNroCliente.TabIndex = 11;
            // 
            // txtCuitOS
            // 
            this.txtCuitOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuitOS.Location = new System.Drawing.Point(348, 309);
            this.txtCuitOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuitOS.Name = "txtCuitOS";
            this.txtCuitOS.Size = new System.Drawing.Size(274, 22);
            this.txtCuitOS.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(143, 420);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 39);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(348, 420);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RegistroyGestion
            // 
            this.RegistroyGestion.Controls.Add(this.Registrar_Cliente);
            this.RegistroyGestion.Controls.Add(this.btnModificar);
            this.RegistroyGestion.Location = new System.Drawing.Point(16, 15);
            this.RegistroyGestion.Margin = new System.Windows.Forms.Padding(4);
            this.RegistroyGestion.Name = "RegistroyGestion";
            this.RegistroyGestion.SelectedIndex = 0;
            this.RegistroyGestion.Size = new System.Drawing.Size(708, 726);
            this.RegistroyGestion.TabIndex = 15;
            // 
            // Registrar_Cliente
            // 
            this.Registrar_Cliente.Controls.Add(this.btnListarPorApellido);
            this.Registrar_Cliente.Controls.Add(this.btnCancelar);
            this.Registrar_Cliente.Controls.Add(this.label1);
            this.Registrar_Cliente.Controls.Add(this.label2);
            this.Registrar_Cliente.Controls.Add(this.label3);
            this.Registrar_Cliente.Controls.Add(this.label4);
            this.Registrar_Cliente.Controls.Add(this.label5);
            this.Registrar_Cliente.Controls.Add(this.label6);
            this.Registrar_Cliente.Controls.Add(this.label7);
            this.Registrar_Cliente.Controls.Add(this.txtApellido);
            this.Registrar_Cliente.Controls.Add(this.txtNombre);
            this.Registrar_Cliente.Controls.Add(this.txtDNI);
            this.Registrar_Cliente.Controls.Add(this.txtDireccion);
            this.Registrar_Cliente.Controls.Add(this.txtNroCliente);
            this.Registrar_Cliente.Controls.Add(this.txtCuitOS);
            this.Registrar_Cliente.Controls.Add(this.btnGuardar);
            this.Registrar_Cliente.Location = new System.Drawing.Point(4, 25);
            this.Registrar_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Registrar_Cliente.Name = "Registrar_Cliente";
            this.Registrar_Cliente.Padding = new System.Windows.Forms.Padding(4);
            this.Registrar_Cliente.Size = new System.Drawing.Size(700, 697);
            this.Registrar_Cliente.TabIndex = 0;
            this.Registrar_Cliente.Text = "Registrar";
            this.Registrar_Cliente.UseVisualStyleBackColor = true;
            // 
            // btnListarPorApellido
            // 
            this.btnListarPorApellido.Location = new System.Drawing.Point(232, 489);
            this.btnListarPorApellido.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPorApellido.Name = "btnListarPorApellido";
            this.btnListarPorApellido.Size = new System.Drawing.Size(177, 28);
            this.btnListarPorApellido.TabIndex = 15;
            this.btnListarPorApellido.Text = "Listar por Apellido";
            this.btnListarPorApellido.UseVisualStyleBackColor = true;
            this.btnListarPorApellido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Controls.Add(this.lblModificarTitulo);
            this.btnModificar.Controls.Add(this.btnCambios);
            this.btnModificar.Controls.Add(this.txtModApellido);
            this.btnModificar.Controls.Add(this.txtModNombre);
            this.btnModificar.Controls.Add(this.txtModDni);
            this.btnModificar.Controls.Add(this.txtModDireccion);
            this.btnModificar.Controls.Add(this.txtModCarnet);
            this.btnModificar.Controls.Add(this.txtModCuit);
            this.btnModificar.Controls.Add(this.lblModificar);
            this.btnModificar.Controls.Add(this.label9);
            this.btnModificar.Controls.Add(this.label10);
            this.btnModificar.Controls.Add(this.label11);
            this.btnModificar.Controls.Add(this.label12);
            this.btnModificar.Controls.Add(this.label13);
            this.btnModificar.Controls.Add(this.modcliente);
            this.btnModificar.Controls.Add(this.btnEliminar);
            this.btnModificar.Controls.Add(this.btnConsultar);
            this.btnModificar.Controls.Add(this.txtBuscaDni);
            this.btnModificar.Controls.Add(this.txtBuscaApe);
            this.btnModificar.Controls.Add(this.Dni);
            this.btnModificar.Controls.Add(this.Apellido);
            this.btnModificar.Controls.Add(this.Gestion);
            this.btnModificar.Location = new System.Drawing.Point(4, 25);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(4);
            this.btnModificar.Size = new System.Drawing.Size(700, 697);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Gestionar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCambios
            // 
            this.btnCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCambios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCambios.Location = new System.Drawing.Point(95, 622);
            this.btnCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(216, 53);
            this.btnCambios.TabIndex = 21;
            this.btnCambios.Text = "Guardar cambios";
            this.btnCambios.UseVisualStyleBackColor = false;
            // 
            // txtModApellido
            // 
            this.txtModApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModApellido.Location = new System.Drawing.Point(313, 343);
            this.txtModApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtModApellido.Name = "txtModApellido";
            this.txtModApellido.Size = new System.Drawing.Size(274, 22);
            this.txtModApellido.TabIndex = 15;
            // 
            // txtModNombre
            // 
            this.txtModNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModNombre.Location = new System.Drawing.Point(313, 389);
            this.txtModNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(274, 22);
            this.txtModNombre.TabIndex = 16;
            // 
            // txtModDni
            // 
            this.txtModDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModDni.Location = new System.Drawing.Point(313, 432);
            this.txtModDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtModDni.Name = "txtModDni";
            this.txtModDni.Size = new System.Drawing.Size(274, 22);
            this.txtModDni.TabIndex = 17;
            // 
            // txtModDireccion
            // 
            this.txtModDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModDireccion.Location = new System.Drawing.Point(313, 471);
            this.txtModDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtModDireccion.Name = "txtModDireccion";
            this.txtModDireccion.Size = new System.Drawing.Size(274, 22);
            this.txtModDireccion.TabIndex = 18;
            // 
            // txtModCarnet
            // 
            this.txtModCarnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModCarnet.Location = new System.Drawing.Point(313, 512);
            this.txtModCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtModCarnet.Name = "txtModCarnet";
            this.txtModCarnet.Size = new System.Drawing.Size(274, 22);
            this.txtModCarnet.TabIndex = 19;
            // 
            // txtModCuit
            // 
            this.txtModCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModCuit.Location = new System.Drawing.Point(313, 559);
            this.txtModCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtModCuit.Name = "txtModCuit";
            this.txtModCuit.Size = new System.Drawing.Size(274, 22);
            this.txtModCuit.TabIndex = 20;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(28, 346);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(95, 23);
            this.lblModificar.TabIndex = 9;
            this.lblModificar.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 389);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "DNI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 471);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Direccion: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 512);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Numero de Carnet:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 559);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cuit Obra Social:";
            // 
            // modcliente
            // 
            this.modcliente.AutoSize = true;
            this.modcliente.BackColor = System.Drawing.Color.Transparent;
            this.modcliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modcliente.Location = new System.Drawing.Point(216, 249);
            this.modcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modcliente.Name = "modcliente";
            this.modcliente.Size = new System.Drawing.Size(236, 32);
            this.modcliente.TabIndex = 8;
            this.modcliente.Text = "Modificar Cliente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(401, 622);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 48);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultar.Location = new System.Drawing.Point(484, 86);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(187, 48);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // txtBuscaDni
            // 
            this.txtBuscaDni.Location = new System.Drawing.Point(204, 128);
            this.txtBuscaDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaDni.Name = "txtBuscaDni";
            this.txtBuscaDni.Size = new System.Drawing.Size(217, 22);
            this.txtBuscaDni.TabIndex = 5;
            // 
            // txtBuscaApe
            // 
            this.txtBuscaApe.Location = new System.Drawing.Point(204, 70);
            this.txtBuscaApe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaApe.Name = "txtBuscaApe";
            this.txtBuscaApe.Size = new System.Drawing.Size(217, 22);
            this.txtBuscaApe.TabIndex = 4;
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.BackColor = System.Drawing.Color.Transparent;
            this.Dni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dni.Location = new System.Drawing.Point(28, 127);
            this.Dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(52, 23);
            this.Dni.TabIndex = 3;
            this.Dni.Text = "DNI:";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.BackColor = System.Drawing.Color.Transparent;
            this.Apellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(28, 73);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(95, 23);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido:";
            // 
            // Gestion
            // 
            this.Gestion.AutoSize = true;
            this.Gestion.BackColor = System.Drawing.Color.Transparent;
            this.Gestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gestion.Location = new System.Drawing.Point(252, 4);
            this.Gestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(204, 32);
            this.Gestion.TabIndex = 1;
            this.Gestion.Text = "Buscar cliente";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(749, 42);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(744, 699);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // lblModificarTitulo
            // 
            this.lblModificarTitulo.AutoSize = true;
            this.lblModificarTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTitulo.Location = new System.Drawing.Point(28, 295);
            this.lblModificarTitulo.Name = "lblModificarTitulo";
            this.lblModificarTitulo.Size = new System.Drawing.Size(467, 20);
            this.lblModificarTitulo.TabIndex = 22;
            this.lblModificarTitulo.Text = "Puede seleccionar un nombre de la tabla para modificar";
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 756);
            this.Controls.Add(this.RegistroyGestion);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.RegistroyGestion.ResumeLayout(false);
            this.Registrar_Cliente.ResumeLayout(false);
            this.Registrar_Cliente.PerformLayout();
            this.btnModificar.ResumeLayout(false);
            this.btnModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.TextBox txtCuitOS;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl RegistroyGestion;
        private System.Windows.Forms.TabPage Registrar_Cliente;
        private System.Windows.Forms.TabPage btnModificar;
        private System.Windows.Forms.Label Gestion;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox txtBuscaApe;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtBuscaDni;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label modcliente;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.TextBox txtModApellido;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.TextBox txtModDni;
        private System.Windows.Forms.TextBox txtModDireccion;
        private System.Windows.Forms.TextBox txtModCarnet;
        private System.Windows.Forms.TextBox txtModCuit;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListarPorApellido;
        private System.Windows.Forms.Label lblModificarTitulo;
    }
}