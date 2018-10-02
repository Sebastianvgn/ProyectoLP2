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
    public partial class frmRegistroIngresoComprobantes : Form
    {
        private BindingList<Articulo> articulos;

        private BindingList<AlmacenPrincipal> almPrincipal;
        public frmRegistroIngresoComprobantes()
        {

            InitializeComponent();
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(TTipoComprobante));
            articulos = new BindingList<Articulo>();
            LeerArticulos();
            dgvArticulosAbuscar.DataSource = articulos;
            dgvArticulosAbuscar.Columns["colArticuloBuscar"].Visible = false;
            dgvArticulosAbuscar.Columns["id_articulo"].Visible = false;
            dgvArticulosAbuscar.Columns["Codigo"].Visible = false;
            dgvArticulosAbuscar.Columns["Fecha_caducidad"].Visible = false;
            dgvArticulosAbuscar.Columns["Unidad"].Visible = false;
            dgvArticulosAbuscar.Columns["Cantidad"].Visible = false;
            dgvArticulosAbuscar.Columns["Precio"].Visible = false;
            dgvArticulosAbuscar.Columns["Categoria"].Visible = false;
            dgvArticulosAbuscar.Columns["Descripcion"].Width = 200;
            dgvArticulosAbuscar.Columns["Descripcion"].ReadOnly = true;


            almPrincipal = new BindingList<AlmacenPrincipal>();
            LeerAlmaPrincipales();
            cmbAlmacen.DataSource = almPrincipal;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Grabar", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se guardo la Factura N° :" + txtSerie.Text + txtNumero.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Anular este pedido", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se cancelo la Factura N° :" + txtSerie.Text + txtNumero.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Imprimir este pedido", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se imprimio la Factura N° :" + txtSerie.Text + txtNumero.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Ingresar\nun nuevo comprobante de pago", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se creo la Factura N° :" + txtSerie.Text + txtNumero.Text);
            }
            else
            {
                MessageBox.Show("");
            }
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
    }
}
