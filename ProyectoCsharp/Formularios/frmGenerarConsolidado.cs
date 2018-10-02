using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmGenerarConsolidado : Form
    {
        public frmGenerarConsolidado()
        {
            InitializeComponent();
        }

        private void frmGenerarConsolidado_Load(object sender, EventArgs e)
        {

        }

        private void btnConsolidarOP_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            if (ValidarDatos(ref mensaje))
            {
                if (MessageBox.Show("Estas seguro que desea Consolidar\nesta fecha de proceso", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MessageBox.Show("Se realizó el proceso de consolidación\ncon fecha de: " + string.Format(mCFecProceso.SelectionEnd.ToShortDateString(), "dd-MM-yyyy"), "◄ AVISO | LUCET S.A.C. ►");

                }
                else
                {
                    MessageBox.Show("No", "◄ AVISO | LUCET S.A.C. ►");
                }
            }
            else
            {
                MessageBox.Show(mensaje, "◄ AVISO | LUCET S.A.C. ►");
            }
                       
        }
        public bool ValidarDatos(ref String mensaje)
        {
            

            if (chbDiario.Checked==false && chbSemanal.Checked == false)
            {
                mensaje = "Seleccion al menos un tipo de pedido";
                return false;
            }
            if (chbRecibir.Checked == false && chbDespachar.Checked == false)
            {
                mensaje = "Seleccion al menos un tipo de agrupación";
                return false;
            }
            if (chbSemanal.Checked)
            {
                if (chbConsolidado.Checked == false && chbPerecible.Checked == false && chbNoPerecible.Checked == false)
                {
                    mensaje = "Seleccion al menos un tipo de producción";
                    return false;
                }
            }


            return true;
        }

        private void btnRevertir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Revertir este consolidado", "◄ AVISO | LUCET S.A.C. ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("El proceso fue revertido con éxito", "◄ AVISO | LUCET S.A.C. ►");

            }
            else
            {
                MessageBox.Show("No", "◄ AVISO | LUCET S.A.C. ►");
            }
        }
    }
}
