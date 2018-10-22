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
            this.msk_sahibi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // msk_sahibi
            // 
            this.msk_sahibi.Location = new System.Drawing.Point(12, 12);
            this.msk_sahibi.Name = "msk_sahibi";
            this.msk_sahibi.Size = new System.Drawing.Size(100, 20);
            this.msk_sahibi.TabIndex = 3;
            this.msk_sahibi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_sahibi_MaskInputRejected);
            // 
            // HayvanlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.msk_sahibi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HayvanlarFormu";
            this.Text = "HayvanlarFormu";
            this.Load += new System.EventHandler(this.HayvanlarFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_sahibi;
    }
}