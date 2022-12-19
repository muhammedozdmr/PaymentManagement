namespace GuvenliAlimSatim.UI.Alici
{
    partial class TransferBilgileriForm
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
            this.cmbBanka = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransferReferans = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblMasraf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBanka
            // 
            this.cmbBanka.FormattingEnabled = true;
            this.cmbBanka.Items.AddRange(new object[] {
            "Halkbank",
            "AkBank",
            "İş Bankası",
            "Vakıfbank",
            "QNB Finansbank",
            "Garanti BBVA",
            "Yapı Kredi"});
            this.cmbBanka.Location = new System.Drawing.Point(197, 35);
            this.cmbBanka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBanka.Name = "cmbBanka";
            this.cmbBanka.Size = new System.Drawing.Size(257, 33);
            this.cmbBanka.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 31);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer Açıklaması:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transfer Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masraf Tutarı:";
            // 
            // lblTransferReferans
            // 
            this.lblTransferReferans.AutoSize = true;
            this.lblTransferReferans.Location = new System.Drawing.Point(231, 187);
            this.lblTransferReferans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransferReferans.Name = "lblTransferReferans";
            this.lblTransferReferans.Size = new System.Drawing.Size(59, 25);
            this.lblTransferReferans.TabIndex = 2;
            this.lblTransferReferans.Text = "label1";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(231, 238);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(59, 25);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "label1";
            // 
            // lblMasraf
            // 
            this.lblMasraf.AutoSize = true;
            this.lblMasraf.Location = new System.Drawing.Point(231, 290);
            this.lblMasraf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasraf.Name = "lblMasraf";
            this.lblMasraf.Size = new System.Drawing.Size(59, 25);
            this.lblMasraf.TabIndex = 2;
            this.lblMasraf.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Banka Hesabı Seçiniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Transfer Yapılacak Kişi:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(350, 328);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 40);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "TL";
            // 
            // TransferBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMasraf);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTransferReferans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbBanka);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransferBilgileriForm";
            this.Text = "Transfer Bilgileri ";
            this.Load += new System.EventHandler(this.TransferBilgileriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbBanka;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTransferReferans;
        private Label lblFiyat;
        private Label lblMasraf;
        private Label label7;
        private Label label8;
        private Button btnOk;
        private Label label4;
    }
}