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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlis));
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.LblTarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunGrubuFiltre = new System.Windows.Forms.TextBox();
            this.btnUrunGrubuFiltreleme = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblKalanToplam = new System.Windows.Forms.Label();
            this.lblToplamFatura = new System.Windows.Forms.Label();
            this.lblToplamAlisLitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(11, 201);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(118, 25);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // TxtAlisID
            // 
            this.TxtAlisID.Location = new System.Drawing.Point(13, 27);
            this.TxtAlisID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAlisID.Name = "TxtAlisID";
            this.TxtAlisID.Size = new System.Drawing.Size(23, 27);
            this.TxtAlisID.TabIndex = 4;
            // 
            // CmbUrunAdi
            // 
            this.CmbUrunAdi.FormattingEnabled = true;
            this.CmbUrunAdi.Location = new System.Drawing.Point(173, 46);
            this.CmbUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.CmbUrunAdi.Name = "CmbUrunAdi";
            this.CmbUrunAdi.Size = new System.Drawing.Size(191, 27);
            this.CmbUrunAdi.TabIndex = 5;
            this.CmbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.CmbUrunAdi_SelectedIndexChanged);
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.AutoSize = true;
            this.TxtUrunAd.Location = new System.Drawing.Point(109, 46);
            this.TxtUrunAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(49, 19);
            this.TxtUrunAd.TabIndex = 6;
            this.TxtUrunAd.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "B. Fiyatı Alış (TL):";
            // 
            // TxtMiktarLT
            // 
            this.TxtMiktarLT.Location = new System.Drawing.Point(174, 115);
            this.TxtMiktarLT.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMiktarLT.Name = "TxtMiktarLT";
            this.TxtMiktarLT.Size = new System.Drawing.Size(190, 27);
            this.TxtMiktarLT.TabIndex = 10;
            this.TxtMiktarLT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Miktar (LT):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stok (LT):";
            // 
            // TxtFaturaBedeli
            // 
            this.TxtFaturaBedeli.Location = new System.Drawing.Point(154, 36);
            this.TxtFaturaBedeli.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFaturaBedeli.Name = "TxtFaturaBedeli";
            this.TxtFaturaBedeli.Size = new System.Drawing.Size(132, 27);
            this.TxtFaturaBedeli.TabIndex = 16;
            this.TxtFaturaBedeli.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fatura Bedeli (TL):";
            // 
            // TxtOdeme
            // 
            this.TxtOdeme.Location = new System.Drawing.Point(154, 69);
            this.TxtOdeme.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOdeme.Name = "TxtOdeme";
            this.TxtOdeme.Size = new System.Drawing.Size(132, 27);
            this.TxtOdeme.TabIndex = 18;
            this.TxtOdeme.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ödeme (TL):";
            // 
            // TxtKalanBakiye
            // 
            this.TxtKalanBakiye.Location = new System.Drawing.Point(154, 102);
            this.TxtKalanBakiye.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKalanBakiye.Name = "TxtKalanBakiye";
            this.TxtKalanBakiye.Size = new System.Drawing.Size(132, 27);
            this.TxtKalanBakiye.TabIndex = 20;
            this.TxtKalanBakiye.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kalan Bakiye (TL):";
            // 
            // CmbTedarikci
            // 
            this.CmbTedarikci.FormattingEnabled = true;
            this.CmbTedarikci.Location = new System.Drawing.Point(174, 147);
            this.CmbTedarikci.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTedarikci.Name = "CmbTedarikci";
            this.CmbTedarikci.Size = new System.Drawing.Size(190, 27);
            this.CmbTedarikci.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tedarikçi";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(133, 201);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(118, 25);
            this.BtnListele.TabIndex = 23;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(255, 201);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(121, 25);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(505, 201);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(103, 25);
            this.BtnSil.TabIndex = 25;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(380, 201);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(121, 25);
            this.BtnTemizle.TabIndex = 26;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 230);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CmbBirimFiyati
            // 
            this.CmbBirimFiyati.FormattingEnabled = true;
            this.CmbBirimFiyati.Location = new System.Drawing.Point(174, 81);
            this.CmbBirimFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.CmbBirimFiyati.Name = "CmbBirimFiyati";
            this.CmbBirimFiyati.Size = new System.Drawing.Size(190, 27);
            this.CmbBirimFiyati.TabIndex = 28;
            this.CmbBirimFiyati.SelectedIndexChanged += new System.EventHandler(this.CmbBirimFiyati_SelectedIndexChanged);
            // 
            // CmbStok
            // 
            this.CmbStok.FormattingEnabled = true;
            this.CmbStok.Location = new System.Drawing.Point(154, 3);
            this.CmbStok.Margin = new System.Windows.Forms.Padding(2);
            this.CmbStok.Name = "CmbStok";
            this.CmbStok.Size = new System.Drawing.Size(132, 27);
            this.CmbStok.TabIndex = 29;
            this.CmbStok.SelectedIndexChanged += new System.EventHandler(this.CmbStok_SelectedIndexChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(154, 142);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(131, 25);
            this.btnHesapla.TabIndex = 30;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSil);
            this.splitContainer1.Panel1.Controls.Add(this.BtnTemizle);
            this.splitContainer1.Panel1.Controls.Add(this.BtnListele);
            this.splitContainer1.Panel1.Controls.Add(this.BtnGuncelle);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEkle);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblToplamOdeme);
            this.splitContainer1.Panel2.Controls.Add(this.lblKalanToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblToplamFatura);
            this.splitContainer1.Panel2.Controls.Add(this.lblToplamAlisLitre);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1059, 578);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 100;
            this.button1.Text = "YAZDIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.BtnFiltrele);
            this.panel4.Controls.Add(this.LblTarih);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Location = new System.Drawing.Point(752, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 147);
            this.panel4.TabIndex = 99;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 73);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 29);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiltrele.Location = new System.Drawing.Point(90, 110);
            this.BtnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFiltrele.Size = new System.Drawing.Size(97, 33);
            this.BtnFiltrele.TabIndex = 21;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = false;
            this.BtnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.Location = new System.Drawing.Point(113, 7);
            this.LblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(57, 23);
            this.LblTarih.TabIndex = 26;
            this.LblTarih.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 29);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtUrunGrubuFiltre);
            this.panel3.Controls.Add(this.btnUrunGrubuFiltreleme);
            this.panel3.Location = new System.Drawing.Point(750, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 108);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(75, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ürün Grubu";
            // 
            // txtUrunGrubuFiltre
            // 
            this.txtUrunGrubuFiltre.Location = new System.Drawing.Point(58, 32);
            this.txtUrunGrubuFiltre.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunGrubuFiltre.Name = "txtUrunGrubuFiltre";
            this.txtUrunGrubuFiltre.Size = new System.Drawing.Size(156, 27);
            this.txtUrunGrubuFiltre.TabIndex = 22;
            // 
            // btnUrunGrubuFiltreleme
            // 
            this.btnUrunGrubuFiltreleme.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGrubuFiltreleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGrubuFiltreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGrubuFiltreleme.Location = new System.Drawing.Point(92, 64);
            this.btnUrunGrubuFiltreleme.Name = "btnUrunGrubuFiltreleme";
            this.btnUrunGrubuFiltreleme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUrunGrubuFiltreleme.Size = new System.Drawing.Size(97, 30);
            this.btnUrunGrubuFiltreleme.TabIndex = 23;
            this.btnUrunGrubuFiltreleme.Text = "Filtrele";
            this.btnUrunGrubuFiltreleme.UseVisualStyleBackColor = false;
            this.btnUrunGrubuFiltreleme.Click += new System.EventHandler(this.btnUrunGrubuFiltreleme_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtKalanBakiye);
            this.panel2.Controls.Add(this.TxtFaturaBedeli);
            this.panel2.Controls.Add(this.btnHesapla);
            this.panel2.Controls.Add(this.CmbStok);
            this.panel2.Controls.Add(this.TxtOdeme);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(429, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 180);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtAlisTarih);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtAlisID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbUrunAdi);
            this.panel1.Controls.Add(this.CmbBirimFiyati);
            this.panel1.Controls.Add(this.TxtUrunAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtMiktarLT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CmbTedarikci);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 180);
            this.panel1.TabIndex = 0;
            // 
            // dtAlisTarih
            // 
            this.dtAlisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtAlisTarih.Location = new System.Drawing.Point(173, 6);
            this.dtAlisTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtAlisTarih.Name = "dtAlisTarih";
            this.dtAlisTarih.Size = new System.Drawing.Size(191, 24);
            this.dtAlisTarih.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tarih:";
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Location = new System.Drawing.Point(579, 241);
            this.lblToplamOdeme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(16, 19);
            this.lblToplamOdeme.TabIndex = 37;
            this.lblToplamOdeme.Text = "x";
            // 
            // lblKalanToplam
            // 
            this.lblKalanToplam.AutoSize = true;
            this.lblKalanToplam.Location = new System.Drawing.Point(579, 271);
            this.lblKalanToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalanToplam.Name = "lblKalanToplam";
            this.lblKalanToplam.Size = new System.Drawing.Size(16, 19);
            this.lblKalanToplam.TabIndex = 36;
            this.lblKalanToplam.Text = "x";
            // 
            // lblToplamFatura
            // 
            this.lblToplamFatura.AutoSize = true;
            this.lblToplamFatura.Location = new System.Drawing.Point(115, 271);
            this.lblToplamFatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamFatura.Name = "lblToplamFatura";
            this.lblToplamFatura.Size = new System.Drawing.Size(16, 19);
            this.lblToplamFatura.TabIndex = 32;
            this.lblToplamFatura.Text = "x";
            // 
            // lblToplamAlisLitre
            // 
            this.lblToplamAlisLitre.AutoSize = true;
            this.lblToplamAlisLitre.Location = new System.Drawing.Point(115, 241);
            this.lblToplamAlisLitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamAlisLitre.Name = "lblToplamAlisLitre";
            this.lblToplamAlisLitre.Size = new System.Drawing.Size(16, 19);
            this.lblToplamAlisLitre.TabIndex = 29;
            this.lblToplamAlisLitre.Text = "x";
            // 
            // FrmAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 578);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALIŞ PANELİ";
            this.Load += new System.EventHandler(this.FrmAlis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUrunGrubuFiltreleme;
        private System.Windows.Forms.TextBox txtUrunGrubuFiltre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblKalanToplam;
        private System.Windows.Forms.Label lblToplamFatura;
        private System.Windows.Forms.Label lblToplamAlisLitre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtAlisTarih;
        private System.Windows.Forms.Button button1;
    }
}