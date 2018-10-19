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

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
          //  DataView dv = da.Tables[0].DefaultView;
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

                    SqlCommand komut = new SqlCommand("insert into musterilertbl (isletmeno,adi,soyadi,adresi,tel) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                    komut.Parameters.AddWithValue("@p1", mskdtb_isletmeno.Text);
                    komut.Parameters.AddWithValue("@p2", tb_adi.Text);
                    komut.Parameters.AddWithValue("@p3", tb_soyadi.Text);
                    komut.Parameters.AddWithValue("@p4", rtb_adres.Text);
                    komut.Parameters.AddWithValue("@p5", mskdtb_telefon.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    mskdtb_isletmeno.Text = null;
                    tb_adi.Text = null;
                    tb_soyadi.Text = null;
                    rtb_adres.Text = null;
                    mskdtb_telefon.Text = null;
                    Cb_sil.Text = null;
                    cb_arama.Text = null;
                    tb_guncelle_soyad.Text = null;
                    tb_guncelle_adi.Text = null;
                    msk_guncelle_isletmeno.Text = null;
                    msk_guncelle_tel.Text = null;
                    rtb_guncelleadres.Text = null;
                }
            }
            listele();
            }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dgv_musteriler.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.
                msk_guncelle_isletmeno.Text = dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_guncelle_adi.Text = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_guncelle_soyad.Text = dgv_musteriler.Rows[e.RowIndex].Cells[3].Value.ToString();
                msk_guncelle_tel.Text = dgv_musteriler.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtb_guncelleadres.Text = dgv_musteriler.Rows[e.RowIndex].Cells[5].Value.ToString();
                Cb_sil.Text= dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
             //   cb_arama.Text = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_id.Text = dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            cb_adi.Checked = false;
            cb_isletmeno.Checked = false;
            cb_soyadi.Checked = false;
            cb_tel.Checked = false;
            cb_adres.Checked = false;
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

            if (Cb_sil.Text == "")
            {
                MessageBox.Show("Lütfen Silmek istediğiniz müşteriyi seçiniz yada müşterinin adını giriniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string musteriadi = Cb_sil.Text;

                    DialogResult cikis = new DialogResult();
                    cikis = MessageBox.Show(musteriadi+" ait bilgiler silinecek devam etmek istiyor musun ?", "Uyarı", MessageBoxButtons.YesNo);
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
                        MessageBox.Show("İşlem İptal Edildi.");

                    }

            
            }
            mskdtb_isletmeno.Text = null;
            tb_adi.Text = null;
            tb_soyadi.Text = null;
            rtb_adres.Text = null;
            mskdtb_telefon.Text = null;
            Cb_sil.Text = null;
            cb_arama.Text = null;
            tb_guncelle_soyad.Text = null;
            tb_guncelle_adi.Text = null;
            msk_guncelle_isletmeno.Text = null;
            msk_guncelle_tel.Text = null;
            rtb_guncelleadres.Text = null;
            listele();
        }

        private void MusterilerFormu_Load_1(object sender, EventArgs e)
        {
             this.musterilertblTableAdapter1.Fill(this.hTODataSet1.musterilertbl);
            cb_adi.Checked = false;
            cb_isletmeno.Checked = false;
            cb_soyadi.Checked = false;
            cb_tel.Checked = false;
            cb_adres.Checked = false;
            listele();

        }


        private void cb_isletmeno_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_isletmeno.Checked == true) { msk_guncelle_isletmeno.ReadOnly = false; }
            if (cb_isletmeno.Checked == false) { msk_guncelle_isletmeno.ReadOnly = true; }
        }

        private void cb_adi_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_adi.Checked == true) { tb_guncelle_adi.ReadOnly = false; }
            if (cb_adi.Checked == false) { tb_guncelle_adi.ReadOnly = true; }
        }

        private void cb_soyadi_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_soyadi.Checked == true) { tb_guncelle_soyad.ReadOnly = false; }
            if (cb_soyadi.Checked == false) { tb_guncelle_soyad.ReadOnly = true; }
        }

        private void cb_tel_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_tel.Checked == true) { msk_guncelle_tel.ReadOnly = false; }
            if (cb_tel.Checked == false) { msk_guncelle_tel.ReadOnly = true; }
        }

        private void cb_adres_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_adres.Checked == true) { rtb_guncelleadres.ReadOnly = false; }
            if (cb_adres.Checked == false) { rtb_guncelleadres.ReadOnly = true; }
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
        //    if (tb_guncelle_adi.Text==)


            if (tb_guncelle_adi.Text == "")
            {
                MessageBox.Show("Lütfen Müşterinin Adını Giriniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

              /*  bool durum = true;

                SqlCommand komut1 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
                SqlDataReader read;
                read = komut1.ExecuteReader();


                while (read.Read())
                {

                    if (read["adi"].ToString() == tb_guncelle_adi.Text)
                    {

                        MessageBox.Show("Bu isme ait Müşteri Sistemde Kayıtlı !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        durum = false;
                        bgl.baglanti().Close();
                    }
                }

                if (durum == true)

                {*/

                    SqlCommand komut = new SqlCommand("update musterilertbl set isletmeno=@p1,adi=@p2,soyadi=@p3,adresi=@p4,tel=@p5 where id=@p6", bgl.baglanti());

                    komut.Parameters.AddWithValue("@p1", msk_guncelle_isletmeno.Text);
                    komut.Parameters.AddWithValue("@p2", tb_guncelle_adi.Text);
                    komut.Parameters.AddWithValue("@p3", tb_guncelle_soyad.Text);
                    komut.Parameters.AddWithValue("@p4", rtb_guncelleadres.Text);
                    komut.Parameters.AddWithValue("@p5", msk_guncelle_tel.Text);
                    komut.Parameters.AddWithValue("@p6", tb_id.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mskdtb_isletmeno.Text = null;
                    tb_adi.Text = null;
                    tb_soyadi.Text = null;
                    rtb_adres.Text = null;
                    mskdtb_telefon.Text = null;
                    Cb_sil.Text = null;
                    cb_arama.Text = null;
                    tb_guncelle_soyad.Text = null;
                    tb_guncelle_adi.Text = null;
                    msk_guncelle_isletmeno.Text = null;
                    msk_guncelle_tel.Text = null;
                    rtb_guncelleadres.Text = null;
                    cb_adi.Checked = false;
                    cb_isletmeno.Checked = false;
                    cb_soyadi.Checked = false;
                    cb_tel.Checked = false;
                    cb_adres.Checked = false;

             //   }
            }
           




            listele();




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
      //  AnaMenu hayvanlaragecis = new AnaMenu();
        public void dgv_musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     /*       this.Close();
            hayvanlaragecis.btn_hayvanlar_Click(sender, e);
            hayvanlaragecis.pnl_islem.Controls.Clear();
            HayvanlarFormu ilkform = new HayvanlarFormu();
            ilkform.TopLevel = false;
           hayvanlaragecis.pnl_islem.Controls.Add(ilkform);
            ilkform.Show();
            ilkform.Dock = DockStyle.Fill;
            ilkform.BringToFront();
            MessageBox.Show("de");*/
            //  this.Close();
            //    AnaMenu. pnl_islem.Controls.Clear();
            //   HayvanlarFormu ilkform = new HayvanlarFormu();
            //    ilkform.TopLevel = false;
            //   pnl_islem.Controls.Add(ilkform);
            //  ilkform.Show();
            //    ilkform.Dock = DockStyle.Fill;
            //   ilkform.BringToFront();


            /*   Form2 f2 = new Form2();
               private void button2_Click(object sender, EventArgs e)
               {
                   f2.button1_Click(sender, e);
               }*/
        }
    }
    }
    

