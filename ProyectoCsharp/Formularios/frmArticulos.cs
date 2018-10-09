using LogicaNegocio;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmArticulos : Form
    {
        private DataTable dtArticulos;
        private ArticuloBL articuloBL;
        private DataView vistaArticulos;
        private CategoriaBL categoriaBL;

        public frmArticulos()
        {
            InitializeComponent();
            articuloBL = new ArticuloBL();
            categoriaBL = new CategoriaBL();
            dtArticulos = articuloBL.ListarArticulos();
            vistaArticulos = new DataView(dtArticulos);
            cbCategoria.DataSource = categoriaBL.ListarCategorias();
            cbCategoria.DisplayMember = "NOMBRE";
            dgvArticulos.DataSource = dtArticulos;
            lblCantRegistros.Text = dgvArticulos.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            //dgvArticulos.Rows.Add("INSAB", "ACEITE VEGETAL", "LITROS", "70", "");
        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmMovimientosArticulo frm = new frmMovimientosArticulo();
            frm.ShowDialog();
        }

        private void btnVerMovimientos_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.SelectedRows.Count != 0)
            {
                int i = dgvArticulos.SelectedRows[0].Index;
                string codigo = dgvArticulos.Rows[i].Cells[0].Value.ToString();
                string categoria = dgvArticulos.Rows[i].Cells[5].Value.ToString();
                string descripcion = dgvArticulos.Rows[i].Cells[1].Value.ToString();
                string unidad = dgvArticulos.Rows[i].Cells[2].Value.ToString();
                frmMovimientosArticulo frm = new frmMovimientosArticulo(codigo, categoria, descripcion, unidad);
                frm.ShowDialog();
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCodigo.Checked)
            {
                txtCodigo.Enabled = true;
                txtDescripcion.Enabled = false;
                cbCategoria.Enabled = false;
            }
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDescripcion.Checked)
            {
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = true;
                cbCategoria.Enabled = false;
            }
            else
            {
                cbCategoria.Enabled = false;
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCategoria.Checked)
            {
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                cbCategoria.Enabled = true;
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTodos.Checked)
            {
                rbCategoria.Enabled = true;
                cbCategoria.Enabled = true;
                vistaArticulos.RowFilter = "";
                dgvArticulos.DataSource = vistaArticulos;
            }
        }

        private void rbMercaderia_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMercaderia.Checked)
            {
                rbCategoria.Enabled = false;
                cbCategoria.Enabled = false;
                rbCategoria.Checked = false;
                vistaArticulos.RowFilter = "Categoria = 'MERCADERIA'";
                dgvArticulos.DataSource = vistaArticulos;
            }
        }

        private void rbInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbInsumo.Checked)
            {
                rbCategoria.Enabled = true;
                cbCategoria.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbCategoria.Checked)
            {
                vistaArticulos.RowFilter = "";
                int i = cbCategoria.SelectedIndex;
                if (i < 0) return;
                string filtro = cbCategoria.Text;
                vistaArticulos.RowFilter = String.Format("Categoria = '{0}'", filtro);
                //vistaArticulos.RowFilter = "Categoria = '" + filtro + "'";
                dgvArticulos.DataSource = vistaArticulos;
            }
        }
    }
}
