namespace Sayac_Proje
{
    partial class frmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.dtPosTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZiraat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtVakif = new System.Windows.Forms.TextBox();
            this.txtPosToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYapiKredi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQnb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGaranti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHalk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblZiraat = new System.Windows.Forms.Label();
            this.lblVakif = new System.Windows.Forms.Label();
            this.lblYapi = new System.Windows.Forms.Label();
            this.lblQnb = new System.Windows.Forms.Label();
            this.lblGaranti = new System.Windows.Forms.Label();
            this.lblIsToplam = new System.Windows.Forms.Label();
            this.lblHalkToplam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnTemizle);
            this.splitContainer1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblZiraat);
            this.splitContainer1.Panel2.Controls.Add(this.lblVakif);
            this.splitContainer1.Panel2.Controls.Add(this.lblYapi);
            this.splitContainer1.Panel2.Controls.Add(this.lblQnb);
            this.splitContainer1.Panel2.Controls.Add(this.lblGaranti);
            this.splitContainer1.Panel2.Controls.Add(this.lblIsToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblHalkToplam);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 633);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(629, 187);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 66);
            this.btnTemizle.TabIndex = 50;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(999, 10);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(106, 66);
            this.btnFiltrele.TabIndex = 49;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(667, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 48;
            this.label16.Text = "Tarih Bitiş:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(634, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Tarih Başlangıç:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(752, 51);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(239, 25);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 10);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 25);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListele);
            this.panel1.Controls.Add(this.dtPosTarih);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtZiraat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnHesapla);
            this.panel1.Controls.Add(this.txtVakif);
            this.panel1.Controls.Add(this.txtPosToplam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtYapiKredi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQnb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtGaranti);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtIs);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtHalk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 241);
            this.panel1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(469, 190);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(89, 31);
            this.btnListele.TabIndex = 137;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtPosTarih
            // 
            this.dtPosTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPosTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPosTarih.Location = new System.Drawing.Point(357, 40);
            this.dtPosTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtPosTarih.Name = "dtPosTarih";
            this.dtPosTarih.Size = new System.Drawing.Size(220, 24);
            this.dtPosTarih.TabIndex = 138;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(357, 190);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 31);
            this.btnKaydet.TabIndex = 136;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 139;
            this.label4.Text = "Tarih:";
            // 
            // txtZiraat
            // 
            this.txtZiraat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZiraat.Location = new System.Drawing.Point(126, 199);
            this.txtZiraat.Margin = new System.Windows.Forms.Padding(4);
            this.txtZiraat.Name = "txtZiraat";
            this.txtZiraat.Size = new System.Drawing.Size(194, 25);
            this.txtZiraat.TabIndex = 136;
            this.txtZiraat.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 137;
            this.label3.Text = "Ziraat:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHesapla.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(427, 78);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 33);
            this.btnHesapla.TabIndex = 127;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtVakif
            // 
            this.txtVakif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVakif.Location = new System.Drawing.Point(126, 166);
            this.txtVakif.Margin = new System.Windows.Forms.Padding(4);
            this.txtVakif.Name = "txtVakif";
            this.txtVakif.Size = new System.Drawing.Size(194, 25);
            this.txtVakif.TabIndex = 134;
            this.txtVakif.Text = "0";
            // 
            // txtPosToplam
            // 
            this.txtPosToplam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPosToplam.Location = new System.Drawing.Point(399, 140);
            this.txtPosToplam.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosToplam.Name = "txtPosToplam";
            this.txtPosToplam.Size = new System.Drawing.Size(178, 25);
            this.txtPosToplam.TabIndex = 126;
            this.txtPosToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 135;
            this.label2.Text = "Vakıfbank:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(337, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 132;
            this.label12.Text = "Toplam";
            // 
            // txtYapiKredi
            // 
            this.txtYapiKredi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYapiKredi.Location = new System.Drawing.Point(126, 136);
            this.txtYapiKredi.Margin = new System.Windows.Forms.Padding(4);
            this.txtYapiKredi.Name = "txtYapiKredi";
            this.txtYapiKredi.Size = new System.Drawing.Size(194, 25);
            this.txtYapiKredi.TabIndex = 132;
            this.txtYapiKredi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 133;
            this.label1.Text = "Yapı Kredi:";
            // 
            // txtQnb
            // 
            this.txtQnb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQnb.Location = new System.Drawing.Point(126, 106);
            this.txtQnb.Margin = new System.Windows.Forms.Padding(4);
            this.txtQnb.Name = "txtQnb";
            this.txtQnb.Size = new System.Drawing.Size(194, 25);
            this.txtQnb.TabIndex = 125;
            this.txtQnb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 131;
            this.label9.Text = "QNB Finans:";
            // 
            // txtGaranti
            // 
            this.txtGaranti.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGaranti.Location = new System.Drawing.Point(126, 76);
            this.txtGaranti.Margin = new System.Windows.Forms.Padding(4);
            this.txtGaranti.Name = "txtGaranti";
            this.txtGaranti.Size = new System.Drawing.Size(194, 25);
            this.txtGaranti.TabIndex = 124;
            this.txtGaranti.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(43, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 130;
            this.label8.Text = "Garanti:";
            // 
            // txtIs
            // 
            this.txtIs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIs.Location = new System.Drawing.Point(126, 46);
            this.txtIs.Margin = new System.Windows.Forms.Padding(4);
            this.txtIs.Name = "txtIs";
            this.txtIs.Size = new System.Drawing.Size(194, 25);
            this.txtIs.TabIndex = 123;
            this.txtIs.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 129;
            this.label6.Text = "İş Bankası:";
            // 
            // txtHalk
            // 
            this.txtHalk.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHalk.Location = new System.Drawing.Point(126, 16);
            this.txtHalk.Margin = new System.Windows.Forms.Padding(4);
            this.txtHalk.Name = "txtHalk";
            this.txtHalk.Size = new System.Drawing.Size(194, 25);
            this.txtHalk.TabIndex = 122;
            this.txtHalk.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 128;
            this.label5.Text = "HalkBank:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(997, 285);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(17, 17);
            this.lblToplam.TabIndex = 147;
            this.lblToplam.Text = "X";
            // 
            // lblZiraat
            // 
            this.lblZiraat.AutoSize = true;
            this.lblZiraat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraat.Location = new System.Drawing.Point(891, 285);
            this.lblZiraat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZiraat.Name = "lblZiraat";
            this.lblZiraat.Size = new System.Drawing.Size(17, 17);
            this.lblZiraat.TabIndex = 146;
            this.lblZiraat.Text = "X";
            // 
            // lblVakif
            // 
            this.lblVakif.AutoSize = true;
            this.lblVakif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVakif.Location = new System.Drawing.Point(788, 285);
            this.lblVakif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVakif.Name = "lblVakif";
            this.lblVakif.Size = new System.Drawing.Size(17, 17);
            this.lblVakif.TabIndex = 145;
            this.lblVakif.Text = "X";
            // 
            // lblYapi
            // 
            this.lblYapi.AutoSize = true;
            this.lblYapi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapi.Location = new System.Drawing.Point(667, 285);
            this.lblYapi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYapi.Name = "lblYapi";
            this.lblYapi.Size = new System.Drawing.Size(17, 17);
            this.lblYapi.TabIndex = 144;
            this.lblYapi.Text = "X";
            // 
            // lblQnb
            // 
            this.lblQnb.AutoSize = true;
            this.lblQnb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQnb.Location = new System.Drawing.Point(553, 285);
            this.lblQnb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQnb.Name = "lblQnb";
            this.lblQnb.Size = new System.Drawing.Size(17, 17);
            this.lblQnb.TabIndex = 143;
            this.lblQnb.Text = "X";
            // 
            // lblGaranti
            // 
            this.lblGaranti.AutoSize = true;
            this.lblGaranti.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGaranti.Location = new System.Drawing.Point(441, 285);
            this.lblGaranti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGaranti.Name = "lblGaranti";
            this.lblGaranti.Size = new System.Drawing.Size(17, 17);
            this.lblGaranti.TabIndex = 142;
            this.lblGaranti.Text = "X";
            // 
            // lblIsToplam
            // 
            this.lblIsToplam.AutoSize = true;
            this.lblIsToplam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsToplam.Location = new System.Drawing.Point(315, 285);
            this.lblIsToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsToplam.Name = "lblIsToplam";
            this.lblIsToplam.Size = new System.Drawing.Size(17, 17);
            this.lblIsToplam.TabIndex = 141;
            this.lblIsToplam.Text = "X";
            // 
            // lblHalkToplam
            // 
            this.lblHalkToplam.AutoSize = true;
            this.lblHalkToplam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHalkToplam.Location = new System.Drawing.Point(203, 285);
            this.lblHalkToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHalkToplam.Name = "lblHalkToplam";
            this.lblHalkToplam.Size = new System.Drawing.Size(17, 17);
            this.lblHalkToplam.TabIndex = 140;
            this.lblHalkToplam.Text = "X";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 258);
            this.dataGridView1.TabIndex = 100;
            // 
            // frmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1168, 633);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pos Paneli";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtVakif;
        private System.Windows.Forms.TextBox txtPosToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYapiKredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQnb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGaranti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHalk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZiraat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPosTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIsToplam;
        private System.Windows.Forms.Label lblHalkToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblZiraat;
        private System.Windows.Forms.Label lblVakif;
        private System.Windows.Forms.Label lblYapi;
        private System.Windows.Forms.Label lblQnb;
        private System.Windows.Forms.Label lblGaranti;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTemizle;
    }
}