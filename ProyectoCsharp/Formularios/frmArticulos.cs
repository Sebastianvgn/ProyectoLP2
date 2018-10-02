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
            cbUnidad.DataSource = Enum.GetValues(typeof(TUnidad));
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
    }
}
