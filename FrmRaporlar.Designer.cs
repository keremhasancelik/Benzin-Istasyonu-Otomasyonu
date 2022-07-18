namespace Sayac_Proje
{
    partial class FrmRaporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tbl_SayacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Db_SayacDataSet = new Sayac_Proje.Db_SayacDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_SayacTableAdapter = new Sayac_Proje.Db_SayacDataSetTableAdapters.Tbl_SayacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SayacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Db_SayacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_SayacBindingSource
            // 
            this.Tbl_SayacBindingSource.DataMember = "Tbl_Sayac";
            this.Tbl_SayacBindingSource.DataSource = this.Db_SayacDataSet;
            // 
            // Db_SayacDataSet
            // 
            this.Db_SayacDataSet.DataSetName = "Db_SayacDataSet";
            this.Db_SayacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_SayacBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sayac_Proje.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(844, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tbl_SayacTableAdapter
            // 
            this.Tbl_SayacTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 435);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_SayacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Db_SayacDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_SayacBindingSource;
        private Db_SayacDataSet Db_SayacDataSet;
        private Db_SayacDataSetTableAdapters.Tbl_SayacTableAdapter Tbl_SayacTableAdapter;
    }
}