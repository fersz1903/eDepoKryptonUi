using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace eDepoKryptonUi
{
    public partial class frmGiris : KryptonForm
    {
        public frmGiris()
        {
            InitializeComponent();
            btn_kategoriSec.Enabled = false;
        }

        private void kategoriSec_Click(object sender, EventArgs e)
        {
            string kategori;
            if (rdBtn_teknolojikAlet.Checked == true)
            {
                kategori = "teknolojikAlet";
            }
            else if (rdBtn_araba.Checked == true)
            {
                kategori = "araba";
            }
            else
            {
                kategori = "ev";
            }
            VeriTabaniIslemleri.kategori= kategori;
            frmDataGridview frm = new frmDataGridview(kategori);
            frm.Show();
        }

        private void rdBtn_teknolojikAlet_CheckedChanged(object sender, EventArgs e)
        {
            btn_kategoriSec.Enabled = true;
        }
    }
}
