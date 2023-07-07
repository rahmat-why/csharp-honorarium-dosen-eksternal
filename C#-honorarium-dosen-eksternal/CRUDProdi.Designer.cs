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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbIDJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSingkatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDProdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getListProdiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.getListProdiTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListProdiTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nama_prodiToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nama_prodiToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListProdiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.guna2Panel1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cmbIDJenis);
            this.guna2Panel1.Controls.Add(this.txtSingkatan);
            this.guna2Panel1.Controls.Add(this.txtNamaProdi);
            this.guna2Panel1.Controls.Add(this.txtIDProdi);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(485, 1032);
            this.guna2Panel1.TabIndex = 3;
            // 
            // cmbIDJenis
            // 
            this.cmbIDJenis.AutoRoundedCorners = true;
            this.cmbIDJenis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbIDJenis.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbIDJenis.BorderRadius = 17;
            this.cmbIDJenis.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cmbIDJenis.DisplayMember = "id_prodi";
            this.cmbIDJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIDJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDJenis.FillColor = System.Drawing.SystemColors.HighlightText;
            this.cmbIDJenis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDJenis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIDJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbIDJenis.ItemHeight = 30;
            this.cmbIDJenis.Location = new System.Drawing.Point(133, 505);
            this.cmbIDJenis.Name = "cmbIDJenis";
            this.cmbIDJenis.Size = new System.Drawing.Size(324, 36);
            this.cmbIDJenis.TabIndex = 36;
            this.cmbIDJenis.ValueMember = "id_prodi";
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
            this.txtSingkatan.Location = new System.Drawing.Point(21, 429);
            this.txtSingkatan.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.PasswordChar = '\0';
            this.txtSingkatan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSingkatan.PlaceholderText = "Singkatan";
            this.txtSingkatan.SelectedText = "";
            this.txtSingkatan.Size = new System.Drawing.Size(436, 49);
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
            this.txtNamaProdi.Location = new System.Drawing.Point(21, 360);
            this.txtNamaProdi.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.PasswordChar = '\0';
            this.txtNamaProdi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNamaProdi.PlaceholderText = "Nama Prodi";
            this.txtNamaProdi.SelectedText = "";
            this.txtNamaProdi.Size = new System.Drawing.Size(436, 49);
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
            this.txtIDProdi.Location = new System.Drawing.Point(21, 288);
            this.txtIDProdi.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtIDProdi.Name = "txtIDProdi";
            this.txtIDProdi.PasswordChar = '\0';
            this.txtIDProdi.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIDProdi.PlaceholderText = "ID Dosen";
            this.txtIDProdi.SelectedText = "";
            this.txtIDProdi.Size = new System.Drawing.Size(436, 49);
            this.txtIDProdi.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 55);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data Prodi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 239);
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
            this.txtSearch.DefaultText = "Search nama";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(717, 216);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(264, 52);
            this.txtSearch.TabIndex = 35;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.Controls.Add(this.btnUpdate);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Location = new System.Drawing.Point(503, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1011, 1032);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 22;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn,
            this.singkatanDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.getListProdiBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(30, 288);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(951, 253);
            this.guna2DataGridView1.TabIndex = 41;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "ID Prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "Nama Prodi";
            this.namaprodiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            // 
            // singkatanDataGridViewTextBoxColumn
            // 
            this.singkatanDataGridViewTextBoxColumn.DataPropertyName = "singkatan";
            this.singkatanDataGridViewTextBoxColumn.HeaderText = "Singkatan";
            this.singkatanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.singkatanDataGridViewTextBoxColumn.Name = "singkatanDataGridViewTextBoxColumn";
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.transportDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
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
            this.btnSave.Location = new System.Drawing.Point(158, 591);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 43);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClear.Location = new System.Drawing.Point(656, 591);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 43);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
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
            this.btnUpdate.Location = new System.Drawing.Point(324, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 43);
            this.btnUpdate.TabIndex = 38;
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
            this.btnDelete.Location = new System.Drawing.Point(488, 591);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 43);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            // 
            // getListProdiTableAdapter
            // 
            this.getListProdiTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nama_prodiToolStripLabel,
            this.nama_prodiToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1526, 34);
            this.fillBy1ToolStrip.TabIndex = 4;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // nama_prodiToolStripLabel
            // 
            this.nama_prodiToolStripLabel.Name = "nama_prodiToolStripLabel";
            this.nama_prodiToolStripLabel.Size = new System.Drawing.Size(110, 29);
            this.nama_prodiToolStripLabel.Text = "nama_prodi:";
            // 
            // nama_prodiToolStripTextBox
            // 
            this.nama_prodiToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nama_prodiToolStripTextBox.Name = "nama_prodiToolStripTextBox";
            this.nama_prodiToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(66, 29);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            // 
            // CRUDProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 1048);
            this.Controls.Add(this.fillBy1ToolStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListProdiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2ComboBox cmbIDJenis;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getListProdiBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListProdiTableAdapter getListProdiTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel nama_prodiToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nama_prodiToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}