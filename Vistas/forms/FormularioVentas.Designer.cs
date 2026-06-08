namespace Vistas
{
    partial class FormularioVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVentas));
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPorFecha = new System.Windows.Forms.Button();
            this.lblModificar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(50, 82);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpDesde.TabIndex = 0;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(50, 169);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(599, 362);
            this.dgvVentas.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(384, 82);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpHasta.TabIndex = 2;
            // 
            // btnBuscarPorFecha
            // 
            this.btnBuscarPorFecha.Location = new System.Drawing.Point(305, 133);
            this.btnBuscarPorFecha.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorFecha.Name = "btnBuscarPorFecha";
            this.btnBuscarPorFecha.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarPorFecha.TabIndex = 3;
            this.btnBuscarPorFecha.Text = "Buscar";
            this.btnBuscarPorFecha.UseVisualStyleBackColor = true;
            this.btnBuscarPorFecha.Click += new System.EventHandler(this.btnBuscarPorFecha_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(251, 9);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(190, 23);
            this.lblModificar.TabIndex = 4;
            this.lblModificar.Text = "Buscar por fechas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta:";
            // 
            // FormularioVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.btnBuscarPorFecha);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dtpDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioVentas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscarPorFecha;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}