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
    public partial class frmIngresarPedido : Form
    {
        private BindingList<Articulo> articulos;
        private BindingList<Operario> operarios;
        private BindingList<AlmacenVirtual> almacenes;
        private BindingList<AlmacenPrincipal> almPrincipal;
        private BindingList<Area> areas;
        public frmIngresarPedido()
        {
            InitializeComponent();
            dtpFecEntrega.MinDate = DateTime.Now;
            cmbTipoPedido.DataSource = Enum.GetValues(typeof(TTipoPedido));
            cmbEstado.DataSource = Enum.GetValues(typeof(TEstado));
            cmbEstado.Enabled = false;
            articulos = new BindingList<Articulo>();
            LeerArticulos();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.Columns["colNombArticu"].Visible = false;
            dgvArticulos.Columns["id_articulo"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Fecha_caducidad"].Visible = false;
            dgvArticulos.Columns["Unidad"].Visible = false;
            dgvArticulos.Columns["Cantidad"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Width = 200;
            dgvArticulos.Columns["Descripcion"].ReadOnly = true;

            operarios = new BindingList<Operario>();
            LeerUsuarios();
            cmbResponsable.DataSource = operarios;

            almacenes = new BindingList<AlmacenVirtual>();
            LeerAlmacenes();
            cmbAlmDestino.DataSource = almacenes;

            areas = new BindingList<Area>();
            LeerAreas();
            cmbArea.DataSource = areas;

            almPrincipal = new BindingList<AlmacenPrincipal>();
            LeerAlmaPrincipales();
            cmbAlmOrigen.DataSource = almPrincipal;
            //lblCantRegistros.Text = dgvArticulos.Rows.Count.ToString();
        }

        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecEntrega_ValueChanged(object sender, EventArgs e)
        {
            dtpFecProduccion.MinDate = dtpFecEntrega.Value;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Grabar", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                 MessageBox.Show("Se grabo el Pedido N° :" + txtNOrden.Text);
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
                MessageBox.Show("Se anulo el Pedido N° :" + txtNOrden.Text);
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
                MessageBox.Show("Se imprimio el Pedido N° :" + txtNOrden.Text);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Duplicar este pedido", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Se duplico el Pedido N° :" + txtNOrden.Text);
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
        private void LeerUsuarios()
        {
            String id;
            FileStream fs = new FileStream("Usuarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                Operario user = new Operario(Int32.Parse(id), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                operarios.Add(user);
            }
            sr.Close();
            fs.Close();
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
    }
}
