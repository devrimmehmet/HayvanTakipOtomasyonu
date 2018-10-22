using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hayvan_Takip_Otomasyonu
{
    public partial class HayvanlarFormu : Form
    {
        public HayvanlarFormu()
        {
            InitializeComponent();
        }
       // public string cekilenveri;
        private sqlbaglantisi bgl = new sqlbaglantisi();

        private void listele()
        {
            SqlCommand komut13 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
            SqlDataReader read2;
            read2 = komut13.ExecuteReader();
            Cb_sahibi.Items.Clear();
    
            while (read2.Read())
            {
        
                Cb_sahibi.Items.Add(read2["adi"]);
            }
        }
        private void HayvanlarFormu_Load(object sender, EventArgs e)
        {
            listele();
         //   Cb_sahibi.SelectedItem=(cekilenveri);
        }

      

        private void cb_adi_CheckStateChanged(object sender, EventArgs e)
        {
        //    if (cb_adi.Checked == true) { cb_sahibi.ReadOnly = false; }
         //   if (cb_adi.Checked == false) { cb_sahibi.ReadOnly = true; }
        }

        private void cb_adi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
