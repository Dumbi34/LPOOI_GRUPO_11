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
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Venta";
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(23, 170);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(144, 22);
            this.dateFecha.TabIndex = 1;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(23, 99);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(144, 24);
            this.cbClientes.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(229, 40);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(120, 20);
            this.lblDetalleVenta.TabIndex = 10;
            this.lblDetalleVenta.Text = "Detalle Venta";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(229, 69);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(133, 17);
            this.lblCodigoProducto.TabIndex = 11;
            this.lblCodigoProducto.Text = "Codigo de Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(229, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(229, 201);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbCodigoProductos
            // 
            this.cbCodigoProductos.FormattingEnabled = true;
            this.cbCodigoProductos.Location = new System.Drawing.Point(232, 99);
            this.cbCodigoProductos.Name = "cbCodigoProductos";
            this.cbCodigoProductos.Size = new System.Drawing.Size(144, 24);
            this.cbCodigoProductos.TabIndex = 14;
            this.cbCodigoProductos.SelectedIndexChanged += new System.EventHandler(this.cbCodigoProductos_SelectedIndexChanged);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(232, 166);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.ReadOnly = true;
            this.txtPrecioUnidad.Size = new System.Drawing.Size(144, 22);
            this.txtPrecioUnidad.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(232, 230);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 22);
            this.txtCantidad.TabIndex = 16;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(575, 348);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(84, 17);
            this.lblPrecioTotal.TabIndex = 17;
            this.lblPrecioTotal.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(676, 345);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(144, 22);
            this.txtPrecioTotal.TabIndex = 18;
            // 
            // dgwVentas
            // 
            this.dgwVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVentas.Location = new System.Drawing.Point(404, 69);
            this.dgwVentas.Name = "dgwVentas";
            this.dgwVentas.RowTemplate.Height = 24;
            this.dgwVentas.Size = new System.Drawing.Size(433, 259);
            this.dgwVentas.TabIndex = 19;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(23, 289);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(144, 39);
            this.btnRegistrarVenta.TabIndex = 20;
            this.btnRegistrarVenta.Text = "Guardar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnAñadirCarrito
            // 
            this.btnAñadirCarrito.Location = new System.Drawing.Point(232, 289);
            this.btnAñadirCarrito.Name = "btnAñadirCarrito";
            this.btnAñadirCarrito.Size = new System.Drawing.Size(144, 39);
            this.btnAñadirCarrito.TabIndex = 21;
            this.btnAñadirCarrito.Text = "Añadir Producto";
            this.btnAñadirCarrito.UseVisualStyleBackColor = true;
            this.btnAñadirCarrito.Click += new System.EventHandler(this.btnAñadirCarrito_Click);
            // 
            // lblProductosLista
            // 
            this.lblProductosLista.AutoSize = true;
            this.lblProductosLista.Location = new System.Drawing.Point(401, 43);
            this.lblProductosLista.Name = "lblProductosLista";
            this.lblProductosLista.Size = new System.Drawing.Size(188, 17);
            this.lblProductosLista.TabIndex = 22;
            this.lblProductosLista.Text = "Lista de Productos añadidos";
            // 
            // frmVentaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 383);
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
    }
}