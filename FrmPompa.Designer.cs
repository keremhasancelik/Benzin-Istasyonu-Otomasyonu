namespace Sayac_Proje
{
    partial class FrmPompa
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
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TxtTankNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtPompaNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPompaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(340, 10);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(121, 26);
            this.CmbUrun.TabIndex = 84;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(577, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 99);
            this.richTextBox1.TabIndex = 83;
            this.richTextBox1.Text = "";
            // 
            // TxtTankNo
            // 
            this.TxtTankNo.Location = new System.Drawing.Point(340, 50);
            this.TxtTankNo.Name = "TxtTankNo";
            this.TxtTankNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTankNo.Size = new System.Drawing.Size(121, 25);
            this.TxtTankNo.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 10);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Ürün:";
            // 
            // TxtAdaNo
            // 
            this.TxtAdaNo.Location = new System.Drawing.Point(109, 89);
            this.TxtAdaNo.Name = "TxtAdaNo";
            this.TxtAdaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtAdaNo.Size = new System.Drawing.Size(116, 25);
            this.TxtAdaNo.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Ada No:";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(560, 137);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(116, 33);
            this.BtnSil.TabIndex = 78;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(422, 137);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(116, 32);
            this.BtnGuncelle.TabIndex = 77;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(283, 137);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(116, 32);
            this.BtnListele.TabIndex = 76;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtPompaNO
            // 
            this.TxtPompaNO.Location = new System.Drawing.Point(109, 48);
            this.TxtPompaNO.Name = "TxtPompaNO";
            this.TxtPompaNO.Size = new System.Drawing.Size(116, 25);
            this.TxtPompaNO.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Açıklama:";
            // 
            // TxtPompaID
            // 
            this.TxtPompaID.Location = new System.Drawing.Point(109, 7);
            this.TxtPompaID.Name = "TxtPompaID";
            this.TxtPompaID.Size = new System.Drawing.Size(116, 25);
            this.TxtPompaID.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tank No:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(8, 50);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(84, 18);
            this.TxtUrunAd.TabIndex = 72;
            this.TxtUrunAd.Text = "Pompa No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Pompa ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(149, 137);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 193);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmPompa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(845, 403);
            this.Controls.Add(this.CmbUrun);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtTankNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtPompaNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPompaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPompa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pompa Paneli";
            this.Load += new System.EventHandler(this.FrmPompa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TxtTankNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtPompaNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPompaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}