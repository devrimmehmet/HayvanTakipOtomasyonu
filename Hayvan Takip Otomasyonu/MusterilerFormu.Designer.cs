namespace Hayvan_Takip_Otomasyonu
{
    partial class MusterilerFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_musteriadi = new System.Windows.Forms.Label();
            this.rtb_adres = new System.Windows.Forms.RichTextBox();
            this.mskdtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.tb_soyadi = new System.Windows.Forms.TextBox();
            this.tb_adi = new System.Windows.Forms.TextBox();
            this.mskdtb_isletmeno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_isletmeno = new System.Windows.Forms.Label();
            this.dgv_musteriler = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isletmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTODataSet = new Hayvan_Takip_Otomasyonu.HTODataSet();
            this.hTODataSetgiris = new Hayvan_Takip_Otomasyonu.HTODataSetgiris();
            this.musterilertblTableAdapter = new Hayvan_Takip_Otomasyonu.HTODataSetTableAdapters.musterilertblTableAdapter();
            this.Gb_musteriekle = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.Gb_musterisil = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_sil = new System.Windows.Forms.ComboBox();
            this.musterilertblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_sil = new System.Windows.Forms.Button();
            this.musterilertblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hTODataSet1 = new Hayvan_Takip_Otomasyonu.HTODataSet1();
            this.musterilertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musterilertblTableAdapter1 = new Hayvan_Takip_Otomasyonu.HTODataSet1TableAdapters.musterilertblTableAdapter();
            this.Gb_Guncelle = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.cb_adres = new System.Windows.Forms.CheckBox();
            this.cb_tel = new System.Windows.Forms.CheckBox();
            this.cb_soyadi = new System.Windows.Forms.CheckBox();
            this.cb_adi = new System.Windows.Forms.CheckBox();
            this.cb_isletmeno = new System.Windows.Forms.CheckBox();
            this.rtb_guncelleadres = new System.Windows.Forms.RichTextBox();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_guncelle_tel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_guncelle_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_guncelle_adi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_guncelle_isletmeno = new System.Windows.Forms.MaskedTextBox();
            this.cb_arama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).BeginInit();
            this.Gb_musteriekle.SuspendLayout();
            this.Gb_musterisil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource1)).BeginInit();
            this.Gb_Guncelle.SuspendLayout();
            this.SuspendLayout();
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
            // mskdtb_telefon
            // 
            this.mskdtb_telefon.Location = new System.Drawing.Point(127, 98);
            this.mskdtb_telefon.Mask = "(999) 000-0000";
            this.mskdtb_telefon.Name = "mskdtb_telefon";
            this.mskdtb_telefon.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_telefon.TabIndex = 8;
            // 
            // tb_soyadi
            // 
            this.tb_soyadi.Location = new System.Drawing.Point(127, 72);
            this.tb_soyadi.MaxLength = 20;
            this.tb_soyadi.Name = "tb_soyadi";
            this.tb_soyadi.Size = new System.Drawing.Size(100, 20);
            this.tb_soyadi.TabIndex = 7;
            // 
            // tb_adi
            // 
            this.tb_adi.Location = new System.Drawing.Point(127, 46);
            this.tb_adi.MaxLength = 20;
            this.tb_adi.Name = "tb_adi";
            this.tb_adi.Size = new System.Drawing.Size(100, 20);
            this.tb_adi.TabIndex = 6;
            this.tb_adi.WordWrap = false;
            // 
            // mskdtb_isletmeno
            // 
            this.mskdtb_isletmeno.Location = new System.Drawing.Point(127, 20);
            this.mskdtb_isletmeno.Mask = "000000000000000";
            this.mskdtb_isletmeno.Name = "mskdtb_isletmeno";
            this.mskdtb_isletmeno.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_isletmeno.TabIndex = 5;
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
            // dgv_musteriler
            // 
            this.dgv_musteriler.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.dgv_musteriler.AllowUserToAddRows = false;
            this.dgv_musteriler.AllowUserToDeleteRows = false;
            this.dgv_musteriler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_musteriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_musteriler.AutoGenerateColumns = false;
            this.dgv_musteriler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_musteriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_musteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.isletmenoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresiDataGridViewTextBoxColumn});
            this.dgv_musteriler.DataSource = this.musterilertblBindingSource;
            this.dgv_musteriler.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_musteriler.Location = new System.Drawing.Point(250, 33);
            this.dgv_musteriler.MultiSelect = false;
            this.dgv_musteriler.Name = "dgv_musteriler";
            this.dgv_musteriler.ReadOnly = true;
            this.dgv_musteriler.RowHeadersVisible = false;
            this.dgv_musteriler.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_musteriler.Size = new System.Drawing.Size(1081, 594);
            this.dgv_musteriler.TabIndex = 2;
            this.dgv_musteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_musteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musteriler_CellDoubleClick);
            this.dgv_musteriler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_musteriler_CellFormatting);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 30;
            // 
            // isletmenoDataGridViewTextBoxColumn
            // 
            this.isletmenoDataGridViewTextBoxColumn.DataPropertyName = "isletmeno";
            this.isletmenoDataGridViewTextBoxColumn.HeaderText = "İŞLETME NO";
            this.isletmenoDataGridViewTextBoxColumn.Name = "isletmenoDataGridViewTextBoxColumn";
            this.isletmenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "AD";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            this.adiDataGridViewTextBoxColumn.Width = 120;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadiDataGridViewTextBoxColumn.Width = 120;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresiDataGridViewTextBoxColumn
            // 
            this.adresiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresiDataGridViewTextBoxColumn.DataPropertyName = "adresi";
            this.adresiDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresiDataGridViewTextBoxColumn.Name = "adresiDataGridViewTextBoxColumn";
            this.adresiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musterilertblBindingSource
            // 
            this.musterilertblBindingSource.DataMember = "musterilertbl";
            this.musterilertblBindingSource.DataSource = this.hTODataSet;
            // 
            // hTODataSet
            // 
            this.hTODataSet.DataSetName = "HTODataSet";
            this.hTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Gb_musteriekle.Controls.Add(this.tb_adi);
            this.Gb_musteriekle.Controls.Add(this.lbl_adres);
            this.Gb_musteriekle.Controls.Add(this.mskdtb_isletmeno);
            this.Gb_musteriekle.Location = new System.Drawing.Point(2, 12);
            this.Gb_musteriekle.Name = "Gb_musteriekle";
            this.Gb_musteriekle.Size = new System.Drawing.Size(242, 269);
            this.Gb_musteriekle.TabIndex = 3;
            this.Gb_musteriekle.TabStop = false;
            this.Gb_musteriekle.Text = "Yeni Müşteri Ekle";
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
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Gb_musterisil
            // 
            this.Gb_musterisil.BackColor = System.Drawing.Color.Red;
            this.Gb_musterisil.Controls.Add(this.label1);
            this.Gb_musterisil.Controls.Add(this.Cb_sil);
            this.Gb_musterisil.Controls.Add(this.btn_sil);
            this.Gb_musterisil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gb_musterisil.Location = new System.Drawing.Point(2, 287);
            this.Gb_musterisil.Name = "Gb_musterisil";
            this.Gb_musterisil.Size = new System.Drawing.Size(242, 59);
            this.Gb_musterisil.TabIndex = 12;
            this.Gb_musterisil.TabStop = false;
            this.Gb_musterisil.Text = "Müşteri Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad :";
            // 
            // Cb_sil
            // 
            this.Cb_sil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Cb_sil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_sil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musterilertblBindingSource2, "adi", true));
            this.Cb_sil.FormattingEnabled = true;
            this.Cb_sil.Location = new System.Drawing.Point(61, 19);
            this.Cb_sil.Name = "Cb_sil";
            this.Cb_sil.Size = new System.Drawing.Size(121, 21);
            this.Cb_sil.TabIndex = 12;
            // 
            // musterilertblBindingSource2
            // 
            this.musterilertblBindingSource2.DataMember = "musterilertbl";
            this.musterilertblBindingSource2.DataSource = this.hTODataSet;
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.silicon;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(193, 13);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(42, 35);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // musterilertblBindingSource3
            // 
            this.musterilertblBindingSource3.DataMember = "musterilertbl";
            this.musterilertblBindingSource3.DataSource = this.hTODataSet1;
            // 
            // hTODataSet1
            // 
            this.hTODataSet1.DataSetName = "HTODataSet1";
            this.hTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilertblBindingSource1
            // 
            this.musterilertblBindingSource1.DataMember = "musterilertbl";
            this.musterilertblBindingSource1.DataSource = this.hTODataSet;
            // 
            // musterilertblTableAdapter1
            // 
            this.musterilertblTableAdapter1.ClearBeforeFill = true;
            // 
            // Gb_Guncelle
            // 
            this.Gb_Guncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.Gb_Guncelle.Controls.Add(this.tb_id);
            this.Gb_Guncelle.Controls.Add(this.cb_adres);
            this.Gb_Guncelle.Controls.Add(this.cb_tel);
            this.Gb_Guncelle.Controls.Add(this.cb_soyadi);
            this.Gb_Guncelle.Controls.Add(this.cb_adi);
            this.Gb_Guncelle.Controls.Add(this.cb_isletmeno);
            this.Gb_Guncelle.Controls.Add(this.rtb_guncelleadres);
            this.Gb_Guncelle.Controls.Add(this.Btn_guncelle);
            this.Gb_Guncelle.Controls.Add(this.label2);
            this.Gb_Guncelle.Controls.Add(this.label3);
            this.Gb_Guncelle.Controls.Add(this.msk_guncelle_tel);
            this.Gb_Guncelle.Controls.Add(this.label4);
            this.Gb_Guncelle.Controls.Add(this.tb_guncelle_soyad);
            this.Gb_Guncelle.Controls.Add(this.label5);
            this.Gb_Guncelle.Controls.Add(this.tb_guncelle_adi);
            this.Gb_Guncelle.Controls.Add(this.label6);
            this.Gb_Guncelle.Controls.Add(this.msk_guncelle_isletmeno);
            this.Gb_Guncelle.Location = new System.Drawing.Point(2, 352);
            this.Gb_Guncelle.Name = "Gb_Guncelle";
            this.Gb_Guncelle.Size = new System.Drawing.Size(242, 275);
            this.Gb_Guncelle.TabIndex = 11;
            this.Gb_Guncelle.TabStop = false;
            this.Gb_Guncelle.Text = "Müşteri Bilgileri Güncelle";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(19, 192);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(31, 20);
            this.tb_id.TabIndex = 17;
            this.tb_id.Visible = false;
            // 
            // cb_adres
            // 
            this.cb_adres.AutoSize = true;
            this.cb_adres.Location = new System.Drawing.Point(220, 135);
            this.cb_adres.Name = "cb_adres";
            this.cb_adres.Size = new System.Drawing.Size(15, 14);
            this.cb_adres.TabIndex = 16;
            this.cb_adres.UseVisualStyleBackColor = true;
            this.cb_adres.CheckStateChanged += new System.EventHandler(this.cb_adres_CheckStateChanged);
            // 
            // cb_tel
            // 
            this.cb_tel.AutoSize = true;
            this.cb_tel.Location = new System.Drawing.Point(220, 109);
            this.cb_tel.Name = "cb_tel";
            this.cb_tel.Size = new System.Drawing.Size(15, 14);
            this.cb_tel.TabIndex = 15;
            this.cb_tel.UseVisualStyleBackColor = true;
            this.cb_tel.CheckStateChanged += new System.EventHandler(this.cb_tel_CheckStateChanged);
            // 
            // cb_soyadi
            // 
            this.cb_soyadi.AutoSize = true;
            this.cb_soyadi.Location = new System.Drawing.Point(220, 82);
            this.cb_soyadi.Name = "cb_soyadi";
            this.cb_soyadi.Size = new System.Drawing.Size(15, 14);
            this.cb_soyadi.TabIndex = 14;
            this.cb_soyadi.UseVisualStyleBackColor = true;
            this.cb_soyadi.CheckStateChanged += new System.EventHandler(this.cb_soyadi_CheckStateChanged);
            // 
            // cb_adi
            // 
            this.cb_adi.AutoSize = true;
            this.cb_adi.Location = new System.Drawing.Point(220, 56);
            this.cb_adi.Name = "cb_adi";
            this.cb_adi.Size = new System.Drawing.Size(15, 14);
            this.cb_adi.TabIndex = 13;
            this.cb_adi.UseVisualStyleBackColor = true;
            this.cb_adi.Visible = false;
            this.cb_adi.CheckStateChanged += new System.EventHandler(this.cb_adi_CheckStateChanged);
            // 
            // cb_isletmeno
            // 
            this.cb_isletmeno.AutoSize = true;
            this.cb_isletmeno.Location = new System.Drawing.Point(220, 29);
            this.cb_isletmeno.Name = "cb_isletmeno";
            this.cb_isletmeno.Size = new System.Drawing.Size(15, 14);
            this.cb_isletmeno.TabIndex = 12;
            this.cb_isletmeno.UseVisualStyleBackColor = true;
            this.cb_isletmeno.CheckStateChanged += new System.EventHandler(this.cb_isletmeno_CheckStateChanged);
            // 
            // rtb_guncelleadres
            // 
            this.rtb_guncelleadres.Location = new System.Drawing.Point(79, 132);
            this.rtb_guncelleadres.Name = "rtb_guncelleadres";
            this.rtb_guncelleadres.ReadOnly = true;
            this.rtb_guncelleadres.Size = new System.Drawing.Size(126, 80);
            this.rtb_guncelleadres.TabIndex = 11;
            this.rtb_guncelleadres.Text = "";
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_guncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_guncelle.ForeColor = System.Drawing.Color.DarkBlue;
            this.Btn_guncelle.Location = new System.Drawing.Point(19, 218);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(208, 49);
            this.Btn_guncelle.TabIndex = 10;
            this.Btn_guncelle.Text = "Bilgileri Güncelle";
            this.Btn_guncelle.UseVisualStyleBackColor = false;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "İşletme No :";
            // 
            // msk_guncelle_tel
            // 
            this.msk_guncelle_tel.Location = new System.Drawing.Point(121, 106);
            this.msk_guncelle_tel.Mask = "(999) 000-0000";
            this.msk_guncelle_tel.Name = "msk_guncelle_tel";
            this.msk_guncelle_tel.ReadOnly = true;
            this.msk_guncelle_tel.Size = new System.Drawing.Size(84, 20);
            this.msk_guncelle_tel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad :";
            // 
            // tb_guncelle_soyad
            // 
            this.tb_guncelle_soyad.Location = new System.Drawing.Point(121, 79);
            this.tb_guncelle_soyad.MaxLength = 20;
            this.tb_guncelle_soyad.Name = "tb_guncelle_soyad";
            this.tb_guncelle_soyad.ReadOnly = true;
            this.tb_guncelle_soyad.Size = new System.Drawing.Size(84, 20);
            this.tb_guncelle_soyad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefon :";
            // 
            // tb_guncelle_adi
            // 
            this.tb_guncelle_adi.Location = new System.Drawing.Point(121, 53);
            this.tb_guncelle_adi.MaxLength = 20;
            this.tb_guncelle_adi.Name = "tb_guncelle_adi";
            this.tb_guncelle_adi.ReadOnly = true;
            this.tb_guncelle_adi.Size = new System.Drawing.Size(84, 20);
            this.tb_guncelle_adi.TabIndex = 6;
            this.tb_guncelle_adi.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adres :";
            // 
            // msk_guncelle_isletmeno
            // 
            this.msk_guncelle_isletmeno.Location = new System.Drawing.Point(121, 26);
            this.msk_guncelle_isletmeno.Mask = "000000000000000";
            this.msk_guncelle_isletmeno.Name = "msk_guncelle_isletmeno";
            this.msk_guncelle_isletmeno.ReadOnly = true;
            this.msk_guncelle_isletmeno.Size = new System.Drawing.Size(93, 20);
            this.msk_guncelle_isletmeno.TabIndex = 5;
            // 
            // cb_arama
            // 
            this.cb_arama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_arama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_arama.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.musterilertblBindingSource2, "adi", true));
            this.cb_arama.FormattingEnabled = true;
            this.cb_arama.Location = new System.Drawing.Point(382, 6);
            this.cb_arama.Name = "cb_arama";
            this.cb_arama.Size = new System.Drawing.Size(121, 21);
            this.cb_arama.TabIndex = 13;
            this.cb_arama.TextChanged += new System.EventHandler(this.cb_arama_TextChanged);
            // 
            // MusterilerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.cb_arama);
            this.Controls.Add(this.Gb_Guncelle);
            this.Controls.Add(this.Gb_musterisil);
            this.Controls.Add(this.Gb_musteriekle);
            this.Controls.Add(this.dgv_musteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusterilerFormu";
            this.ShowIcon = false;
            this.Text = "MusterilerFrm";
            this.Load += new System.EventHandler(this.MusterilerFormu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).EndInit();
            this.Gb_musteriekle.ResumeLayout(false);
            this.Gb_musteriekle.PerformLayout();
            this.Gb_musterisil.ResumeLayout(false);
            this.Gb_musterisil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource1)).EndInit();
            this.Gb_Guncelle.ResumeLayout(false);
            this.Gb_Guncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_musteriadi;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_isletmeno;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.RichTextBox rtb_adres;
        private System.Windows.Forms.MaskedTextBox mskdtb_telefon;
        private System.Windows.Forms.TextBox tb_soyadi;
        private System.Windows.Forms.TextBox tb_adi;
        private System.Windows.Forms.MaskedTextBox mskdtb_isletmeno;
        private System.Windows.Forms.DataGridView dgv_musteriler;
        private HTODataSetgiris hTODataSetgiris;
        private HTODataSet hTODataSet;
        private System.Windows.Forms.BindingSource musterilertblBindingSource;
        private HTODataSetTableAdapters.musterilertblTableAdapter musterilertblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isletmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Gb_musteriekle;
        private System.Windows.Forms.GroupBox Gb_musterisil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_sil;
        private System.Windows.Forms.BindingSource musterilertblBindingSource1;
        private System.Windows.Forms.BindingSource musterilertblBindingSource2;
        private HTODataSet1 hTODataSet1;
        private System.Windows.Forms.BindingSource musterilertblBindingSource3;
        private HTODataSet1TableAdapters.musterilertblTableAdapter musterilertblTableAdapter1;
        private System.Windows.Forms.GroupBox Gb_Guncelle;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_guncelle_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_guncelle_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_guncelle_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_guncelle_isletmeno;
        private System.Windows.Forms.RichTextBox rtb_guncelleadres;
        private System.Windows.Forms.CheckBox cb_soyadi;
        private System.Windows.Forms.CheckBox cb_adi;
        private System.Windows.Forms.CheckBox cb_isletmeno;
        private System.Windows.Forms.CheckBox cb_adres;
        private System.Windows.Forms.CheckBox cb_tel;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ComboBox cb_arama;
    }
}