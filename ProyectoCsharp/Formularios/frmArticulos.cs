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
        private DataTable insumos;
        private DataTable mercaderias;
        private DataTable categoriasCompletas;

        public frmArticulos()
        {
            InitializeComponent();
            articuloBL = new ArticuloBL();
            categoriaBL = new CategoriaBL();
            dtArticulos = articuloBL.ListarArticulos();
            vistaArticulos = new DataView(dtArticulos);
            categoriasCompletas = new DataTable();
            insumos = categoriaBL.ListarInsumos();
            mercaderias = categoriaBL.ListarMercaderias();
            categoriasCompletas.Merge(insumos);
            categoriasCompletas.Merge(mercaderias);
            cbCategoria.DataSource = categoriasCompletas;
            cbCategoria.DisplayMember = "NOMBRE";
            rbCategoria.Checked = false;
            cbCategoria.Enabled = false;
            rbDescripcion.Checked = true;
            txtDescripcion.Enabled = true;
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

        private void FiltrarArticulos(string filtro) {
            vistaArticulos.RowFilter = "";
            vistaArticulos.RowFilter = filtro;
            dgvArticulos.DataSource = vistaArticulos;
            lblCantRegistros.Text = dgvArticulos.Rows.Count.ToString();
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
                txtDescripcion.Text = "";
                cbCategoria.Enabled = false;
            }
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDescripcion.Checked)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = "";
                txtDescripcion.Enabled = true;
                cbCategoria.Enabled = false;
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategoria.Checked)
            {
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                cbCategoria.Enabled = true;
                FiltrarArticulos(String.Format("Categoria = '{0}'", cbCategoria.Text));
            }
            else
            {
                if (rbMercaderia.Checked)
                {
                    FiltrarArticulos("Categoria like '%MER-*'");
                }
                else if (rbInsumo.Checked) {
                    FiltrarArticulos("Categoria NOT like '%MER-*'");
                }
                else if (rbTodos.Checked)
                {
                    FiltrarArticulos("");
                }
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTodos.Checked)
            {
                rbDescripcion.Checked = true;
                rbCategoria.Enabled = true;
                rbCategoria.Checked = false;
                cbCategoria.Enabled = false;
                DataTable categoria = new DataTable();
                cbCategoria.DataSource = categoriasCompletas;
                cbCategoria.DisplayMember = "NOMBRE";
                FiltrarArticulos("");
            }
        }

        private void FiltroMercaderiaInicial() {
            vistaArticulos.RowFilter = "";
            vistaArticulos.RowFilter = "Categoria like '%MER-*'";
            dgvArticulos.DataSource = vistaArticulos;
        }
    

        private void rbMercaderia_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMercaderia.Checked)
            {
                rbDescripcion.Checked = true;
                rbCategoria.Enabled = true;
                rbCategoria.Checked = false;
                cbCategoria.Enabled = false;
                cbCategoria.DataSource = mercaderias;
                FiltrarArticulos("Categoria like '%MER-*'");
                lblCantRegistros.Text = dgvArticulos.Rows.Count.ToString();
            }
        }

        private void FiltroInsumosInicial()
        {
            vistaArticulos.RowFilter = "";
            vistaArticulos.RowFilter = "Categoria NOT like '%MER-*'";
            dgvArticulos.DataSource = vistaArticulos;
        }

        private void rbInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbInsumo.Checked)
            {
                rbCategoria.Enabled = true;
                rbCategoria.Checked = false;
                cbCategoria.Enabled = false;
                cbCategoria.DataSource = insumos;
                FiltrarArticulos("Categoria NOT like '%MER-*'");
                lblCantRegistros.Text = dgvArticulos.Rows.Count.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbCategoria.Checked)
            {
                
                int i = cbCategoria.SelectedIndex;
                if (i < 0) return;
                FiltrarArticulos(String.Format("Categoria = '{0}'", cbCategoria.Text));
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (rbTodos.Checked)
                    FiltrarArticulos(String.Format("Codigo LIKE '%{0}*'", txtCodigo.Text));
                else if (rbInsumo.Checked)
                    FiltrarArticulos(String.Format("Codigo LIKE '%{0}*' AND Categoria NOT like '%MER-*'", txtCodigo.Text));
                else if (rbMercaderia.Checked)
                {
                    FiltrarArticulos(String.Format("Codigo LIKE '%{0}*' AND Categoria like '%MER-*'", txtCodigo.Text));
                }
            }
            else {
                if (rbTodos.Checked)
                    FiltrarArticulos(String.Format("", txtCodigo.Text));
                else if (rbInsumo.Checked)
                    FiltrarArticulos(String.Format("Categoria NOT like '%MER-*'", txtCodigo.Text));
                else if (rbMercaderia.Checked)
                {
                    FiltrarArticulos(String.Format("Categoria like '%MER-*'", txtCodigo.Text));
                }
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                if (rbTodos.Checked)
                    FiltrarArticulos(String.Format("Nombre LIKE '%{0}*'", txtDescripcion.Text));
                else if (rbInsumo.Checked)
                    FiltrarArticulos(String.Format("Nombre LIKE '%{0}*' AND Categoria NOT like '%MER-*'", txtDescripcion.Text));
                else if (rbMercaderia.Checked)
                {
                    FiltrarArticulos(String.Format("Nombre LIKE '%{0}*' AND Categoria like '%MER-*'", txtDescripcion.Text));
                }
            }
            else
            {
                if (rbTodos.Checked)
                    FiltrarArticulos("");
                else if (rbInsumo.Checked)
                    FiltrarArticulos("Categoria NOT like '%MER-*'");
                else if (rbMercaderia.Checked)
                {
                    FiltrarArticulos("Categoria like '%MER-*'");
                }
            }
        }
    }
}
