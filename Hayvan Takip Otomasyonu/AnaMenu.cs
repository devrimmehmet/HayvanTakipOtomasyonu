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

       // public AnaMenu f2 = new AnaMenu();
        //private MusterilerFormu f10 = new MusterilerFormu();
        //private HayvanlarFormu f11 = new HayvanlarFormu();
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
     
        }

        private void btn_musteriler_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            MusterilerFormu ilk1form = new MusterilerFormu();
            ilk1form.TopLevel = false;
            pnl_islem.Controls.Add(ilk1form);
            ilk1form.Show();
            ilk1form.Dock = DockStyle.Fill;
            ilk1form.BringToFront();
          //   f5 = (AnaMenu)Application.OpenForms["AnaMenu"];
          //     f11.Close();
         //   Close();

            
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            MusterilerFormu ilk2form = new MusterilerFormu();
            ilk2form.TopLevel = false;
            pnl_islem.Controls.Add(ilk2form);
            ilk2form.Close();
            ilk2form.Dock = DockStyle.Fill;
            ilk2form.BringToFront();
            //f10.Close();
            //f11.Close();
        }

        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        public  void btn_hayvanlar_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            HayvanlarFormu ilk3form = new HayvanlarFormu();
            ilk3form.TopLevel = false;
            pnl_islem.Controls.Add(ilk3form);
            ilk3form.Show();
            ilk3form.Dock = DockStyle.Fill;
            ilk3form.BringToFront();
            //f10.Close();
        }

        private void pnl_islem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_topbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
