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
        }

        private void pnl_musteriekle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bool durum = true;

            SqlCommand komut1 = new SqlCommand("select *from musterilertbl", bgl.baglanti());
            SqlDataReader read;
            read = komut1.ExecuteReader();


            while (read.Read())
            {
                if (read["adi"].ToString() == tb_adi.Text)
                {
                    MessageBox.Show("Bu isme ait Müşteri Sistemde Kayıtlı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        listele();
            
                }
              
            }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From musterilertbl where adi=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", tb_adi.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
    }

