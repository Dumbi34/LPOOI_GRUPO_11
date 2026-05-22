using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClaseBase.service;
namespace Vistas.forms
{
    public partial class FrmProductoConsulta : Form
    {
        public FrmProductoConsulta()
        {
            InitializeComponent();
        }

        private void FrmProductoConsulta_Load(object sender, EventArgs e)
        {
            productos_load();
        }
        private void productos_load()
        {
            dgwProductos.DataSource = ProductoService.Listar_Productos();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.Text != "")
            {
                dgwProductos.DataSource = ProductoService.buscar_producto(txtBuscarCodigo.Text);
            }
            else
            {
                productos_load();
            }
        }
    }
}
