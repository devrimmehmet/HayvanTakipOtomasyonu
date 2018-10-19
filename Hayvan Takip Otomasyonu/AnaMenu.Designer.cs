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
            this.btn_musteriler = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.pnl_islem = new System.Windows.Forms.Panel();
            this.btn_hayvanlar = new System.Windows.Forms.Button();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.BackColor = System.Drawing.Color.Coral;
            this.pnl_topbar.Controls.Add(this.btn_hayvanlar);
            this.pnl_topbar.Controls.Add(this.btn_musteriler);
            this.pnl_topbar.Controls.Add(this.btn_anasayfa);
            resources.ApplyResources(this.pnl_topbar, "pnl_topbar");
            this.pnl_topbar.Name = "pnl_topbar";
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
            // 
            // btn_hayvanlar
            // 
            this.btn_hayvanlar.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.musterilericon;
            resources.ApplyResources(this.btn_hayvanlar, "btn_hayvanlar");
            this.btn_hayvanlar.Name = "btn_hayvanlar";
            this.btn_hayvanlar.UseVisualStyleBackColor = true;
            this.btn_hayvanlar.Click += new System.EventHandler(this.btn_hayvanlar_Click);
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

        private System.Windows.Forms.Panel pnl_topbar;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_musteriler;
        private System.Windows.Forms.Button btn_hayvanlar;
        public System.Windows.Forms.Panel pnl_islem;
    }
}

