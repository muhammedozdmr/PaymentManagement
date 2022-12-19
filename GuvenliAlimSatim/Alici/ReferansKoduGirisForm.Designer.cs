namespace GuvenliAlimSatim.UI.Alici
{
    partial class ReferansKoduGirisForm
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
            this.txtReference = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(27, 46);
            this.txtReference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReference.Mask = "000000";
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(148, 23);
            this.txtReference.TabIndex = 0;
            this.txtReference.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Referans Kodunu Giriniz:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(27, 79);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Alıcı referans kodu satıcı tarafından oluşturulmaktadır.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Lütfen satıcı kişi ile iletişime geçiniz.";
            // 
            // ReferansKoduGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReference);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReferansKoduGirisForm";
            this.Text = "Referans Kodu Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtReference;
        private Label label1;
        private Button btnOk;
        private Label label2;
        private Label label3;
    }
}