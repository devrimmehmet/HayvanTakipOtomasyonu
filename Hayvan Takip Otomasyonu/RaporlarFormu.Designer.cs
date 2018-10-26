namespace Hayvan_Takip_Otomasyonu
{
    partial class RaporlarFormu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.musterilertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raporlamads = new Hayvan_Takip_Otomasyonu.raporlamads();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_raporlar = new System.Windows.Forms.GroupBox();
            this.btn_musterilerR = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.musterilertblTableAdapter = new Hayvan_Takip_Otomasyonu.raporlamadsTableAdapters.musterilertblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporlamads)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_raporlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // musterilertblBindingSource
            // 
            this.musterilertblBindingSource.DataMember = "musterilertbl";
            this.musterilertblBindingSource.DataSource = this.raporlamads;
            // 
            // raporlamads
            // 
            this.raporlamads.DataSetName = "raporlamads";
            this.raporlamads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.gb_raporlar);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(1350, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 84);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gb_raporlar
            // 
            this.gb_raporlar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gb_raporlar.Controls.Add(this.btn_musterilerR);
            this.gb_raporlar.Location = new System.Drawing.Point(3, 0);
            this.gb_raporlar.Name = "gb_raporlar";
            this.gb_raporlar.Size = new System.Drawing.Size(151, 79);
            this.gb_raporlar.TabIndex = 21;
            this.gb_raporlar.TabStop = false;
            this.gb_raporlar.Text = "Müşteri Listesini Raporla";
            // 
            // btn_musterilerR
            // 
            this.btn_musterilerR.BackgroundImage = global::Hayvan_Takip_Otomasyonu.Properties.Resources.musterilericon;
            this.btn_musterilerR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_musterilerR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_musterilerR.Location = new System.Drawing.Point(8, 19);
            this.btn_musterilerR.Name = "btn_musterilerR";
            this.btn_musterilerR.Size = new System.Drawing.Size(137, 54);
            this.btn_musterilerR.TabIndex = 2;
            this.btn_musterilerR.UseVisualStyleBackColor = true;
            this.btn_musterilerR.Click += new System.EventHandler(this.btn_musterilerR_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "raporlama";
            reportDataSource2.Value = this.musterilertblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hayvan_Takip_Otomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1343, 535);
            this.reportViewer1.TabIndex = 23;
            this.reportViewer1.Visible = false;
            // 
            // musterilertblTableAdapter
            // 
            this.musterilertblTableAdapter.ClearBeforeFill = true;
            // 
            // RaporlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 631);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1350, 631);
            this.MinimumSize = new System.Drawing.Size(1350, 631);
            this.Name = "RaporlarFormu";
            this.Text = "RaporlarFormu";
            this.Load += new System.EventHandler(this.RaporlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporlamads)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gb_raporlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_raporlar;
        public System.Windows.Forms.Button btn_musterilerR;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource musterilertblBindingSource;
        private raporlamads raporlamads;
        private raporlamadsTableAdapters.musterilertblTableAdapter musterilertblTableAdapter;
    }
}