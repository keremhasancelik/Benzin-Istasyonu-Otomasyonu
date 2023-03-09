namespace Sayac_Proje
{
    partial class FrmPersonelMaasHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelMaasHareket));
            this.cmbPersonelKalanMaas = new System.Windows.Forms.ComboBox();
            this.cmbGiderPersonel = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPersonelAdiFiltre = new System.Windows.Forms.TextBox();
            this.btnUrunGrubuFiltreleme = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtToplamAlinanAvans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaasArttir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuç = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtAvans = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersonelKalanMaas
            // 
            this.cmbPersonelKalanMaas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonelKalanMaas.FormattingEnabled = true;
            this.cmbPersonelKalanMaas.Location = new System.Drawing.Point(101, 78);
            this.cmbPersonelKalanMaas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPersonelKalanMaas.Name = "cmbPersonelKalanMaas";
            this.cmbPersonelKalanMaas.Size = new System.Drawing.Size(153, 25);
            this.cmbPersonelKalanMaas.TabIndex = 2;
            // 
            // cmbGiderPersonel
            // 
            this.cmbGiderPersonel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGiderPersonel.FormattingEnabled = true;
            this.cmbGiderPersonel.Location = new System.Drawing.Point(101, 43);
            this.cmbGiderPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGiderPersonel.Name = "cmbGiderPersonel";
            this.cmbGiderPersonel.Size = new System.Drawing.Size(153, 25);
            this.cmbGiderPersonel.TabIndex = 1;
            this.cmbGiderPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbGiderPersonel_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(5, 81);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 17);
            this.label33.TabIndex = 147;
            this.label33.Text = "Kalan Maaş:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(23, 46);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 17);
            this.label31.TabIndex = 146;
            this.label31.Text = "Personel:";
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
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.btnYazdir);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.btnListele);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 562);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 148;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPersonelAdiFiltre);
            this.panel6.Controls.Add(this.btnUrunGrubuFiltreleme);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(841, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 153);
            this.panel6.TabIndex = 162;
            // 
            // txtPersonelAdiFiltre
            // 
            this.txtPersonelAdiFiltre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdiFiltre.Location = new System.Drawing.Point(15, 43);
            this.txtPersonelAdiFiltre.Name = "txtPersonelAdiFiltre";
            this.txtPersonelAdiFiltre.Size = new System.Drawing.Size(174, 25);
            this.txtPersonelAdiFiltre.TabIndex = 22;
            // 
            // btnUrunGrubuFiltreleme
            // 
            this.btnUrunGrubuFiltreleme.BackColor = System.Drawing.Color.Transparent;
            this.btnUrunGrubuFiltreleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunGrubuFiltreleme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGrubuFiltreleme.Location = new System.Drawing.Point(15, 106);
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
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Personel";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.BtnFiltrele);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dateTimePicker3);
            this.panel4.Location = new System.Drawing.Point(584, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 153);
            this.panel4.TabIndex = 161;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(105, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarih";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYazdir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(895, 192);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(118, 25);
            this.btnYazdir.TabIndex = 160;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtToplamAlinanAvans);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 45);
            this.panel5.TabIndex = 159;
            // 
            // txtToplamAlinanAvans
            // 
            this.txtToplamAlinanAvans.Location = new System.Drawing.Point(106, 6);
            this.txtToplamAlinanAvans.Name = "txtToplamAlinanAvans";
            this.txtToplamAlinanAvans.Size = new System.Drawing.Size(149, 25);
            this.txtToplamAlinanAvans.TabIndex = 7;
            this.txtToplamAlinanAvans.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 155;
            this.label2.Text = "Avans Toplam:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAciklama);
            this.panel3.Location = new System.Drawing.Point(288, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 47);
            this.panel3.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 156;
            this.label4.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(106, 11);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(169, 25);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaasArttir);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSonuç);
            this.panel2.Controls.Add(this.txtSonuc);
            this.panel2.Controls.Add(this.txtAvans);
            this.panel2.Controls.Add(this.btnHesapla);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(288, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 166);
            this.panel2.TabIndex = 156;
            // 
            // txtMaasArttir
            // 
            this.txtMaasArttir.Location = new System.Drawing.Point(90, 46);
            this.txtMaasArttir.Name = "txtMaasArttir";
            this.txtMaasArttir.Size = new System.Drawing.Size(169, 25);
            this.txtMaasArttir.TabIndex = 4;
            this.txtMaasArttir.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 155;
            this.label3.Text = "Maaş Arttır:";
            // 
            // lblSonuç
            // 
            this.lblSonuç.AutoSize = true;
            this.lblSonuç.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuç.Location = new System.Drawing.Point(20, 116);
            this.lblSonuç.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuç.Name = "lblSonuç";
            this.lblSonuç.Size = new System.Drawing.Size(54, 17);
            this.lblSonuç.TabIndex = 152;
            this.lblSonuç.Text = "Sonuç:";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(90, 113);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(169, 25);
            this.txtSonuc.TabIndex = 6;
            // 
            // txtAvans
            // 
            this.txtAvans.Location = new System.Drawing.Point(89, 10);
            this.txtAvans.Name = "txtAvans";
            this.txtAvans.Size = new System.Drawing.Size(170, 25);
            this.txtAvans.TabIndex = 3;
            this.txtAvans.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapla.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(89, 78);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(170, 25);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 149;
            this.label1.Text = "Avans:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(624, 192);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 25);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(759, 192);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(118, 25);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmbPersonelKalanMaas);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.cmbGiderPersonel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 165);
            this.panel1.TabIndex = 148;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(45, 17);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(43, 17);
            this.lblTarih.TabIndex = 153;
            this.lblTarih.Text = "Tarih:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 319);
            this.dataGridView1.TabIndex = 98;
            // 
            // FrmPersonelMaasHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 562);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonelMaasHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Hareket Paneli";
            this.Load += new System.EventHandler(this.FrmPersonelMaasHareket_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonelKalanMaas;
        private System.Windows.Forms.ComboBox cmbGiderPersonel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvans;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSonuç;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtToplamAlinanAvans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaasArttir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPersonelAdiFiltre;
        private System.Windows.Forms.Button btnUrunGrubuFiltreleme;
        private System.Windows.Forms.Label label9;
    }
}