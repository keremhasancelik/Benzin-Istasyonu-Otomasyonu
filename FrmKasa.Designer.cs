namespace Sayac_Proje
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnYikama = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnCadir = new System.Windows.Forms.Button();
            this.btnYakit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnYikama, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMarket, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCadir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnYakit, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnYikama
            // 
            this.btnYikama.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnYikama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYikama.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYikama.Location = new System.Drawing.Point(451, 3);
            this.btnYikama.Name = "btnYikama";
            this.btnYikama.Size = new System.Drawing.Size(218, 152);
            this.btnYikama.TabIndex = 2;
            this.btnYikama.Text = "YIKAMA\r\nKASASI";
            this.btnYikama.UseVisualStyleBackColor = false;
            this.btnYikama.Click += new System.EventHandler(this.btnYikama_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMarket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarket.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarket.Location = new System.Drawing.Point(227, 3);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(218, 152);
            this.btnMarket.TabIndex = 1;
            this.btnMarket.Text = "MARKET\r\nKASASI";
            this.btnMarket.UseVisualStyleBackColor = false;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnCadir
            // 
            this.btnCadir.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnCadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadir.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCadir.Location = new System.Drawing.Point(675, 3);
            this.btnCadir.Name = "btnCadir";
            this.btnCadir.Size = new System.Drawing.Size(218, 152);
            this.btnCadir.TabIndex = 3;
            this.btnCadir.Text = "RESTAURANT\r\nKASASI";
            this.btnCadir.UseVisualStyleBackColor = false;
            this.btnCadir.Click += new System.EventHandler(this.btnCadir_Click);
            // 
            // btnYakit
            // 
            this.btnYakit.BackColor = System.Drawing.Color.IndianRed;
            this.btnYakit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYakit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYakit.Location = new System.Drawing.Point(3, 3);
            this.btnYakit.Name = "btnYakit";
            this.btnYakit.Size = new System.Drawing.Size(218, 152);
            this.btnYakit.TabIndex = 0;
            this.btnYakit.Text = "YAKIT\r\nKASASI";
            this.btnYakit.UseVisualStyleBackColor = false;
            this.btnYakit.Click += new System.EventHandler(this.btnYakit_Click);
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Paneli";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadir;
        private System.Windows.Forms.Button btnYikama;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnYakit;
    }
}