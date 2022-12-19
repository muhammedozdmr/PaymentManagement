namespace GuvenliAlimSatim.UI
{
    partial class KullaniciPanelForm
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
            this.btnApplicationCancel = new System.Windows.Forms.Button();
            this.btnApplicationStatus = new System.Windows.Forms.Button();
            this.btnBuyerForm = new System.Windows.Forms.Button();
            this.btnSellerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplicationCancel
            // 
            this.btnApplicationCancel.Location = new System.Drawing.Point(194, 310);
            this.btnApplicationCancel.Name = "btnApplicationCancel";
            this.btnApplicationCancel.Size = new System.Drawing.Size(411, 72);
            this.btnApplicationCancel.TabIndex = 1;
            this.btnApplicationCancel.Text = "Başvuru İptal";
            this.btnApplicationCancel.UseVisualStyleBackColor = true;
            this.btnApplicationCancel.Click += new System.EventHandler(this.btnApplicationCancel_Click);
            // 
            // btnApplicationStatus
            // 
            this.btnApplicationStatus.Location = new System.Drawing.Point(194, 230);
            this.btnApplicationStatus.Name = "btnApplicationStatus";
            this.btnApplicationStatus.Size = new System.Drawing.Size(411, 72);
            this.btnApplicationStatus.TabIndex = 2;
            this.btnApplicationStatus.Text = "Başvuru Durum Sorgulama";
            this.btnApplicationStatus.UseVisualStyleBackColor = true;
            this.btnApplicationStatus.Click += new System.EventHandler(this.btnApplicationStatus_Click);
            // 
            // btnBuyerForm
            // 
            this.btnBuyerForm.Location = new System.Drawing.Point(194, 150);
            this.btnBuyerForm.Name = "btnBuyerForm";
            this.btnBuyerForm.Size = new System.Drawing.Size(411, 72);
            this.btnBuyerForm.TabIndex = 3;
            this.btnBuyerForm.Text = "Alıcı Başvurusu Oluştur";
            this.btnBuyerForm.UseVisualStyleBackColor = true;
            this.btnBuyerForm.Click += new System.EventHandler(this.btnBuyerForm_Click);
            // 
            // btnSellerForm
            // 
            this.btnSellerForm.Location = new System.Drawing.Point(194, 70);
            this.btnSellerForm.Name = "btnSellerForm";
            this.btnSellerForm.Size = new System.Drawing.Size(411, 72);
            this.btnSellerForm.TabIndex = 4;
            this.btnSellerForm.Text = "Satıcı Başvurusu Oluştur";
            this.btnSellerForm.UseVisualStyleBackColor = true;
            this.btnSellerForm.Click += new System.EventHandler(this.btnSellerForm_Click);
            // 
            // KullaniciPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApplicationCancel);
            this.Controls.Add(this.btnApplicationStatus);
            this.Controls.Add(this.btnBuyerForm);
            this.Controls.Add(this.btnSellerForm);
            this.Name = "KullaniciPanelForm";
            this.Text = "Güvenli Alım Satım";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnApplicationCancel;
        private Button btnApplicationStatus;
        private Button btnBuyerForm;
        private Button btnSellerForm;
    }
}