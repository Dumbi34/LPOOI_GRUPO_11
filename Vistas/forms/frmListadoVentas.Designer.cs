namespace Vistas.Forms
{
    partial class frmListadoVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoVentas));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblTItulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(22, 132);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(472, 214);
            this.dgvVentas.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(22, 85);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(115, 21);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItulo.Location = new System.Drawing.Point(20, 17);
            this.lblTItulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(158, 18);
            this.lblTItulo.TabIndex = 2;
            this.lblTItulo.Text = "Listado por Cliente";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Location = new System.Drawing.Point(20, 61);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(63, 13);
            this.lblTitulo2.TabIndex = 3;
            this.lblTitulo2.Text = "DNI cliente:";
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(199, 85);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(123, 23);
            this.btnEliminarVenta.TabIndex = 4;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // frmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 393);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTItulo);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblTItulo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Button btnEliminarVenta;
    }
}