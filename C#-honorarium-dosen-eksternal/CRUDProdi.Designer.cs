namespace C__honorarium_dosen_eksternal
{
    partial class CRUDProdi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbTransport = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSingkatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tblProdi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_id_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_singkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_transport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getListProdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.getListProdiTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListProdiTableAdapter();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListProdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnSave);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.cmbTransport);
            this.guna2Panel1.Controls.Add(this.txtSingkatan);
            this.guna2Panel1.Controls.Add(this.txtNamaProdi);
            this.guna2Panel1.Controls.Add(this.txtIDProdi);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(485, 1032);
            this.guna2Panel1.TabIndex = 3;
            // 
            // cmbTransport
            // 
            this.cmbTransport.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbTransport.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTransport.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmbTransport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransport.FillColor = System.Drawing.SystemColors.HighlightText;
            this.cmbTransport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbTransport.ItemHeight = 30;
            this.cmbTransport.Items.AddRange(new object[] {
            "PER SEKALI MENGAJAR",
            "PER HARI MENGAJAR"});
            this.cmbTransport.Location = new System.Drawing.Point(135, 365);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(324, 36);
            this.cmbTransport.TabIndex = 36;
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.AutoRoundedCorners = true;
            this.txtSingkatan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSingkatan.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSingkatan.BorderRadius = 23;
            this.txtSingkatan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSingkatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSingkatan.DefaultText = "";
            this.txtSingkatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSingkatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSingkatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSingkatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSingkatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSingkatan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSingkatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSingkatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSingkatan.Location = new System.Drawing.Point(36, 289);
            this.txtSingkatan.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.PasswordChar = '\0';
            this.txtSingkatan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSingkatan.PlaceholderText = "Singkatan";
            this.txtSingkatan.SelectedText = "";
            this.txtSingkatan.Size = new System.Drawing.Size(423, 49);
            this.txtSingkatan.TabIndex = 35;
            this.txtSingkatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSingkatan_KeyPress);
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.AutoRoundedCorners = true;
            this.txtNamaProdi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNamaProdi.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNamaProdi.BorderRadius = 23;
            this.txtNamaProdi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNamaProdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaProdi.DefaultText = "";
            this.txtNamaProdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaProdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaProdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaProdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaProdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaProdi.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaProdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNamaProdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaProdi.Location = new System.Drawing.Point(36, 220);
            this.txtNamaProdi.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.PasswordChar = '\0';
            this.txtNamaProdi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNamaProdi.PlaceholderText = "Nama Prodi";
            this.txtNamaProdi.SelectedText = "";
            this.txtNamaProdi.Size = new System.Drawing.Size(423, 49);
            this.txtNamaProdi.TabIndex = 34;
            this.txtNamaProdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaProdi_KeyPress);
            // 
            // txtIDProdi
            // 
            this.txtIDProdi.AutoRoundedCorners = true;
            this.txtIDProdi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDProdi.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIDProdi.BorderRadius = 23;
            this.txtIDProdi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIDProdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProdi.DefaultText = "ID Prodi (Otomatis)";
            this.txtIDProdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProdi.Enabled = false;
            this.txtIDProdi.FillColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDProdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProdi.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtIDProdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProdi.Location = new System.Drawing.Point(36, 142);
            this.txtIDProdi.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtIDProdi.Name = "txtIDProdi";
            this.txtIDProdi.PasswordChar = '\0';
            this.txtIDProdi.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIDProdi.PlaceholderText = "ID Dosen";
            this.txtIDProdi.SelectedText = "";
            this.txtIDProdi.Size = new System.Drawing.Size(423, 49);
            this.txtIDProdi.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 52);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data Prodi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(646, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BorderRadius = 25;
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(729, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(264, 52);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.tblProdi);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Location = new System.Drawing.Point(503, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1011, 1032);
            this.guna2Panel2.TabIndex = 1;
            // 
            // tblProdi
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tblProdi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblProdi.AutoGenerateColumns = false;
            this.tblProdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblProdi.ColumnHeadersHeight = 22;
            this.tblProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_prodi,
            this.col_nama_prodi,
            this.col_singkatan,
            this.col_transport});
            this.tblProdi.DataSource = this.getListProdiBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblProdi.DefaultCellStyle = dataGridViewCellStyle6;
            this.tblProdi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProdi.Location = new System.Drawing.Point(30, 95);
            this.tblProdi.Name = "tblProdi";
            this.tblProdi.RowHeadersVisible = false;
            this.tblProdi.RowHeadersWidth = 62;
            this.tblProdi.RowTemplate.Height = 28;
            this.tblProdi.Size = new System.Drawing.Size(951, 908);
            this.tblProdi.TabIndex = 41;
            this.tblProdi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblProdi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblProdi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblProdi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblProdi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblProdi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblProdi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProdi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tblProdi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblProdi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProdi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblProdi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblProdi.ThemeStyle.HeaderStyle.Height = 22;
            this.tblProdi.ThemeStyle.ReadOnly = false;
            this.tblProdi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblProdi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblProdi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProdi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblProdi.ThemeStyle.RowsStyle.Height = 28;
            this.tblProdi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblProdi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblProdi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProdi_CellClick);
            // 
            // col_id_prodi
            // 
            this.col_id_prodi.DataPropertyName = "id_prodi";
            this.col_id_prodi.HeaderText = "ID Prodi";
            this.col_id_prodi.MinimumWidth = 8;
            this.col_id_prodi.Name = "col_id_prodi";
            this.col_id_prodi.Width = 238;
            // 
            // col_nama_prodi
            // 
            this.col_nama_prodi.DataPropertyName = "nama_prodi";
            this.col_nama_prodi.HeaderText = "Nama Prodi";
            this.col_nama_prodi.MinimumWidth = 8;
            this.col_nama_prodi.Name = "col_nama_prodi";
            this.col_nama_prodi.Width = 238;
            // 
            // col_singkatan
            // 
            this.col_singkatan.DataPropertyName = "singkatan";
            this.col_singkatan.HeaderText = "Singkatan";
            this.col_singkatan.MinimumWidth = 8;
            this.col_singkatan.Name = "col_singkatan";
            this.col_singkatan.Width = 237;
            // 
            // col_transport
            // 
            this.col_transport.DataPropertyName = "transport";
            this.col_transport.HeaderText = "Transport";
            this.col_transport.MinimumWidth = 8;
            this.col_transport.Name = "col_transport";
            this.col_transport.Width = 238;
            // 
            // getListProdiBindingSource
            // 
            this.getListProdiBindingSource.DataMember = "getListProdi";
            this.getListProdiBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getListProdiTableAdapter
            // 
            this.getListProdiTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.Navy;
            this.btnClear.BorderRadius = 20;
            this.btnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.broom;
            this.btnClear.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Location = new System.Drawing.Point(36, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(423, 43);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderColor = System.Drawing.Color.Navy;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.diskette__1_;
            this.btnSave.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSave.Location = new System.Drawing.Point(36, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 43);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderColor = System.Drawing.Color.Navy;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.circle__1_;
            this.btnUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate.Location = new System.Drawing.Point(182, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 43);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.Navy;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.delete__2_;
            this.btnDelete.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDelete.Location = new System.Drawing.Point(324, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 43);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            // 
            // CRUDProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 1048);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDProdi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDProdi_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListProdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSingkatan;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaProdi;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTransport;
        private Guna.UI2.WinForms.Guna2DataGridView tblProdi;
        private System.Windows.Forms.BindingSource getListProdiBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListProdiTableAdapter getListProdiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_singkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_transport;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}