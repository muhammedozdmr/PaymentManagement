namespace GuvenliAlimSatim.UI.Main
{
    partial class BasvuruDetayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReferansNo = new System.Windows.Forms.Label();
            this.lblBasvuruDurum = new System.Windows.Forms.Label();
            this.lblOdemeDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referans No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başvuru Durumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ödeme Durum Bilgisi:";
            // 
            // lblReferansNo
            // 
            this.lblReferansNo.AutoSize = true;
            this.lblReferansNo.Location = new System.Drawing.Point(259, 32);
            this.lblReferansNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferansNo.Name = "lblReferansNo";
            this.lblReferansNo.Size = new System.Drawing.Size(59, 25);
            this.lblReferansNo.TabIndex = 1;
            this.lblReferansNo.Text = "label4";
            // 
            // lblBasvuruDurum
            // 
            this.lblBasvuruDurum.AutoSize = true;
            this.lblBasvuruDurum.Location = new System.Drawing.Point(259, 72);
            this.lblBasvuruDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasvuruDurum.Name = "lblBasvuruDurum";
            this.lblBasvuruDurum.Size = new System.Drawing.Size(59, 25);
            this.lblBasvuruDurum.TabIndex = 1;
            this.lblBasvuruDurum.Text = "label4";
            // 
            // lblOdemeDurum
            // 
            this.lblOdemeDurum.AutoSize = true;
            this.lblOdemeDurum.Location = new System.Drawing.Point(259, 112);
            this.lblOdemeDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdemeDurum.Name = "lblOdemeDurum";
            this.lblOdemeDurum.Size = new System.Drawing.Size(59, 25);
            this.lblOdemeDurum.TabIndex = 1;
            this.lblOdemeDurum.Text = "label4";
            // 
            // BasvuruDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 169);
            this.Controls.Add(this.lblOdemeDurum);
            this.Controls.Add(this.lblBasvuruDurum);
            this.Controls.Add(this.lblReferansNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasvuruDetayForm";
            this.Text = "BasvuruDetayForm";
            this.Load += new System.EventHandler(this.BasvuruDetayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblReferansNo;
        private Label lblBasvuruDurum;
        private Label lblOdemeDurum;
    }
}