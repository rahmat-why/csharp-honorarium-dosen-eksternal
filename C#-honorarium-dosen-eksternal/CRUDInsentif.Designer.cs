namespace C__honorarium_dosen_eksternal
{
    partial class CRUDInsentif
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtTahunBatasBawah = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTahunBatasAtas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtInsentifKehadiran = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDGolongan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaGolongan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tblGolongan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.getListGolonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honorariumDosenEksternalDataSet = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSet();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.getListGolonganTableAdapter = new C__honorarium_dosen_eksternal.HonorariumDosenEksternalDataSetTableAdapters.getListGolonganTableAdapter();
            this.col_id_golongan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nama_golongan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_insentif_kehadiran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tahun_batas_bawah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tahun_batas_atas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGolongan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListGolonganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.btnClear);
            this.guna2Panel1.Controls.Add(this.btnSave);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.txtTahunBatasBawah);
            this.guna2Panel1.Controls.Add(this.txtTahunBatasAtas);
            this.guna2Panel1.Controls.Add(this.txtInsentifKehadiran);
            this.guna2Panel1.Controls.Add(this.txtIDGolongan);
            this.guna2Panel1.Controls.Add(this.txtNamaGolongan);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(352, 647);
            this.guna2Panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Form Golongan Insentif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(20, -274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 41);
            this.label7.TabIndex = 48;
            this.label7.Text = "Data Dosen";
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
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.reload;
            this.btnClear.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClear.Location = new System.Drawing.Point(15, 375);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(322, 28);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Bersihkan";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.diskette1;
            this.btnSave.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSave.Location = new System.Drawing.Point(15, 341);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 28);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Tambah";
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
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.edit;
            this.btnUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.btnUpdate.Location = new System.Drawing.Point(125, 341);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 28);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
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
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Image = global::C__honorarium_dosen_eksternal.Properties.Resources.trash_can;
            this.btnDelete.ImageSize = new System.Drawing.Size(15, 15);
            this.btnDelete.Location = new System.Drawing.Point(230, 341);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 28);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtTahunBatasBawah
            // 
            this.txtTahunBatasBawah.AutoRoundedCorners = true;
            this.txtTahunBatasBawah.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTahunBatasBawah.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtTahunBatasBawah.BorderRadius = 15;
            this.txtTahunBatasBawah.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTahunBatasBawah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahunBatasBawah.DefaultText = "";
            this.txtTahunBatasBawah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahunBatasBawah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahunBatasBawah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunBatasBawah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunBatasBawah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunBatasBawah.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahunBatasBawah.ForeColor = System.Drawing.Color.Black;
            this.txtTahunBatasBawah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunBatasBawah.Location = new System.Drawing.Point(16, 216);
            this.txtTahunBatasBawah.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTahunBatasBawah.Name = "txtTahunBatasBawah";
            this.txtTahunBatasBawah.PasswordChar = '\0';
            this.txtTahunBatasBawah.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTahunBatasBawah.PlaceholderText = "Tahun Batas Bawah";
            this.txtTahunBatasBawah.SelectedText = "";
            this.txtTahunBatasBawah.Size = new System.Drawing.Size(322, 32);
            this.txtTahunBatasBawah.TabIndex = 43;
            this.txtTahunBatasBawah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahunBatasBawah_KeyPress);
            // 
            // txtTahunBatasAtas
            // 
            this.txtTahunBatasAtas.AutoRoundedCorners = true;
            this.txtTahunBatasAtas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTahunBatasAtas.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtTahunBatasAtas.BorderRadius = 15;
            this.txtTahunBatasAtas.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTahunBatasAtas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahunBatasAtas.DefaultText = "";
            this.txtTahunBatasAtas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahunBatasAtas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahunBatasAtas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunBatasAtas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunBatasAtas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunBatasAtas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahunBatasAtas.ForeColor = System.Drawing.Color.Black;
            this.txtTahunBatasAtas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunBatasAtas.Location = new System.Drawing.Point(16, 260);
            this.txtTahunBatasAtas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTahunBatasAtas.Name = "txtTahunBatasAtas";
            this.txtTahunBatasAtas.PasswordChar = '\0';
            this.txtTahunBatasAtas.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTahunBatasAtas.PlaceholderText = "Tahun Batas Atas";
            this.txtTahunBatasAtas.SelectedText = "";
            this.txtTahunBatasAtas.Size = new System.Drawing.Size(322, 32);
            this.txtTahunBatasAtas.TabIndex = 42;
            this.txtTahunBatasAtas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahunBatasAtas_KeyPress);
            // 
            // txtInsentifKehadiran
            // 
            this.txtInsentifKehadiran.AutoRoundedCorners = true;
            this.txtInsentifKehadiran.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInsentifKehadiran.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtInsentifKehadiran.BorderRadius = 15;
            this.txtInsentifKehadiran.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtInsentifKehadiran.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInsentifKehadiran.DefaultText = "";
            this.txtInsentifKehadiran.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInsentifKehadiran.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInsentifKehadiran.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsentifKehadiran.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInsentifKehadiran.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsentifKehadiran.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsentifKehadiran.ForeColor = System.Drawing.Color.Black;
            this.txtInsentifKehadiran.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInsentifKehadiran.Location = new System.Drawing.Point(16, 173);
            this.txtInsentifKehadiran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtInsentifKehadiran.Name = "txtInsentifKehadiran";
            this.txtInsentifKehadiran.PasswordChar = '\0';
            this.txtInsentifKehadiran.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtInsentifKehadiran.PlaceholderText = "Insentif Kehadiran";
            this.txtInsentifKehadiran.SelectedText = "";
            this.txtInsentifKehadiran.Size = new System.Drawing.Size(322, 32);
            this.txtInsentifKehadiran.TabIndex = 40;
            this.txtInsentifKehadiran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsentifKehadiran_KeyPress);
            // 
            // txtIDGolongan
            // 
            this.txtIDGolongan.AutoRoundedCorners = true;
            this.txtIDGolongan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDGolongan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtIDGolongan.BorderRadius = 15;
            this.txtIDGolongan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtIDGolongan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDGolongan.DefaultText = "ID Golongan (Otomatis)";
            this.txtIDGolongan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDGolongan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDGolongan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDGolongan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDGolongan.Enabled = false;
            this.txtIDGolongan.FillColor = System.Drawing.SystemColors.HighlightText;
            this.txtIDGolongan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDGolongan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGolongan.ForeColor = System.Drawing.Color.Black;
            this.txtIDGolongan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDGolongan.Location = new System.Drawing.Point(16, 86);
            this.txtIDGolongan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIDGolongan.Name = "txtIDGolongan";
            this.txtIDGolongan.PasswordChar = '\0';
            this.txtIDGolongan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIDGolongan.PlaceholderText = "ID Golongan (Otomatis)";
            this.txtIDGolongan.SelectedText = "";
            this.txtIDGolongan.Size = new System.Drawing.Size(322, 32);
            this.txtIDGolongan.TabIndex = 38;
            // 
            // txtNamaGolongan
            // 
            this.txtNamaGolongan.AutoRoundedCorners = true;
            this.txtNamaGolongan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNamaGolongan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtNamaGolongan.BorderRadius = 15;
            this.txtNamaGolongan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNamaGolongan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaGolongan.DefaultText = "";
            this.txtNamaGolongan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaGolongan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaGolongan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaGolongan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaGolongan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaGolongan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaGolongan.ForeColor = System.Drawing.Color.Black;
            this.txtNamaGolongan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaGolongan.Location = new System.Drawing.Point(16, 129);
            this.txtNamaGolongan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNamaGolongan.Name = "txtNamaGolongan";
            this.txtNamaGolongan.PasswordChar = '\0';
            this.txtNamaGolongan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNamaGolongan.PlaceholderText = "Nama Golongan";
            this.txtNamaGolongan.SelectedText = "";
            this.txtNamaGolongan.Size = new System.Drawing.Size(322, 32);
            this.txtNamaGolongan.TabIndex = 39;
            this.txtNamaGolongan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaGolongan_KeyPress);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.tblGolongan);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Location = new System.Drawing.Point(369, 12);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(641, 647);
            this.guna2Panel2.TabIndex = 38;
            // 
            // tblGolongan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tblGolongan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblGolongan.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblGolongan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblGolongan.ColumnHeadersHeight = 40;
            this.tblGolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblGolongan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_golongan,
            this.col_nama_golongan,
            this.col_insentif_kehadiran,
            this.col_tahun_batas_bawah,
            this.col_tahun_batas_atas});
            this.tblGolongan.DataSource = this.getListGolonganBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblGolongan.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblGolongan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblGolongan.Location = new System.Drawing.Point(16, 74);
            this.tblGolongan.Name = "tblGolongan";
            this.tblGolongan.RowHeadersVisible = false;
            this.tblGolongan.Size = new System.Drawing.Size(608, 550);
            this.tblGolongan.TabIndex = 46;
            this.tblGolongan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tblGolongan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tblGolongan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tblGolongan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tblGolongan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tblGolongan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tblGolongan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblGolongan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.tblGolongan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblGolongan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblGolongan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tblGolongan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tblGolongan.ThemeStyle.HeaderStyle.Height = 40;
            this.tblGolongan.ThemeStyle.ReadOnly = false;
            this.tblGolongan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tblGolongan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tblGolongan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblGolongan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tblGolongan.ThemeStyle.RowsStyle.Height = 22;
            this.tblGolongan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tblGolongan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            this.tblGolongan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblGolongan_CellClick);
            // 
            // getListGolonganBindingSource
            // 
            this.getListGolonganBindingSource.DataMember = "getListGolongan";
            this.getListGolonganBindingSource.DataSource = this.honorariumDosenEksternalDataSet;
            // 
            // honorariumDosenEksternalDataSet
            // 
            this.honorariumDosenEksternalDataSet.DataSetName = "HonorariumDosenEksternalDataSet";
            this.honorariumDosenEksternalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearch.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(465, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Cari disini...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(159, 32);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp_1);
            // 
            // getListGolonganTableAdapter
            // 
            this.getListGolonganTableAdapter.ClearBeforeFill = true;
            // 
            // col_id_golongan
            // 
            this.col_id_golongan.DataPropertyName = "id_golongan";
            this.col_id_golongan.HeaderText = "ID Golongan";
            this.col_id_golongan.Name = "col_id_golongan";
            // 
            // col_nama_golongan
            // 
            this.col_nama_golongan.DataPropertyName = "nama";
            this.col_nama_golongan.HeaderText = "Nama";
            this.col_nama_golongan.Name = "col_nama_golongan";
            // 
            // col_insentif_kehadiran
            // 
            this.col_insentif_kehadiran.DataPropertyName = "insentif_kehadiran";
            this.col_insentif_kehadiran.HeaderText = "Insentif";
            this.col_insentif_kehadiran.Name = "col_insentif_kehadiran";
            // 
            // col_tahun_batas_bawah
            // 
            this.col_tahun_batas_bawah.DataPropertyName = "tahun_batas_bawah";
            this.col_tahun_batas_bawah.HeaderText = "Tahun Atas";
            this.col_tahun_batas_bawah.Name = "col_tahun_batas_bawah";
            // 
            // col_tahun_batas_atas
            // 
            this.col_tahun_batas_atas.DataPropertyName = "tahun_batas_atas";
            this.col_tahun_batas_atas.HeaderText = "Tahun Bawah";
            this.col_tahun_batas_atas.Name = "col_tahun_batas_atas";
            // 
            // CRUDInsentif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUDInsentif";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDInsentif_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblGolongan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListGolonganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honorariumDosenEksternalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTahunBatasBawah;
        private Guna.UI2.WinForms.Guna2TextBox txtTahunBatasAtas;
        private Guna.UI2.WinForms.Guna2TextBox txtInsentifKehadiran;
        private Guna.UI2.WinForms.Guna2TextBox txtIDGolongan;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaGolongan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.BindingSource getListGolonganBindingSource;
        private HonorariumDosenEksternalDataSet honorariumDosenEksternalDataSet;
        private HonorariumDosenEksternalDataSetTableAdapters.getListGolonganTableAdapter getListGolonganTableAdapter;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView tblGolongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_golongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nama_golongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_insentif_kehadiran;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tahun_batas_bawah;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tahun_batas_atas;
    }
}