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

        private sqlbaglantisi bgl = new sqlbaglantisi();


        private void msk_sahibi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
        private void HayvanlarFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
