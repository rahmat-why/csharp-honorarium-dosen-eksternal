namespace C__honorarium_dosen_eksternal
{
    partial class ReportProdi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getReportProdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.txtTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbJenisDosen = new System.Windows.Forms.ComboBox();
            this.getListJenisDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getListJenisDosenTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter();
            this.getReportProdiTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getReportProdiTableAdapter();
            this.getReportTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getReportDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.getReportProdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportDosenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getReportProdiBindingSource
            // 
            this.getReportProdiBindingSource.DataMember = "getReportProdi";
            this.getReportProdiBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTanggalAwal
            // 
            this.txtTanggalAwal.Checked = true;
            this.txtTanggalAwal.FillColor = System.Drawing.Color.Silver;
            this.txtTanggalAwal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAwal.Location = new System.Drawing.Point(123, 14);
            this.txtTanggalAwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTanggalAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAwal.Name = "txtTanggalAwal";
            this.txtTanggalAwal.Size = new System.Drawing.Size(278, 32);
            this.txtTanggalAwal.TabIndex = 0;
            this.txtTanggalAwal.Value = new System.DateTime(2023, 7, 13, 8, 24, 39, 239);
            this.txtTanggalAwal.ValueChanged += new System.EventHandler(this.txtTanggalAwal_ValueChanged);
            // 
            // txtTanggalAkhir
            // 
            this.txtTanggalAkhir.Checked = true;
            this.txtTanggalAkhir.FillColor = System.Drawing.Color.Silver;
            this.txtTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAkhir.Location = new System.Drawing.Point(123, 57);
            this.txtTanggalAkhir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAkhir.Name = "txtTanggalAkhir";
            this.txtTanggalAkhir.Size = new System.Drawing.Size(278, 31);
            this.txtTanggalAkhir.TabIndex = 1;
            this.txtTanggalAkhir.Value = new System.DateTime(2023, 7, 13, 8, 24, 43, 467);
            this.txtTanggalAkhir.ValueChanged += new System.EventHandler(this.txtTanggalAkhir_ValueChanged);
            // 
            // cmbJenisDosen
            // 
            this.cmbJenisDosen.DataSource = this.getListJenisDosenBindingSource;
            this.cmbJenisDosen.DisplayMember = "nama_jenis";
            this.cmbJenisDosen.FormattingEnabled = true;
            this.cmbJenisDosen.Location = new System.Drawing.Point(866, 57);
            this.cmbJenisDosen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJenisDosen.Name = "cmbJenisDosen";
            this.cmbJenisDosen.Size = new System.Drawing.Size(180, 28);
            this.cmbJenisDosen.TabIndex = 2;
            this.cmbJenisDosen.ValueMember = "id_jenis_dosen";
            this.cmbJenisDosen.SelectedIndexChanged += new System.EventHandler(this.cmbJenisDosen_SelectedIndexChanged);
            // 
            // getListJenisDosenBindingSource
            // 
            this.getListJenisDosenBindingSource.DataMember = "getListJenisDosen";
            this.getListJenisDosenBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tanggal Awal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tanggal Akhir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Dosen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // getListJenisDosenTableAdapter
            // 
            this.getListJenisDosenTableAdapter.ClearBeforeFill = true;
            // 
            // getReportProdiTableAdapter
            // 
            this.getReportProdiTableAdapter.ClearBeforeFill = true;
            // 
            // getReportTransferBindingSource
            // 
            this.getReportTransferBindingSource.DataMember = "getReportTransfer";
            this.getReportTransferBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // getReportDosenBindingSource
            // 
            this.getReportDosenBindingSource.DataMember = "getReportDosen";
            this.getReportDosenBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DatasetReportProdi";
            reportDataSource3.Value = this.getReportProdiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C__honorarium_dosen_eksternal.ReportProdi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1274, 578);
            this.reportViewer1.TabIndex = 16;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderColor = System.Drawing.Color.Navy;
            this.btnFilter.BorderRadius = 19;
            this.btnFilter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnFilter.BorderThickness = 1;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilter.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.filter_filled_tool_symbol;
            this.btnFilter.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFilter.Location = new System.Drawing.Point(1081, 48);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(160, 40);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filter";
            // 
            // ReportProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 680);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbJenisDosen);
            this.Controls.Add(this.txtTanggalAkhir);
            this.Controls.Add(this.txtTanggalAwal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportProdi";
            this.Text = "ReportProdi";
            this.Load += new System.EventHandler(this.ReportProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getReportProdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportDosenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAwal;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAkhir;
        private System.Windows.Forms.ComboBox cmbJenisDosen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource getListJenisDosenBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter getListJenisDosenTableAdapter;
        private System.Windows.Forms.BindingSource getReportProdiBindingSource;
        private HonorariumDosenEksternalDataSetTableAdapters.getReportProdiTableAdapter getReportProdiTableAdapter;
        private System.Windows.Forms.BindingSource getReportTransferBindingSource;
        private System.Windows.Forms.BindingSource getReportDosenBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
    }
}