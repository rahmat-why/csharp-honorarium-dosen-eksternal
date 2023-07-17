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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getReportProdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.getListJenisDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getListJenisDosenTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter();
            this.getReportProdiTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getReportProdiTableAdapter();
            this.getReportTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getReportDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJenisDosen = new System.Windows.Forms.ComboBox();
            this.txtTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.getReportProdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportDosenBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
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
            // getListJenisDosenBindingSource
            // 
            this.getListJenisDosenBindingSource.DataMember = "getListJenisDosen";
            this.getListJenisDosenBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.guna2Panel1.Controls.Add(this.txtTanggalAwal);
            this.guna2Panel1.Controls.Add(this.btnFilter);
            this.guna2Panel1.Controls.Add(this.txtTanggalAkhir);
            this.guna2Panel1.Controls.Add(this.cmbJenisDosen);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(660, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(207, 481);
            this.guna2Panel1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tanggal Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Dosen";
            // 
            // cmbJenisDosen
            // 
            this.cmbJenisDosen.DataSource = this.getListJenisDosenBindingSource;
            this.cmbJenisDosen.DisplayMember = "nama_jenis";
            this.cmbJenisDosen.FormattingEnabled = true;
            this.cmbJenisDosen.Location = new System.Drawing.Point(9, 123);
            this.cmbJenisDosen.Name = "cmbJenisDosen";
            this.cmbJenisDosen.Size = new System.Drawing.Size(185, 21);
            this.cmbJenisDosen.TabIndex = 2;
            this.cmbJenisDosen.ValueMember = "id_jenis_dosen";
            // 
            // txtTanggalAkhir
            // 
            this.txtTanggalAkhir.Checked = true;
            this.txtTanggalAkhir.FillColor = System.Drawing.Color.Silver;
            this.txtTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAkhir.Location = new System.Drawing.Point(9, 79);
            this.txtTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAkhir.Name = "txtTanggalAkhir";
            this.txtTanggalAkhir.Size = new System.Drawing.Size(185, 20);
            this.txtTanggalAkhir.TabIndex = 1;
            this.txtTanggalAkhir.Value = new System.DateTime(2023, 7, 13, 8, 24, 43, 467);
            // 
            // btnFilter
            // 
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderColor = System.Drawing.Color.Navy;
            this.btnFilter.BorderRadius = 12;
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
            this.btnFilter.Location = new System.Drawing.Point(9, 160);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(185, 26);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // txtTanggalAwal
            // 
            this.txtTanggalAwal.Checked = true;
            this.txtTanggalAwal.FillColor = System.Drawing.Color.Silver;
            this.txtTanggalAwal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAwal.Location = new System.Drawing.Point(9, 39);
            this.txtTanggalAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAwal.Name = "txtTanggalAwal";
            this.txtTanggalAwal.Size = new System.Drawing.Size(185, 21);
            this.txtTanggalAwal.TabIndex = 0;
            this.txtTanggalAwal.Value = new System.DateTime(2023, 7, 13, 8, 24, 39, 239);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DatasetReportProdi";
            reportDataSource2.Value = this.getReportProdiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C__honorarium_dosen_eksternal.ReportProdi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 481);
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.reportViewer1);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(867, 481);
            this.guna2Panel2.TabIndex = 45;
            // 
            // ReportProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportProdi";
            this.Text = "ReportProdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getReportProdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportDosenBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource getListJenisDosenBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter getListJenisDosenTableAdapter;
        private System.Windows.Forms.BindingSource getReportProdiBindingSource;
        private HonorariumDosenEksternalDataSetTableAdapters.getReportProdiTableAdapter getReportProdiTableAdapter;
        private System.Windows.Forms.BindingSource getReportTransferBindingSource;
        private System.Windows.Forms.BindingSource getReportDosenBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAwal;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAkhir;
        private System.Windows.Forms.ComboBox cmbJenisDosen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}