namespace Sayac_Proje
{
    partial class FrmSatis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            this.CmbBirimFiyati = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTahsilar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMiktarLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSil = new System.Windows.Forms.Button();
            this.dtSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrunGrubuFiltre = new System.Windows.Forms.TextBox();
            this.btnUrunGrubuFiltreleme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbToplamAlacak = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.TxtSatisID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.LblTarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCariAdi = new System.Windows.Forms.ComboBox();
            this.lblFark = new System.Windows.Forms.Label();
            this.lblLitre = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTahsilat = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBirimFiyati
            // 
            this.CmbBirimFiyati.FormattingEnabled = true;
            this.CmbBirimFiyati.Location = new System.Drawing.Point(634, 88);
            this.CmbBirimFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBirimFiyati.Name = "CmbBirimFiyati";
            this.CmbBirimFiyati.Size = new System.Drawing.Size(141, 29);
            this.CmbBirimFiyati.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 296);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.ForeColor = System.Drawing.Color.White;
            this.BtnTemizle.Location = new System.Drawing.Point(138, 259);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(102, 32);
            this.BtnTemizle.TabIndex = 14;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.BackColor = System.Drawing.Color.Turquoise;
            this.BtnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYazdir.Location = new System.Drawing.Point(256, 219);
            this.BtnYazdir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(133, 32);
            this.BtnYazdir.TabIndex = 15;
            this.BtnYazdir.Text = "YAZDIR";
            this.BtnYazdir.UseVisualStyleBackColor = false;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(13, 259);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(117, 32);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListele.ForeColor = System.Drawing.Color.White;
            this.BtnListele.Location = new System.Drawing.Point(138, 219);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(102, 32);
            this.BtnListele.TabIndex = 12;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(118, 171);
            this.TxtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(373, 28);
            this.TxtAciklama.TabIndex = 9;
            this.TxtAciklama.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Açıklama:";
            // 
            // TxtTahsilar
            // 
            this.TxtTahsilar.Location = new System.Drawing.Point(634, 171);
            this.TxtTahsilar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTahsilar.Name = "TxtTahsilar";
            this.TxtTahsilar.Size = new System.Drawing.Size(141, 28);
            this.TxtTahsilar.TabIndex = 10;
            this.TxtTahsilar.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tahsilat (TL):";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(113, 129);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(131, 28);
            this.TxtTutar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tutar (TL):";
            // 
            // TxtMiktarLT
            // 
            this.TxtMiktarLT.Location = new System.Drawing.Point(362, 88);
            this.TxtMiktarLT.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMiktarLT.Name = "TxtMiktarLT";
            this.TxtMiktarLT.Size = new System.Drawing.Size(129, 28);
            this.TxtMiktarLT.TabIndex = 5;
            this.TxtMiktarLT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Miktar (LT):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "B. Fiyatı (TL):";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Location = new System.Drawing.Point(13, 219);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(117, 32);
            this.BtnEkle.TabIndex = 11;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(362, 126);
            this.txtFisNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(129, 28);
            this.txtFisNo.TabIndex = 8;
            this.txtFisNo.Text = "0";
            this.txtFisNo.TextChanged += new System.EventHandler(this.txtFisNo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 90;
            this.label10.Text = "Fiş No:";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(113, 87);
            this.cmbUrun.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(131, 29);
            this.cmbUrun.TabIndex = 4;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 93;
            this.label11.Text = "Ürün Ad:";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnSil);
            this.splitContainer1.Panel1.Controls.Add(this.dtSatisTarih);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrun);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.cmbToplamAlacak);
            this.splitContainer1.Panel1.Controls.Add(this.TxtTahsilar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAra);
            this.splitContainer1.Panel1.Controls.Add(this.TxtTutar);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtAra);
            this.splitContainer1.Panel1.Controls.Add(this.TxtMiktarLT);
            this.splitContainer1.Panel1.Controls.Add(this.TxtSatisID);
            this.splitContainer1.Panel1.Controls.Add(this.TxtAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCari);
            this.splitContainer1.Panel1.Controls.Add(this.CmbBirimFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFisNo);
            this.splitContainer1.Panel1.Controls.Add(this.BtnTemizle);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.CmbCariAdi);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEkle);
            this.splitContainer1.Panel1.Controls.Add(this.BtnListele);
            this.splitContainer1.Panel1.Controls.Add(this.BtnGuncelle);
            this.splitContainer1.Panel1.Controls.Add(this.BtnYazdir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblFark);
            this.splitContainer1.Panel2.Controls.Add(this.lblLitre);
            this.splitContainer1.Panel2.Controls.Add(this.lblTutar);
            this.splitContainer1.Panel2.Controls.Add(this.lblTahsilat);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 644);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 96;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(256, 261);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 31);
            this.btnSil.TabIndex = 103;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dtSatisTarih
            // 
            this.dtSatisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSatisTarih.Location = new System.Drawing.Point(169, 10);
            this.dtSatisTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtSatisTarih.Name = "dtSatisTarih";
            this.dtSatisTarih.Size = new System.Drawing.Size(273, 29);
            this.dtSatisTarih.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUrunGrubuFiltre);
            this.panel1.Controls.Add(this.btnUrunGrubuFiltreleme);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(798, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 127);
            this.panel1.TabIndex = 102;
            // 
            // txtUrunGrubuFiltre
            // 
            this.txtUrunGrubuFiltre.Location = new System.Drawing.Point(15, 43);
            this.txtUrunGrubuFiltre.Name = "txtUrunGrubuFiltre";
            this.txtUrunGrubuFiltre.Size = new System.Drawing.Size(273, 28);
            this.txtUrunGrubuFiltre.TabIndex = 22;
            // 
            // btnUrunGrubuFiltreleme
            // 
            this.btnUrunGrubuFiltreleme.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGrubuFiltreleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGrubuFiltreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGrubuFiltreleme.Location = new System.Drawing.Point(15, 81);
            this.btnUrunGrubuFiltreleme.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunGrubuFiltreleme.Name = "btnUrunGrubuFiltreleme";
            this.btnUrunGrubuFiltreleme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUrunGrubuFiltreleme.Size = new System.Drawing.Size(273, 34);
            this.btnUrunGrubuFiltreleme.TabIndex = 23;
            this.btnUrunGrubuFiltreleme.Text = "Filtrele";
            this.btnUrunGrubuFiltreleme.UseVisualStyleBackColor = false;
            this.btnUrunGrubuFiltreleme.Click += new System.EventHandler(this.btnUrunGrubuFiltreleme_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(93, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ürün Grubu";
            // 
            // cmbToplamAlacak
            // 
            this.cmbToplamAlacak.FormattingEnabled = true;
            this.cmbToplamAlacak.Location = new System.Drawing.Point(634, 49);
            this.cmbToplamAlacak.Margin = new System.Windows.Forms.Padding(4);
            this.cmbToplamAlacak.Name = "cmbToplamAlacak";
            this.cmbToplamAlacak.Size = new System.Drawing.Size(141, 29);
            this.cmbToplamAlacak.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(545, 219);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(230, 32);
            this.btnAra.TabIndex = 18;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 95;
            this.label5.Text = "Toplam Alacak:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(545, 263);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(229, 28);
            this.txtAra.TabIndex = 17;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // TxtSatisID
            // 
            this.TxtSatisID.Enabled = false;
            this.TxtSatisID.Location = new System.Drawing.Point(68, 13);
            this.TxtSatisID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSatisID.Name = "TxtSatisID";
            this.TxtSatisID.Size = new System.Drawing.Size(30, 28);
            this.TxtSatisID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.BtnFiltrele);
            this.panel3.Controls.Add(this.LblTarih);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(798, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 162);
            this.panel3.TabIndex = 98;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 77);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 29);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiltrele.Location = new System.Drawing.Point(15, 115);
            this.BtnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFiltrele.Size = new System.Drawing.Size(273, 34);
            this.BtnFiltrele.TabIndex = 21;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = false;
            this.BtnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.Location = new System.Drawing.Point(105, 6);
            this.LblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(57, 23);
            this.LblTarih.TabIndex = 26;
            this.LblTarih.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 29);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // TxtCari
            // 
            this.TxtCari.AutoSize = true;
            this.TxtCari.Location = new System.Drawing.Point(32, 51);
            this.TxtCari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(74, 21);
            this.TxtCari.TabIndex = 34;
            this.TxtCari.Text = "Müşteri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 89;
            this.label4.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // CmbCariAdi
            // 
            this.CmbCariAdi.FormattingEnabled = true;
            this.CmbCariAdi.Location = new System.Drawing.Point(114, 48);
            this.CmbCariAdi.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCariAdi.Name = "CmbCariAdi";
            this.CmbCariAdi.Size = new System.Drawing.Size(377, 29);
            this.CmbCariAdi.TabIndex = 2;
            this.CmbCariAdi.SelectedIndexChanged += new System.EventHandler(this.CmbCariAdi_SelectedIndexChanged);
            // 
            // lblFark
            // 
            this.lblFark.AutoSize = true;
            this.lblFark.Location = new System.Drawing.Point(901, 304);
            this.lblFark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(34, 21);
            this.lblFark.TabIndex = 105;
            this.lblFark.Text = "xxx";
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Location = new System.Drawing.Point(246, 304);
            this.lblLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(34, 21);
            this.lblLitre.TabIndex = 104;
            this.lblLitre.Text = "xxx";
            this.lblLitre.Click += new System.EventHandler(this.lblLitre_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(437, 304);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(34, 21);
            this.lblTutar.TabIndex = 103;
            this.lblTutar.Text = "xxx";
            this.lblTutar.Click += new System.EventHandler(this.lblTutar_Click);
            // 
            // lblTahsilat
            // 
            this.lblTahsilat.AutoSize = true;
            this.lblTahsilat.Location = new System.Drawing.Point(655, 304);
            this.lblTahsilat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTahsilat.Name = "lblTahsilat";
            this.lblTahsilat.Size = new System.Drawing.Size(34, 21);
            this.lblTahsilat.TabIndex = 102;
            this.lblTahsilat.Text = "xxx";
            this.lblTahsilat.Click += new System.EventHandler(this.lblTahsilat_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // tblSatisBindingSource
            // 
            this.tblSatisBindingSource.DataMember = "Tbl_Satis";
            this.tblSatisBindingSource.DataSource = this.bindingSource1;
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 644);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Paneli";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.tblSatisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbBirimFiyati;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTahsilar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMiktarLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbToplamAlacak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSatisID;
        private System.Windows.Forms.Label TxtCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCariAdi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        //private Db_SayacSatisRaporDS db_SayacSatisRaporDS1;
        private System.Windows.Forms.BindingSource bindingSource1;
        //private Db_SayacDataSet3 db_SayacDataSet3;
        private System.Windows.Forms.BindingSource tblSatisBindingSource;
        private System.Windows.Forms.Label lblTahsilat;
        private System.Windows.Forms.Label lblLitre;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrunGrubuFiltreleme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunGrubuFiltre;
        private System.Windows.Forms.DateTimePicker dtSatisTarih;
        private System.Windows.Forms.Button btnSil;
    }
}