namespace Vistas.forms
{
    partial class FrmProductoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoConsulta));
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.dgwProductos = new System.Windows.Forms.DataGridView();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            this.lblOrden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(23, 19);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(191, 23);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta Producto";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(424, 58);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(95, 27);
            this.btnBuscarCodigo.TabIndex = 3;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // dgwProductos
            // 
            this.dgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductos.Location = new System.Drawing.Point(27, 110);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.RowTemplate.Height = 24;
            this.dgwProductos.Size = new System.Drawing.Size(492, 347);
            this.dgwProductos.TabIndex = 4;
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(95, 61);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(90, 21);
            this.rbtnCategoria.TabIndex = 5;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoria";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Location = new System.Drawing.Point(200, 61);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(103, 21);
            this.rbtnDescripcion.TabIndex = 6;
            this.rbtnDescripcion.TabStop = true;
            this.rbtnDescripcion.Text = "Descripcion";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(24, 63);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(65, 17);
            this.lblOrden.TabIndex = 7;
            this.lblOrden.Text = "Ordenar:";
            // 
            // FrmProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 482);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.rbtnDescripcion);
            this.Controls.Add(this.rbtnCategoria);
            this.Controls.Add(this.dgwProductos);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.lblConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductoConsulta";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmProductoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.DataGridView dgwProductos;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
        private System.Windows.Forms.Label lblOrden;
    }
}