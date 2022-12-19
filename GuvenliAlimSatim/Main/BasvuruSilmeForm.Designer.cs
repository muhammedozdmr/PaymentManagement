namespace GuvenliAlimSatim.UI.Main
{
    partial class BasvuruSilmeForm
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
            this.cmbGercekTuzel = new System.Windows.Forms.ComboBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReferans = new System.Windows.Forms.MaskedTextBox();
            this.txtIptalNedeni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGercekTuzel
            // 
            this.cmbGercekTuzel.FormattingEnabled = true;
            this.cmbGercekTuzel.Location = new System.Drawing.Point(303, 37);
            this.cmbGercekTuzel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGercekTuzel.Name = "cmbGercekTuzel";
            this.cmbGercekTuzel.Size = new System.Drawing.Size(188, 33);
            this.cmbGercekTuzel.TabIndex = 0;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(303, 98);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(188, 31);
            this.txtTcKimlik.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(303, 157);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(188, 31);
            this.txtTelefon.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(365, 402);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ünvan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cep Telefonu Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "İptal Nedeni:";
            // 
            // txtReferans
            // 
            this.txtReferans.Location = new System.Drawing.Point(303, 346);
            this.txtReferans.Mask = "000000";
            this.txtReferans.Name = "txtReferans";
            this.txtReferans.Size = new System.Drawing.Size(188, 31);
            this.txtReferans.TabIndex = 9;
            // 
            // txtIptalNedeni
            // 
            this.txtIptalNedeni.Location = new System.Drawing.Point(303, 216);
            this.txtIptalNedeni.Multiline = true;
            this.txtIptalNedeni.Name = "txtIptalNedeni";
            this.txtIptalNedeni.Size = new System.Drawing.Size(188, 102);
            this.txtIptalNedeni.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Referans Numarası:";
            // 
            // btnRemember
            // 
            this.btnRemember.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemember.Location = new System.Drawing.Point(241, 447);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(253, 44);
            this.btnRemember.TabIndex = 12;
            this.btnRemember.Text = "Referans Numaramı Unuttum";
            this.btnRemember.UseVisualStyleBackColor = false;
            this.btnRemember.Click += new System.EventHandler(this.btnRemember_Click);
            // 
            // BasvuruSilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 539);
            this.Controls.Add(this.btnRemember);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIptalNedeni);
            this.Controls.Add(this.txtReferans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.cmbGercekTuzel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasvuruSilmeForm";
            this.Text = "BasvuruSilmeForm";
            this.Load += new System.EventHandler(this.BasvuruSilmeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbGercekTuzel;
        private MaskedTextBox txtTcKimlik;
        private MaskedTextBox txtTelefon;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtReferans;
        private TextBox txtIptalNedeni;
        private Label label5;
        private Button btnRemember;
    }
}