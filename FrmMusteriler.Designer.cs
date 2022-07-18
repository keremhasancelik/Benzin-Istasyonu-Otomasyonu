namespace Sayac_Proje
{
    partial class FrmMusteriler
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
            this.TxtAlacak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBorcAlacak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.CmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.TxtMusteriID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtOdeme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAlacak
            // 
            this.TxtAlacak.Location = new System.Drawing.Point(352, 50);
            this.TxtAlacak.Name = "TxtAlacak";
            this.TxtAlacak.Size = new System.Drawing.Size(137, 25);
            this.TxtAlacak.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Alacak:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(623, 124);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(137, 25);
            this.TxtMail.TabIndex = 74;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(623, 86);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(137, 25);
            this.MskTel.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 201);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(366, 153);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(115, 32);
            this.BtnSil.TabIndex = 71;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(245, 153);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(115, 32);
            this.BtnGuncelle.TabIndex = 70;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(124, 153);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(115, 32);
            this.BtnListele.TabIndex = 69;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(73, 48);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(144, 25);
            this.TxtAd.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 67;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Telefon:";
            // 
            // TxtBorcAlacak
            // 
            this.TxtBorcAlacak.Location = new System.Drawing.Point(623, 10);
            this.TxtBorcAlacak.Name = "TxtBorcAlacak";
            this.TxtBorcAlacak.Size = new System.Drawing.Size(137, 25);
            this.TxtBorcAlacak.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Kalan Alacak:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(352, 12);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(137, 25);
            this.TxtMiktar.TabIndex = 63;
            // 
            // CmbUrunAdi
            // 
            this.CmbUrunAdi.FormattingEnabled = true;
            this.CmbUrunAdi.Location = new System.Drawing.Point(73, 82);
            this.CmbUrunAdi.Name = "CmbUrunAdi";
            this.CmbUrunAdi.Size = new System.Drawing.Size(144, 26);
            this.CmbUrunAdi.TabIndex = 59;
            // 
            // TxtMusteriID
            // 
            this.TxtMusteriID.Location = new System.Drawing.Point(73, 14);
            this.TxtMusteriID.Name = "TxtMusteriID";
            this.TxtMusteriID.Size = new System.Drawing.Size(144, 25);
            this.TxtMusteriID.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Miktar (LT):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ürün:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(13, 50);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(54, 18);
            this.TxtUrunAd.TabIndex = 60;
            this.TxtUrunAd.Text = "Firma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(3, 153);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(115, 32);
            this.BtnEkle.TabIndex = 56;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtOdeme
            // 
            this.TxtOdeme.Location = new System.Drawing.Point(352, 85);
            this.TxtOdeme.Name = "TxtOdeme";
            this.TxtOdeme.Size = new System.Drawing.Size(137, 25);
            this.TxtOdeme.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 77;
            this.label8.Text = "Ödeme:";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(623, 48);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(137, 25);
            this.TxtPlaka.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "Plaka:";
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(786, 394);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtOdeme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtAlacak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBorcAlacak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMiktar);
            this.Controls.Add(this.CmbUrunAdi);
            this.Controls.Add(this.TxtMusteriID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler Paneli";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAlacak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBorcAlacak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.ComboBox CmbUrunAdi;
        private System.Windows.Forms.TextBox TxtMusteriID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtOdeme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label9;
    }
}