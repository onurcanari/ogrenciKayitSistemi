namespace StudentManagementSystem
{
    partial class anaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.aramaBilgiPaneli = new MetroFramework.Controls.MetroPanel();
            this.lAramaBilgi = new MetroFramework.Controls.MetroLabel();
            this.gridArananOgrenciler = new MetroFramework.Controls.MetroGrid();
            this.btnOgrenciAra = new MetroFramework.Controls.MetroButton();
            this.tbAranacakMetin = new MetroFramework.Controls.MetroTextBox();
            this.cbNeyeGore = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bildirimPaneli = new MetroFramework.Controls.MetroPanel();
            this.lbildirim = new MetroFramework.Controls.MetroLabel();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbOgrenciNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbTcKimlikNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbAd = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.gridOgrenciListesi = new MetroFramework.Controls.MetroGrid();
            this.yeniKullaniciEkle = new MetroFramework.Controls.MetroTabControl();
            this.bildirimYoket = new System.Windows.Forms.Timer(this.components);
            this.aramaBilgiYoket = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2.SuspendLayout();
            this.aramaBilgiPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArananOgrenciler)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.bildirimPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciListesi)).BeginInit();
            this.yeniKullaniciEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.aramaBilgiPaneli);
            this.metroTabPage2.Controls.Add(this.gridArananOgrenciler);
            this.metroTabPage2.Controls.Add(this.btnOgrenciAra);
            this.metroTabPage2.Controls.Add(this.tbAranacakMetin);
            this.metroTabPage2.Controls.Add(this.cbNeyeGore);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(893, 388);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Öğrenci Ara";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // aramaBilgiPaneli
            // 
            this.aramaBilgiPaneli.Controls.Add(this.lAramaBilgi);
            this.aramaBilgiPaneli.HorizontalScrollbarBarColor = true;
            this.aramaBilgiPaneli.HorizontalScrollbarHighlightOnWheel = false;
            this.aramaBilgiPaneli.HorizontalScrollbarSize = 10;
            this.aramaBilgiPaneli.Location = new System.Drawing.Point(627, 261);
            this.aramaBilgiPaneli.Name = "aramaBilgiPaneli";
            this.aramaBilgiPaneli.Size = new System.Drawing.Size(232, 83);
            this.aramaBilgiPaneli.TabIndex = 8;
            this.aramaBilgiPaneli.VerticalScrollbarBarColor = true;
            this.aramaBilgiPaneli.VerticalScrollbarHighlightOnWheel = false;
            this.aramaBilgiPaneli.VerticalScrollbarSize = 10;
            this.aramaBilgiPaneli.Visible = false;
            this.aramaBilgiPaneli.VisibleChanged += new System.EventHandler(this.AramaBilgiPaneli_VisibleChanged);
            // 
            // lAramaBilgi
            // 
            this.lAramaBilgi.AutoSize = true;
            this.lAramaBilgi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lAramaBilgi.ForeColor = System.Drawing.Color.Green;
            this.lAramaBilgi.Location = new System.Drawing.Point(9, 54);
            this.lAramaBilgi.Name = "lAramaBilgi";
            this.lAramaBilgi.Size = new System.Drawing.Size(94, 19);
            this.lAramaBilgi.TabIndex = 6;
            this.lAramaBilgi.Text = "metroLabel5";
            this.lAramaBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lAramaBilgi.UseCustomForeColor = true;
            // 
            // gridArananOgrenciler
            // 
            this.gridArananOgrenciler.AllowUserToAddRows = false;
            this.gridArananOgrenciler.AllowUserToDeleteRows = false;
            this.gridArananOgrenciler.AllowUserToResizeColumns = false;
            this.gridArananOgrenciler.AllowUserToResizeRows = false;
            this.gridArananOgrenciler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridArananOgrenciler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridArananOgrenciler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridArananOgrenciler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArananOgrenciler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArananOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridArananOgrenciler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridArananOgrenciler.EnableHeadersVisualStyles = false;
            this.gridArananOgrenciler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridArananOgrenciler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridArananOgrenciler.Location = new System.Drawing.Point(66, 66);
            this.gridArananOgrenciler.MultiSelect = false;
            this.gridArananOgrenciler.Name = "gridArananOgrenciler";
            this.gridArananOgrenciler.ReadOnly = true;
            this.gridArananOgrenciler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridArananOgrenciler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridArananOgrenciler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridArananOgrenciler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridArananOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArananOgrenciler.ShowEditingIcon = false;
            this.gridArananOgrenciler.ShowRowErrors = false;
            this.gridArananOgrenciler.Size = new System.Drawing.Size(524, 268);
            this.gridArananOgrenciler.TabIndex = 5;
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(636, 135);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(223, 29);
            this.btnOgrenciAra.TabIndex = 2;
            this.btnOgrenciAra.Text = "ARA";
            this.btnOgrenciAra.UseSelectable = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.BtnOgrenciAra_Click);
            // 
            // tbAranacakMetin
            // 
            // 
            // 
            // 
            this.tbAranacakMetin.CustomButton.Image = null;
            this.tbAranacakMetin.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.tbAranacakMetin.CustomButton.Name = "";
            this.tbAranacakMetin.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbAranacakMetin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAranacakMetin.CustomButton.TabIndex = 1;
            this.tbAranacakMetin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAranacakMetin.CustomButton.UseSelectable = true;
            this.tbAranacakMetin.CustomButton.Visible = false;
            this.tbAranacakMetin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbAranacakMetin.Lines = new string[0];
            this.tbAranacakMetin.Location = new System.Drawing.Point(636, 101);
            this.tbAranacakMetin.MaxLength = 32767;
            this.tbAranacakMetin.Name = "tbAranacakMetin";
            this.tbAranacakMetin.PasswordChar = '\0';
            this.tbAranacakMetin.PromptText = "Ara.....";
            this.tbAranacakMetin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAranacakMetin.SelectedText = "";
            this.tbAranacakMetin.SelectionLength = 0;
            this.tbAranacakMetin.SelectionStart = 0;
            this.tbAranacakMetin.ShortcutsEnabled = true;
            this.tbAranacakMetin.Size = new System.Drawing.Size(223, 28);
            this.tbAranacakMetin.TabIndex = 1;
            this.tbAranacakMetin.UseSelectable = true;
            this.tbAranacakMetin.WaterMark = "Ara.....";
            this.tbAranacakMetin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAranacakMetin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbNeyeGore
            // 
            this.cbNeyeGore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNeyeGore.FormattingEnabled = true;
            this.cbNeyeGore.ItemHeight = 23;
            this.cbNeyeGore.Items.AddRange(new object[] {
            "TC Kimlik No",
            "Ad",
            "Soyad",
            "Öğrenci No"});
            this.cbNeyeGore.Location = new System.Drawing.Point(636, 66);
            this.cbNeyeGore.MaxDropDownItems = 4;
            this.cbNeyeGore.Name = "cbNeyeGore";
            this.cbNeyeGore.PromptText = "Neye göre";
            this.cbNeyeGore.Size = new System.Drawing.Size(223, 29);
            this.cbNeyeGore.TabIndex = 0;
            this.cbNeyeGore.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.bildirimPaneli);
            this.metroTabPage1.Controls.Add(this.btnEkle);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.tbOgrenciNo);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.tbSoyad);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.tbTcKimlikNo);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tbAd);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(893, 388);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Yeni Öğrenci Ekle";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // bildirimPaneli
            // 
            this.bildirimPaneli.Controls.Add(this.lbildirim);
            this.bildirimPaneli.HorizontalScrollbarBarColor = true;
            this.bildirimPaneli.HorizontalScrollbarHighlightOnWheel = false;
            this.bildirimPaneli.HorizontalScrollbarSize = 10;
            this.bildirimPaneli.Location = new System.Drawing.Point(350, 335);
            this.bildirimPaneli.Name = "bildirimPaneli";
            this.bildirimPaneli.Size = new System.Drawing.Size(445, 30);
            this.bildirimPaneli.TabIndex = 11;
            this.bildirimPaneli.VerticalScrollbarBarColor = true;
            this.bildirimPaneli.VerticalScrollbarHighlightOnWheel = false;
            this.bildirimPaneli.VerticalScrollbarSize = 10;
            this.bildirimPaneli.Visible = false;
            this.bildirimPaneli.VisibleChanged += new System.EventHandler(this.BildirimPaneli_VisibleChanged);
            // 
            // lbildirim
            // 
            this.lbildirim.AutoSize = true;
            this.lbildirim.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbildirim.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbildirim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbildirim.Location = new System.Drawing.Point(12, 0);
            this.lbildirim.Name = "lbildirim";
            this.lbildirim.Size = new System.Drawing.Size(77, 25);
            this.lbildirim.Style = MetroFramework.MetroColorStyle.Green;
            this.lbildirim.TabIndex = 6;
            this.lbildirim.Text = "bildirim";
            this.lbildirim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbildirim.UseCustomForeColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEkle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnEkle.Location = new System.Drawing.Point(663, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 161);
            this.btnEkle.Style = MetroFramework.MetroColorStyle.Green;
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Yeni Öğrenci Ekle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Öğrenci No :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOgrenciNo
            // 
            // 
            // 
            // 
            this.tbOgrenciNo.CustomButton.Image = null;
            this.tbOgrenciNo.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tbOgrenciNo.CustomButton.Name = "";
            this.tbOgrenciNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbOgrenciNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbOgrenciNo.CustomButton.TabIndex = 1;
            this.tbOgrenciNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbOgrenciNo.CustomButton.UseSelectable = true;
            this.tbOgrenciNo.CustomButton.Visible = false;
            this.tbOgrenciNo.Lines = new string[] {
        "76852"};
            this.tbOgrenciNo.Location = new System.Drawing.Point(362, 218);
            this.tbOgrenciNo.MaxLength = 32767;
            this.tbOgrenciNo.Name = "tbOgrenciNo";
            this.tbOgrenciNo.PasswordChar = '\0';
            this.tbOgrenciNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOgrenciNo.SelectedText = "";
            this.tbOgrenciNo.SelectionLength = 0;
            this.tbOgrenciNo.SelectionStart = 0;
            this.tbOgrenciNo.ShortcutsEnabled = true;
            this.tbOgrenciNo.Size = new System.Drawing.Size(282, 23);
            this.tbOgrenciNo.TabIndex = 3;
            this.tbOgrenciNo.Text = "76852";
            this.tbOgrenciNo.UseSelectable = true;
            this.tbOgrenciNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbOgrenciNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(285, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Soyad :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSoyad
            // 
            // 
            // 
            // 
            this.tbSoyad.CustomButton.Image = null;
            this.tbSoyad.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tbSoyad.CustomButton.Name = "";
            this.tbSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSoyad.CustomButton.TabIndex = 1;
            this.tbSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSoyad.CustomButton.UseSelectable = true;
            this.tbSoyad.CustomButton.Visible = false;
            this.tbSoyad.Lines = new string[] {
        "memet"};
            this.tbSoyad.Location = new System.Drawing.Point(362, 170);
            this.tbSoyad.MaxLength = 32767;
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.PasswordChar = '\0';
            this.tbSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSoyad.SelectedText = "";
            this.tbSoyad.SelectionLength = 0;
            this.tbSoyad.SelectionStart = 0;
            this.tbSoyad.ShortcutsEnabled = true;
            this.tbSoyad.Size = new System.Drawing.Size(282, 23);
            this.tbSoyad.TabIndex = 2;
            this.tbSoyad.Text = "memet";
            this.tbSoyad.UseSelectable = true;
            this.tbSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(304, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Ad :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTcKimlikNo
            // 
            // 
            // 
            // 
            this.tbTcKimlikNo.CustomButton.Image = null;
            this.tbTcKimlikNo.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tbTcKimlikNo.CustomButton.Name = "";
            this.tbTcKimlikNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTcKimlikNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTcKimlikNo.CustomButton.TabIndex = 1;
            this.tbTcKimlikNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTcKimlikNo.CustomButton.UseSelectable = true;
            this.tbTcKimlikNo.CustomButton.Visible = false;
            this.tbTcKimlikNo.Lines = new string[] {
        "12582158"};
            this.tbTcKimlikNo.Location = new System.Drawing.Point(362, 80);
            this.tbTcKimlikNo.MaxLength = 32767;
            this.tbTcKimlikNo.Name = "tbTcKimlikNo";
            this.tbTcKimlikNo.PasswordChar = '\0';
            this.tbTcKimlikNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTcKimlikNo.SelectedText = "";
            this.tbTcKimlikNo.SelectionLength = 0;
            this.tbTcKimlikNo.SelectionStart = 0;
            this.tbTcKimlikNo.ShortcutsEnabled = true;
            this.tbTcKimlikNo.Size = new System.Drawing.Size(282, 23);
            this.tbTcKimlikNo.TabIndex = 0;
            this.tbTcKimlikNo.Text = "12582158";
            this.tbTcKimlikNo.UseSelectable = true;
            this.tbTcKimlikNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTcKimlikNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(246, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "TC Kimlik No :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAd
            // 
            // 
            // 
            // 
            this.tbAd.CustomButton.Image = null;
            this.tbAd.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tbAd.CustomButton.Name = "";
            this.tbAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAd.CustomButton.TabIndex = 1;
            this.tbAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAd.CustomButton.UseSelectable = true;
            this.tbAd.CustomButton.Visible = false;
            this.tbAd.Lines = new string[] {
        "deniz"};
            this.tbAd.Location = new System.Drawing.Point(362, 124);
            this.tbAd.MaxLength = 32767;
            this.tbAd.Name = "tbAd";
            this.tbAd.PasswordChar = '\0';
            this.tbAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAd.SelectedText = "";
            this.tbAd.SelectionLength = 0;
            this.tbAd.SelectionStart = 0;
            this.tbAd.ShortcutsEnabled = true;
            this.tbAd.Size = new System.Drawing.Size(282, 23);
            this.tbAd.TabIndex = 1;
            this.tbAd.Text = "deniz";
            this.tbAd.UseSelectable = true;
            this.tbAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OgrenciKayitSistemi.Properties.Resources.Blank_Club_Website_Avatar_Gray;
            this.pictureBox1.InitialImage = global::OgrenciKayitSistemi.Properties.Resources.Blank_Club_Website_Avatar_Gray;
            this.pictureBox1.Location = new System.Drawing.Point(78, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gridOgrenciListesi);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(893, 388);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Öğrenci Listesi";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // gridOgrenciListesi
            // 
            this.gridOgrenciListesi.AllowUserToAddRows = false;
            this.gridOgrenciListesi.AllowUserToDeleteRows = false;
            this.gridOgrenciListesi.AllowUserToResizeColumns = false;
            this.gridOgrenciListesi.AllowUserToResizeRows = false;
            this.gridOgrenciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOgrenciListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOgrenciListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOgrenciListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOgrenciListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOgrenciListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridOgrenciListesi.ColumnHeadersHeight = 30;
            this.gridOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOgrenciListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridOgrenciListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOgrenciListesi.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridOgrenciListesi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOgrenciListesi.EnableHeadersVisualStyles = false;
            this.gridOgrenciListesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridOgrenciListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOgrenciListesi.Location = new System.Drawing.Point(57, 27);
            this.gridOgrenciListesi.Name = "gridOgrenciListesi";
            this.gridOgrenciListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOgrenciListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOgrenciListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOgrenciListesi.RowTemplate.ReadOnly = true;
            this.gridOgrenciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOgrenciListesi.Size = new System.Drawing.Size(754, 324);
            this.gridOgrenciListesi.Style = MetroFramework.MetroColorStyle.Lime;
            this.gridOgrenciListesi.TabIndex = 2;
            // 
            // yeniKullaniciEkle
            // 
            this.yeniKullaniciEkle.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.yeniKullaniciEkle.Controls.Add(this.metroTabPage3);
            this.yeniKullaniciEkle.Controls.Add(this.metroTabPage1);
            this.yeniKullaniciEkle.Controls.Add(this.metroTabPage2);
            this.yeniKullaniciEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yeniKullaniciEkle.Location = new System.Drawing.Point(5, 60);
            this.yeniKullaniciEkle.Multiline = true;
            this.yeniKullaniciEkle.Name = "yeniKullaniciEkle";
            this.yeniKullaniciEkle.SelectedIndex = 0;
            this.yeniKullaniciEkle.Size = new System.Drawing.Size(901, 430);
            this.yeniKullaniciEkle.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.yeniKullaniciEkle.Style = MetroFramework.MetroColorStyle.Green;
            this.yeniKullaniciEkle.TabIndex = 0;
            this.yeniKullaniciEkle.UseSelectable = true;
            // 
            // bildirimYoket
            // 
            this.bildirimYoket.Interval = 2000;
            this.bildirimYoket.Tick += new System.EventHandler(this.BildirimYoket_Tick);
            // 
            // aramaBilgiYoket
            // 
            this.aramaBilgiYoket.Interval = 2000;
            this.aramaBilgiYoket.Tick += new System.EventHandler(this.AramaBilgiYoket_Tick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 490);
            this.Controls.Add(this.yeniKullaniciEkle);
            this.MaximizeBox = false;
            this.Name = "anaForm";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Öğrenci Kayıt Sistemi";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveCaption;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage2.ResumeLayout(false);
            this.aramaBilgiPaneli.ResumeLayout(false);
            this.aramaBilgiPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArananOgrenciler)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.bildirimPaneli.ResumeLayout(false);
            this.bildirimPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciListesi)).EndInit();
            this.yeniKullaniciEkle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnOgrenciAra;
        private MetroFramework.Controls.MetroTextBox tbAranacakMetin;
        private MetroFramework.Controls.MetroComboBox cbNeyeGore;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbOgrenciNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbTcKimlikNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroGrid gridOgrenciListesi;
        private MetroFramework.Controls.MetroTabControl yeniKullaniciEkle;
        private MetroFramework.Controls.MetroGrid gridArananOgrenciler;
        private MetroFramework.Controls.MetroPanel aramaBilgiPaneli;
        private MetroFramework.Controls.MetroLabel lAramaBilgi;
        private System.Windows.Forms.Timer bildirimYoket;
        private MetroFramework.Controls.MetroPanel bildirimPaneli;
        private MetroFramework.Controls.MetroLabel lbildirim;
        private System.Windows.Forms.Timer aramaBilgiYoket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

