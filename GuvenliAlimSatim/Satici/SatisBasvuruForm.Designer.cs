namespace GuvenliAlimSatim.UI
{
    partial class SatisBasvuruForm
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
            this.txtAracPlaka = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSellerSave = new System.Windows.Forms.Button();
            this.chkReklamMetni = new System.Windows.Forms.CheckBox();
            this.chkRizaMetni = new System.Windows.Forms.CheckBox();
            this.numSatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtSaticiIban = new System.Windows.Forms.MaskedTextBox();
            this.txtSaticiCep = new System.Windows.Forms.MaskedTextBox();
            this.txtAliciCep = new System.Windows.Forms.MaskedTextBox();
            this.txtAliciEposta = new System.Windows.Forms.TextBox();
            this.txtSaticiAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtSaticiEposta = new System.Windows.Forms.TextBox();
            this.cmbGercekTuzel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSatisFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(161, 125);
            this.txtAracPlaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtAracPlaka.Mask = "00-AAA-0000";
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(152, 23);
            this.txtAracPlaka.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Satış Tutarı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Satıcı IBAN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Alıcı Ceptelefonu Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Satıcı Cep Telefonu Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "T.C. Kimlik Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Araç Plakası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Alıcı E-Posta Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Satıcı E-Posta Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Satıcı Adı ve Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ünvan:";
            // 
            // btnSellerSave
            // 
            this.btnSellerSave.Location = new System.Drawing.Point(510, 163);
            this.btnSellerSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSellerSave.Name = "btnSellerSave";
            this.btnSellerSave.Size = new System.Drawing.Size(162, 31);
            this.btnSellerSave.TabIndex = 20;
            this.btnSellerSave.Text = "Talep Oluştur";
            this.btnSellerSave.UseVisualStyleBackColor = true;
            this.btnSellerSave.Click += new System.EventHandler(this.btnSellerSave_Click);
            // 
            // chkReklamMetni
            // 
            this.chkReklamMetni.AutoSize = true;
            this.chkReklamMetni.Location = new System.Drawing.Point(25, 197);
            this.chkReklamMetni.Margin = new System.Windows.Forms.Padding(2);
            this.chkReklamMetni.Name = "chkReklamMetni";
            this.chkReklamMetni.Size = new System.Drawing.Size(120, 19);
            this.chkReklamMetni.TabIndex = 19;
            this.chkReklamMetni.Text = "Reklam Metni İzni";
            this.chkReklamMetni.UseVisualStyleBackColor = true;
            // 
            // chkRizaMetni
            // 
            this.chkRizaMetni.AutoSize = true;
            this.chkRizaMetni.Location = new System.Drawing.Point(25, 176);
            this.chkRizaMetni.Margin = new System.Windows.Forms.Padding(2);
            this.chkRizaMetni.Name = "chkRizaMetni";
            this.chkRizaMetni.Size = new System.Drawing.Size(138, 19);
            this.chkRizaMetni.TabIndex = 18;
            this.chkRizaMetni.Text = "Açık Rıza Metnini İzni";
            this.chkRizaMetni.UseVisualStyleBackColor = true;
            // 
            // numSatisFiyati
            // 
            this.numSatisFiyati.Location = new System.Drawing.Point(510, 125);
            this.numSatisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.numSatisFiyati.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numSatisFiyati.Name = "numSatisFiyati";
            this.numSatisFiyati.Size = new System.Drawing.Size(179, 23);
            this.numSatisFiyati.TabIndex = 17;
            // 
            // txtSaticiIban
            // 
            this.txtSaticiIban.Location = new System.Drawing.Point(510, 97);
            this.txtSaticiIban.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiIban.Mask = "TR00-0000-0000-0000-0000-0000-00";
            this.txtSaticiIban.Name = "txtSaticiIban";
            this.txtSaticiIban.Size = new System.Drawing.Size(179, 23);
            this.txtSaticiIban.TabIndex = 16;
            // 
            // txtSaticiCep
            // 
            this.txtSaticiCep.Location = new System.Drawing.Point(510, 42);
            this.txtSaticiCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiCep.Mask = "(999) 000-0000";
            this.txtSaticiCep.Name = "txtSaticiCep";
            this.txtSaticiCep.Size = new System.Drawing.Size(179, 23);
            this.txtSaticiCep.TabIndex = 15;
            // 
            // txtAliciCep
            // 
            this.txtAliciCep.Location = new System.Drawing.Point(510, 70);
            this.txtAliciCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtAliciCep.Mask = "(999) 000-0000";
            this.txtAliciCep.Name = "txtAliciCep";
            this.txtAliciCep.Size = new System.Drawing.Size(179, 23);
            this.txtAliciCep.TabIndex = 14;
            // 
            // txtAliciEposta
            // 
            this.txtAliciEposta.Location = new System.Drawing.Point(161, 98);
            this.txtAliciEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtAliciEposta.Name = "txtAliciEposta";
            this.txtAliciEposta.Size = new System.Drawing.Size(152, 23);
            this.txtAliciEposta.TabIndex = 11;
            // 
            // txtSaticiAdSoyad
            // 
            this.txtSaticiAdSoyad.Location = new System.Drawing.Point(161, 43);
            this.txtSaticiAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiAdSoyad.Name = "txtSaticiAdSoyad";
            this.txtSaticiAdSoyad.Size = new System.Drawing.Size(152, 23);
            this.txtSaticiAdSoyad.TabIndex = 10;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(510, 14);
            this.txtTCKimlik.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCKimlik.Mask = "00000000000";
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(179, 23);
            this.txtTCKimlik.TabIndex = 13;
            this.txtTCKimlik.ValidatingType = typeof(int);
            // 
            // txtSaticiEposta
            // 
            this.txtSaticiEposta.Location = new System.Drawing.Point(161, 71);
            this.txtSaticiEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaticiEposta.Name = "txtSaticiEposta";
            this.txtSaticiEposta.Size = new System.Drawing.Size(152, 23);
            this.txtSaticiEposta.TabIndex = 12;
            // 
            // cmbGercekTuzel
            // 
            this.cmbGercekTuzel.FormattingEnabled = true;
            this.cmbGercekTuzel.Location = new System.Drawing.Point(161, 14);
            this.cmbGercekTuzel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGercekTuzel.Name = "cmbGercekTuzel";
            this.cmbGercekTuzel.Size = new System.Drawing.Size(152, 23);
            this.cmbGercekTuzel.TabIndex = 9;
            // 
            // SatisBasvuruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 234);
            this.Controls.Add(this.txtAracPlaka);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSellerSave);
            this.Controls.Add(this.chkReklamMetni);
            this.Controls.Add(this.chkRizaMetni);
            this.Controls.Add(this.numSatisFiyati);
            this.Controls.Add(this.txtSaticiIban);
            this.Controls.Add(this.txtSaticiCep);
            this.Controls.Add(this.txtAliciCep);
            this.Controls.Add(this.txtAliciEposta);
            this.Controls.Add(this.txtSaticiAdSoyad);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.txtSaticiEposta);
            this.Controls.Add(this.cmbGercekTuzel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SatisBasvuruForm";
            this.Text = "Satış Başvuru Formu";
            this.Load += new System.EventHandler(this.SatisBasvuruForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSatisFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtAracPlaka;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSellerSave;
        private CheckBox chkReklamMetni;
        private CheckBox chkRizaMetni;
        private NumericUpDown numSatisFiyati;
        private MaskedTextBox txtSaticiIban;
        private MaskedTextBox txtSaticiCep;
        private MaskedTextBox txtAliciCep;
        private TextBox txtAliciEposta;
        private TextBox txtSaticiAdSoyad;
        private MaskedTextBox txtTCKimlik;
        private TextBox txtSaticiEposta;
        private ComboBox cmbGercekTuzel;
    }
}