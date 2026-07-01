namespace Vistas.forms
{
    partial class frmVentaRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaRegistrar));
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbCodigoProductos = new System.Windows.Forms.ComboBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.dgwVentas = new System.Windows.Forms.DataGridView();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnAñadirCarrito = new System.Windows.Forms.Button();
            this.lblProductosLista = new System.Windows.Forms.Label();
            this.buscarclientebc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Venta";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(17, 138);
            this.dateFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(109, 20);
            this.dateFecha.TabIndex = 1;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(17, 80);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(109, 21);
            this.cbClientes.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 59);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 114);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(221, 32);
            this.lblDetalleVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(98, 16);
            this.lblDetalleVenta.TabIndex = 10;
            this.lblDetalleVenta.Text = "Detalle Venta";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(221, 56);
            this.lblCodigoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(101, 13);
            this.lblCodigoProducto.TabIndex = 11;
            this.lblCodigoProducto.Text = "Codigo de Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(221, 111);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(221, 163);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbCodigoProductos
            // 
            this.cbCodigoProductos.FormattingEnabled = true;
            this.cbCodigoProductos.Location = new System.Drawing.Point(223, 80);
            this.cbCodigoProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCodigoProductos.Name = "cbCodigoProductos";
            this.cbCodigoProductos.Size = new System.Drawing.Size(109, 21);
            this.cbCodigoProductos.TabIndex = 14;
            this.cbCodigoProductos.SelectedIndexChanged += new System.EventHandler(this.cbCodigoProductos_SelectedIndexChanged);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(223, 135);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.ReadOnly = true;
            this.txtPrecioUnidad.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioUnidad.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(223, 187);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(488, 283);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioTotal.TabIndex = 17;
            this.lblPrecioTotal.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(564, 280);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioTotal.TabIndex = 18;
            // 
            // dgwVentas
            // 
            this.dgwVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVentas.Location = new System.Drawing.Point(360, 56);
            this.dgwVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwVentas.Name = "dgwVentas";
            this.dgwVentas.RowTemplate.Height = 24;
            this.dgwVentas.Size = new System.Drawing.Size(325, 210);
            this.dgwVentas.TabIndex = 19;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(17, 235);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(108, 32);
            this.btnRegistrarVenta.TabIndex = 20;
            this.btnRegistrarVenta.Text = "Guardar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnAñadirCarrito
            // 
            this.btnAñadirCarrito.Location = new System.Drawing.Point(223, 235);
            this.btnAñadirCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAñadirCarrito.Name = "btnAñadirCarrito";
            this.btnAñadirCarrito.Size = new System.Drawing.Size(108, 32);
            this.btnAñadirCarrito.TabIndex = 21;
            this.btnAñadirCarrito.Text = "Añadir Producto";
            this.btnAñadirCarrito.UseVisualStyleBackColor = true;
            this.btnAñadirCarrito.Click += new System.EventHandler(this.btnAñadirCarrito_Click);
            // 
            // lblProductosLista
            // 
            this.lblProductosLista.AutoSize = true;
            this.lblProductosLista.Location = new System.Drawing.Point(358, 35);
            this.lblProductosLista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosLista.Name = "lblProductosLista";
            this.lblProductosLista.Size = new System.Drawing.Size(141, 13);
            this.lblProductosLista.TabIndex = 22;
            this.lblProductosLista.Text = "Lista de Productos añadidos";
            // 
            // buscarclientebc
            // 
            this.buscarclientebc.Location = new System.Drawing.Point(131, 80);
            this.buscarclientebc.Name = "buscarclientebc";
            this.buscarclientebc.Size = new System.Drawing.Size(75, 23);
            this.buscarclientebc.TabIndex = 23;
            this.buscarclientebc.Text = "\"...\"";
            this.buscarclientebc.UseVisualStyleBackColor = true;
            this.buscarclientebc.Click += new System.EventHandler(this.buscarclientebc_Click);
            // 
            // frmVentaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 368);
            this.Controls.Add(this.buscarclientebc);
            this.Controls.Add(this.lblProductosLista);
            this.Controls.Add(this.btnAñadirCarrito);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.dgwVentas);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.cbCodigoProductos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVentaRegistrar";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVentaRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbCodigoProductos;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.DataGridView dgwVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnAñadirCarrito;
        private System.Windows.Forms.Label lblProductosLista;
        private System.Windows.Forms.Button buscarclientebc;
    }
}