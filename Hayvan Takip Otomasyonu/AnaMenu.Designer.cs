namespace Hayvan_Takip_Otomasyonu
{
    partial class AnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.btn_hayvanlar = new System.Windows.Forms.Button();
            this.btn_musteriler = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.pnl_islem = new System.Windows.Forms.Panel();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.BackColor = System.Drawing.Color.Coral;
            this.pnl_topbar.Controls.Add(this.btn_raporlar);
            this.pnl_topbar.Controls.Add(this.btn_islemler);
            this.pnl_topbar.Controls.Add(this.btn_hayvanlar);
            this.pnl_topbar.Controls.Add(this.btn_musteriler);
            this.pnl_topbar.Controls.Add(this.btn_anasayfa);
            resources.ApplyResources(this.pnl_topbar, "pnl_topbar");
            this.pnl_topbar.Name = "pnl_topbar";
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.raporlar;
            resources.ApplyResources(this.btn_raporlar, "btn_raporlar");
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.UseVisualStyleBackColor = true;
            this.btn_raporlar.Click += new System.EventHandler(this.btn_raporlar_Click);
            // 
            // btn_islemler
            // 
            this.btn_islemler.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.tedaviicon;
            resources.ApplyResources(this.btn_islemler, "btn_islemler");
            this.btn_islemler.Name = "btn_islemler";
            this.btn_islemler.UseVisualStyleBackColor = true;
            this.btn_islemler.Click += new System.EventHandler(this.btn_islemler_Click);
            // 
            // btn_hayvanlar
            // 
            this.btn_hayvanlar.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.hayvanlar1;
            resources.ApplyResources(this.btn_hayvanlar, "btn_hayvanlar");
            this.btn_hayvanlar.Name = "btn_hayvanlar";
            this.btn_hayvanlar.UseVisualStyleBackColor = true;
            this.btn_hayvanlar.Click += new System.EventHandler(this.btn_hayvanlar_Click);
            // 
            // btn_musteriler
            // 
            this.btn_musteriler.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.musterilericon;
            resources.ApplyResources(this.btn_musteriler, "btn_musteriler");
            this.btn_musteriler.Name = "btn_musteriler";
            this.btn_musteriler.UseVisualStyleBackColor = true;
            this.btn_musteriler.Click += new System.EventHandler(this.btn_musteriler_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.anasayfaicon1;
            resources.ApplyResources(this.btn_anasayfa, "btn_anasayfa");
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // pnl_islem
            // 
            resources.ApplyResources(this.pnl_islem, "pnl_islem");
            this.pnl_islem.Name = "pnl_islem";
            this.pnl_islem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_islem_Paint);
            // 
            // AnaMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_islem);
            this.Controls.Add(this.pnl_topbar);
            this.Name = "AnaMenu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.pnl_topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public  System.Windows.Forms.Panel pnl_topbar;
        public System.Windows.Forms.Button btn_anasayfa;
        public System.Windows.Forms.Button btn_musteriler;
        public System.Windows.Forms.Button btn_hayvanlar;
        public  System.Windows.Forms.Panel pnl_islem;
        public System.Windows.Forms.Button btn_islemler;
        public System.Windows.Forms.Button btn_raporlar;
    }
}

