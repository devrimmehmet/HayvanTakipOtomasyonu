namespace Hayvan_Takip_Otomasyonu
{
    partial class GirisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(12, 156);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(121, 23);
            this.lbl_kullaniciadi.TabIndex = 9;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(75, 182);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifre :";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(140, 156);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciadi.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(140, 182);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_girisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_girisyap.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_girisyap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.ForeColor = System.Drawing.Color.Red;
            this.btn_girisyap.Location = new System.Drawing.Point(140, 208);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_girisyap.Size = new System.Drawing.Size(100, 28);
            this.btn_girisyap.TabIndex = 2;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // GirisFormu
            // 
            this.AcceptButton = this.btn_girisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.girisformu1;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvan Takip Programı (Tayfun Ünal)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            this.Enter += new System.EventHandler(this.GirisFormu_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GirisFormu_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GirisFormu_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisyap;
    }
}