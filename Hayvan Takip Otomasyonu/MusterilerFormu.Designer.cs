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
            this.lbl_musteriadi = new System.Windows.Forms.Label();
            this.pnl_musteriekle = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
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
            this.pnl_musteriekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_musteriadi
            // 
            this.lbl_musteriadi.AutoSize = true;
            this.lbl_musteriadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriadi.Location = new System.Drawing.Point(70, 57);
            this.lbl_musteriadi.Name = "lbl_musteriadi";
            this.lbl_musteriadi.Size = new System.Drawing.Size(42, 19);
            this.lbl_musteriadi.TabIndex = 0;
            this.lbl_musteriadi.Text = "Ad :";
            // 
            // pnl_musteriekle
            // 
            this.pnl_musteriekle.BackColor = System.Drawing.Color.DarkGray;
            this.pnl_musteriekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_musteriekle.Controls.Add(this.tb_id);
            this.pnl_musteriekle.Controls.Add(this.label1);
            this.pnl_musteriekle.Controls.Add(this.btn_sil);
            this.pnl_musteriekle.Controls.Add(this.btn_kaydet);
            this.pnl_musteriekle.Controls.Add(this.rtb_adres);
            this.pnl_musteriekle.Controls.Add(this.mskdtb_telefon);
            this.pnl_musteriekle.Controls.Add(this.tb_soyadi);
            this.pnl_musteriekle.Controls.Add(this.tb_adi);
            this.pnl_musteriekle.Controls.Add(this.mskdtb_isletmeno);
            this.pnl_musteriekle.Controls.Add(this.lbl_adres);
            this.pnl_musteriekle.Controls.Add(this.lbl_tel);
            this.pnl_musteriekle.Controls.Add(this.lbl_soyadi);
            this.pnl_musteriekle.Controls.Add(this.lbl_isletmeno);
            this.pnl_musteriekle.Controls.Add(this.lbl_musteriadi);
            this.pnl_musteriekle.Location = new System.Drawing.Point(5, 12);
            this.pnl_musteriekle.Name = "pnl_musteriekle";
            this.pnl_musteriekle.Size = new System.Drawing.Size(239, 281);
            this.pnl_musteriekle.TabIndex = 1;
            this.pnl_musteriekle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_musteriekle_Paint);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(115, 7);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.silicon;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(7, 227);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(60, 49);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.btn_kaydet.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.kaydet;
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kaydet.Location = new System.Drawing.Point(168, 227);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(59, 49);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // rtb_adres
            // 
            this.rtb_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_adres.Location = new System.Drawing.Point(92, 137);
            this.rtb_adres.Name = "rtb_adres";
            this.rtb_adres.Size = new System.Drawing.Size(123, 84);
            this.rtb_adres.TabIndex = 9;
            this.rtb_adres.Text = "";
            // 
            // mskdtb_telefon
            // 
            this.mskdtb_telefon.Location = new System.Drawing.Point(115, 111);
            this.mskdtb_telefon.Mask = "(999) 000-0000";
            this.mskdtb_telefon.Name = "mskdtb_telefon";
            this.mskdtb_telefon.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_telefon.TabIndex = 8;
            // 
            // tb_soyadi
            // 
            this.tb_soyadi.Location = new System.Drawing.Point(115, 85);
            this.tb_soyadi.Name = "tb_soyadi";
            this.tb_soyadi.Size = new System.Drawing.Size(100, 20);
            this.tb_soyadi.TabIndex = 7;
            // 
            // tb_adi
            // 
            this.tb_adi.Location = new System.Drawing.Point(115, 59);
            this.tb_adi.Name = "tb_adi";
            this.tb_adi.Size = new System.Drawing.Size(100, 20);
            this.tb_adi.TabIndex = 6;
            // 
            // mskdtb_isletmeno
            // 
            this.mskdtb_isletmeno.Location = new System.Drawing.Point(115, 33);
            this.mskdtb_isletmeno.Mask = "000000000000000";
            this.mskdtb_isletmeno.Name = "mskdtb_isletmeno";
            this.mskdtb_isletmeno.Size = new System.Drawing.Size(100, 20);
            this.mskdtb_isletmeno.TabIndex = 5;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(19, 137);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(67, 19);
            this.lbl_adres.TabIndex = 4;
            this.lbl_adres.Text = "Adres :";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tel.Location = new System.Drawing.Point(30, 109);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(82, 19);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Telefon :";
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.Location = new System.Drawing.Point(45, 83);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(69, 19);
            this.lbl_soyadi.TabIndex = 2;
            this.lbl_soyadi.Text = "Soyad :";
            // 
            // lbl_isletmeno
            // 
            this.lbl_isletmeno.AutoSize = true;
            this.lbl_isletmeno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isletmeno.Location = new System.Drawing.Point(3, 34);
            this.lbl_isletmeno.Name = "lbl_isletmeno";
            this.lbl_isletmeno.Size = new System.Drawing.Size(109, 19);
            this.lbl_isletmeno.TabIndex = 1;
            this.lbl_isletmeno.Text = "İşletme No :";
            // 
            // dgv_musteriler
            // 
            this.dgv_musteriler.AutoGenerateColumns = false;
            this.dgv_musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.isletmenoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresiDataGridViewTextBoxColumn});
            this.dgv_musteriler.DataSource = this.musterilertblBindingSource;
            this.dgv_musteriler.Location = new System.Drawing.Point(250, 12);
            this.dgv_musteriler.Name = "dgv_musteriler";
            this.dgv_musteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_musteriler.Size = new System.Drawing.Size(1083, 281);
            this.dgv_musteriler.TabIndex = 2;
            this.dgv_musteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_musteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_musteriler_CellContentClick);
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
            // MusterilerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.dgv_musteriler);
            this.Controls.Add(this.pnl_musteriekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusterilerFormu";
            this.ShowIcon = false;
            this.Text = "MusterilerFrm";
            this.Load += new System.EventHandler(this.MusterilerFormu_Load);
            this.pnl_musteriekle.ResumeLayout(false);
            this.pnl_musteriekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTODataSetgiris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_musteriadi;
        private System.Windows.Forms.Panel pnl_musteriekle;
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
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
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
    }
}