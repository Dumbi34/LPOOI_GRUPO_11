namespace Vistas.forms
{
    partial class frmConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsuario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.dgwConsultaUser = new System.Windows.Forms.DataGridView();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsultaUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta Usuario";
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(33, 69);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(135, 17);
            this.lblNombreBuscar.TabIndex = 1;
            this.lblNombreBuscar.Text = "Nombre de Usuario:";
            // 
            // dgwConsultaUser
            // 
            this.dgwConsultaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwConsultaUser.Location = new System.Drawing.Point(49, 110);
            this.dgwConsultaUser.Name = "dgwConsultaUser";
            this.dgwConsultaUser.Size = new System.Drawing.Size(729, 252);
            this.dgwConsultaUser.TabIndex = 2;
            this.dgwConsultaUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwConsultaUser_CellContentClick);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(174, 64);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(205, 22);
            this.txtBuscarUser.TabIndex = 3;
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.Location = new System.Drawing.Point(401, 61);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(156, 29);
            this.btnBuscarUser.TabIndex = 4;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // frmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 459);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.dgwConsultaUser);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarUsuario";
            this.Text = "frmConsultaruser";
            this.Load += new System.EventHandler(this.frmConsultaruser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwConsultaUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.DataGridView dgwConsultaUser;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.Button btnBuscarUser;
    }
}