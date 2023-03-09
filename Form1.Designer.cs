namespace Sayac_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtAcilis = new System.Windows.Forms.TextBox();
            this.TxtKapanis = new System.Windows.Forms.TextBox();
            this.LblSayacId = new System.Windows.Forms.Label();
            this.LblUrun = new System.Windows.Forms.Label();
            this.LblPompa = new System.Windows.Forms.Label();
            this.LblBirimFiyati = new System.Windows.Forms.Label();
            this.LblAcilis = new System.Windows.Forms.Label();
            this.LblKapanis = new System.Windows.Forms.Label();
            this.LblSatilanLitre = new System.Windows.Forms.Label();
            this.TxtSatilanLitre = new System.Windows.Forms.TextBox();
            this.LblTutar = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.TxtSayacID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTarih = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFiltrele = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.BtnUrunler = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnTedarikciler = new System.Windows.Forms.Button();
            this.BtnRaporlar = new System.Windows.Forms.Button();
            this.BtnPompa = new System.Windows.Forms.Button();
            this.BtnAlis = new System.Windows.Forms.Button();
            this.BtnGider = new System.Windows.Forms.Button();
            this.BtnFaturalar = new System.Windows.Forms.Button();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.CmbBFiyati = new System.Windows.Forms.ComboBox();
            this.CmbPompa = new System.Windows.Forms.ComboBox();
            this.CmbStok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.db_SayacDataSet = new Sayac_Proje.Db_SayacDataSet();
            this.dbSayacDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnPrintt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtToplamTutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtToplamLitre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblBenzinTopLitre = new System.Windows.Forms.Label();
            this.LblBenzinTopTutar = new System.Windows.Forms.Label();
            this.LblMotorinTopTutar = new System.Windows.Forms.Label();
            this.LblMotorinTopLitre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblLpgTopTutar = new System.Windows.Forms.Label();
            this.LblLpgTopLitre = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnKurlar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblGelir = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblGider = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_SayacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSayacDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAcilis
            // 
            this.TxtAcilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAcilis.Location = new System.Drawing.Point(501, 49);
            this.TxtAcilis.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAcilis.Name = "TxtAcilis";
            this.TxtAcilis.Size = new System.Drawing.Size(131, 30);
            this.TxtAcilis.TabIndex = 4;
            this.TxtAcilis.Text = "0";
            // 
            // TxtKapanis
            // 
            this.TxtKapanis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKapanis.Location = new System.Drawing.Point(641, 49);
            this.TxtKapanis.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKapanis.Name = "TxtKapanis";
            this.TxtKapanis.Size = new System.Drawing.Size(131, 30);
            this.TxtKapanis.TabIndex = 5;
            this.TxtKapanis.Text = "0";
            // 
            // LblSayacId
            // 
            this.LblSayacId.AutoSize = true;
            this.LblSayacId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSayacId.Location = new System.Drawing.Point(27, 21);
            this.LblSayacId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSayacId.Name = "LblSayacId";
            this.LblSayacId.Size = new System.Drawing.Size(26, 20);
            this.LblSayacId.TabIndex = 5;
            this.LblSayacId.Text = "ID";
            // 
            // LblUrun
            // 
            this.LblUrun.AutoSize = true;
            this.LblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrun.Location = new System.Drawing.Point(121, 21);
            this.LblUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUrun.Name = "LblUrun";
            this.LblUrun.Size = new System.Drawing.Size(57, 20);
            this.LblUrun.TabIndex = 6;
            this.LblUrun.Text = "ÜRÜN";
            // 
            // LblPompa
            // 
            this.LblPompa.AutoSize = true;
            this.LblPompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPompa.Location = new System.Drawing.Point(243, 21);
            this.LblPompa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPompa.Name = "LblPompa";
            this.LblPompa.Size = new System.Drawing.Size(69, 20);
            this.LblPompa.TabIndex = 7;
            this.LblPompa.Text = "POMPA";
            // 
            // LblBirimFiyati
            // 
            this.LblBirimFiyati.AutoSize = true;
            this.LblBirimFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBirimFiyati.Location = new System.Drawing.Point(371, 21);
            this.LblBirimFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBirimFiyati.Name = "LblBirimFiyati";
            this.LblBirimFiyati.Size = new System.Drawing.Size(109, 20);
            this.LblBirimFiyati.TabIndex = 8;
            this.LblBirimFiyati.Text = "BİRİM FİYATI";
            // 
            // LblAcilis
            // 
            this.LblAcilis.AutoSize = true;
            this.LblAcilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAcilis.Location = new System.Drawing.Point(540, 21);
            this.LblAcilis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAcilis.Name = "LblAcilis";
            this.LblAcilis.Size = new System.Drawing.Size(61, 20);
            this.LblAcilis.TabIndex = 9;
            this.LblAcilis.Text = "AÇILIŞ";
            // 
            // LblKapanis
            // 
            this.LblKapanis.AutoSize = true;
            this.LblKapanis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKapanis.Location = new System.Drawing.Point(676, 21);
            this.LblKapanis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKapanis.Name = "LblKapanis";
            this.LblKapanis.Size = new System.Drawing.Size(80, 20);
            this.LblKapanis.TabIndex = 10;
            this.LblKapanis.Text = "KAPANIŞ";
            // 
            // LblSatilanLitre
            // 
            this.LblSatilanLitre.AutoSize = true;
            this.LblSatilanLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSatilanLitre.Location = new System.Drawing.Point(916, 21);
            this.LblSatilanLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSatilanLitre.Name = "LblSatilanLitre";
            this.LblSatilanLitre.Size = new System.Drawing.Size(130, 20);
            this.LblSatilanLitre.TabIndex = 12;
            this.LblSatilanLitre.Text = "SATILAN LİTRE";
            // 
            // TxtSatilanLitre
            // 
            this.TxtSatilanLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatilanLitre.Location = new System.Drawing.Point(920, 50);
            this.TxtSatilanLitre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSatilanLitre.Name = "TxtSatilanLitre";
            this.TxtSatilanLitre.Size = new System.Drawing.Size(131, 30);
            this.TxtSatilanLitre.TabIndex = 7;
            // 
            // LblTutar
            // 
            this.LblTutar.AutoSize = true;
            this.LblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTutar.Location = new System.Drawing.Point(1075, 21);
            this.LblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(111, 20);
            this.LblTutar.TabIndex = 14;
            this.LblTutar.Text = "TUTAR ( TL )";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Location = new System.Drawing.Point(1060, 50);
            this.TxtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(131, 30);
            this.TxtTutar.TabIndex = 8;
            // 
            // TxtSayacID
            // 
            this.TxtSayacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSayacID.Location = new System.Drawing.Point(11, 49);
            this.TxtSayacID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSayacID.Name = "TxtSayacID";
            this.TxtSayacID.Size = new System.Drawing.Size(63, 30);
            this.TxtSayacID.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1294, 423);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.Location = new System.Drawing.Point(1357, 388);
            this.LblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(57, 23);
            this.LblTarih.TabIndex = 17;
            this.LblTarih.Text = "Tarih";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(1393, 243);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(119, 38);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.Location = new System.Drawing.Point(1393, 197);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnListele.Size = new System.Drawing.Size(119, 38);
            this.BtnListele.TabIndex = 13;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(1263, 243);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(119, 38);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(1263, 197);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(119, 38);
            this.BtnEkle.TabIndex = 11;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 242);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.BackColor = System.Drawing.Color.Transparent;
            this.BtnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFiltrele.Location = new System.Drawing.Point(1329, 524);
            this.BtnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFiltrele.Size = new System.Drawing.Size(119, 38);
            this.BtnFiltrele.TabIndex = 20;
            this.BtnFiltrele.Text = "Filtrele";
            this.BtnFiltrele.UseVisualStyleBackColor = false;
            this.BtnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(1294, 472);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 29);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.BackColor = System.Drawing.Color.Transparent;
            this.BtnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYazdir.Location = new System.Drawing.Point(1263, 333);
            this.BtnYazdir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnYazdir.Size = new System.Drawing.Size(249, 38);
            this.BtnYazdir.TabIndex = 17;
            this.BtnYazdir.Text = "Temizle";
            this.BtnYazdir.UseVisualStyleBackColor = false;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.BackColor = System.Drawing.Color.Green;
            this.BtnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUrunler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunler.Location = new System.Drawing.Point(632, 447);
            this.BtnUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(96, 60);
            this.BtnUrunler.TabIndex = 27;
            this.BtnUrunler.Text = "ÜRÜN";
            this.BtnUrunler.UseVisualStyleBackColor = false;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.Location = new System.Drawing.Point(211, 447);
            this.BtnMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(203, 60);
            this.BtnMusteriler.TabIndex = 22;
            this.BtnMusteriler.Text = "CARİLER";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(421, 514);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 60);
            this.button3.TabIndex = 26;
            this.button3.Text = "PERSONEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnTedarikciler
            // 
            this.BtnTedarikciler.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnTedarikciler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTedarikciler.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTedarikciler.Location = new System.Drawing.Point(209, 514);
            this.BtnTedarikciler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTedarikciler.Name = "BtnTedarikciler";
            this.BtnTedarikciler.Size = new System.Drawing.Size(203, 60);
            this.BtnTedarikciler.TabIndex = 24;
            this.BtnTedarikciler.Text = "TEDARİKÇİLER";
            this.BtnTedarikciler.UseVisualStyleBackColor = false;
            this.BtnTedarikciler.Click += new System.EventHandler(this.BtnTedarikciler_Click);
            // 
            // BtnRaporlar
            // 
            this.BtnRaporlar.BackColor = System.Drawing.Color.HotPink;
            this.BtnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRaporlar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporlar.Location = new System.Drawing.Point(1044, 447);
            this.BtnRaporlar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRaporlar.Name = "BtnRaporlar";
            this.BtnRaporlar.Size = new System.Drawing.Size(214, 60);
            this.BtnRaporlar.TabIndex = 33;
            this.BtnRaporlar.Text = "RAPORLAR";
            this.BtnRaporlar.UseVisualStyleBackColor = false;
            this.BtnRaporlar.Click += new System.EventHandler(this.BtnRaporlar_Click);
            // 
            // BtnPompa
            // 
            this.BtnPompa.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnPompa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPompa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPompa.Location = new System.Drawing.Point(735, 447);
            this.BtnPompa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPompa.Name = "BtnPompa";
            this.BtnPompa.Size = new System.Drawing.Size(100, 60);
            this.BtnPompa.TabIndex = 29;
            this.BtnPompa.Text = "POMPA";
            this.BtnPompa.UseVisualStyleBackColor = false;
            this.BtnPompa.Click += new System.EventHandler(this.BtnPompa_Click);
            // 
            // BtnAlis
            // 
            this.BtnAlis.BackColor = System.Drawing.Color.Yellow;
            this.BtnAlis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAlis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlis.Location = new System.Drawing.Point(3, 514);
            this.BtnAlis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlis.Name = "BtnAlis";
            this.BtnAlis.Size = new System.Drawing.Size(203, 60);
            this.BtnAlis.TabIndex = 23;
            this.BtnAlis.Text = "ALIŞ";
            this.BtnAlis.UseVisualStyleBackColor = false;
            this.BtnAlis.Click += new System.EventHandler(this.BtnAlis_Click);
            // 
            // BtnGider
            // 
            this.BtnGider.BackColor = System.Drawing.Color.Orchid;
            this.BtnGider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGider.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGider.Location = new System.Drawing.Point(735, 514);
            this.BtnGider.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGider.Name = "BtnGider";
            this.BtnGider.Size = new System.Drawing.Size(100, 60);
            this.BtnGider.TabIndex = 30;
            this.BtnGider.Text = "GİDER";
            this.BtnGider.UseVisualStyleBackColor = false;
            this.BtnGider.Click += new System.EventHandler(this.BtnGider_Click);
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.BackColor = System.Drawing.Color.Pink;
            this.BtnFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFaturalar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFaturalar.Location = new System.Drawing.Point(421, 447);
            this.BtnFaturalar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFaturalar.Name = "BtnFaturalar";
            this.BtnFaturalar.Size = new System.Drawing.Size(203, 60);
            this.BtnFaturalar.TabIndex = 25;
            this.BtnFaturalar.Text = "FATURALAR";
            this.BtnFaturalar.UseVisualStyleBackColor = false;
            this.BtnFaturalar.Click += new System.EventHandler(this.BtnFaturalar_Click);
            // 
            // CmbUrun
            // 
            this.CmbUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(83, 49);
            this.CmbUrun.Margin = new System.Windows.Forms.Padding(4);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(129, 32);
            this.CmbUrun.TabIndex = 1;
            this.CmbUrun.SelectedIndexChanged += new System.EventHandler(this.CmbUrun_SelectedIndexChanged);
            // 
            // CmbBFiyati
            // 
            this.CmbBFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBFiyati.FormattingEnabled = true;
            this.CmbBFiyati.ItemHeight = 24;
            this.CmbBFiyati.Location = new System.Drawing.Point(361, 50);
            this.CmbBFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBFiyati.Name = "CmbBFiyati";
            this.CmbBFiyati.Size = new System.Drawing.Size(129, 32);
            this.CmbBFiyati.TabIndex = 37;
            this.CmbBFiyati.SelectedIndexChanged += new System.EventHandler(this.CmbBFiyati_SelectedIndexChanged);
            // 
            // CmbPompa
            // 
            this.CmbPompa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbPompa.FormattingEnabled = true;
            this.CmbPompa.ItemHeight = 24;
            this.CmbPompa.Location = new System.Drawing.Point(223, 49);
            this.CmbPompa.Margin = new System.Windows.Forms.Padding(4);
            this.CmbPompa.Name = "CmbPompa";
            this.CmbPompa.Size = new System.Drawing.Size(129, 32);
            this.CmbPompa.TabIndex = 38;
            // 
            // CmbStok
            // 
            this.CmbStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbStok.FormattingEnabled = true;
            this.CmbStok.Location = new System.Drawing.Point(781, 49);
            this.CmbStok.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStok.Name = "CmbStok";
            this.CmbStok.Size = new System.Drawing.Size(129, 32);
            this.CmbStok.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(816, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "STOK";
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPrint.Location = new System.Drawing.Point(1263, 288);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrint.Size = new System.Drawing.Size(119, 38);
            this.BtnPrint.TabIndex = 15;
            this.BtnPrint.Text = "Yazdır";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // db_SayacDataSet
            // 
            this.db_SayacDataSet.DataSetName = "Db_SayacDataSet";
            this.db_SayacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSayacDataSetBindingSource
            // 
            this.dbSayacDataSetBindingSource.DataSource = this.db_SayacDataSet;
            this.dbSayacDataSetBindingSource.Position = 0;
            this.dbSayacDataSetBindingSource.CurrentChanged += new System.EventHandler(this.dbSayacDataSetBindingSource_CurrentChanged);
            // 
            // BtnPrintt
            // 
            this.BtnPrintt.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrintt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrintt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPrintt.Location = new System.Drawing.Point(1393, 288);
            this.BtnPrintt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrintt.Name = "BtnPrintt";
            this.BtnPrintt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrintt.Size = new System.Drawing.Size(119, 38);
            this.BtnPrintt.TabIndex = 16;
            this.BtnPrintt.Text = "Ön İzleme";
            this.BtnPrintt.UseVisualStyleBackColor = false;
            this.BtnPrintt.Click += new System.EventHandler(this.BtnPrintt_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1348, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "TOP. TUTAR ( TL )";
            // 
            // TxtToplamTutar
            // 
            this.TxtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplamTutar.Location = new System.Drawing.Point(1345, 50);
            this.TxtToplamTutar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtToplamTutar.Name = "TxtToplamTutar";
            this.TxtToplamTutar.Size = new System.Drawing.Size(156, 30);
            this.TxtToplamTutar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1196, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "TOP. SAT. LİTRE";
            // 
            // TxtToplamLitre
            // 
            this.TxtToplamLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplamLitre.Location = new System.Drawing.Point(1205, 50);
            this.TxtToplamLitre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtToplamLitre.Name = "TxtToplamLitre";
            this.TxtToplamLitre.Size = new System.Drawing.Size(131, 30);
            this.TxtToplamLitre.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(631, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 28;
            this.button1.Text = "GELİR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "BENZİN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "TOP. SAT. LİTRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(168, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "TOP. TUTAR";
            // 
            // LblBenzinTopLitre
            // 
            this.LblBenzinTopLitre.AutoSize = true;
            this.LblBenzinTopLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBenzinTopLitre.Location = new System.Drawing.Point(43, 75);
            this.LblBenzinTopLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBenzinTopLitre.Name = "LblBenzinTopLitre";
            this.LblBenzinTopLitre.Size = new System.Drawing.Size(40, 20);
            this.LblBenzinTopLitre.TabIndex = 51;
            this.LblBenzinTopLitre.Text = "0,00";
            // 
            // LblBenzinTopTutar
            // 
            this.LblBenzinTopTutar.AutoSize = true;
            this.LblBenzinTopTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBenzinTopTutar.Location = new System.Drawing.Point(191, 75);
            this.LblBenzinTopTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBenzinTopTutar.Name = "LblBenzinTopTutar";
            this.LblBenzinTopTutar.Size = new System.Drawing.Size(40, 20);
            this.LblBenzinTopTutar.TabIndex = 52;
            this.LblBenzinTopTutar.Text = "0,00";
            // 
            // LblMotorinTopTutar
            // 
            this.LblMotorinTopTutar.AutoSize = true;
            this.LblMotorinTopTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMotorinTopTutar.Location = new System.Drawing.Point(196, 75);
            this.LblMotorinTopTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMotorinTopTutar.Name = "LblMotorinTopTutar";
            this.LblMotorinTopTutar.Size = new System.Drawing.Size(40, 20);
            this.LblMotorinTopTutar.TabIndex = 57;
            this.LblMotorinTopTutar.Text = "0,00";
            // 
            // LblMotorinTopLitre
            // 
            this.LblMotorinTopLitre.AutoSize = true;
            this.LblMotorinTopLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMotorinTopLitre.Location = new System.Drawing.Point(48, 75);
            this.LblMotorinTopLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMotorinTopLitre.Name = "LblMotorinTopLitre";
            this.LblMotorinTopLitre.Size = new System.Drawing.Size(40, 20);
            this.LblMotorinTopLitre.TabIndex = 56;
            this.LblMotorinTopLitre.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(164, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "TOP. TUTAR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(5, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "TOP. SAT. LİTRE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(111, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "MOTORİN";
            // 
            // LblLpgTopTutar
            // 
            this.LblLpgTopTutar.AutoSize = true;
            this.LblLpgTopTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLpgTopTutar.Location = new System.Drawing.Point(199, 74);
            this.LblLpgTopTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLpgTopTutar.Name = "LblLpgTopTutar";
            this.LblLpgTopTutar.Size = new System.Drawing.Size(40, 20);
            this.LblLpgTopTutar.TabIndex = 62;
            this.LblLpgTopTutar.Text = "0,00";
            // 
            // LblLpgTopLitre
            // 
            this.LblLpgTopLitre.AutoSize = true;
            this.LblLpgTopLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblLpgTopLitre.Location = new System.Drawing.Point(51, 74);
            this.LblLpgTopLitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLpgTopLitre.Name = "LblLpgTopLitre";
            this.LblLpgTopLitre.Size = new System.Drawing.Size(40, 20);
            this.LblLpgTopLitre.TabIndex = 61;
            this.LblLpgTopLitre.Text = "0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(168, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "TOP. TUTAR";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(9, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 20);
            this.label17.TabIndex = 59;
            this.label17.Text = "TOP. SAT. LİTRE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(115, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 58;
            this.label18.Text = "LPG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.LblLpgTopTutar);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.LblLpgTopLitre);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(605, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(295, 103);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblMotorinTopTutar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.LblMotorinTopLitre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(309, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(288, 103);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblBenzinTopTutar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LblBenzinTopLitre);
            this.groupBox3.Location = new System.Drawing.Point(5, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(296, 103);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtToplamTutar);
            this.groupBox4.Controls.Add(this.TxtAcilis);
            this.groupBox4.Controls.Add(this.TxtKapanis);
            this.groupBox4.Controls.Add(this.LblSayacId);
            this.groupBox4.Controls.Add(this.LblUrun);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.LblPompa);
            this.groupBox4.Controls.Add(this.LblBirimFiyati);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.LblAcilis);
            this.groupBox4.Controls.Add(this.TxtToplamLitre);
            this.groupBox4.Controls.Add(this.LblKapanis);
            this.groupBox4.Controls.Add(this.TxtSatilanLitre);
            this.groupBox4.Controls.Add(this.LblSatilanLitre);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TxtTutar);
            this.groupBox4.Controls.Add(this.CmbStok);
            this.groupBox4.Controls.Add(this.LblTutar);
            this.groupBox4.Controls.Add(this.CmbPompa);
            this.groupBox4.Controls.Add(this.TxtSayacID);
            this.groupBox4.Controls.Add(this.CmbBFiyati);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1512, 89);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            // 
            // BtnKasa
            // 
            this.BtnKasa.BackColor = System.Drawing.Color.Crimson;
            this.BtnKasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKasa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKasa.Location = new System.Drawing.Point(837, 447);
            this.BtnKasa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(203, 60);
            this.BtnKasa.TabIndex = 31;
            this.BtnKasa.Text = "KASA";
            this.BtnKasa.UseVisualStyleBackColor = false;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnKurlar
            // 
            this.BtnKurlar.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnKurlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKurlar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKurlar.Location = new System.Drawing.Point(837, 514);
            this.BtnKurlar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKurlar.Name = "BtnKurlar";
            this.BtnKurlar.Size = new System.Drawing.Size(203, 60);
            this.BtnKurlar.TabIndex = 32;
            this.BtnKurlar.Text = "POS";
            this.BtnKurlar.UseVisualStyleBackColor = false;
            this.BtnKurlar.Click += new System.EventHandler(this.BtnKurlar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.LblGelir);
            this.groupBox5.Location = new System.Drawing.Point(908, 90);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(132, 103);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "GELİR";
            // 
            // LblGelir
            // 
            this.LblGelir.AutoSize = true;
            this.LblGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGelir.Location = new System.Drawing.Point(24, 74);
            this.LblGelir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGelir.Name = "LblGelir";
            this.LblGelir.Size = new System.Drawing.Size(40, 20);
            this.LblGelir.TabIndex = 62;
            this.LblGelir.Text = "0,00";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.LblGider);
            this.groupBox6.Location = new System.Drawing.Point(1048, 90);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(132, 103);
            this.groupBox6.TabIndex = 65;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "GİDER";
            // 
            // LblGider
            // 
            this.LblGider.AutoSize = true;
            this.LblGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGider.Location = new System.Drawing.Point(24, 74);
            this.LblGider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGider.Name = "LblGider";
            this.LblGider.Size = new System.Drawing.Size(40, 20);
            this.LblGider.TabIndex = 62;
            this.LblGider.Text = "0,00";
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.Green;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(5, 447);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(201, 60);
            this.btnSatis.TabIndex = 21;
            this.btnSatis.Text = "SATIŞ";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1044, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 60);
            this.button2.TabIndex = 67;
            this.button2.Text = "BUCKUP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(1162, 514);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 60);
            this.btnCikis.TabIndex = 68;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1520, 581);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnKurlar);
            this.Controls.Add(this.BtnKasa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPrintt);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnFaturalar);
            this.Controls.Add(this.BtnGider);
            this.Controls.Add(this.BtnAlis);
            this.Controls.Add(this.BtnRaporlar);
            this.Controls.Add(this.BtnPompa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnTedarikciler);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnUrunler);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.BtnFiltrele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_SayacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSayacDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAcilis;
        private System.Windows.Forms.TextBox TxtKapanis;
        private System.Windows.Forms.Label LblSayacId;
        private System.Windows.Forms.Label LblUrun;
        private System.Windows.Forms.Label LblPompa;
        private System.Windows.Forms.Label LblBirimFiyati;
        private System.Windows.Forms.Label LblAcilis;
        private System.Windows.Forms.Label LblKapanis;
        private System.Windows.Forms.Label LblSatilanLitre;
        private System.Windows.Forms.TextBox TxtSatilanLitre;
        private System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.TextBox TxtSayacID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnFiltrele;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Button BtnUrunler;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnTedarikciler;
        private System.Windows.Forms.Button BtnRaporlar;
        private System.Windows.Forms.Button BtnPompa;
        private System.Windows.Forms.Button BtnAlis;
        private System.Windows.Forms.Button BtnGider;
        private System.Windows.Forms.Button BtnFaturalar;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.ComboBox CmbBFiyati;
        private System.Windows.Forms.ComboBox CmbPompa;
        private System.Windows.Forms.ComboBox CmbStok;
        private System.Windows.Forms.Label label1;
        private Db_SayacDataSet db_SayacDataSet;
        private System.Windows.Forms.BindingSource dbSayacDataSetBindingSource;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnPrintt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtToplamTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtToplamLitre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblBenzinTopLitre;
        private System.Windows.Forms.Label LblBenzinTopTutar;
        private System.Windows.Forms.Label LblMotorinTopTutar;
        private System.Windows.Forms.Label LblMotorinTopLitre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblLpgTopTutar;
        private System.Windows.Forms.Label LblLpgTopLitre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnKurlar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblGelir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblGider;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCikis;
    }
}

