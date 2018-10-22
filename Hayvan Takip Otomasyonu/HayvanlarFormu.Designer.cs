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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gb_musteriekle = new System.Windows.Forms.GroupBox();
            this.cbox_sahibi = new System.Windows.Forms.CheckBox();
            this.tb_sahibi = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_durum = new System.Windows.Forms.ComboBox();
            this.dtp_stt = new System.Windows.Forms.DateTimePicker();
            this.dtp_buzagilama = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ls = new System.Windows.Forms.ComboBox();
            this.dtp_dt = new System.Windows.Forms.DateTimePicker();
            this.rb_dişi = new System.Windows.Forms.RadioButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_sahibi = new System.Windows.Forms.Label();
            this.msk_kupeno = new System.Windows.Forms.MaskedTextBox();
            this.msk_tanim = new System.Windows.Forms.MaskedTextBox();
            this.lbl_kupeno = new System.Windows.Forms.Label();
            this.lbl_tanim = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_ls = new System.Windows.Forms.Label();
            this.lbl_hdt = new System.Windows.Forms.Label();
            this.Gb_Guncelle = new System.Windows.Forms.GroupBox();
            this.Cb_sahibi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_hayvanlar = new System.Windows.Forms.DataGridView();
            this.sahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buzagilamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senkronizasyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hayvanlartblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tdbDataSet = new Hayvan_Takip_Otomasyonu.tdbDataSet();
            this.hayvanlartblTableAdapter = new Hayvan_Takip_Otomasyonu.tdbDataSetTableAdapters.hayvanlartblTableAdapter();
            this.Gb_musteriekle.SuspendLayout();
            this.Gb_Guncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlartblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_musteriekle
            // 
            this.Gb_musteriekle.BackColor = System.Drawing.Color.Goldenrod;
            this.Gb_musteriekle.Controls.Add(this.cbox_sahibi);
            this.Gb_musteriekle.Controls.Add(this.tb_sahibi);
            this.Gb_musteriekle.Controls.Add(this.btn_sil);
            this.Gb_musteriekle.Controls.Add(this.label4);
            this.Gb_musteriekle.Controls.Add(this.cb_durum);
            this.Gb_musteriekle.Controls.Add(this.dtp_stt);
            this.Gb_musteriekle.Controls.Add(this.dtp_buzagilama);
            this.Gb_musteriekle.Controls.Add(this.label3);
            this.Gb_musteriekle.Controls.Add(this.label1);
            this.Gb_musteriekle.Controls.Add(this.cb_ls);
            this.Gb_musteriekle.Controls.Add(this.dtp_dt);
            this.Gb_musteriekle.Controls.Add(this.rb_dişi);
            this.Gb_musteriekle.Controls.Add(this.rb_erkek);
            this.Gb_musteriekle.Controls.Add(this.lbl_cinsiyet);
            this.Gb_musteriekle.Controls.Add(this.lbl_sahibi);
            this.Gb_musteriekle.Controls.Add(this.msk_kupeno);
            this.Gb_musteriekle.Controls.Add(this.msk_tanim);
            this.Gb_musteriekle.Controls.Add(this.lbl_kupeno);
            this.Gb_musteriekle.Controls.Add(this.lbl_tanim);
            this.Gb_musteriekle.Controls.Add(this.btn_kaydet);
            this.Gb_musteriekle.Controls.Add(this.lbl_ls);
            this.Gb_musteriekle.Controls.Add(this.lbl_hdt);
            this.Gb_musteriekle.Location = new System.Drawing.Point(3, 81);
            this.Gb_musteriekle.Name = "Gb_musteriekle";
            this.Gb_musteriekle.Size = new System.Drawing.Size(270, 548);
            this.Gb_musteriekle.TabIndex = 18;
            this.Gb_musteriekle.TabStop = false;
            this.Gb_musteriekle.Text = "Hayvan Ekle";
            // 
            // cbox_sahibi
            // 
            this.cbox_sahibi.AutoSize = true;
            this.cbox_sahibi.Location = new System.Drawing.Point(235, 456);
            this.cbox_sahibi.Name = "cbox_sahibi";
            this.cbox_sahibi.Size = new System.Drawing.Size(15, 14);
            this.cbox_sahibi.TabIndex = 36;
            this.cbox_sahibi.UseVisualStyleBackColor = true;
            this.cbox_sahibi.Visible = false;
            this.cbox_sahibi.CheckStateChanged += new System.EventHandler(this.cbox_sahibi_CheckStateChanged);
            // 
            // tb_sahibi
            // 
            this.tb_sahibi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sahibi.Location = new System.Drawing.Point(86, 448);
            this.tb_sahibi.Name = "tb_sahibi";
            this.tb_sahibi.Size = new System.Drawing.Size(135, 27);
            this.tb_sahibi.TabIndex = 35;
            this.tb_sahibi.Visible = false;
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.silicon;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(6, 492);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(56, 49);
            this.btn_sil.TabIndex = 34;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Uygulama Durumu";
            // 
            // cb_durum
            // 
            this.cb_durum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_durum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_durum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_durum.FormattingEnabled = true;
            this.cb_durum.Items.AddRange(new object[] {
            "TOHUMLANMIŞ"});
            this.cb_durum.Location = new System.Drawing.Point(38, 415);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(180, 27);
            this.cb_durum.TabIndex = 32;
            // 
            // dtp_stt
            // 
            this.dtp_stt.CustomFormat = "DD/MM/YYYY";
            this.dtp_stt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_stt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_stt.Location = new System.Drawing.Point(76, 347);
            this.dtp_stt.Name = "dtp_stt";
            this.dtp_stt.Size = new System.Drawing.Size(110, 27);
            this.dtp_stt.TabIndex = 31;
            this.dtp_stt.Value = new System.DateTime(2018, 10, 22, 0, 0, 0, 0);
            // 
            // dtp_buzagilama
            // 
            this.dtp_buzagilama.CustomFormat = "DD/MM/YYYY";
            this.dtp_buzagilama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_buzagilama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_buzagilama.Location = new System.Drawing.Point(76, 284);
            this.dtp_buzagilama.Name = "dtp_buzagilama";
            this.dtp_buzagilama.Size = new System.Drawing.Size(110, 27);
            this.dtp_buzagilama.TabIndex = 30;
            this.dtp_buzagilama.Value = new System.DateTime(2018, 10, 22, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Son Tohumlanma Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Son Buzağılama Tarihi";
            // 
            // cb_ls
            // 
            this.cb_ls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_ls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ls.FormattingEnabled = true;
            this.cb_ls.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cb_ls.Location = new System.Drawing.Point(101, 222);
            this.cb_ls.Name = "cb_ls";
            this.cb_ls.Size = new System.Drawing.Size(50, 27);
            this.cb_ls.TabIndex = 27;
            // 
            // dtp_dt
            // 
            this.dtp_dt.CustomFormat = "DD/MM/YYYY";
            this.dtp_dt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dt.Location = new System.Drawing.Point(77, 150);
            this.dtp_dt.Name = "dtp_dt";
            this.dtp_dt.Size = new System.Drawing.Size(110, 27);
            this.dtp_dt.TabIndex = 26;
            this.dtp_dt.Value = new System.DateTime(2018, 10, 22, 0, 0, 0, 0);
            // 
            // rb_dişi
            // 
            this.rb_dişi.AutoSize = true;
            this.rb_dişi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_dişi.Location = new System.Drawing.Point(187, 84);
            this.rb_dişi.Name = "rb_dişi";
            this.rb_dişi.Size = new System.Drawing.Size(57, 23);
            this.rb_dişi.TabIndex = 25;
            this.rb_dişi.TabStop = true;
            this.rb_dişi.Text = "Dişi";
            this.rb_dişi.UseVisualStyleBackColor = true;
            this.rb_dişi.CheckedChanged += new System.EventHandler(this.rb_dişi_CheckedChanged);
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_erkek.Location = new System.Drawing.Point(107, 84);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(74, 23);
            this.rb_erkek.TabIndex = 24;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            this.rb_erkek.CheckedChanged += new System.EventHandler(this.rb_erkek_CheckedChanged);
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(6, 86);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(90, 19);
            this.lbl_cinsiyet.TabIndex = 23;
            this.lbl_cinsiyet.Text = "Cinsiyeti :";
            // 
            // lbl_sahibi
            // 
            this.lbl_sahibi.AutoSize = true;
            this.lbl_sahibi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sahibi.Location = new System.Drawing.Point(16, 451);
            this.lbl_sahibi.Name = "lbl_sahibi";
            this.lbl_sahibi.Size = new System.Drawing.Size(70, 19);
            this.lbl_sahibi.TabIndex = 21;
            this.lbl_sahibi.Text = "Sahibi :";
            this.lbl_sahibi.Visible = false;
            // 
            // msk_kupeno
            // 
            this.msk_kupeno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk_kupeno.Location = new System.Drawing.Point(147, 49);
            this.msk_kupeno.Mask = "TR000000000";
            this.msk_kupeno.Name = "msk_kupeno";
            this.msk_kupeno.Size = new System.Drawing.Size(108, 27);
            this.msk_kupeno.TabIndex = 14;
            // 
            // msk_tanim
            // 
            this.msk_tanim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk_tanim.Location = new System.Drawing.Point(149, 19);
            this.msk_tanim.Mask = "00000";
            this.msk_tanim.Name = "msk_tanim";
            this.msk_tanim.Size = new System.Drawing.Size(55, 27);
            this.msk_tanim.TabIndex = 13;
            // 
            // lbl_kupeno
            // 
            this.lbl_kupeno.AutoSize = true;
            this.lbl_kupeno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kupeno.Location = new System.Drawing.Point(0, 52);
            this.lbl_kupeno.Name = "lbl_kupeno";
            this.lbl_kupeno.Size = new System.Drawing.Size(153, 19);
            this.lbl_kupeno.TabIndex = 12;
            this.lbl_kupeno.Text = "Hayvan Küpe No :";
            // 
            // lbl_tanim
            // 
            this.lbl_tanim.AutoSize = true;
            this.lbl_tanim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tanim.Location = new System.Drawing.Point(82, 22);
            this.lbl_tanim.Name = "lbl_tanim";
            this.lbl_tanim.Size = new System.Drawing.Size(71, 19);
            this.lbl_tanim.TabIndex = 11;
            this.lbl_tanim.Text = "Tanım :";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.kaydetbutton;
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(130, 471);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(125, 70);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_ls
            // 
            this.lbl_ls.AutoSize = true;
            this.lbl_ls.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ls.Location = new System.Drawing.Point(0, 200);
            this.lbl_ls.Name = "lbl_ls";
            this.lbl_ls.Size = new System.Drawing.Size(261, 19);
            this.lbl_ls.TabIndex = 0;
            this.lbl_ls.Text = "Hayvanın Yaptığı Doğum Sayısı";
            // 
            // lbl_hdt
            // 
            this.lbl_hdt.AutoSize = true;
            this.lbl_hdt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hdt.Location = new System.Drawing.Point(28, 128);
            this.lbl_hdt.Name = "lbl_hdt";
            this.lbl_hdt.Size = new System.Drawing.Size(199, 19);
            this.lbl_hdt.TabIndex = 1;
            this.lbl_hdt.Text = "Hayvanın Doğum Tarihi";
            // 
            // Gb_Guncelle
            // 
            this.Gb_Guncelle.BackColor = System.Drawing.Color.GreenYellow;
            this.Gb_Guncelle.Controls.Add(this.Cb_sahibi);
            this.Gb_Guncelle.Controls.Add(this.label2);
            this.Gb_Guncelle.Location = new System.Drawing.Point(3, 3);
            this.Gb_Guncelle.Name = "Gb_Guncelle";
            this.Gb_Guncelle.Size = new System.Drawing.Size(270, 72);
            this.Gb_Guncelle.TabIndex = 19;
            this.Gb_Guncelle.TabStop = false;
            this.Gb_Guncelle.Text = "İşlem Yapılan Müşteri Bilgileri";
            // 
            // Cb_sahibi
            // 
            this.Cb_sahibi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Cb_sahibi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_sahibi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cb_sahibi.FormattingEnabled = true;
            this.Cb_sahibi.Location = new System.Drawing.Point(10, 42);
            this.Cb_sahibi.Name = "Cb_sahibi";
            this.Cb_sahibi.Size = new System.Drawing.Size(249, 24);
            this.Cb_sahibi.TabIndex = 20;
            this.Cb_sahibi.SelectedIndexChanged += new System.EventHandler(this.Cb_sahibi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // dgv_hayvanlar
            // 
            this.dgv_hayvanlar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.dgv_hayvanlar.AllowUserToAddRows = false;
            this.dgv_hayvanlar.AllowUserToDeleteRows = false;
            this.dgv_hayvanlar.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hayvanlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hayvanlar.AutoGenerateColumns = false;
            this.dgv_hayvanlar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_hayvanlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_hayvanlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_hayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hayvanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sahibi,
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.tanımDataGridViewTextBoxColumn,
            this.tRDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.lSDataGridViewTextBoxColumn,
            this.sGSDataGridViewTextBoxColumn,
            this.bKGDataGridViewTextBoxColumn,
            this.tTDataGridViewTextBoxColumn,
            this.buzagilamaDataGridViewTextBoxColumn,
            this.uDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.senkronizasyonDataGridViewTextBoxColumn,
            this.detay});
            this.dgv_hayvanlar.DataSource = this.hayvanlartblBindingSource;
            this.dgv_hayvanlar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_hayvanlar.Location = new System.Drawing.Point(279, 3);
            this.dgv_hayvanlar.MultiSelect = false;
            this.dgv_hayvanlar.Name = "dgv_hayvanlar";
            this.dgv_hayvanlar.ReadOnly = true;
            this.dgv_hayvanlar.RowHeadersVisible = false;
            this.dgv_hayvanlar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_hayvanlar.Size = new System.Drawing.Size(1065, 626);
            this.dgv_hayvanlar.TabIndex = 20;
            this.dgv_hayvanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hayvanlar_CellClick);
            this.dgv_hayvanlar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_hayvanlar_CellFormatting);
            // 
            // sahibi
            // 
            this.sahibi.DataPropertyName = "sahibi";
            this.sahibi.HeaderText = "sahibi";
            this.sahibi.Name = "sahibi";
            this.sahibi.ReadOnly = true;
            this.sahibi.Visible = false;
            // 
            // dogumtarihiDataGridViewTextBoxColumn
            // 
            this.dogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.HeaderText = "Hayvanın Doğum Tarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.Name = "dogumtarihiDataGridViewTextBoxColumn";
            this.dogumtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogumtarihiDataGridViewTextBoxColumn.Visible = false;
            // 
            // tanımDataGridViewTextBoxColumn
            // 
            this.tanımDataGridViewTextBoxColumn.DataPropertyName = "Tanım";
            this.tanımDataGridViewTextBoxColumn.HeaderText = "Tanım";
            this.tanımDataGridViewTextBoxColumn.MinimumWidth = 42;
            this.tanımDataGridViewTextBoxColumn.Name = "tanımDataGridViewTextBoxColumn";
            this.tanımDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanımDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tanımDataGridViewTextBoxColumn.Width = 42;
            // 
            // tRDataGridViewTextBoxColumn
            // 
            this.tRDataGridViewTextBoxColumn.DataPropertyName = "TR";
            this.tRDataGridViewTextBoxColumn.HeaderText = "Küpe No";
            this.tRDataGridViewTextBoxColumn.MinimumWidth = 79;
            this.tRDataGridViewTextBoxColumn.Name = "tRDataGridViewTextBoxColumn";
            this.tRDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tRDataGridViewTextBoxColumn.Width = 79;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 45;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinsiyetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cinsiyetDataGridViewTextBoxColumn.Width = 45;
            // 
            // lSDataGridViewTextBoxColumn
            // 
            this.lSDataGridViewTextBoxColumn.DataPropertyName = "LS";
            this.lSDataGridViewTextBoxColumn.HeaderText = "LS";
            this.lSDataGridViewTextBoxColumn.MinimumWidth = 25;
            this.lSDataGridViewTextBoxColumn.Name = "lSDataGridViewTextBoxColumn";
            this.lSDataGridViewTextBoxColumn.ReadOnly = true;
            this.lSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lSDataGridViewTextBoxColumn.Width = 25;
            // 
            // sGSDataGridViewTextBoxColumn
            // 
            this.sGSDataGridViewTextBoxColumn.DataPropertyName = "SGS";
            this.sGSDataGridViewTextBoxColumn.HeaderText = "SGS";
            this.sGSDataGridViewTextBoxColumn.MinimumWidth = 32;
            this.sGSDataGridViewTextBoxColumn.Name = "sGSDataGridViewTextBoxColumn";
            this.sGSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sGSDataGridViewTextBoxColumn.Width = 32;
            // 
            // bKGDataGridViewTextBoxColumn
            // 
            this.bKGDataGridViewTextBoxColumn.DataPropertyName = "BKG";
            this.bKGDataGridViewTextBoxColumn.HeaderText = "BKG";
            this.bKGDataGridViewTextBoxColumn.MinimumWidth = 32;
            this.bKGDataGridViewTextBoxColumn.Name = "bKGDataGridViewTextBoxColumn";
            this.bKGDataGridViewTextBoxColumn.ReadOnly = true;
            this.bKGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bKGDataGridViewTextBoxColumn.Width = 32;
            // 
            // tTDataGridViewTextBoxColumn
            // 
            this.tTDataGridViewTextBoxColumn.DataPropertyName = "TT";
            this.tTDataGridViewTextBoxColumn.HeaderText = "Son Tohumlanma Tarihi";
            this.tTDataGridViewTextBoxColumn.Name = "tTDataGridViewTextBoxColumn";
            this.tTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTDataGridViewTextBoxColumn.Width = 70;
            // 
            // buzagilamaDataGridViewTextBoxColumn
            // 
            this.buzagilamaDataGridViewTextBoxColumn.DataPropertyName = "buzagilama";
            this.buzagilamaDataGridViewTextBoxColumn.HeaderText = "Son Buzağılama Tarihi";
            this.buzagilamaDataGridViewTextBoxColumn.Name = "buzagilamaDataGridViewTextBoxColumn";
            this.buzagilamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.buzagilamaDataGridViewTextBoxColumn.Width = 70;
            // 
            // uDDataGridViewTextBoxColumn
            // 
            this.uDDataGridViewTextBoxColumn.DataPropertyName = "UD";
            this.uDDataGridViewTextBoxColumn.HeaderText = "Uygulama Durumu";
            this.uDDataGridViewTextBoxColumn.Name = "uDDataGridViewTextBoxColumn";
            this.uDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senkronizasyonDataGridViewTextBoxColumn
            // 
            this.senkronizasyonDataGridViewTextBoxColumn.DataPropertyName = "Senkronizasyon";
            this.senkronizasyonDataGridViewTextBoxColumn.HeaderText = "Senkronizasyon";
            this.senkronizasyonDataGridViewTextBoxColumn.Name = "senkronizasyonDataGridViewTextBoxColumn";
            this.senkronizasyonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detay
            // 
            this.detay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detay.DataPropertyName = "detay";
            this.detay.HeaderText = "Detay";
            this.detay.MinimumWidth = 50;
            this.detay.Name = "detay";
            this.detay.ReadOnly = true;
            this.detay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hayvanlartblBindingSource
            // 
            this.hayvanlartblBindingSource.DataMember = "hayvanlartbl";
            this.hayvanlartblBindingSource.DataSource = this.tdbDataSet;
            // 
            // tdbDataSet
            // 
            this.tdbDataSet.DataSetName = "tdbDataSet";
            this.tdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hayvanlartblTableAdapter
            // 
            this.hayvanlartblTableAdapter.ClearBeforeFill = true;
            // 
            // HayvanlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1350, 631);
            this.Controls.Add(this.dgv_hayvanlar);
            this.Controls.Add(this.Gb_Guncelle);
            this.Controls.Add(this.Gb_musteriekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HayvanlarFormu";
            this.Text = "HayvanlarFormu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HayvanlarFormu_Load);
            this.Gb_musteriekle.ResumeLayout(false);
            this.Gb_musteriekle.PerformLayout();
            this.Gb_Guncelle.ResumeLayout(false);
            this.Gb_Guncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hayvanlartblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gb_musteriekle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_ls;
        private System.Windows.Forms.Label lbl_hdt;
        private System.Windows.Forms.GroupBox Gb_Guncelle;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cb_sahibi;
        private tdbDataSet tdbDataSet;
        private System.Windows.Forms.BindingSource hayvanlartblBindingSource;
        private tdbDataSetTableAdapters.hayvanlartblTableAdapter hayvanlartblTableAdapter;
        public System.Windows.Forms.ComboBox cb_ls;
        private System.Windows.Forms.RadioButton rb_dişi;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Label lbl_sahibi;
        private System.Windows.Forms.MaskedTextBox msk_kupeno;
        private System.Windows.Forms.MaskedTextBox msk_tanim;
        private System.Windows.Forms.Label lbl_kupeno;
        private System.Windows.Forms.Label lbl_tanim;
        private System.Windows.Forms.DataGridView dgv_hayvanlar;
        public System.Windows.Forms.DateTimePicker dtp_dt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_durum;
        public System.Windows.Forms.DateTimePicker dtp_stt;
        public System.Windows.Forms.DateTimePicker dtp_buzagilama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox tb_sahibi;
        private System.Windows.Forms.CheckBox cbox_sahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buzagilamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senkronizasyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detay;
    }
}