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
    public partial class MusterilerFormu : Form
    {
        public MusterilerFormu()
        {
            InitializeComponent();
        }
      
        private sqlbaglantisi bgl = new sqlbaglantisi();

        private void listele()
        {
            DataTable dt = new DataTable();
         
            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;


            SqlCommand komut13 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
            SqlDataReader read2;
            read2 = komut13.ExecuteReader();
            Cb_sil.Items.Clear();
            cb_arama.Items.Clear();
            while (read2.Read())
            {
                cb_arama.Items.Add(read2["adi"]);
                Cb_sil.Items.Add(read2["adi"]);
            }
        }
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            tb_id.Text = "19231923";
            if (tb_adi.Text == "")
            {
                MessageBox.Show("Lütfen Müşterinin Adını Giriniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                bool durum = true;

                SqlCommand komut1 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
                SqlDataReader read;
                read = komut1.ExecuteReader();


                while (read.Read())
                {
             
                    if (read["adi"].ToString() == tb_adi.Text)
                    {

                        MessageBox.Show("Bu isme ait Müşteri Sistemde Kayıtlı !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        durum = false;
                        bgl.baglanti().Close();
                    }
                }
            
                if (durum == true)

                {

                    string isletmeno = mskdtb_isletmeno.Text;
                    string musteriadi = tb_adi.Text;
                    string telefon = mskdtb_telefon.Text;
                    string telefon2 = mskdtb_telefon2.Text;
                    string il = cb_il.Text;
                    string ilce = cb_ilce.Text;
                    string koy = cb_koy.Text;
                   

                    DialogResult cikis = new DialogResult();
                    cikis = MessageBox.Show("\n"+ " Müşteri Adı: "+musteriadi+ "\n\n İşletme No: " + isletmeno+ "\n\n Telefon No: " + telefon+ "\n\n Telefon2 No: " + telefon2+ "\n\n İl: " + il+ "\n\n İlçe: " + ilce+ "\n\n Köy/Mahalle: " + koy + "\n\n\n Yukarıdaki bilgilere ait müşteriyi sisteme eklemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (cikis == DialogResult.Yes)
                    {
                       SqlCommand komut = new SqlCommand("insert into musterilertbl (isletmeno,adi,tel,tel2,il,ilce,koy) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());

                    komut.Parameters.AddWithValue("@p1", mskdtb_isletmeno.Text);
                    komut.Parameters.AddWithValue("@p2", tb_adi.Text);
                    komut.Parameters.AddWithValue("@p3", mskdtb_telefon.Text);
                    komut.Parameters.AddWithValue("@p4", mskdtb_telefon2.Text);
                    komut.Parameters.AddWithValue("@p5", cb_il.Text);
                    komut.Parameters.AddWithValue("@p6", cb_ilce.Text);
                    komut.Parameters.AddWithValue("@p7", cb_koy.Text);
                 
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    mskdtb_isletmeno.Text = null;
                    tb_adi.Text = null;
                    mskdtb_telefon.Text = null;
                    mskdtb_telefon2.Text = null;
                    Cb_sil.Text = null;
                    cb_arama.Text = null;
                    tb_guncelle_adi.Text = null;
                    msk_guncelle_isletmeno.Text = null;
                    
                    }
                    if (cikis == DialogResult.No)
                    {
                        MessageBox.Show("İşlem İptal Edildi.");

                    }
                    
                }
            }
            listele();
            }

        string musteriadi1="";
        string musteriteli1="";
        string musteriteli2="";
        string musteriili1="";
        string musterilcesi1="";
      //  string musterikoyu1="";
        string musteriisletmeno1="";
        string koy = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // cb_ilce.Items.Clear();
       //     cb_il.Items.Clear();
       //    cb_koy.Items.Clear();



             //  string il="";
            //   string ilce="";
              
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                
                dgv_musteriler.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.
               musteriisletmeno1 = dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
                msk_guncelle_isletmeno.Text = musteriisletmeno1.ToString();
                musteriadi1 = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_guncelle_adi.Text = musteriadi1.ToString();
               musteriteli1 = dgv_musteriler.Rows[e.RowIndex].Cells[3].Value.ToString();
                mskd_guncelle_tel.Text = musteriteli1.ToString();
                musteriteli2 = dgv_musteriler.Rows[e.RowIndex].Cells[4].Value.ToString();
                mskd_guncelle_tel2.Text = musteriteli2.ToString();
               musteriili1 = dgv_musteriler.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_guncelle_il.Text = musteriili1.ToString();   
                musterilcesi1 = dgv_musteriler.Rows[e.RowIndex].Cells[6].Value.ToString();
                cb_guncelle_ilce.Text = musterilcesi1.ToString();
               koy = dgv_musteriler.Rows[e.RowIndex].Cells[7].Value.ToString();
                cb_guncelle_koy.Items.Clear();
                //    cb_guncelle_koy.SelectedIndex = koy;
                string[] koyversiyon = {koy };
                    cb_guncelle_koy.Items.AddRange(koyversiyon);
                cb_guncelle_koy.SelectedIndex = 0;

                
            //    cb_guncelle_koy.Items.Add =(koy.ToString());
                //cb_guncelle_koy.DropDownStyle = ComboBoxStyle.DropDownList;

             //   [] koyversiyon=
                Cb_sil.Text = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_id.Text = dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            chck_guncelle_isletmeno.Checked = false;
            chck_guncelle_adi.Checked = false;
            chck_guncelle_tel.Checked = false;
            chck_guncelle_tel2.Checked = false;
            chck_guncelle_il.Checked = false;
            chck_guncelle_ilce.Checked = false;
            chck_guncelle_koy.Checked = false;

            
                  SqlCommand komut = new SqlCommand("Select ilce from ilceler where Sehir=@p1", bgl.baglanti());
              komut.Parameters.AddWithValue("@p1", cb_il.SelectedIndex + 1);
              SqlDataReader dr1 = komut.ExecuteReader();
              while (dr1.Read())
              {
                  cb_guncelle_ilce.Items.Add(dr1[0]);

              }
              if (cb_guncelle_ilce.Text == "Devrekani")
              {
                  SqlCommand komut1 = new SqlCommand("Select koy from koyler where ilce=@p1", bgl.baglanti());
                  komut1.Parameters.AddWithValue("@p1", 427);
                  SqlDataReader dr12 = komut1.ExecuteReader();
                  while (dr12.Read())
                  {
                      cb_guncelle_koy.Items.Add(dr12[0]);

                  }
                 
        

            } 
            bgl.baglanti().Close();
        }

      

        private void dgv_musteriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_musteriler.Rows[e.RowIndex].Selected)

            {              
                e.CellStyle.SelectionBackColor= Color.Red;  //seçli  satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionForeColor= Color.White; //seçili  satır yazı rengini beyaz yapıyoruz

            }
        }
    
      

       

        private void btn_sil_Click(object sender, EventArgs e)
        {
            tb_id.Text = "19231923";
            if (Cb_sil.Text == "")
            {
            

                MessageBox.Show("Lütfen Silmek istediğiniz müşteriyi tablodan seçiniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                
                string musteriadi = Cb_sil.Text;
                
                    DialogResult cikis = new DialogResult();
                    cikis = MessageBox.Show("\n" + " Müşteri Adı: " + musteriadi + "\n\n İşletme No: " + musteriisletmeno1 + "\n\n Telefon No: " + musteriteli1 + "\n\n Telefon2 No: " + musteriteli2 + "\n\n İl: " + musteriili1 + "\n\n İlçe: " + musterilcesi1 + "\n\n Köy/Mahalle: " + koy + "\n\n\n Yukarıdaki bilgilere ait müşteriyi sistemden silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (cikis == DialogResult.Yes)
                    {
                        SqlCommand komutsil = new SqlCommand("Delete From musterilertbl where adi=@p1", bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", Cb_sil.Text);
                        komutsil.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    }
                    if (cikis == DialogResult.No)
                    {
                        MessageBox.Show("Silme İşlemi İptal Edildi.");

                    }

            
            }
            mskdtb_isletmeno.Text = null;
            tb_adi.Text = null;
   
            //rtb_adres.Text = null;
            mskdtb_telefon.Text = null;
            Cb_sil.Text = null;
            cb_arama.Text = null;
         
            tb_guncelle_adi.Text = null;
            msk_guncelle_isletmeno.Text = null;
       //     msk_guncelle_tel.Text = null;
            //rtb_guncelleadres.Text = null;
            listele();
        }

        private void MusterilerFormu_Load_1(object sender, EventArgs e)
        {
            tb_id.Text = "19231923";


            // TODO: Bu kod satırı 'tdbDataSet1.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //    this.musterilertblTableAdapter.Fill(this.tdbDataSet1.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //         this.ilcelerTableAdapter.Fill(this.tdbDataSet.ilceler);
            // TODO: Bu kod satırı 'tdbDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //  this.illerTableAdapter.Fill(this.tdbDataSet.iller);
            sehirlistesi();


            chck_guncelle_tel.Checked = false;
            chck_guncelle_isletmeno.Checked = false;
         
            chck_guncelle_tel2.Checked = false;
            chck_guncelle_il.Checked = false;
            listele();

        }


        private void cb_isletmeno_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_isletmeno.Checked == true) { msk_guncelle_isletmeno.ReadOnly = false; }
            if (chck_guncelle_isletmeno.Checked == false) { msk_guncelle_isletmeno.ReadOnly = true; }
        }

        private void cb_adi_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_tel.Checked == true) { tb_guncelle_adi.ReadOnly = false; }
            if (chck_guncelle_tel.Checked == false) { tb_guncelle_adi.ReadOnly = true; }
        }

        private void cb_soyadi_CheckStateChanged(object sender, EventArgs e)
        {
        
        }
        
        private void cb_adres_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_il.Checked == true) { cb_guncelle_il.Visible = true; }
            if (chck_guncelle_il.Checked == false) { cb_guncelle_il.Visible = false; }
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            
            if (tb_id.Text == "19231923") { MessageBox.Show("Lütfen Müşteri Seçiniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            else {
            if (tb_guncelle_adi.Text == "")
            {
                MessageBox.Show("Lütfen Müşterinin Adını Giriniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
           
                    SqlCommand komut = new SqlCommand("update musterilertbl set isletmeno=@p1,adi=@p2,tel=@p3,tel2=@p4,il=@p5,ilce=@p6,koy=@p7 where id=@p8", bgl.baglanti());

                    komut.Parameters.AddWithValue("@p1", msk_guncelle_isletmeno.Text);
                    komut.Parameters.AddWithValue("@p2", tb_guncelle_adi.Text);
                    komut.Parameters.AddWithValue("@p3", mskd_guncelle_tel.Text);
                    komut.Parameters.AddWithValue("@p4", mskd_guncelle_tel2.Text);

                     komut.Parameters.AddWithValue("@p5", cb_guncelle_il.Text); 
                   komut.Parameters.AddWithValue("@p6", cb_guncelle_ilce.Text); 
                  komut.Parameters.AddWithValue("@p7", cb_guncelle_koy.Text); 
                    komut.Parameters.AddWithValue("@p8", tb_id.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

                mskdtb_telefon.Text = null;
                    Cb_sil.Text = null;
                    cb_arama.Text = null;

                msk_guncelle_isletmeno.Text = null;
                tb_guncelle_adi.Text = null;
                mskd_guncelle_tel.Text = null;
                mskd_guncelle_tel2.Text = null;
                cb_guncelle_il.Text = null;
                cb_guncelle_ilce.Text = null;
                cb_guncelle_koy.Text = null;
                chck_guncelle_isletmeno.Checked = false;
                chck_guncelle_adi.Checked = false;
                chck_guncelle_tel.Checked = false;
                chck_guncelle_tel2.Checked = false;
                chck_guncelle_il.Checked = false;
                chck_guncelle_ilce.Checked = false;
                chck_guncelle_koy.Checked = false;
                    tb_id.Text = "19231923";
                }
           

            listele();
            }
        }

        private void cb_arama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
          
            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;
           
            DataView dv = dt.DefaultView;
            dv.RowFilter = "adi Like '" + cb_arama.Text + "%'";
            dgv_musteriler.DataSource = dv;


        }
       
      
        private AnaMenu f5 = new AnaMenu();
       
        public void dgv_musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            f5 = (AnaMenu)Application.OpenForms["AnaMenu"];
            f5.btn_hayvanlar.PerformClick();

        //    f6 = (HayvanlarFormu)Application.OpenForms["HayvanlarFormu"];
       //     f6.cekilenveri = tb_guncelle_adi.Text.Trim();
           // f6.Cb_sahibi.SelectedItem=(tb_guncelle_adi.Text);
            
            this.Close();
        }

        private void dgv_musteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select sehir from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cb_il.Items.Add(dr[0]);
                cb_guncelle_il.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
            cb_il.SelectedIndex = 36;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ilce.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from ilceler where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cb_il.SelectedIndex+1);
            SqlDataReader dr1 = komut.ExecuteReader();
            while(dr1.Read())
            {
                cb_ilce.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close() ;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            cb_koy.Items.Clear();


            /* BU KISMIN TEKRARDAN YAZILMASI LAZIM */
            if (cb_ilce.Text == "Devrekani")
            {
                SqlCommand komut = new SqlCommand("Select koy from koyler where ilce=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", 427);
                SqlDataReader dr1 = komut.ExecuteReader();
                while (dr1.Read())
                {
                    cb_koy.Items.Add(dr1[0]);

                }
            


            }
            bgl.baglanti().Close();
        }

        private void chck_tel2_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_tel2.Checked == true) { mskdtb_telefon2.ReadOnly = false; }
            if (chck_tel2.Checked == false) { mskdtb_telefon2.ReadOnly = true; }
        }

        private void chck_guncelle_adi_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_adi.Checked == true) { tb_guncelle_adi.ReadOnly = false; }
            if (chck_guncelle_adi.Checked == false) { tb_guncelle_adi.ReadOnly = true; }
        }

        private void chck_guncelle_ilce_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_ilce.Checked == true) { cb_guncelle_ilce.Visible = true; }
            if (chck_guncelle_ilce.Checked == false) { cb_guncelle_ilce.Visible = false; }
        }

        private void chck_guncelle_koy_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_guncelle_koy.Checked == true) { cb_guncelle_koy.Visible = true; }
            if (chck_guncelle_koy.Checked == false) { cb_guncelle_koy.Visible = false; }
        }

        private void cb_guncelle_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_guncelle_koy.Items.Clear();


            /* BU KISMIN TEKRARDAN YAZILMASI LAZIM */
            if (cb_guncelle_ilce.Text == "Devrekani")
            {
                SqlCommand komut = new SqlCommand("Select koy from koyler where ilce=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", 427);
                SqlDataReader dr1 = komut.ExecuteReader();
                while (dr1.Read())
                {
                    cb_guncelle_koy.Items.Add(dr1[0]);

                }



            }
            bgl.baglanti().Close();
           
            

          
        }

        private void cb_guncelle_koy_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                
            }

        private void cb_guncelle_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_guncelle_ilce.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from ilceler where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cb_guncelle_il.SelectedIndex + 1);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                cb_guncelle_ilce.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close();
        }

        private void cb_arama_il_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "il Like '" + cb_arama_il.Text + "%'";
            dgv_musteriler.DataSource = dv;
        }

        private void cb_arama_ilce_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "ilce Like '" + cb_arama_ilce.Text + "%'";
            dgv_musteriler.DataSource = dv;
        }

        private void cb_arama_koy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "koy Like '" + cb_arama_koy.Text + "%'";
            dgv_musteriler.DataSource = dv;
        }

        private void cb_guncelle_koy_TextChanged(object sender, EventArgs e)
        {
         //   MessageBox.Show("birşey yazamazsın");
        }

        private void Cb_sil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_arama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

