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
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
       //     this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);


        //    this.reportViewer1.RefreshReport();
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
           
        }

        private void btn_islemler_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            TedavilerFormu ilk4form = new TedavilerFormu();
            ilk4form.TopLevel = false;
            pnl_islem.Controls.Add(ilk4form);
            ilk4form.Show();
            ilk4form.Dock = DockStyle.Fill;
            ilk4form.BringToFront();
        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            pnl_islem.Controls.Clear();
            RaporlarFormu ilk5form = new RaporlarFormu();
            ilk5form.TopLevel = false;
            pnl_islem.Controls.Add(ilk5form);
            ilk5form.Show();
            ilk5form.Dock = DockStyle.Fill;
            ilk5form.BringToFront();
        }

        private void pnl_islem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
