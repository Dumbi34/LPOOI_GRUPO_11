namespace Vistas.forms
{
    partial class FrmProductoListados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoListados));
            this.tcListado = new System.Windows.Forms.TabControl();
            this.tbCliente = new System.Windows.Forms.TabPage();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TabPage();
            this.txtCantidadVentas = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTItuloFecha = new System.Windows.Forms.Label();
            this.btnBuscarFechas = new System.Windows.Forms.Button();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgwListadoProductos = new System.Windows.Forms.DataGridView();
            this.lblCantidadProductosCliente = new System.Windows.Forms.Label();
            this.tcListado.SuspendLayout();
            this.tbCliente.SuspendLayout();
            this.tbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tcListado
            // 
            this.tcListado.Controls.Add(this.tbCliente);
            this.tcListado.Controls.Add(this.tbFecha);
            this.tcListado.Location = new System.Drawing.Point(9, 40);
            this.tcListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcListado.Name = "tcListado";
            this.tcListado.SelectedIndex = 0;
            this.tcListado.Size = new System.Drawing.Size(176, 269);
            this.tcListado.TabIndex = 0;
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tbCliente.Controls.Add(this.lblTituloCliente);
            this.tbCliente.Controls.Add(this.cbClientes);
            this.tbCliente.Controls.Add(this.lblClientes);
            this.tbCliente.Location = new System.Drawing.Point(4, 22);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCliente.Size = new System.Drawing.Size(168, 243);
            this.tbCliente.TabIndex = 0;
            this.tbCliente.Text = "Cliente";
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.Location = new System.Drawing.Point(10, 11);
            this.lblTituloCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(154, 16);
            this.lblTituloCliente.TabIndex = 2;
            this.lblTituloCliente.Text = "Busqueda por Cliente";
            this.lblTituloCliente.Click += new System.EventHandler(this.lblTituloCliente_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(16, 73);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(103, 21);
            this.cbClientes.TabIndex = 1;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(14, 48);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(84, 13);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "DNI de Clientes:";
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbFecha.Controls.Add(this.txtCantidadVentas);
            this.tbFecha.Controls.Add(this.lblCantidad);
            this.tbFecha.Controls.Add(this.lblTItuloFecha);
            this.tbFecha.Controls.Add(this.btnBuscarFechas);
            this.tbFecha.Controls.Add(this.dtpFecha2);
            this.tbFecha.Controls.Add(this.dtpFecha1);
            this.tbFecha.Controls.Add(this.lblFecha2);
            this.tbFecha.Controls.Add(this.lblFecha1);
            this.tbFecha.Location = new System.Drawing.Point(4, 22);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFecha.Size = new System.Drawing.Size(168, 243);
            this.tbFecha.TabIndex = 1;
            this.tbFecha.Text = "Fecha";
            // 
            // txtCantidadVentas
            // 
            this.txtCantidadVentas.Location = new System.Drawing.Point(128, 212);
            this.txtCantidadVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadVentas.Name = "txtCantidadVentas";
            this.txtCantidadVentas.Size = new System.Drawing.Size(26, 20);
            this.txtCantidadVentas.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 214);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(118, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad de Productos:";
            // 
            // lblTItuloFecha
            // 
            this.lblTItuloFecha.AutoSize = true;
            this.lblTItuloFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloFecha.Location = new System.Drawing.Point(9, 15);
            this.lblTItuloFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTItuloFecha.Name = "lblTItuloFecha";
            this.lblTItuloFecha.Size = new System.Drawing.Size(155, 16);
            this.lblTItuloFecha.TabIndex = 5;
            this.lblTItuloFecha.Text = "Busqueda Por Fechas";
            // 
            // btnBuscarFechas
            // 
            this.btnBuscarFechas.Location = new System.Drawing.Point(44, 164);
            this.btnBuscarFechas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarFechas.Name = "btnBuscarFechas";
            this.btnBuscarFechas.Size = new System.Drawing.Size(76, 24);
            this.btnBuscarFechas.TabIndex = 4;
            this.btnBuscarFechas.Text = "Buscar";
            this.btnBuscarFechas.UseVisualStyleBackColor = true;
            this.btnBuscarFechas.Click += new System.EventHandler(this.btnBuscarFechas_Click);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(10, 126);
            this.dtpFecha2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(85, 20);
            this.dtpFecha2.TabIndex = 3;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(9, 67);
            this.dtpFecha1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(86, 20);
            this.dtpFecha1.TabIndex = 2;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(10, 98);
            this.lblFecha2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(71, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha Hasta:";
            // 
            // lblFecha1
            // 
            this.lblFecha1.AutoSize = true;
            this.lblFecha1.Location = new System.Drawing.Point(4, 41);
            this.lblFecha1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha1.Name = "lblFecha1";
            this.lblFecha1.Size = new System.Drawing.Size(72, 13);
            this.lblFecha1.TabIndex = 0;
            this.lblFecha1.Text = "Fecha desde:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Listado de Producto";
            // 
            // dgwListadoProductos
            // 
            this.dgwListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListadoProductos.Location = new System.Drawing.Point(198, 40);
            this.dgwListadoProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwListadoProductos.Name = "dgwListadoProductos";
            this.dgwListadoProductos.RowTemplate.Height = 24;
            this.dgwListadoProductos.Size = new System.Drawing.Size(380, 269);
            this.dgwListadoProductos.TabIndex = 2;
            // 
            // lblCantidadProductosCliente
            // 
            this.lblCantidadProductosCliente.AutoSize = true;
            this.lblCantidadProductosCliente.Location = new System.Drawing.Point(71, 312);
            this.lblCantidadProductosCliente.Name = "lblCantidadProductosCliente";
            this.lblCantidadProductosCliente.Size = new System.Drawing.Size(61, 13);
            this.lblCantidadProductosCliente.TabIndex = 3;
            this.lblCantidadProductosCliente.Text = "Cantidad: 0";
            // 
            // FrmProductoListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 334);
            this.Controls.Add(this.lblCantidadProductosCliente);
            this.Controls.Add(this.dgwListadoProductos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tcListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProductoListados";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductoListados_Load);
            this.tcListado.ResumeLayout(false);
            this.tbCliente.ResumeLayout(false);
            this.tbCliente.PerformLayout();
            this.tbFecha.ResumeLayout(false);
            this.tbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListadoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcListado;
        private System.Windows.Forms.TabPage tbCliente;
        private System.Windows.Forms.TabPage tbFecha;
        private System.Windows.Forms.Label lblFecha1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgwListadoProductos;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnBuscarFechas;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Label lblTItuloFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.TextBox txtCantidadVentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidadProductosCliente;
    }
}