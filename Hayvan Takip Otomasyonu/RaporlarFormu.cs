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
    public partial class RaporlarFormu : Form
    {
        public RaporlarFormu()
        {
            InitializeComponent();
        }

        private void RaporlarFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'raporlamads.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilertblTableAdapter.Fill(this.raporlamads.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //    this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.hayvanlartbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hayvanlartblTableAdapter.Fill(this.tdbDataSet.hayvanlartbl);
            // TODO: Bu kod satırı 'tdbDataSet.hayvanlartbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.hayvanlartblTableAdapter.Fill(this.tdbDataSet.hayvanlartbl);
            // TODO: Bu kod satırı 'tdbDataSet1.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //   this.musterilertblTableAdapter.Fill(this.tdbDataSet1.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);
            // TODO: Bu kod satırı 'tdbDataSet.musterilertbl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.musterilertblTableAdapter.Fill(this.tdbDataSet.musterilertbl);

            //   this.Rw_raporlar.RefreshReport();
            //      this.reportViewer1.RefreshReport();

            //      this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_musterilerR_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
        }
    }
}
