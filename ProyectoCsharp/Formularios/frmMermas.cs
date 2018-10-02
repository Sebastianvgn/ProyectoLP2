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
    public partial class frmMermas : Form
    {
        private BindingList<Merma> mermas;
        public frmMermas()
        {
            InitializeComponent();
            cbMotivoBaja.DataSource = Enum.GetValues(typeof(TTipoMerma));
            cbUnidad.DataSource = Enum.GetValues(typeof(TUnidad));
            mermas = new BindingList<Merma>();
            LeerMermas();
            dgvMermas.DataSource = mermas;
            lblCantRegistros.Text = dgvMermas.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeerMermas()
        {
            String id, unidad;
            FileStream fs = new FileStream("Merma.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while ((id = sr.ReadLine()) != null)
            {
                Merma merm = new Merma();
                merm.Id_articulo = Int32.Parse(id);
                merm.Codigo = sr.ReadLine();
                merm.Descripcion = sr.ReadLine();
                merm.Cantidad = Double.Parse(sr.ReadLine());
                unidad = sr.ReadLine();
                merm.Unidad = (TUnidad)Enum.Parse(typeof(TUnidad), unidad);
                merm.Fecha_caducidad = Convert.ToDateTime(sr.ReadLine());
                Categoria cat = new Categoria();
                cat.Nombre = sr.ReadLine();
                merm.Categoria = cat;
                merm.Motivo_de_baja = (TTipoMerma)Enum.Parse(typeof(TTipoMerma), sr.ReadLine());
                mermas.Add(merm);
            }
            sr.Close();
            fs.Close();
        }
    }
    
}
