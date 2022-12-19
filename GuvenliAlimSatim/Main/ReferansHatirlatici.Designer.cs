namespace GuvenliAlimSatim.UI.Main
{
    partial class ReferansHatirlatici
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
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendReference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(182, 93);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(177, 31);
            this.txtTelefon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefon Numarası:";
            // 
            // btnSendReference
            // 
            this.btnSendReference.Location = new System.Drawing.Point(268, 142);
            this.btnSendReference.Name = "btnSendReference";
            this.btnSendReference.Size = new System.Drawing.Size(91, 34);
            this.btnSendReference.TabIndex = 2;
            this.btnSendReference.Text = "Gönder";
            this.btnSendReference.UseVisualStyleBackColor = true;
            this.btnSendReference.Click += new System.EventHandler(this.btnSendReference_Click);
            // 
            // ReferansHatirlatici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 257);
            this.Controls.Add(this.btnSendReference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Name = "ReferansHatirlatici";
            this.Text = "ReferansHatirlatici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtTelefon;
        private Label label1;
        private Button btnSendReference;
    }
}