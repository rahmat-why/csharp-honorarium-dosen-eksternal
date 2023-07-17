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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getReportTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.txtTglAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTglAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbIDJenis = new System.Windows.Forms.ComboBox();
            this.getListJenisDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getListJenisDosenTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListJenisDosenTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getReportTransferBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getReportTransferTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getReportTransferTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
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
            this.txtTglAwal.Location = new System.Drawing.Point(18, 42);
            this.txtTglAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTglAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTglAwal.Name = "txtTglAwal";
            this.txtTglAwal.Size = new System.Drawing.Size(248, 31);
            this.txtTglAwal.TabIndex = 0;
            this.txtTglAwal.Value = new System.DateTime(2023, 7, 11, 10, 50, 23, 152);
            // 
            // txtTglAkhir
            // 
            this.txtTglAkhir.Checked = true;
            this.txtTglAkhir.FillColor = System.Drawing.Color.White;
            this.txtTglAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTglAkhir.Location = new System.Drawing.Point(18, 100);
            this.txtTglAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTglAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTglAkhir.Name = "txtTglAkhir";
            this.txtTglAkhir.Size = new System.Drawing.Size(248, 28);
            this.txtTglAkhir.TabIndex = 1;
            this.txtTglAkhir.Value = new System.DateTime(2023, 7, 11, 10, 50, 25, 0);
            this.txtTglAkhir.ValueChanged += new System.EventHandler(this.txtTglAkhir_ValueChanged);
            // 
            // cbIDJenis
            // 
            this.cbIDJenis.DataSource = this.getListJenisDosenBindingSource;
            this.cbIDJenis.DisplayMember = "nama_jenis";
            this.cbIDJenis.FormattingEnabled = true;
            this.cbIDJenis.Location = new System.Drawing.Point(18, 154);
            this.cbIDJenis.Name = "cbIDJenis";
            this.cbIDJenis.Size = new System.Drawing.Size(248, 28);
            this.cbIDJenis.TabIndex = 2;
            this.cbIDJenis.ValueMember = "id_jenis_dosen";
            this.cbIDJenis.SelectedIndexChanged += new System.EventHandler(this.cbIDJenis_SelectedIndexChanged);
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getReportTransferBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C__honorarium_dosen_eksternal.ReportTransfer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1021, 903);
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
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Jenis Dosen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tanggal Akhir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tanggal Awal";
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
            this.btnFilter.Location = new System.Drawing.Point(18, 218);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(248, 40);
            this.btnFilter.TabIndex = 43;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.btnFilter);
            this.guna2Panel1.Controls.Add(this.cbIDJenis);
            this.guna2Panel1.Controls.Add(this.txtTglAwal);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtTglAkhir);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1021, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(286, 903);
            this.guna2Panel1.TabIndex = 44;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.reportViewer1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1021, 903);
            this.guna2Panel2.TabIndex = 45;
            // 
            // ReportTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 903);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTransfer";
            this.Text = "ReportTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListJenisDosenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getReportTransferBindingSource1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker txtTglAwal;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTglAkhir;
        private System.Windows.Forms.ComboBox cbIDJenis;
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
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}