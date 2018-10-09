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
        private BindingList<Articulo> articulos;
        public frmArticulos()
        {
            InitializeComponent();
            articulos = new BindingList<Articulo>();
            LeerArticulos();
            
            dgvArticulos.DataSource = articulos;
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

        private void LeerArticulos()
        {
            String id, unidad;
            FileStream fs = new FileStream("Articulos.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                Articulo art = new Articulo();
                art.Id_articulo = Int32.Parse(id);
                art.Codigo = sr.ReadLine();
                art.Descripcion = sr.ReadLine();
                art.Cantidad = Double.Parse(sr.ReadLine());
                unidad = sr.ReadLine();
                art.Unidad = (TUnidad)Enum.Parse(typeof(TUnidad), unidad);
                art.Fecha_caducidad = Convert.ToDateTime(sr.ReadLine());
                Categoria cat = new Categoria();
                cat.Nombre = sr.ReadLine();
                art.Categoria = cat;
                articulos.Add(art);
            }
            sr.Close();
            fs.Close();
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
            }
        }

        private void rbMercaderia_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMercaderia.Checked)
            {
                rbCategoria.Enabled = false;
                cbCategoria.Enabled = false;
                rbCategoria.Checked = false;
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
    }
}
