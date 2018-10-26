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
        string sahibi1 = "";
        string TR1 = "";
        string annekupeno1 = "";
        string tanim1 = "";
        string ls1 = "";
        string dt1 = "";
        string silhayvan = "TR";
        private sqlbaglantisi bgl = new sqlbaglantisi();
        string cinsiyetkontrol="";
        string cinsiyet;
      //  string sgssonucu;
    //    string bkgsonucu;
    //    int bkgsonucu1;
    private void guncelle()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From hayvanlartbl", bgl.baglanti());
            da.Fill(dt);
            dgv_hayvanlar.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.RowFilter = "sahibi Like '" + Cb_sahibi.Text + "%'";
            dgv_hayvanlar.DataSource = dv;
        }
        private void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From hayvanlartbl", bgl.baglanti());
            da.Fill(dt);
            dgv_hayvanlar.DataSource = dt;

            SqlCommand komut13 = new SqlCommand("select *from hayvanlartbl", bgl.baglanti());
            SqlDataReader read2;
            cb_arama.Items.Clear();
            read2 = komut13.ExecuteReader();
          //  Cb_sil.Items.Clear();
            cb_silhayvan.Items.Clear();
            while (read2.Read())
            {
                cb_silhayvan.Items.Add(read2["TR"]);
                cb_arama.Items.Add(read2["TR"]);
                //     Cb_sil.Items.Add(read2["adi"]);
            }

          

        }
        private void dgv_hayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dgv_hayvanlar.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.
                TR1 = dgv_hayvanlar.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    msk_kupeno.Text = TR1.ToString();
                tanim1 = dgv_hayvanlar.Rows[e.RowIndex].Cells[2].Value.ToString();
          //      msk_tanim.Text = tanim1;
                cinsiyetkontrol = dgv_hayvanlar.Rows[e.RowIndex].Cells[4].Value.ToString();
                ls1 = dgv_hayvanlar.Rows[e.RowIndex].Cells[5].Value.ToString();
          //      cb_ls.Text = ls1.ToString();
                dt1 = dgv_hayvanlar.Rows[e.RowIndex].Cells[1].Value.ToString();
          //      dtp_dt.Text = dt1.ToString();
                cb_silhayvan.Text = dgv_hayvanlar.Rows[e.RowIndex].Cells[3].Value.ToString();
             /*   if (cinsiyetkontrol == "Erkek")
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

                }*/
            }
        }
        private void HayvanlarFormu_Load(object sender, EventArgs e)
        {
            //tb_sahibi.ReadOnly = true;
            panel1.Visible = true;
            if (  Cb_sahibi.Text == "") {
                dgv_hayvanlar.Visible = false;
                Gb_musteriekle.Visible = false;
                Gb_musterisil.Visible = false;
            }
            else
            {
                dgv_hayvanlar.Visible = true;
                Gb_musteriekle.Visible = true;
                Gb_musterisil.Visible = true;
            }
            SqlCommand komut13 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
            SqlDataReader read2;
            read2 = komut13.ExecuteReader();
            Cb_sahibi.Items.Clear();

            while (read2.Read())
            {

                Cb_sahibi.Items.Add(read2["adi"]);
            }
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
            if (msk_kupeno.MaskCompleted )


            { 
                
            if (msk_kupeno.Text == "TR") { MessageBox.Show("Hayvanın Küpe No'su eklenmek zorundadır !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else
            {
                if (Cb_sahibi.Text == "") { MessageBox.Show("Sisteme Sahipsiz Hayvan Girişi Mümkün Değildir. \n \n Lütfen Hayvan Sahibini Seçiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); } 
                else { 
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
                if (rb_erkek.Checked == true || rb_dişi.Checked == true)
                {
                    if (cinsiyet == "Erkek")
                    {
                                    sahibi1 = Cb_sahibi.Text;
                                    tanim1 = msk_tanim.Text;
                                    
                                    TR1 = msk_kupeno.Text;
                                    annekupeno1 = mskd_annekupeno.Text;
                                    dt1 = dtp_dt.Text;
                                    DialogResult cikis = new DialogResult();
                                    cikis = MessageBox.Show("\n" + "Hayvan'ın Tanımı: " +tanim1+ "" + "\n\n Hayvan Küpe No: " +TR1  + "\n\n Anne Küpe No: " + annekupeno1 + "\n\n Hayvanın Cinsiyeti: " + cinsiyet + "\n\n Hayvanın Doğum Tarihi: " + dt1 + "\n\n\n Yukarıdaki bilgilere ait hayvanı "+sahibi1+"'nun sürü listesine eklemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                                    if (cikis == DialogResult.Yes)
                                    {
                                        SqlCommand komut = new SqlCommand("insert into hayvanlartbl (Tanım,TR,cinsiyet,dogumtarihi,sahibi,AnneTR) values (@p1,@p2,@p11,@p12,@p14,@p3)", bgl.baglanti());

                                        komut.Parameters.AddWithValue("@p1", msk_tanim.Text);
                                        komut.Parameters.AddWithValue("@p2", msk_kupeno.Text);
                                        komut.Parameters.AddWithValue("@p3", mskd_annekupeno.Text);
                                        komut.Parameters.AddWithValue("@p11", cinsiyet);
                                        komut.Parameters.AddWithValue("@p12", dtp_dt.Value);
                                        komut.Parameters.AddWithValue("@p14", Cb_sahibi.Text);
                                        komut.ExecuteNonQuery();
                                        bgl.baglanti().Close();
                                        MessageBox.Show("Hayvan Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                      

                                    }
                                    if (cikis == DialogResult.No)
                                    {
                                        MessageBox.Show("Hayvan Ekleme İşlemi İptal Edildi.");

                                    }


                                    listele();
                                    guncelle();

                    }
                    else
                    {
                                    sahibi1 = Cb_sahibi.Text;
                                    tanim1 = msk_tanim.Text;
                                    ls1 = cb_ls.Text;

                                    TR1 = msk_kupeno.Text;
                                    annekupeno1 = mskd_annekupeno.Text;
                                    dt1 = dtp_dt.Text;
                                    DialogResult cikis = new DialogResult();
                                    cikis = MessageBox.Show("\n" + "Hayvan'ın Tanımı: " + tanim1 + "" + "\n\n Hayvan Küpe No: " + TR1 + "\n\n Anne Küpe No: " + annekupeno1 + "\n\n Hayvanın Cinsiyeti: " + cinsiyet + "\n\n Hayvanın Doğum Tarihi: " + dt1 + "\n\n Hayvanın Yaptığı Doğum Sayısı: "+ls1 + "\n\n\n Yukarıdaki bilgilere ait hayvanı " + sahibi1 + "'nun sürü listesine eklemek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                                    if (cikis == DialogResult.Yes)
                                    {
                                        SqlCommand komut = new SqlCommand("insert into hayvanlartbl (Tanım,TR,LS,cinsiyet,dogumtarihi,sahibi,AnneTR) values (@p1,@p2,@p3,@p11,@p12,@p14,@p4)", bgl.baglanti());

                                        komut.Parameters.AddWithValue("@p1", msk_tanim.Text);
                                        komut.Parameters.AddWithValue("@p2", msk_kupeno.Text);
                                        komut.Parameters.AddWithValue("@p3", cb_ls.Text);
                                        komut.Parameters.AddWithValue("@p4", mskd_annekupeno.Text);
                                        komut.Parameters.AddWithValue("@p11", cinsiyet);
                                        komut.Parameters.AddWithValue("@p12", dtp_dt.Value);
                                        komut.Parameters.AddWithValue("@p14", Cb_sahibi.Text);
                                        komut.ExecuteNonQuery();
                                        bgl.baglanti().Close();
                                        MessageBox.Show("Hayvan Bilgileri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    }
                                    if (cikis == DialogResult.No)
                                    {
                                        MessageBox.Show("Hayvan Ekleme İşlemi İptal Edildi.");

                                    }


                                    listele();
                                    guncelle();
                                    
                             /*  DateTime dt = DateTime.Parse(dtp_buzagilama.Text);
                        TimeSpan fark = DateTime.Today - dt;
                        sgssonucu = fark.TotalDays.ToString();
                        DateTime dt1 = DateTime.Parse(dtp_stt.Text);
                        TimeSpan fark1 = DateTime.Today - dt1;
                        bkgsonucu = fark1.TotalDays.ToString();
                        bkgsonucu1 = Convert.ToInt32(bkgsonucu);

                        bkgsonucu1 = 280 - bkgsonucu1;
*/
                    
                    }
                }
                else
                {

                    MessageBox.Show("Hayvanın Cinsiyetini Seçiniz");
                }
            }
        }
        }
            }
            else
            {
                MessageBox.Show("Hayvan Küpe No Yanlış Girilmiş ! \n \n Lütfen Hayvan Küpe No'yu doğru giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
        

            if (cb_silhayvan.Text== "TR" || cb_silhayvan.Text=="")
            {
                MessageBox.Show("Lütfen Silmek istediğiniz hayvanı tablodan seçiniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

               

                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show(silhayvan + " ait bilgiler silinecek devam etmek istiyor musun ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (cikis == DialogResult.Yes)
                {
                    SqlCommand komutsil = new SqlCommand("Delete From hayvanlartbl where TR=@p1", bgl.baglanti());
                    komutsil.Parameters.AddWithValue("@p1", silhayvan);
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
            guncelle();
            
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
            //cb_arama.Visible = true;
            panel1.Visible = false;
            dgv_hayvanlar.Visible = true;
            Gb_musterisil.Visible = true;
            Gb_musteriekle.Visible = true;
            //Gb_Guncelle.Location= "3; 3;" ;
            Gb_Guncelle.Location = new Point(3, 3);
          //  Gb_Guncelle.Left = Next(3);
          //  Gb_Guncelle.Top = Next(3);
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

      /*  private int Next(int v)
        {
            throw new NotImplementedException();
        }*/

        private void cbox_sahibi_CheckStateChanged(object sender, EventArgs e)
        {
      //      if (cbox_sahibi.Checked == true) { tb_sahibi.ReadOnly = false; }
     //       if (cbox_sahibi.Checked == false) { tb_sahibi.ReadOnly = true; }
        }
        
        private void cb_silhayvan_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          silhayvan=  cb_silhayvan.Text;
        }
        private AnaMenu f6 = new AnaMenu();
        private void dgv_hayvanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f6 = (AnaMenu)Application.OpenForms["AnaMenu"];
            f6.btn_islemler.PerformClick();
        }

       

        private void cb_arama_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From hayvanlartbl", bgl.baglanti());
            da.Fill(dt);
            dgv_hayvanlar.DataSource = dt;

            DataView dv = dt.DefaultView;

            dv.RowFilter = "TR Like '%TR" + cb_arama.Text + "%'";
           
            dgv_hayvanlar.DataSource = dv;

        }
    }
    }