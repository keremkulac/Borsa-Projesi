namespace WindowsFormsApp4
{
    partial class AdminPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGeri = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUrunOnay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUrunOnay = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dgvBeklemedeBakiye = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBeklemedeBakiyeOnay = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMevcutUye = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunOnay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeklemedeBakiye)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(16, 15);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(40, 36);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGeri.TabIndex = 21;
            this.btnGeri.TabStop = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(1617, 15);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(24, 24);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCikis.TabIndex = 29;
            this.btnCikis.TabStop = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dgvUrunOnay);
            this.groupBox1.Controls.Add(this.btnUrunOnay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(81, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1507, 292);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Satış Onayı Bekleyen Kullanıcılar";
            // 
            // dgvUrunOnay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUrunOnay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrunOnay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunOnay.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunOnay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUrunOnay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUrunOnay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunOnay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUrunOnay.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunOnay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunOnay.EnableHeadersVisualStyles = false;
            this.dgvUrunOnay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunOnay.Location = new System.Drawing.Point(19, 69);
            this.dgvUrunOnay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrunOnay.Name = "dgvUrunOnay";
            this.dgvUrunOnay.RowHeadersVisible = false;
            this.dgvUrunOnay.RowHeadersWidth = 51;
            this.dgvUrunOnay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunOnay.Size = new System.Drawing.Size(1463, 122);
            this.dgvUrunOnay.TabIndex = 27;
            this.dgvUrunOnay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunOnay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUrunOnay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUrunOnay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUrunOnay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUrunOnay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunOnay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUrunOnay.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvUrunOnay.ThemeStyle.ReadOnly = false;
            this.dgvUrunOnay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunOnay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUrunOnay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunOnay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Aqua;
            this.dgvUrunOnay.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUrunOnay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunOnay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUrunOnay
            // 
            this.btnUrunOnay.AutoRoundedCorners = true;
            this.btnUrunOnay.BorderRadius = 26;
            this.btnUrunOnay.CheckedState.Parent = this.btnUrunOnay;
            this.btnUrunOnay.CustomImages.Parent = this.btnUrunOnay;
            this.btnUrunOnay.DisabledState.Parent = this.btnUrunOnay;
            this.btnUrunOnay.FillColor = System.Drawing.Color.Aqua;
            this.btnUrunOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunOnay.ForeColor = System.Drawing.Color.Black;
            this.btnUrunOnay.HoverState.Parent = this.btnUrunOnay;
            this.btnUrunOnay.Location = new System.Drawing.Point(1228, 217);
            this.btnUrunOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunOnay.Name = "btnUrunOnay";
            this.btnUrunOnay.ShadowDecoration.Parent = this.btnUrunOnay;
            this.btnUrunOnay.Size = new System.Drawing.Size(253, 55);
            this.btnUrunOnay.TabIndex = 26;
            this.btnUrunOnay.Text = "Onayla";
            this.btnUrunOnay.Click += new System.EventHandler(this.btnUrunOnay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTarih);
            this.groupBox2.Controls.Add(this.dgvBeklemedeBakiye);
            this.groupBox2.Controls.Add(this.btnBeklemedeBakiyeOnay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(81, 358);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1507, 292);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye Onayı Bekleyen Kullanıcılar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(1335, 26);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 29);
            this.lblTarih.TabIndex = 29;
            // 
            // dgvBeklemedeBakiye
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBeklemedeBakiye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeklemedeBakiye.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeklemedeBakiye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBeklemedeBakiye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeklemedeBakiye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBeklemedeBakiye.ColumnHeadersHeight = 36;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeklemedeBakiye.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBeklemedeBakiye.EnableHeadersVisualStyles = false;
            this.dgvBeklemedeBakiye.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBeklemedeBakiye.Location = new System.Drawing.Point(19, 60);
            this.dgvBeklemedeBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBeklemedeBakiye.Name = "dgvBeklemedeBakiye";
            this.dgvBeklemedeBakiye.RowHeadersVisible = false;
            this.dgvBeklemedeBakiye.RowHeadersWidth = 51;
            this.dgvBeklemedeBakiye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeklemedeBakiye.Size = new System.Drawing.Size(1463, 122);
            this.dgvBeklemedeBakiye.TabIndex = 28;
            this.dgvBeklemedeBakiye.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBeklemedeBakiye.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBeklemedeBakiye.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBeklemedeBakiye.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBeklemedeBakiye.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBeklemedeBakiye.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvBeklemedeBakiye.ThemeStyle.ReadOnly = false;
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Aqua;
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBeklemedeBakiye.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBeklemedeBakiyeOnay
            // 
            this.btnBeklemedeBakiyeOnay.AutoRoundedCorners = true;
            this.btnBeklemedeBakiyeOnay.BorderRadius = 26;
            this.btnBeklemedeBakiyeOnay.CheckedState.Parent = this.btnBeklemedeBakiyeOnay;
            this.btnBeklemedeBakiyeOnay.CustomImages.Parent = this.btnBeklemedeBakiyeOnay;
            this.btnBeklemedeBakiyeOnay.DisabledState.Parent = this.btnBeklemedeBakiyeOnay;
            this.btnBeklemedeBakiyeOnay.FillColor = System.Drawing.Color.Aqua;
            this.btnBeklemedeBakiyeOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeklemedeBakiyeOnay.ForeColor = System.Drawing.Color.Black;
            this.btnBeklemedeBakiyeOnay.HoverState.Parent = this.btnBeklemedeBakiyeOnay;
            this.btnBeklemedeBakiyeOnay.Location = new System.Drawing.Point(1228, 208);
            this.btnBeklemedeBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeklemedeBakiyeOnay.Name = "btnBeklemedeBakiyeOnay";
            this.btnBeklemedeBakiyeOnay.ShadowDecoration.Parent = this.btnBeklemedeBakiyeOnay;
            this.btnBeklemedeBakiyeOnay.Size = new System.Drawing.Size(253, 55);
            this.btnBeklemedeBakiyeOnay.TabIndex = 27;
            this.btnBeklemedeBakiyeOnay.Text = "Onayla";
            this.btnBeklemedeBakiyeOnay.Click += new System.EventHandler(this.btnBeklemedeBakiyeOnay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMevcutUye);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox3.Location = new System.Drawing.Point(81, 663);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1507, 279);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut Üye Bilgileri";
            // 
            // dgvMevcutUye
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvMevcutUye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMevcutUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMevcutUye.BackgroundColor = System.Drawing.Color.White;
            this.dgvMevcutUye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMevcutUye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMevcutUye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMevcutUye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMevcutUye.ColumnHeadersHeight = 36;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMevcutUye.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMevcutUye.EnableHeadersVisualStyles = false;
            this.dgvMevcutUye.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMevcutUye.Location = new System.Drawing.Point(19, 60);
            this.dgvMevcutUye.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMevcutUye.Name = "dgvMevcutUye";
            this.dgvMevcutUye.RowHeadersVisible = false;
            this.dgvMevcutUye.RowHeadersWidth = 51;
            this.dgvMevcutUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMevcutUye.Size = new System.Drawing.Size(1463, 185);
            this.dgvMevcutUye.TabIndex = 1;
            this.dgvMevcutUye.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMevcutUye.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMevcutUye.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMevcutUye.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMevcutUye.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMevcutUye.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMevcutUye.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMevcutUye.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvMevcutUye.ThemeStyle.ReadOnly = false;
            this.dgvMevcutUye.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMevcutUye.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMevcutUye.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvMevcutUye.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Aqua;
            this.dgvMevcutUye.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMevcutUye.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMevcutUye.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1665, 967);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPaneli";
            this.Load += new System.EventHandler(this.AdminPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunOnay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeklemedeBakiye)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnGeri;
        private System.Windows.Forms.PictureBox btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUrunOnay;
        private Guna.UI2.WinForms.Guna2Button btnUrunOnay;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBeklemedeBakiye;
        private Guna.UI2.WinForms.Guna2Button btnBeklemedeBakiyeOnay;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMevcutUye;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}