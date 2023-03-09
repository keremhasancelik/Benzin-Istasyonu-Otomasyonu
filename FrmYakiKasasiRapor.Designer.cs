namespace Sayac_Proje
{
    partial class FrmYakiKasasiRapor
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_SayacDataSet3 = new Sayac_Proje.Db_SayacDataSet3();
            this.tblYakitKasasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_YakitKasasiTableAdapter = new Sayac_Proje.Db_SayacDataSet3TableAdapters.Tbl_YakitKasasiTableAdapter();
            this.Tbl_YakitKasasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_SayacDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYakitKasasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_YakitKasasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sayac_Proje.rprYakitKasasiRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(883, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_SayacDataSet3
            // 
            this.db_SayacDataSet3.DataSetName = "Db_SayacDataSet3";
            this.db_SayacDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblYakitKasasiBindingSource
            // 
            this.tblYakitKasasiBindingSource.DataMember = "Tbl_YakitKasasi";
            this.tblYakitKasasiBindingSource.DataSource = this.db_SayacDataSet3;
            // 
            // tbl_YakitKasasiTableAdapter
            // 
            this.tbl_YakitKasasiTableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_YakitKasasiBindingSource
            // 
            this.Tbl_YakitKasasiBindingSource.DataMember = "Tbl_YakitKasasi";
            this.Tbl_YakitKasasiBindingSource.DataSource = this.db_SayacDataSet3;
            // 
            // FrmYakiKasasiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmYakiKasasiRapor";
            this.Text = "FrmYakiKasasiRapor";
            this.Load += new System.EventHandler(this.FrmYakiKasasiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_SayacDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYakitKasasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_YakitKasasiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Db_SayacDataSet3 db_SayacDataSet3;
        private System.Windows.Forms.BindingSource tblYakitKasasiBindingSource;
        private Db_SayacDataSet3TableAdapters.Tbl_YakitKasasiTableAdapter tbl_YakitKasasiTableAdapter;
        private System.Windows.Forms.BindingSource Tbl_YakitKasasiBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}