namespace Sayac_Proje
{
    partial class FrmYikamaTumunuListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYikamaTumunuListele));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGorListele = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.lblGiderToplam = new System.Windows.Forms.Label();
            this.lblTahsilatToplam = new System.Windows.Forms.Label();
            this.lblVeresiyeToplam = new System.Windows.Forms.Label();
            this.lblKartToplam = new System.Windows.Forms.Label();
            this.lblNakitToplam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGorListele);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblGenelToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblGiderToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblTahsilatToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblVeresiyeToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblKartToplam);
            this.splitContainer1.Panel2.Controls.Add(this.lblNakitToplam);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1316, 568);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(1111, 32);
            this.btnFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(104, 25);
            this.btnFiltrele.TabIndex = 55;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(870, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 54;
            this.label16.Text = "Tarih Bitiş:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(598, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Tarih Başlangıç:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(952, 32);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 25);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(716, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 25);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // btnGorListele
            // 
            this.btnGorListele.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGorListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGorListele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorListele.ForeColor = System.Drawing.Color.White;
            this.btnGorListele.Location = new System.Drawing.Point(151, 32);
            this.btnGorListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnGorListele.Name = "btnGorListele";
            this.btnGorListele.Size = new System.Drawing.Size(104, 25);
            this.btnGorListele.TabIndex = 50;
            this.btnGorListele.Text = "Listele";
            this.btnGorListele.UseVisualStyleBackColor = false;
            this.btnGorListele.Click += new System.EventHandler(this.btnGorListele_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(445, 377);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(15, 17);
            this.lblGenelToplam.TabIndex = 31;
            this.lblGenelToplam.Text = "x";
            // 
            // lblGiderToplam
            // 
            this.lblGiderToplam.AutoSize = true;
            this.lblGiderToplam.Location = new System.Drawing.Point(445, 340);
            this.lblGiderToplam.Name = "lblGiderToplam";
            this.lblGiderToplam.Size = new System.Drawing.Size(15, 17);
            this.lblGiderToplam.TabIndex = 30;
            this.lblGiderToplam.Text = "x";
            // 
            // lblTahsilatToplam
            // 
            this.lblTahsilatToplam.AutoSize = true;
            this.lblTahsilatToplam.Location = new System.Drawing.Point(140, 430);
            this.lblTahsilatToplam.Name = "lblTahsilatToplam";
            this.lblTahsilatToplam.Size = new System.Drawing.Size(15, 17);
            this.lblTahsilatToplam.TabIndex = 28;
            this.lblTahsilatToplam.Text = "x";
            // 
            // lblVeresiyeToplam
            // 
            this.lblVeresiyeToplam.AutoSize = true;
            this.lblVeresiyeToplam.Location = new System.Drawing.Point(140, 398);
            this.lblVeresiyeToplam.Name = "lblVeresiyeToplam";
            this.lblVeresiyeToplam.Size = new System.Drawing.Size(15, 17);
            this.lblVeresiyeToplam.TabIndex = 27;
            this.lblVeresiyeToplam.Text = "x";
            // 
            // lblKartToplam
            // 
            this.lblKartToplam.AutoSize = true;
            this.lblKartToplam.Location = new System.Drawing.Point(140, 372);
            this.lblKartToplam.Name = "lblKartToplam";
            this.lblKartToplam.Size = new System.Drawing.Size(15, 17);
            this.lblKartToplam.TabIndex = 26;
            this.lblKartToplam.Text = "x";
            // 
            // lblNakitToplam
            // 
            this.lblNakitToplam.AutoSize = true;
            this.lblNakitToplam.Location = new System.Drawing.Point(140, 340);
            this.lblNakitToplam.Name = "lblNakitToplam";
            this.lblNakitToplam.Size = new System.Drawing.Size(15, 17);
            this.lblNakitToplam.TabIndex = 25;
            this.lblNakitToplam.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Genel Toplam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gider Toplam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tahsilat Toplam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Veresiye Toplam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kart Toplam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nakit Toplam:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1280, 148);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 148);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmYikamaTumunuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 568);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYikamaTumunuListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yıkama Kasası Tüm Veriler Paneli";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGorListele;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label lblGiderToplam;
        private System.Windows.Forms.Label lblTahsilatToplam;
        private System.Windows.Forms.Label lblVeresiyeToplam;
        private System.Windows.Forms.Label lblKartToplam;
        private System.Windows.Forms.Label lblNakitToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}