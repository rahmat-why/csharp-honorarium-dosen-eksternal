namespace C__honorarium_dosen_eksternal
{
    partial class ReportTransfer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getReportTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.txtTglAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTglAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbIDJenis = new System.Windows.Forms.ComboBox();
            this.getListJenisDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.getListJenisDosenTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getReportTransferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getReportTransferTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getReportTransferTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // getReportTransferBindingSource
            // 
            this.getReportTransferBindingSource.DataMember = "getReportTransfer";
            this.getReportTransferBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTglAwal
            // 
            this.txtTglAwal.Checked = true;
            this.txtTglAwal.FillColor = System.Drawing.Color.White;
            this.txtTglAwal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTglAwal.Location = new System.Drawing.Point(149, 43);
            this.txtTglAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTglAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTglAwal.Name = "txtTglAwal";
            this.txtTglAwal.Size = new System.Drawing.Size(252, 35);
            this.txtTglAwal.TabIndex = 0;
            this.txtTglAwal.Value = new System.DateTime(2023, 7, 11, 10, 50, 23, 152);
            // 
            // txtTglAkhir
            // 
            this.txtTglAkhir.Checked = true;
            this.txtTglAkhir.FillColor = System.Drawing.Color.White;
            this.txtTglAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTglAkhir.Location = new System.Drawing.Point(149, 92);
            this.txtTglAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTglAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTglAkhir.Name = "txtTglAkhir";
            this.txtTglAkhir.Size = new System.Drawing.Size(252, 35);
            this.txtTglAkhir.TabIndex = 1;
            this.txtTglAkhir.Value = new System.DateTime(2023, 7, 11, 10, 50, 25, 0);
            // 
            // cbIDJenis
            // 
            this.cbIDJenis.DataSource = this.getListJenisDosenBindingSource;
            this.cbIDJenis.DisplayMember = "nama_jenis";
            this.cbIDJenis.FormattingEnabled = true;
            this.cbIDJenis.Location = new System.Drawing.Point(687, 94);
            this.cbIDJenis.Name = "cbIDJenis";
            this.cbIDJenis.Size = new System.Drawing.Size(230, 28);
            this.cbIDJenis.TabIndex = 2;
            this.cbIDJenis.ValueMember = "id_jenis_dosen";
            // 
            // getListJenisDosenBindingSource
            // 
            this.getListJenisDosenBindingSource.DataMember = "getListJenisDosen";
            this.getListJenisDosenBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderRadius = 16;
            this.btnFilter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(993, 92);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(146, 35);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // getListJenisDosenTableAdapter
            // 
            this.getListJenisDosenTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getReportTransferBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C__honorarium_dosen_eksternal.ReportTransfer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 144);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 893);
            this.reportViewer1.TabIndex = 13;
            // 
            // getReportTransferBindingSource1
            // 
            this.getReportTransferBindingSource1.DataMember = "getReportTransfer";
            this.getReportTransferBindingSource1.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // getReportTransferTableAdapter
            // 
            this.getReportTransferTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jenis Dosen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tanggal Awal";
            // 
            // ReportTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 873);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbIDJenis);
            this.Controls.Add(this.txtTglAkhir);
            this.Controls.Add(this.txtTglAwal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTransfer";
            this.Text = "ReportTransfer";
            this.Load += new System.EventHandler(this.ReportTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker txtTglAwal;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTglAkhir;
        private System.Windows.Forms.ComboBox cbIDJenis;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private System.Windows.Forms.BindingSource getListJenisDosenBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter getListJenisDosenTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getReportTransferBindingSource;
        private System.Windows.Forms.BindingSource getReportTransferBindingSource1;
        private HonorariumDosenEksternalDataSetTableAdapters.getReportTransferTableAdapter getReportTransferTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}