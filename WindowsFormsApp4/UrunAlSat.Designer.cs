
namespace WindowsFormsApp4
{
    partial class UrunAlSat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunAlSat));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBakiyeMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbParaBirimi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUrunler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrunAlFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUrunAl = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrunAlMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbUrunSecimi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUrunSat = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrunSatMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUrunSatFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUrunAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikisYap = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboRaporTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnCiktiAl = new Guna.UI2.WinForms.Guna2Button();
            this.raporTarihBitis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.raporTarihBaslangic = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri git";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(842, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bakiye Yükle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBakiyeMiktar);
            this.groupBox3.Controls.Add(this.lblBakiye);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbParaBirimi);
            this.groupBox3.Controls.Add(this.guna2Button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox3.Location = new System.Drawing.Point(24, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 329);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bakiye Yükle";
            // 
            // txtBakiyeMiktar
            // 
            this.txtBakiyeMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBakiyeMiktar.DefaultText = "";
            this.txtBakiyeMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBakiyeMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBakiyeMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiyeMiktar.DisabledState.Parent = this.txtBakiyeMiktar;
            this.txtBakiyeMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiyeMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiyeMiktar.FocusedState.Parent = this.txtBakiyeMiktar;
            this.txtBakiyeMiktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBakiyeMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiyeMiktar.HoverState.Parent = this.txtBakiyeMiktar;
            this.txtBakiyeMiktar.Location = new System.Drawing.Point(142, 151);
            this.txtBakiyeMiktar.Name = "txtBakiyeMiktar";
            this.txtBakiyeMiktar.PasswordChar = '\0';
            this.txtBakiyeMiktar.PlaceholderText = "";
            this.txtBakiyeMiktar.SelectedText = "";
            this.txtBakiyeMiktar.ShadowDecoration.Parent = this.txtBakiyeMiktar;
            this.txtBakiyeMiktar.Size = new System.Drawing.Size(108, 36);
            this.txtBakiyeMiktar.TabIndex = 35;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(679, 26);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 25);
            this.lblBakiye.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Para Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(581, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bakiyem:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "Para Birimi";
            // 
            // cmbParaBirimi
            // 
            this.cmbParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.cmbParaBirimi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParaBirimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParaBirimi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbParaBirimi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbParaBirimi.FocusedState.Parent = this.cmbParaBirimi;
            this.cmbParaBirimi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbParaBirimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbParaBirimi.HoverState.Parent = this.cmbParaBirimi;
            this.cmbParaBirimi.ItemHeight = 30;
            this.cmbParaBirimi.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "JPY",
            "AUD",
            "DKK",
            "GBP",
            "CHF",
            "SEK",
            "CAD"});
            this.cmbParaBirimi.ItemsAppearance.Parent = this.cmbParaBirimi;
            this.cmbParaBirimi.Location = new System.Drawing.Point(142, 72);
            this.cmbParaBirimi.Name = "cmbParaBirimi";
            this.cmbParaBirimi.ShadowDecoration.Parent = this.cmbParaBirimi;
            this.cmbParaBirimi.Size = new System.Drawing.Size(108, 36);
            this.cmbParaBirimi.TabIndex = 32;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Aqua;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(162, 223);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(88, 36);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "Onayla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(553, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(451, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(367, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Onaylanmamış Bakiye:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(367, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bakiyem:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage2.Controls.Add(this.dgvUrunler);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün Al";
            // 
            // dgvUrunler
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUrunler.ColumnHeadersHeight = 36;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUrunler.EnableHeadersVisualStyles = false;
            this.dgvUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.Location = new System.Drawing.Point(8, 215);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(753, 150);
            this.dgvUrunler.TabIndex = 26;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUrunler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUrunler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUrunler.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvUrunler.ThemeStyle.ReadOnly = false;
            this.dgvUrunler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUrunler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUrunler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUrunler.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUrunler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUrunler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUrunAlFiyat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnUrunAl);
            this.groupBox2.Controls.Add(this.txtUrunAlMiktar);
            this.groupBox2.Controls.Add(this.cmbUrunSecimi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(9, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(754, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Al";
            // 
            // txtUrunAlFiyat
            // 
            this.txtUrunAlFiyat.AutoRoundedCorners = true;
            this.txtUrunAlFiyat.BorderRadius = 17;
            this.txtUrunAlFiyat.BorderThickness = 0;
            this.txtUrunAlFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAlFiyat.DefaultText = "";
            this.txtUrunAlFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAlFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAlFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAlFiyat.DisabledState.Parent = this.txtUrunAlFiyat;
            this.txtUrunAlFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAlFiyat.FillColor = System.Drawing.Color.Silver;
            this.txtUrunAlFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAlFiyat.FocusedState.Parent = this.txtUrunAlFiyat;
            this.txtUrunAlFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtUrunAlFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAlFiyat.HoverState.Parent = this.txtUrunAlFiyat;
            this.txtUrunAlFiyat.Location = new System.Drawing.Point(497, 26);
            this.txtUrunAlFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAlFiyat.Name = "txtUrunAlFiyat";
            this.txtUrunAlFiyat.PasswordChar = '\0';
            this.txtUrunAlFiyat.PlaceholderText = "";
            this.txtUrunAlFiyat.SelectedText = "";
            this.txtUrunAlFiyat.ShadowDecoration.Parent = this.txtUrunAlFiyat;
            this.txtUrunAlFiyat.Size = new System.Drawing.Size(189, 36);
            this.txtUrunAlFiyat.TabIndex = 10;
            this.txtUrunAlFiyat.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(338, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fiyat (İsteğe bağlı):";
            // 
            // btnUrunAl
            // 
            this.btnUrunAl.AutoRoundedCorners = true;
            this.btnUrunAl.BorderRadius = 19;
            this.btnUrunAl.CheckedState.Parent = this.btnUrunAl;
            this.btnUrunAl.CustomImages.Parent = this.btnUrunAl;
            this.btnUrunAl.DisabledState.Parent = this.btnUrunAl;
            this.btnUrunAl.FillColor = System.Drawing.Color.Aqua;
            this.btnUrunAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btnUrunAl.ForeColor = System.Drawing.Color.Black;
            this.btnUrunAl.HoverState.Parent = this.btnUrunAl;
            this.btnUrunAl.Location = new System.Drawing.Point(128, 114);
            this.btnUrunAl.Name = "btnUrunAl";
            this.btnUrunAl.ShadowDecoration.Parent = this.btnUrunAl;
            this.btnUrunAl.Size = new System.Drawing.Size(125, 40);
            this.btnUrunAl.TabIndex = 8;
            this.btnUrunAl.Text = "Onayla";
            this.btnUrunAl.Click += new System.EventHandler(this.btnUrunAl_Click);
            // 
            // txtUrunAlMiktar
            // 
            this.txtUrunAlMiktar.AutoRoundedCorners = true;
            this.txtUrunAlMiktar.BorderRadius = 17;
            this.txtUrunAlMiktar.BorderThickness = 0;
            this.txtUrunAlMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAlMiktar.DefaultText = "";
            this.txtUrunAlMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAlMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAlMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAlMiktar.DisabledState.Parent = this.txtUrunAlMiktar;
            this.txtUrunAlMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAlMiktar.FillColor = System.Drawing.Color.Silver;
            this.txtUrunAlMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAlMiktar.FocusedState.Parent = this.txtUrunAlMiktar;
            this.txtUrunAlMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtUrunAlMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtUrunAlMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAlMiktar.HoverState.Parent = this.txtUrunAlMiktar;
            this.txtUrunAlMiktar.Location = new System.Drawing.Point(128, 68);
            this.txtUrunAlMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAlMiktar.Name = "txtUrunAlMiktar";
            this.txtUrunAlMiktar.PasswordChar = '\0';
            this.txtUrunAlMiktar.PlaceholderText = "";
            this.txtUrunAlMiktar.SelectedText = "";
            this.txtUrunAlMiktar.ShadowDecoration.Parent = this.txtUrunAlMiktar;
            this.txtUrunAlMiktar.Size = new System.Drawing.Size(189, 36);
            this.txtUrunAlMiktar.TabIndex = 7;
            this.txtUrunAlMiktar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // cmbUrunSecimi
            // 
            this.cmbUrunSecimi.AutoRoundedCorners = true;
            this.cmbUrunSecimi.BackColor = System.Drawing.Color.Transparent;
            this.cmbUrunSecimi.BorderRadius = 17;
            this.cmbUrunSecimi.BorderThickness = 0;
            this.cmbUrunSecimi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUrunSecimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunSecimi.FillColor = System.Drawing.Color.Silver;
            this.cmbUrunSecimi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUrunSecimi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUrunSecimi.FocusedState.Parent = this.cmbUrunSecimi;
            this.cmbUrunSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunSecimi.ForeColor = System.Drawing.Color.Black;
            this.cmbUrunSecimi.HoverState.Parent = this.cmbUrunSecimi;
            this.cmbUrunSecimi.ItemHeight = 30;
            this.cmbUrunSecimi.ItemsAppearance.Parent = this.cmbUrunSecimi;
            this.cmbUrunSecimi.Location = new System.Drawing.Point(128, 26);
            this.cmbUrunSecimi.Name = "cmbUrunSecimi";
            this.cmbUrunSecimi.ShadowDecoration.Parent = this.cmbUrunSecimi;
            this.cmbUrunSecimi.Size = new System.Drawing.Size(189, 36);
            this.cmbUrunSecimi.TabIndex = 6;
            this.cmbUrunSecimi.TextOffset = new System.Drawing.Point(10, 0);
            this.cmbUrunSecimi.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(14, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Miktar(kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Seçiniz:";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.ForeColor = System.Drawing.Color.Aqua;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün Sat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUrunSat);
            this.groupBox1.Controls.Add(this.txtUrunSatMiktar);
            this.groupBox1.Controls.Add(this.txtUrunSatFiyat);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(732, 285);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Sat";
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.AutoRoundedCorners = true;
            this.btnUrunSat.BorderRadius = 21;
            this.btnUrunSat.CheckedState.Parent = this.btnUrunSat;
            this.btnUrunSat.CustomImages.Parent = this.btnUrunSat;
            this.btnUrunSat.DisabledState.Parent = this.btnUrunSat;
            this.btnUrunSat.FillColor = System.Drawing.Color.Aqua;
            this.btnUrunSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSat.ForeColor = System.Drawing.Color.Black;
            this.btnUrunSat.HoverState.Parent = this.btnUrunSat;
            this.btnUrunSat.Location = new System.Drawing.Point(340, 216);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.ShadowDecoration.Parent = this.btnUrunSat;
            this.btnUrunSat.Size = new System.Drawing.Size(180, 45);
            this.btnUrunSat.TabIndex = 11;
            this.btnUrunSat.Text = "Onayla";
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // txtUrunSatMiktar
            // 
            this.txtUrunSatMiktar.BorderRadius = 16;
            this.txtUrunSatMiktar.BorderThickness = 0;
            this.txtUrunSatMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunSatMiktar.DefaultText = "";
            this.txtUrunSatMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunSatMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunSatMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunSatMiktar.DisabledState.Parent = this.txtUrunSatMiktar;
            this.txtUrunSatMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunSatMiktar.FillColor = System.Drawing.Color.Silver;
            this.txtUrunSatMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunSatMiktar.FocusedState.Parent = this.txtUrunSatMiktar;
            this.txtUrunSatMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunSatMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtUrunSatMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunSatMiktar.HoverState.Parent = this.txtUrunSatMiktar;
            this.txtUrunSatMiktar.Location = new System.Drawing.Point(320, 159);
            this.txtUrunSatMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunSatMiktar.Name = "txtUrunSatMiktar";
            this.txtUrunSatMiktar.PasswordChar = '\0';
            this.txtUrunSatMiktar.PlaceholderText = "";
            this.txtUrunSatMiktar.SelectedText = "";
            this.txtUrunSatMiktar.ShadowDecoration.Parent = this.txtUrunSatMiktar;
            this.txtUrunSatMiktar.Size = new System.Drawing.Size(200, 36);
            this.txtUrunSatMiktar.TabIndex = 10;
            this.txtUrunSatMiktar.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtUrunSatFiyat
            // 
            this.txtUrunSatFiyat.AutoRoundedCorners = true;
            this.txtUrunSatFiyat.BorderRadius = 17;
            this.txtUrunSatFiyat.BorderThickness = 0;
            this.txtUrunSatFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunSatFiyat.DefaultText = "";
            this.txtUrunSatFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunSatFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunSatFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunSatFiyat.DisabledState.Parent = this.txtUrunSatFiyat;
            this.txtUrunSatFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunSatFiyat.FillColor = System.Drawing.Color.Silver;
            this.txtUrunSatFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunSatFiyat.FocusedState.Parent = this.txtUrunSatFiyat;
            this.txtUrunSatFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunSatFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtUrunSatFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunSatFiyat.HoverState.Parent = this.txtUrunSatFiyat;
            this.txtUrunSatFiyat.Location = new System.Drawing.Point(320, 102);
            this.txtUrunSatFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunSatFiyat.Name = "txtUrunSatFiyat";
            this.txtUrunSatFiyat.PasswordChar = '\0';
            this.txtUrunSatFiyat.PlaceholderText = "";
            this.txtUrunSatFiyat.SelectedText = "";
            this.txtUrunSatFiyat.ShadowDecoration.Parent = this.txtUrunSatFiyat;
            this.txtUrunSatFiyat.Size = new System.Drawing.Size(200, 36);
            this.txtUrunSatFiyat.TabIndex = 9;
            this.txtUrunSatFiyat.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.AutoRoundedCorners = true;
            this.txtUrunAd.BorderRadius = 17;
            this.txtUrunAd.BorderThickness = 0;
            this.txtUrunAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAd.DefaultText = "";
            this.txtUrunAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAd.DisabledState.Parent = this.txtUrunAd;
            this.txtUrunAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAd.FillColor = System.Drawing.Color.Silver;
            this.txtUrunAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAd.FocusedState.Parent = this.txtUrunAd;
            this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.ForeColor = System.Drawing.Color.Black;
            this.txtUrunAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAd.HoverState.Parent = this.txtUrunAd;
            this.txtUrunAd.Location = new System.Drawing.Point(320, 42);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.PasswordChar = '\0';
            this.txtUrunAd.PlaceholderText = "";
            this.txtUrunAd.SelectedText = "";
            this.txtUrunAd.ShadowDecoration.Parent = this.txtUrunAd;
            this.txtUrunAd.Size = new System.Drawing.Size(200, 36);
            this.txtUrunAd.TabIndex = 8;
            this.txtUrunAd.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(100, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Miktarı Giriniz(kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(100, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünün Kilogram\r\n Fiyatını Giriniz(TL):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.Image")));
            this.btnCikisYap.Location = new System.Drawing.Point(826, 12);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(24, 24);
            this.btnCikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCikisYap.TabIndex = 23;
            this.btnCikisYap.TabStop = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.Image")));
            this.btnGeri.Location = new System.Drawing.Point(12, 7);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(30, 29);
            this.btnGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGeri.TabIndex = 22;
            this.btnGeri.TabStop = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 434);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboRaporTuru);
            this.tabPage4.Controls.Add(this.pictureBox7);
            this.tabPage4.Controls.Add(this.pictureBox8);
            this.tabPage4.Controls.Add(this.btnCiktiAl);
            this.tabPage4.Controls.Add(this.raporTarihBitis);
            this.tabPage4.Controls.Add(this.raporTarihBaslangic);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(842, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboRaporTuru
            // 
            this.comboRaporTuru.BackColor = System.Drawing.Color.Transparent;
            this.comboRaporTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRaporTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRaporTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRaporTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRaporTuru.FocusedState.Parent = this.comboRaporTuru;
            this.comboRaporTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRaporTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboRaporTuru.HoverState.Parent = this.comboRaporTuru;
            this.comboRaporTuru.ItemHeight = 30;
            this.comboRaporTuru.Items.AddRange(new object[] {
            "CSV",
            "XLSX",
            "DAT",
            "PDF"});
            this.comboRaporTuru.ItemsAppearance.Parent = this.comboRaporTuru;
            this.comboRaporTuru.Location = new System.Drawing.Point(336, 174);
            this.comboRaporTuru.Name = "comboRaporTuru";
            this.comboRaporTuru.ShadowDecoration.Parent = this.comboRaporTuru;
            this.comboRaporTuru.Size = new System.Drawing.Size(140, 36);
            this.comboRaporTuru.TabIndex = 30;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(822, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(786, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.CheckedState.Parent = this.btnCiktiAl;
            this.btnCiktiAl.CustomImages.Parent = this.btnCiktiAl;
            this.btnCiktiAl.DisabledState.Parent = this.btnCiktiAl;
            this.btnCiktiAl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCiktiAl.ForeColor = System.Drawing.Color.White;
            this.btnCiktiAl.HoverState.Parent = this.btnCiktiAl;
            this.btnCiktiAl.Location = new System.Drawing.Point(315, 253);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.ShadowDecoration.Parent = this.btnCiktiAl;
            this.btnCiktiAl.Size = new System.Drawing.Size(180, 45);
            this.btnCiktiAl.TabIndex = 2;
            this.btnCiktiAl.Text = "Çıktı Al";
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // raporTarihBitis
            // 
            this.raporTarihBitis.CheckedState.Parent = this.raporTarihBitis;
            this.raporTarihBitis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.raporTarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.raporTarihBitis.HoverState.Parent = this.raporTarihBitis;
            this.raporTarihBitis.Location = new System.Drawing.Point(441, 101);
            this.raporTarihBitis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.raporTarihBitis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.raporTarihBitis.Name = "raporTarihBitis";
            this.raporTarihBitis.ShadowDecoration.Parent = this.raporTarihBitis;
            this.raporTarihBitis.Size = new System.Drawing.Size(200, 36);
            this.raporTarihBitis.TabIndex = 1;
            this.raporTarihBitis.Value = new System.DateTime(2021, 6, 16, 21, 47, 25, 989);
            // 
            // raporTarihBaslangic
            // 
            this.raporTarihBaslangic.CheckedState.Parent = this.raporTarihBaslangic;
            this.raporTarihBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.raporTarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.raporTarihBaslangic.HoverState.Parent = this.raporTarihBaslangic;
            this.raporTarihBaslangic.Location = new System.Drawing.Point(179, 101);
            this.raporTarihBaslangic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.raporTarihBaslangic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.raporTarihBaslangic.Name = "raporTarihBaslangic";
            this.raporTarihBaslangic.ShadowDecoration.Parent = this.raporTarihBaslangic;
            this.raporTarihBaslangic.Size = new System.Drawing.Size(200, 36);
            this.raporTarihBaslangic.TabIndex = 0;
            this.raporTarihBaslangic.Value = new System.DateTime(2021, 6, 16, 21, 47, 25, 989);
            // 
            // UrunAlSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(907, 522);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunAlSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Alım-Satım";
            this.Load += new System.EventHandler(this.UrunAlSat_Load);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeri)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunSatMiktar;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunSatFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private Guna.UI2.WinForms.Guna2Button btnUrunSat;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAlMiktar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUrunSecimi;
        private Guna.UI2.WinForms.Guna2Button btnUrunAl;
        private System.Windows.Forms.PictureBox btnCikisYap;
        private System.Windows.Forms.PictureBox btnGeri;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAlFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2DateTimePicker raporTarihBaslangic;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Guna.UI2.WinForms.Guna2Button btnCiktiAl;
        private Guna.UI2.WinForms.Guna2DateTimePicker raporTarihBitis;
        private Guna.UI2.WinForms.Guna2ComboBox comboRaporTuru;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUrunler;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtBakiyeMiktar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox cmbParaBirimi;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}