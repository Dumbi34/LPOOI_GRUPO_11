namespace Vistas.forms
{
    partial class FrmBuscarCliente
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
            this.txtBusquedabc = new System.Windows.Forms.TextBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.btnBuscarbc = new System.Windows.Forms.Button();
            this.dgvClientesbc = new System.Windows.Forms.DataGridView();
            this.bc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesbc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquedabc
            // 
            this.txtBusquedabc.Location = new System.Drawing.Point(117, 55);
            this.txtBusquedabc.Name = "txtBusquedabc";
            this.txtBusquedabc.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedabc.TabIndex = 0;
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Items.AddRange(new object[] {
            "DNI",
            "Apellido",
            "Nombre"});
            this.cmbCriterio.Location = new System.Drawing.Point(96, 99);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 1;
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cmbOrden.Location = new System.Drawing.Point(260, 99);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(121, 21);
            this.cmbOrden.TabIndex = 2;
            // 
            // btnBuscarbc
            // 
            this.btnBuscarbc.Location = new System.Drawing.Point(246, 53);
            this.btnBuscarbc.Name = "btnBuscarbc";
            this.btnBuscarbc.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarbc.TabIndex = 3;
            this.btnBuscarbc.Text = "Buscar";
            this.btnBuscarbc.UseVisualStyleBackColor = true;
            this.btnBuscarbc.Click += new System.EventHandler(this.btnBuscarbc_Click);
            // 
            // dgvClientesbc
            // 
            this.dgvClientesbc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesbc.Location = new System.Drawing.Point(12, 146);
            this.dgvClientesbc.Name = "dgvClientesbc";
            this.dgvClientesbc.Size = new System.Drawing.Size(460, 381);
            this.dgvClientesbc.TabIndex = 4;
            this.dgvClientesbc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesbc_CellDoubleClick);
            // 
            // bc
            // 
            this.bc.AutoSize = true;
            this.bc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc.Location = new System.Drawing.Point(154, 21);
            this.bc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(126, 18);
            this.bc.TabIndex = 5;
            this.bc.Text = "Buscar Cliente";
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 539);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.dgvClientesbc);
            this.Controls.Add(this.btnBuscarbc);
            this.Controls.Add(this.cmbOrden);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.txtBusquedabc);
            this.Name = "FrmBuscarCliente";
            this.Text = "FrmBuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesbc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusquedabc;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Button btnBuscarbc;
        private System.Windows.Forms.DataGridView dgvClientesbc;
        private System.Windows.Forms.Label bc;
    }
}