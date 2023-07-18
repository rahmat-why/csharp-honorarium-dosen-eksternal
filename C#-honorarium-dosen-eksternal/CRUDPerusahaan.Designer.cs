namespace C__honorarium_dosen_eksternal
{
    partial class CRUDPerusahaan
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
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtNamaPerusahaan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPerusahaan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getListPerusahaanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.getListPerusahaanTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListPerusahaanTableAdapter();
            this.getListPerusahaanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPerusahaan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_id_perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama_perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_singkatan_perusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSingkatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getListPerusahaanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListPerusahaanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPerusahaan)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(94)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel4.BorderRadius = 25;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.txtSingkatan);
            this.guna2Panel4.Controls.Add(this.label1);
            this.guna2Panel4.Controls.Add(this.btnClear);
            this.guna2Panel4.Controls.Add(this.btnSave);
            this.guna2Panel4.Controls.Add(this.btnUpdate);
            this.guna2Panel4.Controls.Add(this.btnDelete);
            this.guna2Panel4.Controls.Add(this.txtNamaPerusahaan);
            this.guna2Panel4.Controls.Add(this.txtIDPerusahaan);
            this.guna2Panel4.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(298, 629);
            this.guna2Panel4.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.BorderRadius = 13;
            this.btnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.reload;
            this.btnClear.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Location = new System.Drawing.Point(17, 280);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(264, 28);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.BorderRadius = 13;
            this.btnSave.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.diskette1;
            this.btnSave.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSave.Location = new System.Drawing.Point(17, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.BorderRadius = 13;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.edit;
            this.btnUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate.Location = new System.Drawing.Point(112, 241);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 28);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.BorderRadius = 13;
            this.btnDelete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.trash_can;
            this.btnDelete.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDelete.Location = new System.Drawing.Point(203, 241);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 28);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNamaPerusahaan
            // 
            this.txtNamaPerusahaan.AutoRoundedCorners = true;
            this.txtNamaPerusahaan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtNamaPerusahaan.BorderRadius = 16;
            this.txtNamaPerusahaan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNamaPerusahaan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPerusahaan.DefaultText = "";
            this.txtNamaPerusahaan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaPerusahaan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaPerusahaan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPerusahaan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPerusahaan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPerusahaan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPerusahaan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNamaPerusahaan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPerusahaan.Location = new System.Drawing.Point(17, 135);
            this.txtNamaPerusahaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPerusahaan.Name = "txtNamaPerusahaan";
            this.txtNamaPerusahaan.PasswordChar = '\0';
            this.txtNamaPerusahaan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNamaPerusahaan.PlaceholderText = "Nama Perusahaan";
            this.txtNamaPerusahaan.SelectedText = "";
            this.txtNamaPerusahaan.Size = new System.Drawing.Size(264, 34);
            this.txtNamaPerusahaan.TabIndex = 22;
            this.txtNamaPerusahaan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaPerusahaan_KeyPress);
            // 
            // txtIDPerusahaan
            // 
            this.txtIDPerusahaan.AutoRoundedCorners = true;
            this.txtIDPerusahaan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtIDPerusahaan.BorderRadius = 16;
            this.txtIDPerusahaan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIDPerusahaan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPerusahaan.DefaultText = "ID Perusahaan (Otomatis)";
            this.txtIDPerusahaan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDPerusahaan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDPerusahaan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPerusahaan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDPerusahaan.Enabled = false;
            this.txtIDPerusahaan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPerusahaan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPerusahaan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDPerusahaan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDPerusahaan.Location = new System.Drawing.Point(17, 91);
            this.txtIDPerusahaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDPerusahaan.Name = "txtIDPerusahaan";
            this.txtIDPerusahaan.PasswordChar = '\0';
            this.txtIDPerusahaan.PlaceholderText = "ID Perusahaan";
            this.txtIDPerusahaan.SelectedText = "";
            this.txtIDPerusahaan.Size = new System.Drawing.Size(264, 34);
            this.txtIDPerusahaan.TabIndex = 20;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.tblPerusahaan);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Location = new System.Drawing.Point(310, 8);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(691, 629);
            this.guna2Panel2.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(509, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(176, 39);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "Form Perusahaan";
            // 
            // getListPerusahaanBindingSource
            // 
            this.getListPerusahaanBindingSource.DataMember = "getListPerusahaan";
            this.getListPerusahaanBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getListPerusahaanTableAdapter
            // 
            this.getListPerusahaanTableAdapter.ClearBeforeFill = true;
            // 
            // getListPerusahaanBindingSource1
            // 
            this.getListPerusahaanBindingSource1.DataMember = "getListPerusahaan";
            this.getListPerusahaanBindingSource1.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // tblPerusahaan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tblPerusahaan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPerusahaan.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPerusahaan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPerusahaan.ColumnHeadersHeight = 40;
            this.tblPerusahaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblPerusahaan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_perusahaan,
            this.col_nama_perusahaan,
            this.col_singkatan_perusahaan});
            this.tblPerusahaan.DataSource = this.getListPerusahaanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPerusahaan.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblPerusahaan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPerusahaan.Location = new System.Drawing.Point(27, 91);
            this.tblPerusahaan.Name = "tblPerusahaan";
            this.tblPerusahaan.RowHeadersVisible = false;
            this.tblPerusahaan.Size = new System.Drawing.Size(658, 512);
            this.tblPerusahaan.TabIndex = 36;
            this.tblPerusahaan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblPerusahaan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblPerusahaan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblPerusahaan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblPerusahaan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblPerusahaan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblPerusahaan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPerusahaan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.tblPerusahaan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblPerusahaan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPerusahaan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblPerusahaan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblPerusahaan.ThemeStyle.HeaderStyle.Height = 40;
            this.tblPerusahaan.ThemeStyle.ReadOnly = false;
            this.tblPerusahaan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblPerusahaan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblPerusahaan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPerusahaan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tblPerusahaan.ThemeStyle.RowsStyle.Height = 22;
            this.tblPerusahaan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblPerusahaan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tblPerusahaan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPerusahaan_CellClick);
            // 
            // col_id_perusahaan
            // 
            this.col_id_perusahaan.DataPropertyName = "id_perusahaan";
            this.col_id_perusahaan.HeaderText = "ID Perusahaan";
            this.col_id_perusahaan.Name = "col_id_perusahaan";
            // 
            // col_nama_perusahaan
            // 
            this.col_nama_perusahaan.DataPropertyName = "nama_perusahaan";
            this.col_nama_perusahaan.HeaderText = "Nama Perusahaan";
            this.col_nama_perusahaan.Name = "col_nama_perusahaan";
            // 
            // col_singkatan_perusahaan
            // 
            this.col_singkatan_perusahaan.DataPropertyName = "singkatan_perusahaan";
            this.col_singkatan_perusahaan.HeaderText = "Singkatan";
            this.col_singkatan_perusahaan.Name = "col_singkatan_perusahaan";
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.AutoRoundedCorners = true;
            this.txtSingkatan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtSingkatan.BorderRadius = 16;
            this.txtSingkatan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSingkatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSingkatan.DefaultText = "";
            this.txtSingkatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSingkatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSingkatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSingkatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSingkatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSingkatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSingkatan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSingkatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSingkatan.Location = new System.Drawing.Point(17, 179);
            this.txtSingkatan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.PasswordChar = '\0';
            this.txtSingkatan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSingkatan.PlaceholderText = "Singkatan";
            this.txtSingkatan.SelectedText = "";
            this.txtSingkatan.Size = new System.Drawing.Size(264, 34);
            this.txtSingkatan.TabIndex = 84;
            // 
            // CRUDPerusahaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1366, 786);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUDPerusahaan";
            this.Text = "CRUDPerusahaan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDPerusahaan_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getListPerusahaanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListPerusahaanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPerusahaan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaPerusahaan;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPerusahaan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.BindingSource getListPerusahaanBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListPerusahaanTableAdapter getListPerusahaanTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource getListPerusahaanBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView tblPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_perusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama_perusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_singkatan_perusahaan;
        private Guna.UI2.WinForms.Guna2TextBox txtSingkatan;
    }
}