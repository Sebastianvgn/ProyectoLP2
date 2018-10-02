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
    public partial class frmRegistroTransferencias : Form
    {
        private BindingList<AlmacenVirtual> almacenes;
        private BindingList<AlmacenPrincipal> almPrincipal;
        private BindingList<Area> areas;
        private BindingList<Articulo> articulos;
        public frmRegistroTransferencias()
        {
            InitializeComponent();
            almacenes = new BindingList<AlmacenVirtual>();
            LeerAlmacenes();
            cmbAlmDestino.DataSource = almacenes;

            areas = new BindingList<Area>();
            LeerAreas();
            cmbArea.DataSource = areas;

            almPrincipal = new BindingList<AlmacenPrincipal>();
            LeerAlmaPrincipales();
            cmbAlmOrigen.DataSource = almPrincipal;

            articulos = new BindingList<Articulo>();
            LeerArticulos();
            foreach(Articulo articulo in articulos)
            {
                txtIngArticulo.AutoCompleteCustomSource.Add(Convert.ToString(articulo));
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Grabar", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se grabo la Transferencia N° :" + lblNTransf.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir esta transferencia", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se imprimio la Tranferencia N° :" + lblNTransf.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea transferir este articulo", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se transfirió este artículo");
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnNewTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que realizar una nueva Transferencia", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se muestra nueva Transferencia");
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void LeerAlmacenes()
        {
            String id;
            FileStream fs = new FileStream("Almacenes.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                AlmacenVirtual alm = new AlmacenVirtual(Int32.Parse(id), sr.ReadLine(), sr.ReadLine());
                almacenes.Add(alm);
            }
            sr.Close();
            fs.Close();
        }
        private void LeerAreas()
        {
            String id;
            FileStream fs = new FileStream("Areas.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                Area area = new Area(Int32.Parse(id), sr.ReadLine());
                areas.Add(area);
            }
            sr.Close();
            fs.Close();
        }
        private void LeerAlmaPrincipales()
        {
            String id;
            FileStream fs = new FileStream("AlmacenesPrincipales.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                AlmacenPrincipal almPrin = new AlmacenPrincipal(Int32.Parse(id), sr.ReadLine(), sr.ReadLine());
                almPrincipal.Add(almPrin);
            }
            sr.Close();
            fs.Close();
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
    }
}
