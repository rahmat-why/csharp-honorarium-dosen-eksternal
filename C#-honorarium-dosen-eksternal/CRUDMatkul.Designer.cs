namespace C__honorarium_dosen_eksternal
{
    partial class CRUDMatkul
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMataKuliah = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSks = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDMatkul = new Guna.UI2.WinForms.Guna2TextBox();
            this.filterToolStrip = new System.Windows.Forms.ToolStrip();
            this.nama_matkulToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nama_matkulToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idmatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getListMatkulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.getListMatkulTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListMatkulTableAdapter();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.filterToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getListMatkulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel2.Controls.Add(this.btnSave);
            this.guna2Panel2.Controls.Add(this.btnClear);
            this.guna2Panel2.Controls.Add(this.btnUpdate);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Location = new System.Drawing.Point(477, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1037, 986);
            this.guna2Panel2.TabIndex = 4;
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
            this.idmatkulDataGridViewTextBoxColumn,
            this.namamatkulDataGridViewTextBoxColumn,
            this.sksDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.getListMatkulBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(31, 297);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(969, 303);
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
            this.btnSave.Location = new System.Drawing.Point(176, 626);
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
            this.btnClear.Location = new System.Drawing.Point(698, 626);
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
            this.btnUpdate.Location = new System.Drawing.Point(354, 626);
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
            this.btnDelete.Location = new System.Drawing.Point(520, 626);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 43);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 65);
            this.label1.TabIndex = 36;
            this.label1.Text = "Data Mata Kuliah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 258);
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
            this.txtSearch.Location = new System.Drawing.Point(736, 234);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(264, 52);
            this.txtSearch.TabIndex = 35;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(94)))));
            this.guna2Panel4.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel4.BorderRadius = 25;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.txtMataKuliah);
            this.guna2Panel4.Controls.Add(this.txtSks);
            this.guna2Panel4.Controls.Add(this.txtIDMatkul);
            this.guna2Panel4.Location = new System.Drawing.Point(24, 50);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(447, 986);
            this.guna2Panel4.TabIndex = 3;
            // 
            // txtMataKuliah
            // 
            this.txtMataKuliah.AutoRoundedCorners = true;
            this.txtMataKuliah.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMataKuliah.BorderRadius = 25;
            this.txtMataKuliah.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMataKuliah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMataKuliah.DefaultText = "";
            this.txtMataKuliah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMataKuliah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMataKuliah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMataKuliah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMataKuliah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMataKuliah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMataKuliah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMataKuliah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMataKuliah.Location = new System.Drawing.Point(26, 365);
            this.txtMataKuliah.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMataKuliah.Name = "txtMataKuliah";
            this.txtMataKuliah.PasswordChar = '\0';
            this.txtMataKuliah.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMataKuliah.PlaceholderText = "Nama Matkul";
            this.txtMataKuliah.SelectedText = "";
            this.txtMataKuliah.Size = new System.Drawing.Size(396, 52);
            this.txtMataKuliah.TabIndex = 22;
            //this.txtMataKuliah.TextChanged += new System.EventHandler(this.txtMataKuliah_TextChanged);
            this.txtMataKuliah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMataKuliah_KeyPress);
            // 
            // txtSks
            // 
            this.txtSks.AutoRoundedCorners = true;
            this.txtSks.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSks.BorderRadius = 25;
            this.txtSks.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSks.DefaultText = "";
            this.txtSks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSks.Location = new System.Drawing.Point(26, 434);
            this.txtSks.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSks.Name = "txtSks";
            this.txtSks.PasswordChar = '\0';
            this.txtSks.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSks.PlaceholderText = "SKS";
            this.txtSks.SelectedText = "";
            this.txtSks.Size = new System.Drawing.Size(396, 52);
            this.txtSks.TabIndex = 21;
            this.txtSks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSks_KeyPress);
            // 
            // txtIDMatkul
            // 
            this.txtIDMatkul.AutoRoundedCorners = true;
            this.txtIDMatkul.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIDMatkul.BorderRadius = 25;
            this.txtIDMatkul.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIDMatkul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDMatkul.DefaultText = "ID Matkul (Otomatis)";
            this.txtIDMatkul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDMatkul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDMatkul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMatkul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDMatkul.Enabled = false;
            this.txtIDMatkul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMatkul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDMatkul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIDMatkul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDMatkul.Location = new System.Drawing.Point(26, 297);
            this.txtIDMatkul.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtIDMatkul.Name = "txtIDMatkul";
            this.txtIDMatkul.PasswordChar = '\0';
            this.txtIDMatkul.PlaceholderText = "ID Matkul";
            this.txtIDMatkul.SelectedText = "";
            this.txtIDMatkul.Size = new System.Drawing.Size(396, 52);
            this.txtIDMatkul.TabIndex = 20;
            // 
            // filterToolStrip
            // 
            this.filterToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.filterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nama_matkulToolStripLabel,
            this.nama_matkulToolStripTextBox,
            this.filterToolStripButton});
            this.filterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.filterToolStrip.Name = "filterToolStrip";
            this.filterToolStrip.Size = new System.Drawing.Size(1526, 38);
            this.filterToolStrip.TabIndex = 5;
            this.filterToolStrip.Text = "filterToolStrip";
            // 
            // nama_matkulToolStripLabel
            // 
            this.nama_matkulToolStripLabel.Name = "nama_matkulToolStripLabel";
            this.nama_matkulToolStripLabel.Size = new System.Drawing.Size(121, 33);
            this.nama_matkulToolStripLabel.Text = "nama_matkul:";
            // 
            // nama_matkulToolStripTextBox
            // 
            this.nama_matkulToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nama_matkulToolStripTextBox.Name = "nama_matkulToolStripTextBox";
            this.nama_matkulToolStripTextBox.Size = new System.Drawing.Size(100, 38);
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(54, 33);
            this.filterToolStripButton.Text = "Filter";
            this.filterToolStripButton.Click += new System.EventHandler(this.filterToolStripButton_Click);
            // 
            // idmatkulDataGridViewTextBoxColumn
            // 
            this.idmatkulDataGridViewTextBoxColumn.DataPropertyName = "id_matkul";
            this.idmatkulDataGridViewTextBoxColumn.HeaderText = "ID Matkul";
            this.idmatkulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idmatkulDataGridViewTextBoxColumn.Name = "idmatkulDataGridViewTextBoxColumn";
            // 
            // namamatkulDataGridViewTextBoxColumn
            // 
            this.namamatkulDataGridViewTextBoxColumn.DataPropertyName = "nama_matkul";
            this.namamatkulDataGridViewTextBoxColumn.HeaderText = "Nama Matkul";
            this.namamatkulDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namamatkulDataGridViewTextBoxColumn.Name = "namamatkulDataGridViewTextBoxColumn";
            // 
            // sksDataGridViewTextBoxColumn
            // 
            this.sksDataGridViewTextBoxColumn.DataPropertyName = "sks";
            this.sksDataGridViewTextBoxColumn.HeaderText = "SKS";
            this.sksDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sksDataGridViewTextBoxColumn.Name = "sksDataGridViewTextBoxColumn";
            // 
            // getListMatkulBindingSource
            // 
            this.getListMatkulBindingSource.DataMember = "getListMatkul";
            this.getListMatkulBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getListMatkulTableAdapter
            // 
            this.getListMatkulTableAdapter.ClearBeforeFill = true;
            // 
            // CRUDMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1526, 1048);
            this.Controls.Add(this.filterToolStrip);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDMatkul";
            this.Text = "CRUDMatkul1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDMatkul_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.filterToolStrip.ResumeLayout(false);
            this.filterToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getListMatkulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtMataKuliah;
        private Guna.UI2.WinForms.Guna2TextBox txtSks;
        private Guna.UI2.WinForms.Guna2TextBox txtIDMatkul;
        private System.Windows.Forms.BindingSource getListMatkulBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListMatkulTableAdapter getListMatkulTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sksDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip filterToolStrip;
        private System.Windows.Forms.ToolStripLabel nama_matkulToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nama_matkulToolStripTextBox;
        private System.Windows.Forms.ToolStripButton filterToolStripButton;
    }
}