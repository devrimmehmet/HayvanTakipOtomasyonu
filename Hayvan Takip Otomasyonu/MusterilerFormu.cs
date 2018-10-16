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
            SqlDataAdapter da = new SqlDataAdapter("Select * From musterilertbl", bgl.baglanti());
            da.Fill(dt);
            dgv_musteriler.DataSource = dt;

        }


        private void MusterilerFormu_Load(object sender, EventArgs e)
        {
            this.musterilertblTableAdapter.Fill(this.hTODataSet.musterilertbl);
        //    dgv_musteriler.MultiSelect = false;
        //    dgv_musteriler.ReadOnly = true;
        }

        private void pnl_musteriekle_Paint(object sender, PaintEventArgs e)
        {

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
                    listele();
                    if (read["adi"].ToString() == tb_adi.Text)
                    {

                        MessageBox.Show("Bu isme ait Müşteri Sistemde Kayıtlı !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        durum = false;
                        bgl.baglanti().Close();
                    }
                }
                listele();
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
                    listele();

                }
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Müşteriye ait bilgiler Silinecek Devam Etmek istiyor musun ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete From musterilertbl where adi=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", tb_adi.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi.");
                
            }

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* dgv_musteriler.MultiSelect = false;
            dgv_musteriler.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                                dgv_musteriler.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.

            }

            //seçili satırın bilgilerini alıyoruz.

           // MessageBox.Show(dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString()+  dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString()+dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString());
            tb_id.Text = dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
            mskdtb_isletmeno.Text= dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_adi.Text= dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_soyadi.Text= dgv_musteriler.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskdtb_telefon.Text = dgv_musteriler.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtb_adres.Text= dgv_musteriler.Rows[e.RowIndex].Cells[5].Value.ToString();
         */
        }

        private void dgv_musteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_musteriler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_musteriler.Rows[e.RowIndex].Selected)

            {              
                e.CellStyle.SelectionBackColor= Color.Red;  //seçli  satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionForeColor= Color.White; //seçili  satır yazı rengini beyaz yapıyoruz

            }
        }
      //  int secilensatir;
        private void dgv_musteriler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*    secilensatir = Convert.ToInt16(data.Tables["tablo"].Rows[e.RowIndex]["Kimlik"]);

                textBox1.Text = secilensatir.ToString();
                textBox2.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["numara"].ToString();
                textBox3.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["adı"].ToString();
                textBox4.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["soyadı"].ToString();
                textBox5.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["vize"].ToString();
                textBox6.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["final"].ToString();
                textBox7.Text = 1ds.Tables["tablo"].Rows[e.RowIndex]["gn"].ToString();
                */
        /*    dgv_musteriler.MultiSelect = false;
            dgv_musteriler.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dgv_musteriler.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.

            }

            //seçili satırın bilgilerini alıyoruz.

            // MessageBox.Show(dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString()+  dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString()+dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString());
            tb_id.Text = dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
            mskdtb_isletmeno.Text = dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_adi.Text = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_soyadi.Text = dgv_musteriler.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskdtb_telefon.Text = dgv_musteriler.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtb_adres.Text = dgv_musteriler.Rows[e.RowIndex].Cells[5].Value.ToString();*/
        }

        private void dgv_musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    /*   //  dgv_musteriler.MultiSelect = false;
        //    dgv_musteriler.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {
                dgv_musteriler.Rows[e.RowIndex].Selected = true;//satır  seçimini true yapıyoruz.

            }

            //seçili satırın bilgilerini alıyoruz.

            // MessageBox.Show(dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString()+  dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString()+dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString());
        //    tb_id.Text = dgv_musteriler.Rows[e.RowIndex].Cells[0].Value.ToString();
            mskdtb_isletmeno.Text = dgv_musteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_adi.Text = dgv_musteriler.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_soyadi.Text = dgv_musteriler.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskdtb_telefon.Text = dgv_musteriler.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtb_adres.Text = dgv_musteriler.Rows[e.RowIndex].Cells[5].Value.ToString();*/
        }
    }
    }

