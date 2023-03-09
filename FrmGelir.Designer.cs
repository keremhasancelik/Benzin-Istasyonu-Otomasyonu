namespace Sayac_Proje
{
    partial class FrmGelir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelir));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtGelirAciklama = new System.Windows.Forms.TextBox();
            this.TxtGelirTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGelir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGelirUrunFiltre = new System.Windows.Forms.TextBox();
            this.btnUrunGrubuFiltreleme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1071, 291);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(14, 132);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(179, 37);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "TEMİZLE";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(14, 48);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(179, 36);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(14, 92);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(179, 36);
            this.BtnListele.TabIndex = 7;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtGelirAciklama
            // 
            this.TxtGelirAciklama.Location = new System.Drawing.Point(125, 93);
            this.TxtGelirAciklama.Name = "TxtGelirAciklama";
            this.TxtGelirAciklama.Size = new System.Drawing.Size(178, 27);
            this.TxtGelirAciklama.TabIndex = 4;
            this.TxtGelirAciklama.Text = "-";
            // 
            // TxtGelirTutar
            // 
            this.TxtGelirTutar.Location = new System.Drawing.Point(125, 132);
            this.TxtGelirTutar.Name = "TxtGelirTutar";
            this.TxtGelirTutar.Size = new System.Drawing.Size(178, 27);
            this.TxtGelirTutar.TabIndex = 1;
            this.TxtGelirTutar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tutar:";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(3, 31);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(31, 27);
            this.TxtUrunID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tarih:";
            // 
            // TxtGelir
            // 
            this.TxtGelir.AutoSize = true;
            this.TxtGelir.Location = new System.Drawing.Point(23, 93);
            this.TxtGelir.Name = "TxtGelir";
            this.TxtGelir.Size = new System.Drawing.Size(81, 19);
            this.TxtGelir.TabIndex = 55;
            this.TxtGelir.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(14, 5);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(179, 36);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Yakıt:";
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnYazdir);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 525);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 68;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(676, 178);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(199, 31);
            this.btnYazdir.TabIndex = 167;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnEkle);
            this.panel2.Controls.Add(this.BtnGuncelle);
            this.panel2.Controls.Add(this.BtnSil);
            this.panel2.Controls.Add(this.BtnListele);
            this.panel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(332, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 179);
            this.panel2.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtGelirUrunFiltre);
            this.panel6.Controls.Add(this.btnUrunGrubuFiltreleme);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(817, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 153);
            this.panel6.TabIndex = 166;
            // 
            // txtGelirUrunFiltre
            // 
            this.txtGelirUrunFiltre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelirUrunFiltre.Location = new System.Drawing.Point(15, 48);
            this.txtGelirUrunFiltre.Name = "txtGelirUrunFiltre";
            this.txtGelirUrunFiltre.Size = new System.Drawing.Size(174, 25);
            this.txtGelirUrunFiltre.TabIndex = 22;
            // 
            // btnUrunGrubuFiltreleme
            // 
            this.btnUrunGrubuFiltreleme.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGrubuFiltreleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGrubuFiltreleme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGrubuFiltreleme.Location = new System.Drawing.Point(15, 105);
            this.btnUrunGrubuFiltreleme.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunGrubuFiltreleme.Name = "btnUrunGrubuFiltreleme";
            this.btnUrunGrubuFiltreleme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUrunGrubuFiltreleme.Size = new System.Drawing.Size(174, 34);
            this.btnUrunGrubuFiltreleme.TabIndex = 23;
            this.btnUrunGrubuFiltreleme.Text = "Filtrele";
            this.btnUrunGrubuFiltreleme.UseVisualStyleBackColor = false;
            this.btnUrunGrubuFiltreleme.Click += new System.EventHandler(this.btnUrunGrubuFiltreleme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(64, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ürün";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtGelirTutar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtUrunID);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtGelirAciklama);
            this.panel1.Controls.Add(this.TxtGelir);
            this.panel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 179);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.BtnFiltrele);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dateTimePicker3);
            this.panel4.Location = new System.Drawing.Point(551, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 153);
            this.panel4.TabIndex = 165;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 67);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 25);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFiltrele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiltrele.Location = new System.Drawing.Point(15, 105);
            this.BtnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFiltrele.Size = new System.Drawing.Size(222, 34);
            this.BtnFiltrele.TabIndex = 21;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = false;
            this.BtnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tarih";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker3.Location = new System.Drawing.Point(15, 29);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(222, 25);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // FrmGelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 525);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGelir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Paneli";
            this.Load += new System.EventHandler(this.FrmGelir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtGelirAciklama;
        private System.Windows.Forms.TextBox TxtGelirTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtGelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGelirUrunFiltre;
        private System.Windows.Forms.Button btnUrunGrubuFiltreleme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}