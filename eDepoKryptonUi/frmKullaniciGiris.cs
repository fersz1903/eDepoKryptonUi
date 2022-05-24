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
    public partial class frmKullaniciGiris : KryptonForm
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
        }
    }
}
