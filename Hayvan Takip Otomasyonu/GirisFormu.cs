using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // formlar arası geçiş kullanırken gerekli kütüphane
using System.Data.SqlClient;
namespace Hayvan_Takip_Otomasyonu
{
    public partial class GirisFormu : Form
    {
        private Thread th; // formlar arası geçişte önceki formu kapamak için lazım
        private void yeniformac(object obj)
        {
            Application.Run(new AnaMenu());  //yeni forma objesi oluşturma
        }

        private sqlbaglantisi baglan = new sqlbaglantisi(); //Sql servere bağlanma


        public GirisFormu()
        {
            InitializeComponent();
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }

        private void GirisFormu_Enter(object sender, EventArgs e)
        {

        }

        private void GirisFormu_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void GirisFormu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)   //escye basıldığında uygulamayı kapatmak için
                this.Close();//escye basıldığında uygulamayı kapatmak için


        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From kullanicilartbl where kullaniciadi=@p1 and sifre=@p2", baglan.baglanti());
           komut.Parameters.AddWithValue("@p1", txt_kullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                this.Close();

                th = new Thread(yeniformac);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();



            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
