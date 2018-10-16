using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Takip_Otomasyonu
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
      
        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_musteriler_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            MusterilerFormu ilkform = new MusterilerFormu();
            ilkform.TopLevel = false;
            pnl_islem.Controls.Add(ilkform);
            ilkform.Show();
            ilkform.Dock = DockStyle.Fill;
            ilkform.BringToFront();

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            MusterilerFormu ilkform = new MusterilerFormu();
            ilkform.TopLevel = false;
            pnl_islem.Controls.Add(ilkform);
            ilkform.Close();
            ilkform.Dock = DockStyle.Fill;
            ilkform.BringToFront();
        }
    }
}
