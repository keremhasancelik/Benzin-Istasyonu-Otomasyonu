namespace Sayac_Proje
{
    partial class FrmTedarikci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtTedarikciFirma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBorcAlacak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOdeme = new System.Windows.Forms.TextBox();
            this.CmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.TxtTedarikciID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 193);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(567, 118);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(208, 26);
            this.BtnSil.TabIndex = 49;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(567, 83);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(208, 26);
            this.BtnGuncelle.TabIndex = 48;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(567, 48);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(208, 26);
            this.BtnListele.TabIndex = 47;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtTedarikciFirma
            // 
            this.TxtTedarikciFirma.Location = new System.Drawing.Point(89, 53);
            this.TxtTedarikciFirma.Name = "TxtTedarikciFirma";
            this.TxtTedarikciFirma.Size = new System.Drawing.Size(116, 25);
            this.TxtTedarikciFirma.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Telefon:";
            // 
            // TxtBorcAlacak
            // 
            this.TxtBorcAlacak.Location = new System.Drawing.Point(347, 52);
            this.TxtBorcAlacak.Name = "TxtBorcAlacak";
            this.TxtBorcAlacak.Size = new System.Drawing.Size(137, 25);
            this.TxtBorcAlacak.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Borç - Alacak:";
            // 
            // TxtOdeme
            // 
            this.TxtOdeme.Location = new System.Drawing.Point(89, 122);
            this.TxtOdeme.Name = "TxtOdeme";
            this.TxtOdeme.Size = new System.Drawing.Size(116, 25);
            this.TxtOdeme.TabIndex = 36;
            // 
            // CmbUrunAdi
            // 
            this.CmbUrunAdi.FormattingEnabled = true;
            this.CmbUrunAdi.Location = new System.Drawing.Point(89, 86);
            this.CmbUrunAdi.Name = "CmbUrunAdi";
            this.CmbUrunAdi.Size = new System.Drawing.Size(116, 26);
            this.CmbUrunAdi.TabIndex = 31;
            // 
            // TxtTedarikciID
            // 
            this.TxtTedarikciID.Location = new System.Drawing.Point(89, 17);
            this.TxtTedarikciID.Name = "TxtTedarikciID";
            this.TxtTedarikciID.Size = new System.Drawing.Size(116, 25);
            this.TxtTedarikciID.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ödeme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ürün:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(20, 52);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(54, 18);
            this.TxtUrunAd.TabIndex = 32;
            this.TxtUrunAd.Text = "Firma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(567, 13);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(208, 26);
            this.BtnEkle.TabIndex = 28;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(347, 89);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(137, 25);
            this.MskTel.TabIndex = 52;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(347, 123);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(137, 25);
            this.TxtMail.TabIndex = 53;
            // 
            // TxtBorc
            // 
            this.TxtBorc.Location = new System.Drawing.Point(347, 18);
            this.TxtBorc.Name = "TxtBorc";
            this.TxtBorc.Size = new System.Drawing.Size(137, 25);
            this.TxtBorc.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Borç:";
            // 
            // FrmTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(788, 403);
            this.Controls.Add(this.TxtBorc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtTedarikciFirma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBorcAlacak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtOdeme);
            this.Controls.Add(this.CmbUrunAdi);
            this.Controls.Add(this.TxtTedarikciID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTedarikci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Paneli";
            this.Load += new System.EventHandler(this.FrmTedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtTedarikciFirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBorcAlacak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOdeme;
        private System.Windows.Forms.ComboBox CmbUrunAdi;
        private System.Windows.Forms.TextBox TxtTedarikciID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtBorc;
        private System.Windows.Forms.Label label4;
    }
}