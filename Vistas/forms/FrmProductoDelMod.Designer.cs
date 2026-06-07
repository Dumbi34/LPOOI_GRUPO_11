namespace Vistas.forms
{
    partial class FrmProductoDelMod
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
            this.dgwProductos = new System.Windows.Forms.DataGridView();
            this.tbModificar = new System.Windows.Forms.TabPage();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.txtModificarCat = new System.Windows.Forms.TextBox();
            this.txtModificarDes = new System.Windows.Forms.TextBox();
            this.txtModificarCod = new System.Windows.Forms.TextBox();
            this.lblModificarPrecio = new System.Windows.Forms.Label();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.lblModificarProducto = new System.Windows.Forms.Label();
            this.lblModificarCodigo = new System.Windows.Forms.Label();
            this.lblModificarTitulo = new System.Windows.Forms.Label();
            this.tbEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.txtEliminarPrecio = new System.Windows.Forms.TextBox();
            this.txtEliminarCategoria = new System.Windows.Forms.TextBox();
            this.txtEliminarDescripcion = new System.Windows.Forms.TextBox();
            this.cbCodigoEliminar = new System.Windows.Forms.ComboBox();
            this.lblEliminarPrecio = new System.Windows.Forms.Label();
            this.lblCategoriaEliminar = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEliminarCodigo = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.lblTituloSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).BeginInit();
            this.tbModificar.SuspendLayout();
            this.tbEliminar.SuspendLayout();
            this.tbcGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProductos
            // 
            this.dgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductos.Location = new System.Drawing.Point(337, 67);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.RowTemplate.Height = 24;
            this.dgwProductos.Size = new System.Drawing.Size(560, 421);
            this.dgwProductos.TabIndex = 1;
            this.dgwProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProductos_CellContentClick);
            // 
            // tbModificar
            // 
            this.tbModificar.Controls.Add(this.btnGuardarModificar);
            this.tbModificar.Controls.Add(this.txtModificarPrecio);
            this.tbModificar.Controls.Add(this.txtModificarCat);
            this.tbModificar.Controls.Add(this.txtModificarDes);
            this.tbModificar.Controls.Add(this.txtModificarCod);
            this.tbModificar.Controls.Add(this.lblModificarPrecio);
            this.tbModificar.Controls.Add(this.lblModificarCategoria);
            this.tbModificar.Controls.Add(this.lblModificarProducto);
            this.tbModificar.Controls.Add(this.lblModificarCodigo);
            this.tbModificar.Controls.Add(this.lblModificarTitulo);
            this.tbModificar.Location = new System.Drawing.Point(4, 25);
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbModificar.Size = new System.Drawing.Size(311, 451);
            this.tbModificar.TabIndex = 1;
            this.tbModificar.Text = "Modificar";
            this.tbModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.Location = new System.Drawing.Point(95, 371);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(115, 32);
            this.btnGuardarModificar.TabIndex = 9;
            this.btnGuardarModificar.Text = "Guardar";
            this.btnGuardarModificar.UseVisualStyleBackColor = true;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Location = new System.Drawing.Point(31, 312);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(215, 22);
            this.txtModificarPrecio.TabIndex = 8;
            // 
            // txtModificarCat
            // 
            this.txtModificarCat.Location = new System.Drawing.Point(31, 243);
            this.txtModificarCat.Name = "txtModificarCat";
            this.txtModificarCat.Size = new System.Drawing.Size(215, 22);
            this.txtModificarCat.TabIndex = 7;
            // 
            // txtModificarDes
            // 
            this.txtModificarDes.Location = new System.Drawing.Point(32, 178);
            this.txtModificarDes.Name = "txtModificarDes";
            this.txtModificarDes.Size = new System.Drawing.Size(215, 22);
            this.txtModificarDes.TabIndex = 6;
            // 
            // txtModificarCod
            // 
            this.txtModificarCod.Location = new System.Drawing.Point(32, 118);
            this.txtModificarCod.Name = "txtModificarCod";
            this.txtModificarCod.Size = new System.Drawing.Size(215, 22);
            this.txtModificarCod.TabIndex = 5;
            // 
            // lblModificarPrecio
            // 
            this.lblModificarPrecio.AutoSize = true;
            this.lblModificarPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPrecio.Location = new System.Drawing.Point(28, 284);
            this.lblModificarPrecio.Name = "lblModificarPrecio";
            this.lblModificarPrecio.Size = new System.Drawing.Size(51, 16);
            this.lblModificarPrecio.TabIndex = 4;
            this.lblModificarPrecio.Text = "Precio";
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCategoria.Location = new System.Drawing.Point(28, 214);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(74, 16);
            this.lblModificarCategoria.TabIndex = 3;
            this.lblModificarCategoria.Text = "Categoria";
            // 
            // lblModificarProducto
            // 
            this.lblModificarProducto.AutoSize = true;
            this.lblModificarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarProducto.Location = new System.Drawing.Point(28, 149);
            this.lblModificarProducto.Name = "lblModificarProducto";
            this.lblModificarProducto.Size = new System.Drawing.Size(89, 16);
            this.lblModificarProducto.TabIndex = 2;
            this.lblModificarProducto.Text = "Descripcion";
            // 
            // lblModificarCodigo
            // 
            this.lblModificarCodigo.AutoSize = true;
            this.lblModificarCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCodigo.Location = new System.Drawing.Point(28, 89);
            this.lblModificarCodigo.Name = "lblModificarCodigo";
            this.lblModificarCodigo.Size = new System.Drawing.Size(142, 16);
            this.lblModificarCodigo.TabIndex = 1;
            this.lblModificarCodigo.Text = "Codigo de producto";
            // 
            // lblModificarTitulo
            // 
            this.lblModificarTitulo.AutoSize = true;
            this.lblModificarTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTitulo.Location = new System.Drawing.Point(27, 30);
            this.lblModificarTitulo.Name = "lblModificarTitulo";
            this.lblModificarTitulo.Size = new System.Drawing.Size(197, 23);
            this.lblModificarTitulo.TabIndex = 0;
            this.lblModificarTitulo.Text = "Modificar Producto";
            // 
            // tbEliminar
            // 
            this.tbEliminar.Controls.Add(this.btnEliminarProducto);
            this.tbEliminar.Controls.Add(this.txtEliminarPrecio);
            this.tbEliminar.Controls.Add(this.txtEliminarCategoria);
            this.tbEliminar.Controls.Add(this.txtEliminarDescripcion);
            this.tbEliminar.Controls.Add(this.cbCodigoEliminar);
            this.tbEliminar.Controls.Add(this.lblEliminarPrecio);
            this.tbEliminar.Controls.Add(this.lblCategoriaEliminar);
            this.tbEliminar.Controls.Add(this.lblDescripcion);
            this.tbEliminar.Controls.Add(this.lblEliminarCodigo);
            this.tbEliminar.Controls.Add(this.lblEliminar);
            this.tbEliminar.Location = new System.Drawing.Point(4, 25);
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEliminar.Size = new System.Drawing.Size(311, 451);
            this.tbEliminar.TabIndex = 0;
            this.tbEliminar.Text = "Eliminar";
            this.tbEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(105, 371);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(107, 35);
            this.btnEliminarProducto.TabIndex = 11;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // txtEliminarPrecio
            // 
            this.txtEliminarPrecio.Location = new System.Drawing.Point(37, 323);
            this.txtEliminarPrecio.Name = "txtEliminarPrecio";
            this.txtEliminarPrecio.ReadOnly = true;
            this.txtEliminarPrecio.Size = new System.Drawing.Size(217, 22);
            this.txtEliminarPrecio.TabIndex = 10;
            // 
            // txtEliminarCategoria
            // 
            this.txtEliminarCategoria.Location = new System.Drawing.Point(37, 247);
            this.txtEliminarCategoria.Name = "txtEliminarCategoria";
            this.txtEliminarCategoria.ReadOnly = true;
            this.txtEliminarCategoria.Size = new System.Drawing.Size(217, 22);
            this.txtEliminarCategoria.TabIndex = 9;
            // 
            // txtEliminarDescripcion
            // 
            this.txtEliminarDescripcion.Location = new System.Drawing.Point(37, 176);
            this.txtEliminarDescripcion.Name = "txtEliminarDescripcion";
            this.txtEliminarDescripcion.ReadOnly = true;
            this.txtEliminarDescripcion.Size = new System.Drawing.Size(217, 22);
            this.txtEliminarDescripcion.TabIndex = 8;
            // 
            // cbCodigoEliminar
            // 
            this.cbCodigoEliminar.FormattingEnabled = true;
            this.cbCodigoEliminar.Location = new System.Drawing.Point(35, 106);
            this.cbCodigoEliminar.Name = "cbCodigoEliminar";
            this.cbCodigoEliminar.Size = new System.Drawing.Size(219, 24);
            this.cbCodigoEliminar.TabIndex = 7;
            this.cbCodigoEliminar.SelectedIndexChanged += new System.EventHandler(this.cbCodigoEliminar_SelectedIndexChanged);
            // 
            // lblEliminarPrecio
            // 
            this.lblEliminarPrecio.AutoSize = true;
            this.lblEliminarPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarPrecio.Location = new System.Drawing.Point(34, 286);
            this.lblEliminarPrecio.Name = "lblEliminarPrecio";
            this.lblEliminarPrecio.Size = new System.Drawing.Size(51, 16);
            this.lblEliminarPrecio.TabIndex = 4;
            this.lblEliminarPrecio.Text = "Precio";
            // 
            // lblCategoriaEliminar
            // 
            this.lblCategoriaEliminar.AutoSize = true;
            this.lblCategoriaEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEliminar.Location = new System.Drawing.Point(34, 219);
            this.lblCategoriaEliminar.Name = "lblCategoriaEliminar";
            this.lblCategoriaEliminar.Size = new System.Drawing.Size(74, 16);
            this.lblCategoriaEliminar.TabIndex = 3;
            this.lblCategoriaEliminar.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descipcion:";
            // 
            // lblEliminarCodigo
            // 
            this.lblEliminarCodigo.AutoSize = true;
            this.lblEliminarCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCodigo.Location = new System.Drawing.Point(29, 78);
            this.lblEliminarCodigo.Name = "lblEliminarCodigo";
            this.lblEliminarCodigo.Size = new System.Drawing.Size(142, 16);
            this.lblEliminarCodigo.TabIndex = 1;
            this.lblEliminarCodigo.Text = "Codigo de Producto";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(28, 24);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(184, 23);
            this.lblEliminar.TabIndex = 0;
            this.lblEliminar.Text = "Eliminar Producto";
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbEliminar);
            this.tbcGestion.Controls.Add(this.tbModificar);
            this.tbcGestion.Location = new System.Drawing.Point(12, 12);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(319, 480);
            this.tbcGestion.TabIndex = 0;
            // 
            // lblTituloSecond
            // 
            this.lblTituloSecond.AutoSize = true;
            this.lblTituloSecond.Location = new System.Drawing.Point(337, 37);
            this.lblTituloSecond.Name = "lblTituloSecond";
            this.lblTituloSecond.Size = new System.Drawing.Size(290, 17);
            this.lblTituloSecond.TabIndex = 2;
            this.lblTituloSecond.Text = "Puede seleccionar un producto de su codigo";
            // 
            // FrmProductoDelMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 543);
            this.Controls.Add(this.lblTituloSecond);
            this.Controls.Add(this.dgwProductos);
            this.Controls.Add(this.tbcGestion);
            this.Name = "FrmProductoDelMod";
            this.Text = "FrmProductoEliminar";
            this.Load += new System.EventHandler(this.FrmProductoEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).EndInit();
            this.tbModificar.ResumeLayout(false);
            this.tbModificar.PerformLayout();
            this.tbEliminar.ResumeLayout(false);
            this.tbEliminar.PerformLayout();
            this.tbcGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProductos;
        private System.Windows.Forms.TabPage tbModificar;
        private System.Windows.Forms.Button btnGuardarModificar;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.TextBox txtModificarCat;
        private System.Windows.Forms.TextBox txtModificarDes;
        private System.Windows.Forms.TextBox txtModificarCod;
        private System.Windows.Forms.Label lblModificarPrecio;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.Label lblModificarProducto;
        private System.Windows.Forms.Label lblModificarCodigo;
        private System.Windows.Forms.Label lblModificarTitulo;
        private System.Windows.Forms.TabPage tbEliminar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TextBox txtEliminarPrecio;
        private System.Windows.Forms.TextBox txtEliminarCategoria;
        private System.Windows.Forms.TextBox txtEliminarDescripcion;
        private System.Windows.Forms.ComboBox cbCodigoEliminar;
        private System.Windows.Forms.Label lblEliminarPrecio;
        private System.Windows.Forms.Label lblCategoriaEliminar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEliminarCodigo;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.Label lblTituloSecond;
    }
}