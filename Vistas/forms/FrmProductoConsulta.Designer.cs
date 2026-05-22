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
            this.lblCodigoBuscar = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.dgwProductos = new System.Windows.Forms.DataGridView();
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
            // lblCodigoBuscar
            // 
            this.lblCodigoBuscar.AutoSize = true;
            this.lblCodigoBuscar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBuscar.Location = new System.Drawing.Point(24, 68);
            this.lblCodigoBuscar.Name = "lblCodigoBuscar";
            this.lblCodigoBuscar.Size = new System.Drawing.Size(105, 16);
            this.lblCodigoBuscar.TabIndex = 1;
            this.lblCodigoBuscar.Text = "Ingrese codigo:";
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(135, 65);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(262, 22);
            this.txtBuscarCodigo.TabIndex = 2;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(469, 63);
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
            this.dgwProductos.Location = new System.Drawing.Point(27, 118);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.RowTemplate.Height = 24;
            this.dgwProductos.Size = new System.Drawing.Size(537, 347);
            this.dgwProductos.TabIndex = 4;
            // 
            // FrmProductoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 508);
            this.Controls.Add(this.dgwProductos);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.lblCodigoBuscar);
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
        private System.Windows.Forms.Label lblCodigoBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.DataGridView dgwProductos;
    }
}