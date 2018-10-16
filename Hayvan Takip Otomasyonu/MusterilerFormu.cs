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
            dataGridView1.DataSource = dt;

        }


        private void MusterilerFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hTODataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilertblTableAdapter.Fill(this.hTODataSet.musterilertbl);
            // TODO: Bu kod satırı 'hTODataSetgiris.DataTable2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        //    this.dataTable2TableAdapter.Fill(this.hTODataSetgiris.DataTable2);

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
        }
    }

