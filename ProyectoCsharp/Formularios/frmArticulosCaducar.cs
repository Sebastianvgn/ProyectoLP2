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
    public partial class frmArticulosCaducar : Form
    {
        public frmArticulosCaducar()
        {
            InitializeComponent();
        }

        private void frmArticuloCaducar_Load(object sender, EventArgs e)
        {
            dgvArticulosVencer.Rows.Add("INSEMB", "EMBUTIDOS", "JAMONADA ESPECIAL", "KG", "100.00", "5.00", "29/09/2018", "5");
            dgvArticulosVencer.Rows.Add("INSEMB", "EMBUTIDOS", "JAMONADA ESPECIAL", "KG", "100.00", "5.00", "09/10/2018", "10");
            dgvArticulosVencer.Rows.Add("INSEMB", "EMBUTIDOS", "JAMONADA ESPECIAL", "KG", "100.00", "5.00", "20/09/2018", "-5");
        }

        private void dgvArticulosVencer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int c = dgvArticulosVencer.ColumnCount - 1;
            if(e.ColumnIndex == c)
            {
                int dias = Convert.ToInt32(e.Value);
                if(dias < 0)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if(0 <= dias && dias <= 7)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}
