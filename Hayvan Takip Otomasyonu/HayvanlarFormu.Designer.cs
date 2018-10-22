namespace Hayvan_Takip_Otomasyonu
{
    partial class HayvanlarFormu
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
            this.components = new System.ComponentModel.Container();
            this.musterilertblBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hTODataSet1 = new Hayvan_Takip_Otomasyonu.HTODataSet1();
            this.Gb_musteriekle = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_musteriadi = new System.Windows.Forms.Label();
            this.rtb_adres = new System.Windows.Forms.RichTextBox();
            this.lbl_isletmeno = new System.Windows.Forms.Label();
            this.mskdtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.tb_soyadi = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.mskdtb_isletmeno = new System.Windows.Forms.MaskedTextBox();
            this.Gb_Guncelle = new System.Windows.Forms.GroupBox();
            this.Cb_sahibi = new System.Windows.Forms.ComboBox();
            this.musterilertblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hTODataSet = new Hayvan_Takip_Otomasyonu.HTODataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.musterilertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTODataSetgiris = new Hayvan_Takip_Otomasyonu.HTODataSetgiris();
            this.musterilertblTableAdapter = new Hayvan_Takip_Otomasyonu.HTODataSetTableAdapters.musterilertblTableAdapter();
            this.musterilertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musterilertblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.musterilertblTableAdapter1 = new Hayvan_Takip_Otomasyonu.HTODataSet1TableAdapters.musterilertblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet1)).BeginInit();
            this.Gb_musteriekle.SuspendLayout();
            this.Gb_Guncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // musterilertblBindingSource4
            // 
            this.musterilertblBindingSource4.DataMember = "musterilertbl";
            this.musterilertblBindingSource4.DataSource = this.hTODataSet1;
            // 
            // hTODataSet1
            // 
            this.hTODataSet1.DataSetName = "HTODataSet1";
            this.hTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Gb_musteriekle
            // 
            this.Gb_musteriekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gb_musteriekle.Controls.Add(this.btn_kaydet);
            this.Gb_musteriekle.Controls.Add(this.lbl_musteriadi);
            this.Gb_musteriekle.Controls.Add(this.rtb_adres);
            this.Gb_musteriekle.Controls.Add(this.lbl_isletmeno);
            this.Gb_musteriekle.Controls.Add(this.mskdtb_telefon);
            this.Gb_musteriekle.Controls.Add(this.lbl_soyadi);
            this.Gb_musteriekle.Controls.Add(this.tb_soyadi);
            this.Gb_musteriekle.Controls.Add(this.lbl_tel);
            this.Gb_musteriekle.Controls.Add(this.lbl_adres);
            this.Gb_musteriekle.Controls.Add(this.mskdtb_isletmeno);
            this.Gb_musteriekle.Location = new System.Drawing.Point(12, 72);
            this.Gb_musteriekle.Name = "Gb_musteriekle";
            this.Gb_musteriekle.Size = new System.Drawing.Size(261, 269);
            this.Gb_musteriekle.TabIndex = 18;
            this.Gb_musteriekle.TabStop = false;
            this.Gb_musteriekle.Text = "İşlem Yapılan Müşteri";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.kaydet;
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kaydet.Location = new System.Drawing.Point(167, 214);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(60, 49);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // lbl_musteriadi
            // 
            this.lbl_musteriadi.AutoSize = true;
            this.lbl_musteriadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriadi.Location = new System.Drawing.Point(82, 44);
            this.lbl_musteriadi.Name = "lbl_musteriadi";
            this.lbl_musteriadi.Size = new System.Drawing.Size(42, 19);
            this.lbl_musteriadi.TabIndex = 0;
            this.lbl_musteriadi.Text = "Ad :";
            // 
            // rtb_adres
            // 
            this.rtb_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_adres.Location = new System.Drawing.Point(79, 127);
            this.rtb_adres.MaxLength = 500;
            this.rtb_adres.Name = "rtb_adres";
            this.rtb_adres.Size = new System.Drawing.Size(148, 84);
            this.rtb_adres.TabIndex = 9;
            this.rtb_adres.Text = "";
            // 
            // lbl_isletmeno
            // 
            this.lbl_isletmeno.AutoSize = true;
            this.lbl_isletmeno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isletmeno.Location = new System.Drawing.Point(15, 21);
            this.lbl_isletmeno.Name = "lbl_isletmeno";
            this.lbl_isletmeno.Size = new System.Drawing.Size(109, 19);
            this.lbl_isletmeno.TabIndex = 1;
            this.lbl_isletmeno.Text = "İşletme No :";
            // 
            // mskdtb_telefon
            // 
            this.mskdtb_telefon.Location = new System.Drawing.Point(127, 98);
            this.mskdtb_telefon.Mask = "(999) 000-0000";
            this.mskdtb_telefon.Name = "mskdtb_telefon";
            this.mskdtb_telefon.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_telefon.TabIndex = 8;
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.Location = new System.Drawing.Point(57, 70);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(69, 19);
            this.lbl_soyadi.TabIndex = 2;
            this.lbl_soyadi.Text = "Soyad :";
            // 
            // tb_soyadi
            // 
            this.tb_soyadi.Location = new System.Drawing.Point(127, 72);
            this.tb_soyadi.MaxLength = 20;
            this.tb_soyadi.Name = "tb_soyadi";
            this.tb_soyadi.Size = new System.Drawing.Size(100, 20);
            this.tb_soyadi.TabIndex = 7;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.Location = new System.Drawing.Point(42, 96);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(82, 19);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Telefon :";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(6, 124);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(67, 19);
            this.lbl_adres.TabIndex = 4;
            this.lbl_adres.Text = "Adres :";
            // 
            // mskdtb_isletmeno
            // 
            this.mskdtb_isletmeno.Location = new System.Drawing.Point(127, 20);
            this.mskdtb_isletmeno.Mask = "000000000000000";
            this.mskdtb_isletmeno.Name = "mskdtb_isletmeno";
            this.mskdtb_isletmeno.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_isletmeno.TabIndex = 5;
            // 
            // Gb_Guncelle
            // 
            this.Gb_Guncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.Gb_Guncelle.Controls.Add(this.Cb_sahibi);
            this.Gb_Guncelle.Controls.Add(this.label2);
            this.Gb_Guncelle.Location = new System.Drawing.Point(12, 12);
            this.Gb_Guncelle.Name = "Gb_Guncelle";
            this.Gb_Guncelle.Size = new System.Drawing.Size(261, 54);
            this.Gb_Guncelle.TabIndex = 19;
            this.Gb_Guncelle.TabStop = false;
            this.Gb_Guncelle.Text = "İşlem Yapılan Müşteri Bilgileri";
            // 
            // Cb_sahibi
            // 
            this.Cb_sahibi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Cb_sahibi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_sahibi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musterilertblBindingSource2, "adi", true));
            this.Cb_sahibi.FormattingEnabled = true;
            this.Cb_sahibi.Location = new System.Drawing.Point(46, 21);
            this.Cb_sahibi.Name = "Cb_sahibi";
            this.Cb_sahibi.Size = new System.Drawing.Size(173, 21);
            this.Cb_sahibi.TabIndex = 20;
            // 
            // musterilertblBindingSource2
            // 
            this.musterilertblBindingSource2.DataMember = "musterilertbl";
            this.musterilertblBindingSource2.DataSource = this.hTODataSet;
            // 
            // hTODataSet
            // 
            this.hTODataSet.DataSetName = "HTODataSet";
            this.hTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // musterilertblBindingSource
            // 
            this.musterilertblBindingSource.DataMember = "musterilertbl";
            this.musterilertblBindingSource.DataSource = this.hTODataSet;
            // 
            // hTODataSetgiris
            // 
            this.hTODataSetgiris.DataSetName = "HTODataSetgiris";
            this.hTODataSetgiris.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilertblTableAdapter
            // 
            this.musterilertblTableAdapter.ClearBeforeFill = true;
            // 
            // musterilertblBindingSource1
            // 
            this.musterilertblBindingSource1.DataMember = "musterilertbl";
            this.musterilertblBindingSource1.DataSource = this.hTODataSet;
            // 
            // musterilertblBindingSource3
            // 
            this.musterilertblBindingSource3.DataMember = "musterilertbl";
            this.musterilertblBindingSource3.DataSource = this.hTODataSet1;
            // 
            // musterilertblTableAdapter1
            // 
            this.musterilertblTableAdapter1.ClearBeforeFill = true;
            // 
            // HayvanlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.Gb_Guncelle);
            this.Controls.Add(this.Gb_musteriekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HayvanlarFormu";
            this.Text = "HayvanlarFormu";
            this.Load += new System.EventHandler(this.HayvanlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet1)).EndInit();
            this.Gb_musteriekle.ResumeLayout(false);
            this.Gb_musteriekle.PerformLayout();
            this.Gb_Guncelle.ResumeLayout(false);
            this.Gb_Guncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gb_musteriekle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_musteriadi;
        private System.Windows.Forms.RichTextBox rtb_adres;
        private System.Windows.Forms.Label lbl_isletmeno;
        private System.Windows.Forms.MaskedTextBox mskdtb_telefon;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.TextBox tb_soyadi;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.MaskedTextBox mskdtb_isletmeno;
        private System.Windows.Forms.GroupBox Gb_Guncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource musterilertblBindingSource;
        private HTODataSet hTODataSet;
        private HTODataSetgiris hTODataSetgiris;
        private HTODataSetTableAdapters.musterilertblTableAdapter musterilertblTableAdapter;
        private System.Windows.Forms.BindingSource musterilertblBindingSource2;
        private System.Windows.Forms.BindingSource musterilertblBindingSource1;
        private System.Windows.Forms.BindingSource musterilertblBindingSource3;
        private HTODataSet1 hTODataSet1;
        private HTODataSet1TableAdapters.musterilertblTableAdapter musterilertblTableAdapter1;
        private System.Windows.Forms.BindingSource musterilertblBindingSource4;
        public System.Windows.Forms.ComboBox Cb_sahibi;
    }
}