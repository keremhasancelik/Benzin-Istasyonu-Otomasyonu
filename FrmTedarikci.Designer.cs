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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTedarikci));
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 306);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(7, 112);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(208, 33);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(7, 77);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(208, 33);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(7, 42);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(208, 33);
            this.BtnListele.TabIndex = 9;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtTedarikciFirma
            // 
            this.TxtTedarikciFirma.Location = new System.Drawing.Point(95, 46);
            this.TxtTedarikciFirma.Name = "TxtTedarikciFirma";
            this.TxtTedarikciFirma.Size = new System.Drawing.Size(232, 29);
            this.TxtTedarikciFirma.TabIndex = 2;
            this.TxtTedarikciFirma.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Telefon:";
            // 
            // TxtBorcAlacak
            // 
            this.TxtBorcAlacak.Location = new System.Drawing.Point(144, 40);
            this.TxtBorcAlacak.Name = "TxtBorcAlacak";
            this.TxtBorcAlacak.Size = new System.Drawing.Size(197, 29);
            this.TxtBorcAlacak.TabIndex = 6;
            this.TxtBorcAlacak.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Borç - Alacak:";
            // 
            // TxtOdeme
            // 
            this.TxtOdeme.Location = new System.Drawing.Point(95, 115);
            this.TxtOdeme.Name = "TxtOdeme";
            this.TxtOdeme.Size = new System.Drawing.Size(232, 29);
            this.TxtOdeme.TabIndex = 4;
            this.TxtOdeme.Text = "0";
            // 
            // CmbUrunAdi
            // 
            this.CmbUrunAdi.FormattingEnabled = true;
            this.CmbUrunAdi.Location = new System.Drawing.Point(95, 79);
            this.CmbUrunAdi.Name = "CmbUrunAdi";
            this.CmbUrunAdi.Size = new System.Drawing.Size(232, 31);
            this.CmbUrunAdi.TabIndex = 3;
            // 
            // TxtTedarikciID
            // 
            this.TxtTedarikciID.Enabled = false;
            this.TxtTedarikciID.Location = new System.Drawing.Point(95, 10);
            this.TxtTedarikciID.Name = "TxtTedarikciID";
            this.TxtTedarikciID.Size = new System.Drawing.Size(232, 29);
            this.TxtTedarikciID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ödeme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ürün:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(18, 47);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(68, 23);
            this.TxtUrunAd.TabIndex = 32;
            this.TxtUrunAd.Text = "Firma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(7, 7);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(208, 33);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(144, 77);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(197, 29);
            this.MskTel.TabIndex = 7;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(144, 111);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(197, 29);
            this.TxtMail.TabIndex = 53;
            this.TxtMail.Text = "-";
            // 
            // TxtBorc
            // 
            this.TxtBorc.Location = new System.Drawing.Point(144, 6);
            this.TxtBorc.Name = "TxtBorc";
            this.TxtBorc.Size = new System.Drawing.Size(197, 29);
            this.TxtBorc.TabIndex = 5;
            this.TxtBorc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Borç:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 527);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnGuncelle);
            this.panel3.Controls.Add(this.BtnSil);
            this.panel3.Controls.Add(this.BtnEkle);
            this.panel3.Controls.Add(this.BtnListele);
            this.panel3.Location = new System.Drawing.Point(795, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 153);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtMail);
            this.panel2.Controls.Add(this.TxtBorc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtBorcAlacak);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MskTel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(433, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 154);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtOdeme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtUrunAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtTedarikciID);
            this.panel1.Controls.Add(this.CmbUrunAdi);
            this.panel1.Controls.Add(this.TxtTedarikciFirma);
            this.panel1.Location = new System.Drawing.Point(61, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 154);
            this.panel1.TabIndex = 0;
            // 
            // FrmTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 527);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTedarikci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Paneli";
            this.Load += new System.EventHandler(this.FrmTedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}