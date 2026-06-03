namespace Vistas
{
    partial class FormularioProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioProducto));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(44, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(45, 86);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 24);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(45, 125);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(108, 24);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(45, 197);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(77, 24);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(49, 256);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 37);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(225, 90);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(253, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(225, 129);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(253, 22);
            this.txtCategoria.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(225, 164);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(253, 22);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(225, 201);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(253, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // FormularioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioProducto";
            this.Text = "FormularioProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}