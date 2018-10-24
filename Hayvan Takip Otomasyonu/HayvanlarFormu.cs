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
        string cinsiyetkontrol;
        string cinsiyet;
      //  string sgssonucu;
    //    string bkgsonucu;
    //    int bkgsonucu1;
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From hayvanlartbl", bgl.baglanti());
            da.Fill(dt);
            dgv_hayvanlar.DataSource = dt;


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
            //tb_sahibi.ReadOnly = true;
         
            listele();
            
        }
        
        private void rb_erkek_CheckedChanged(object sender, EventArgs e)
        {
            cb_ls.Text = "0";
            cinsiyet = "Erkek";
            cb_ls.Visible = false;
      //      dtp_buzagilama.Visible = false;
      //      dtp_stt.Visible = false;
     //       cb_durum.Visible = false;
     //       cb_durum.Text = null;
        }

        private void rb_dişi_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Dişi";
            cb_ls.Visible = true;
    //        dtp_buzagilama.Visible = true;
     //       dtp_stt.Visible = true;
    //        cb_durum.Visible = true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            bool durum = true;

            SqlCommand komut1 = new SqlCommand("select *from hayvanlartbl", bgl.baglanti());
            SqlDataReader read;
            read = komut1.ExecuteReader();


            while (read.Read())
            {
                if (read["TR"].ToString() == msk_kupeno.Text)
                {
                    MessageBox.Show("Bu Hayvan Sistemde Kayıtlı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    durum = false;
                    bgl.baglanti().Close();
                }
            }
            if (durum == true)

            {
                
                //verileri kaydetme
                if (rb_erkek.Checked == true | rb_dişi.Checked == true)
                {
                    if (cinsiyet == "Erkek")
                    {
                        SqlCommand komut = new SqlCommand("insert into hayvanlartbl (Tanım,TR,cinsiyet,dogumtarihi,sahibi) values (@p1,@p2,@p11,@p12,@p14)", bgl.baglanti());

                        komut.Parameters.AddWithValue("@p1", msk_tanim.Text);
                        komut.Parameters.AddWithValue("@p2", msk_kupeno.Text);
                     //   komut.Parameters.AddWithValue("@p6", cb_durum.Text);
                      //  komut.Parameters.AddWithValue("@p9", "");
                     //   komut.Parameters.AddWithValue("@p10", "");
                        komut.Parameters.AddWithValue("@p11", cinsiyet);
                        komut.Parameters.AddWithValue("@p12", dtp_dt.Value);
                        komut.Parameters.AddWithValue("@p14", Cb_sahibi.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Hayvan Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();


                    }
                    else
                    {
                        SqlCommand komut = new SqlCommand("insert into hayvanlartbl (Tanım,TR,LS,cinsiyet,dogumtarihi,sahibi) values (@p1,@p2,@p3,@p11,@p12,@p14)", bgl.baglanti());
                      /*  DateTime dt = DateTime.Parse(dtp_buzagilama.Text);
                        TimeSpan fark = DateTime.Today - dt;
                        sgssonucu = fark.TotalDays.ToString();
                        DateTime dt1 = DateTime.Parse(dtp_stt.Text);
                        TimeSpan fark1 = DateTime.Today - dt1;
                        bkgsonucu = fark1.TotalDays.ToString();
                        bkgsonucu1 = Convert.ToInt32(bkgsonucu);

                        bkgsonucu1 = 280 - bkgsonucu1;
*/
                        komut.Parameters.AddWithValue("@p1", msk_tanim.Text);
                        komut.Parameters.AddWithValue("@p2", msk_kupeno.Text);
                        komut.Parameters.AddWithValue("@p3", cb_ls.Text);
                      //  komut.Parameters.AddWithValue("@p4", sgssonucu);
                      //  komut.Parameters.AddWithValue("@p5", dtp_stt.Value);
                   //     komut.Parameters.AddWithValue("@p6", cb_durum.Text);
                     //   komut.Parameters.AddWithValue("@p7", bkgsonucu1);
                //      komut.Parameters.AddWithValue("@p8", dtp_buzagilama.Value);
                   //     komut.Parameters.AddWithValue("@p9", "");
                    //    komut.Parameters.AddWithValue("@p10", "");
                        komut.Parameters.AddWithValue("@p11", cinsiyet);
                        komut.Parameters.AddWithValue("@p12", dtp_dt.Value);
                        komut.Parameters.AddWithValue("@p14", Cb_sahibi.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Hayvan Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();

                    }
                }
                else
                {

                    MessageBox.Show("Hayvanın Cinsiyetini Seçiniz");
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
        

            if (msk_kupeno.Text == "")
            {
                MessageBox.Show("Lütfen Silmek istediğiniz hayvanın Küpe No'sunu giriniz.Yada hayvanı tablodan seçiniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string hayvankupeno = msk_kupeno.Text;

                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show(hayvankupeno + " ait bilgiler silinecek devam etmek istiyor musun ?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From hayvanlartbl where TR=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", msk_kupeno.Text);
                    komutsil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Hayvan sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (cikis == DialogResult.No)
                {
                    MessageBox.Show("İşlem İptal Edildi.");

                }


            }
            msk_kupeno.Text = null;
            listele();
            
        }

        private void dgv_hayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dgv_hayvanlar.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.
                msk_kupeno.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[3].Value.ToString();
           //     cb_durum.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[10].Value.ToString();
         //       cb_durum.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[10].Value.ToString();
                msk_tanim.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[2].Value.ToString();
          //      tb_sahibi.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[0].Value.ToString();
              cinsiyetkontrol= dgv_hayvanlar.Rows[e.RowIndex].Cells[4].Value.ToString();
                cb_ls.Text= dgv_hayvanlar.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_ls.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[5].Value.ToString();
                //dtp_stt.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[8].Value.ToString();
          //      dtp_buzagilama.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[9].Value.ToString();
                dtp_dt.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (cinsiyetkontrol == "Erkek")
                {
                    rb_erkek.Checked = true;
                    rb_dişi.Checked = false;
                }
                else
                {
                    if (cinsiyetkontrol == "Dişi")
                    {
                        rb_dişi.Checked = true;
                        rb_erkek.Checked = false;
                    }
                    else { }

                }
            }
        }

        private void dgv_hayvanlar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_hayvanlar.Rows[e.RowIndex].Selected)

            {
                e.CellStyle.SelectionBackColor = Color.Red;  //seçli  satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionForeColor = Color.White; //seçili  satır yazı rengini beyaz yapıyoruz

            }
        }

        private void Cb_sahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From hayvanlartbl", bgl.baglanti());
            da.Fill(dt);
            dgv_hayvanlar.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "sahibi Like '" + Cb_sahibi.Text + "%'";
            dgv_hayvanlar.DataSource = dv;
     //       tb_sahibi.Text = (Cb_sahibi.Text);
            msk_kupeno.Text = "TR";
        }
        
        private void cbox_sahibi_CheckStateChanged(object sender, EventArgs e)
        {
      //      if (cbox_sahibi.Checked == true) { tb_sahibi.ReadOnly = false; }
     //       if (cbox_sahibi.Checked == false) { tb_sahibi.ReadOnly = true; }
        }
    }
    }