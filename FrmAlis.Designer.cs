namespace Sayac_Proje
{
    partial class FrmAlis
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAlisID = new System.Windows.Forms.TextBox();
            this.CmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.TxtUrunAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMiktarLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFaturaBedeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOdeme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKalanBakiye = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbBirimFiyati = new System.Windows.Forms.ComboBox();
            this.CmbStok = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(567, 14);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(208, 26);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // TxtAlisID
            // 
            this.TxtAlisID.Location = new System.Drawing.Point(118, 17);
            this.TxtAlisID.Name = "TxtAlisID";
            this.TxtAlisID.Size = new System.Drawing.Size(116, 30);
            this.TxtAlisID.TabIndex = 4;
            // 
            // CmbUrunAdi
            // 
            this.CmbUrunAdi.FormattingEnabled = true;
            this.CmbUrunAdi.Location = new System.Drawing.Point(118, 52);
            this.CmbUrunAdi.Name = "CmbUrunAdi";
            this.CmbUrunAdi.Size = new System.Drawing.Size(116, 32);
            this.CmbUrunAdi.TabIndex = 5;
            this.CmbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.CmbUrunAdi_SelectedIndexChanged);
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(62, 53);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(63, 24);
            this.TxtUrunAd.TabIndex = 6;
            this.TxtUrunAd.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "B. Fiyatı (TL):";
            // 
            // TxtMiktarLT
            // 
            this.TxtMiktarLT.Location = new System.Drawing.Point(118, 122);
            this.TxtMiktarLT.Name = "TxtMiktarLT";
            this.TxtMiktarLT.Size = new System.Drawing.Size(116, 30);
            this.TxtMiktarLT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Miktar (LT):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stok (LT):";
            // 
            // TxtFaturaBedeli
            // 
            this.TxtFaturaBedeli.Location = new System.Drawing.Point(427, 50);
            this.TxtFaturaBedeli.Name = "TxtFaturaBedeli";
            this.TxtFaturaBedeli.Size = new System.Drawing.Size(116, 30);
            this.TxtFaturaBedeli.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fatura Bedeli (TL):";
            // 
            // TxtOdeme
            // 
            this.TxtOdeme.Location = new System.Drawing.Point(427, 86);
            this.TxtOdeme.Name = "TxtOdeme";
            this.TxtOdeme.Size = new System.Drawing.Size(116, 30);
            this.TxtOdeme.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ödeme (TL):";
            // 
            // TxtKalanBakiye
            // 
            this.TxtKalanBakiye.Location = new System.Drawing.Point(427, 122);
            this.TxtKalanBakiye.Name = "TxtKalanBakiye";
            this.TxtKalanBakiye.Size = new System.Drawing.Size(116, 30);
            this.TxtKalanBakiye.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kalan Bakiye (TL):";
            // 
            // CmbTedarikci
            // 
            this.CmbTedarikci.FormattingEnabled = true;
            this.CmbTedarikci.Location = new System.Drawing.Point(118, 154);
            this.CmbTedarikci.Name = "CmbTedarikci";
            this.CmbTedarikci.Size = new System.Drawing.Size(116, 32);
            this.CmbTedarikci.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tedarikçi";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(567, 49);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(208, 26);
            this.BtnListele.TabIndex = 23;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(567, 84);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(208, 26);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(567, 119);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(208, 26);
            this.BtnSil.TabIndex = 25;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(567, 154);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(208, 26);
            this.BtnTemizle.TabIndex = 26;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(779, 193);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CmbBirimFiyati
            // 
            this.CmbBirimFiyati.FormattingEnabled = true;
            this.CmbBirimFiyati.Location = new System.Drawing.Point(118, 85);
            this.CmbBirimFiyati.Name = "CmbBirimFiyati";
            this.CmbBirimFiyati.Size = new System.Drawing.Size(116, 32);
            this.CmbBirimFiyati.TabIndex = 28;
            this.CmbBirimFiyati.SelectedIndexChanged += new System.EventHandler(this.CmbBirimFiyati_SelectedIndexChanged);
            // 
            // CmbStok
            // 
            this.CmbStok.FormattingEnabled = true;
            this.CmbStok.Location = new System.Drawing.Point(427, 14);
            this.CmbStok.Name = "CmbStok";
            this.CmbStok.Size = new System.Drawing.Size(116, 32);
            this.CmbStok.TabIndex = 29;
            // 
            // FrmAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(787, 400);
            this.Controls.Add(this.CmbStok);
            this.Controls.Add(this.CmbBirimFiyati);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CmbTedarikci);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtKalanBakiye);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtOdeme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFaturaBedeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMiktarLT);
            this.Controls.Add(this.CmbUrunAdi);
            this.Controls.Add(this.TxtAlisID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAlis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALIŞ PANELİ";
            this.Load += new System.EventHandler(this.FrmAlis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAlisID;
        private System.Windows.Forms.ComboBox CmbUrunAdi;
        private System.Windows.Forms.Label TxtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMiktarLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFaturaBedeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOdeme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKalanBakiye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbTedarikci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbBirimFiyati;
        private System.Windows.Forms.ComboBox CmbStok;
    }
}