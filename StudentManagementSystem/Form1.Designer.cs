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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.yeniKullaniciEkle = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.gridOgrenciListesi = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnOgrenciAra = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.yeniKullaniciEkle.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciListesi)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.yeniKullaniciEkle.Size = new System.Drawing.Size(922, 430);
            this.yeniKullaniciEkle.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.yeniKullaniciEkle.Style = MetroFramework.MetroColorStyle.Green;
            this.yeniKullaniciEkle.TabIndex = 0;
            this.yeniKullaniciEkle.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gridOgrenciListesi);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(914, 388);
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
            this.gridOgrenciListesi.BackgroundColor = System.Drawing.Color.Honeydew;
            this.gridOgrenciListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOgrenciListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOgrenciListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOgrenciListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOgrenciListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOgrenciListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridOgrenciListesi.EnableHeadersVisualStyles = false;
            this.gridOgrenciListesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridOgrenciListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOgrenciListesi.Location = new System.Drawing.Point(57, 27);
            this.gridOgrenciListesi.Name = "gridOgrenciListesi";
            this.gridOgrenciListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOgrenciListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridOgrenciListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOgrenciListesi.RowTemplate.ReadOnly = true;
            this.gridOgrenciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOgrenciListesi.Size = new System.Drawing.Size(776, 324);
            this.gridOgrenciListesi.Style = MetroFramework.MetroColorStyle.Lime;
            this.gridOgrenciListesi.TabIndex = 2;
            this.gridOgrenciListesi.DataSourceChanged += new System.EventHandler(this.GridOgrenciListesi_DataSourceChanged);
            this.gridOgrenciListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOgrenciListesi_CellContentClick);
            // 
            // metroTabPage1
            // 
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
            this.metroTabPage1.Size = new System.Drawing.Size(914, 388);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Yeni Öğrenci Ekle";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnEkle.Location = new System.Drawing.Point(663, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(132, 161);
            this.btnEkle.Style = MetroFramework.MetroColorStyle.Green;
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "+";
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
            this.tbOgrenciNo.Lines = new string[0];
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
            this.tbSoyad.Lines = new string[0];
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
            this.tbTcKimlikNo.Lines = new string[0];
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
            this.tbAd.Lines = new string[0];
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
            this.tbAd.UseSelectable = true;
            this.tbAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 190);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnOgrenciAra);
            this.metroTabPage2.Controls.Add(this.metroTextBox1);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(914, 388);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Öğrenci Ara";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Location = new System.Drawing.Point(732, 31);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(93, 28);
            this.btnOgrenciAra.TabIndex = 2;
            this.btnOgrenciAra.Text = "ARA";
            this.btnOgrenciAra.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(439, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(261, 32);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Ara.....";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(465, 28);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Ara.....";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "TC Kimlik No",
            "Ad",
            "Soyad",
            "Öğrenci No"});
            this.metroComboBox1.Location = new System.Drawing.Point(66, 31);
            this.metroComboBox1.MaxDropDownItems = 4;
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "Neye göre";
            this.metroComboBox1.Size = new System.Drawing.Size(189, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 490);
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
            this.yeniKullaniciEkle.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciListesi)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbOgrenciNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbTcKimlikNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnOgrenciAra;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroGrid gridOgrenciListesi;
        private MetroFramework.Controls.MetroTabControl yeniKullaniciEkle;
    }
}

