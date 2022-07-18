namespace Sayac_Proje
{
    partial class FrmFatura
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFaturaKurum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtFaturaNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFaturaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtFaturaTutar = new System.Windows.Forms.TextBox();
            this.TxtFaturaDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(88, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 106);
            this.richTextBox1.TabIndex = 83;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 20);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Tutar:";
            // 
            // TxtFaturaKurum
            // 
            this.TxtFaturaKurum.Location = new System.Drawing.Point(130, 97);
            this.TxtFaturaKurum.Name = "TxtFaturaKurum";
            this.TxtFaturaKurum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFaturaKurum.Size = new System.Drawing.Size(116, 25);
            this.TxtFaturaKurum.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Kurum/Kuruluş:";
            // 
            // BtnSil
            // 
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.Location = new System.Drawing.Point(416, 13);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(116, 33);
            this.BtnSil.TabIndex = 78;
            this.BtnSil.Text = "TEMİZLE";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.Location = new System.Drawing.Point(278, 13);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(116, 32);
            this.BtnGuncelle.TabIndex = 77;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListele.Location = new System.Drawing.Point(139, 13);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(116, 32);
            this.BtnListele.TabIndex = 76;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtFaturaNO
            // 
            this.TxtFaturaNO.Location = new System.Drawing.Point(130, 58);
            this.TxtFaturaNO.Name = "TxtFaturaNO";
            this.TxtFaturaNO.Size = new System.Drawing.Size(116, 25);
            this.TxtFaturaNO.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Açıklama:";
            // 
            // TxtFaturaID
            // 
            this.TxtFaturaID.Location = new System.Drawing.Point(130, 19);
            this.TxtFaturaID.Name = "TxtFaturaID";
            this.TxtFaturaID.Size = new System.Drawing.Size(116, 25);
            this.TxtFaturaID.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Son Ödeme:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(42, 61);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(82, 18);
            this.TxtUrunAd.TabIndex = 72;
            this.TxtUrunAd.Text = "Fatura No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fatura ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.Location = new System.Drawing.Point(5, 13);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(116, 32);
            this.BtnEkle.TabIndex = 69;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 203);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtFaturaTutar
            // 
            this.TxtFaturaTutar.Location = new System.Drawing.Point(101, 16);
            this.TxtFaturaTutar.Name = "TxtFaturaTutar";
            this.TxtFaturaTutar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFaturaTutar.Size = new System.Drawing.Size(137, 25);
            this.TxtFaturaTutar.TabIndex = 84;
            // 
            // TxtFaturaDurum
            // 
            this.TxtFaturaDurum.Location = new System.Drawing.Point(101, 98);
            this.TxtFaturaDurum.Name = "TxtFaturaDurum";
            this.TxtFaturaDurum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFaturaDurum.Size = new System.Drawing.Size(137, 25);
            this.TxtFaturaDurum.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 102);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 85;
            this.label6.Text = "Durum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 25);
            this.dateTimePicker1.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFaturaKurum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtUrunAd);
            this.groupBox1.Controls.Add(this.TxtFaturaID);
            this.groupBox1.Controls.Add(this.TxtFaturaNO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 129);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtFaturaDurum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtFaturaTutar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(265, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 129);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(516, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 129);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnSil);
            this.groupBox4.Controls.Add(this.BtnEkle);
            this.groupBox4.Controls.Add(this.BtnListele);
            this.groupBox4.Controls.Add(this.BtnGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(3, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(844, 49);
            this.groupBox4.TabIndex = 91;
            this.groupBox4.TabStop = false;
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Paneli";
            this.Load += new System.EventHandler(this.FrmFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFaturaKurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtFaturaNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFaturaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtFaturaTutar;
        private System.Windows.Forms.TextBox TxtFaturaDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}