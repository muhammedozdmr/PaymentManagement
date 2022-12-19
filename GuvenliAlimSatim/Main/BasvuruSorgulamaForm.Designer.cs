namespace GuvenliAlimSatim.UI.Main
{
    partial class BasvuruSorgulamaForm
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
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtReferans = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.cmbGercekTuzel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(306, 252);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(91, 38);
            this.btnSorgula.TabIndex = 9;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtReferans
            // 
            this.txtReferans.Location = new System.Drawing.Point(207, 203);
            this.txtReferans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReferans.Mask = "000000";
            this.txtReferans.Name = "txtReferans";
            this.txtReferans.Size = new System.Drawing.Size(188, 31);
            this.txtReferans.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(207, 150);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(188, 31);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(207, 97);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(188, 31);
            this.txtTcKimlik.TabIndex = 6;
            // 
            // cmbGercekTuzel
            // 
            this.cmbGercekTuzel.FormattingEnabled = true;
            this.cmbGercekTuzel.Location = new System.Drawing.Point(207, 43);
            this.cmbGercekTuzel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGercekTuzel.Name = "cmbGercekTuzel";
            this.cmbGercekTuzel.Size = new System.Drawing.Size(188, 33);
            this.cmbGercekTuzel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ünvan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Referans No:";
            // 
            // BasvuruSorgulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtReferans);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.cmbGercekTuzel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasvuruSorgulamaForm";
            this.Text = "BasvuruSorgulamaForm";
            this.Load += new System.EventHandler(this.BasvuruSorgulamaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSorgula;
        private MaskedTextBox txtReferans;
        private MaskedTextBox txtTelefon;
        private MaskedTextBox txtTcKimlik;
        private ComboBox cmbGercekTuzel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}