namespace C__honorarium_dosen_eksternal
{
    partial class ReportSlipGaji
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
            this.getReportSlipGajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getReportSlipGajiTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getReportSlipGajiTableAdapter();
            this.cbDosen = new System.Windows.Forms.ComboBox();
            this.getListDosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTanggalAkhir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTanggalAwal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getListDosenTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListDosenTableAdapter();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getReportSlipGajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListDosenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getReportSlipGajiBindingSource
            // 
            this.getReportSlipGajiBindingSource.DataMember = "getReportSlipGaji";
            this.getReportSlipGajiBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReportSlipGaji";
            reportDataSource1.Value = this.getReportSlipGajiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "C__honorarium_dosen_eksternal.ReportSlipGaji.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // getReportSlipGajiTableAdapter
            // 
            this.getReportSlipGajiTableAdapter.ClearBeforeFill = true;
            // 
            // cbDosen
            // 
            this.cbDosen.DataSource = this.getListDosenBindingSource;
            this.cbDosen.DisplayMember = "nama_dosen";
            this.cbDosen.FormattingEnabled = true;
            this.cbDosen.Location = new System.Drawing.Point(25, 45);
            this.cbDosen.Name = "cbDosen";
            this.cbDosen.Size = new System.Drawing.Size(121, 21);
            this.cbDosen.TabIndex = 1;
            this.cbDosen.ValueMember = "id_dosen";
            // 
            // getListDosenBindingSource
            // 
            this.getListDosenBindingSource.DataMember = "getListDosen";
            this.getListDosenBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // txtTanggalAkhir
            // 
            this.txtTanggalAkhir.Checked = true;
            this.txtTanggalAkhir.FillColor = System.Drawing.Color.White;
            this.txtTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAkhir.Location = new System.Drawing.Point(306, 45);
            this.txtTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAkhir.Name = "txtTanggalAkhir";
            this.txtTanggalAkhir.Size = new System.Drawing.Size(121, 21);
            this.txtTanggalAkhir.TabIndex = 2;
            this.txtTanggalAkhir.Value = new System.DateTime(2023, 7, 10, 10, 40, 8, 378);
            // 
            // txtTanggalAwal
            // 
            this.txtTanggalAwal.Checked = true;
            this.txtTanggalAwal.FillColor = System.Drawing.Color.White;
            this.txtTanggalAwal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtTanggalAwal.Location = new System.Drawing.Point(166, 45);
            this.txtTanggalAwal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtTanggalAwal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtTanggalAwal.Name = "txtTanggalAwal";
            this.txtTanggalAwal.Size = new System.Drawing.Size(121, 21);
            this.txtTanggalAwal.TabIndex = 3;
            this.txtTanggalAwal.Value = new System.DateTime(2023, 7, 10, 10, 40, 16, 947);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dosen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanggal Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tanggal Akhir";
            // 
            // getListDosenTableAdapter
            // 
            this.getListDosenTableAdapter.ClearBeforeFill = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(451, 43);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(547, 43);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Kirim Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // ReportSlipGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTanggalAwal);
            this.Controls.Add(this.txtTanggalAkhir);
            this.Controls.Add(this.cbDosen);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportSlipGaji";
            this.Text = "REPORT SLIP GAJI";
            this.Load += new System.EventHandler(this.ReportSlipGaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getReportSlipGajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListDosenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getReportSlipGajiBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getReportSlipGajiTableAdapter getReportSlipGajiTableAdapter;
        private System.Windows.Forms.ComboBox cbDosen;
        private System.Windows.Forms.BindingSource getListDosenBindingSource;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAkhir;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtTanggalAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HonorariumDosenEksternalDataSetTableAdapters.getListDosenTableAdapter getListDosenTableAdapter;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSendEmail;
    }
}