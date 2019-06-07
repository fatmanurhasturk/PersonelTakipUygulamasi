namespace _04_PersonelTakipUygulamasi
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.grbPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.btnSilinenleriGoster = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nudCocukSayisi = new System.Windows.Forms.NumericUpDown();
            this.chbE = new System.Windows.Forms.CheckBox();
            this.chbC = new System.Windows.Forms.CheckBox();
            this.chbB = new System.Windows.Forms.CheckBox();
            this.chbA2 = new System.Windows.Forms.CheckBox();
            this.chbA1 = new System.Windows.Forms.CheckBox();
            this.pnlCinsiyet = new System.Windows.Forms.Panel();
            this.rdbDiger = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.pnlMedeniHal = new System.Windows.Forms.Panel();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.pcbPersonelResmi = new System.Windows.Forms.PictureBox();
            this.contextMenuStripResimIslemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaldirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblCocukSayisi = new System.Windows.Forms.Label();
            this.lblEhliyet = new System.Windows.Forms.Label();
            this.lblMedeniHal = new System.Windows.Forms.Label();
            this.lblIseBaslamaTarihi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.toolTipBilgi = new System.Windows.Forms.ToolTip(this.components);
            this.lstPersoneller = new System.Windows.Forms.ListView();
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconIK = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tamEkranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogResim = new System.Windows.Forms.OpenFileDialog();
            this.grbPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocukSayisi)).BeginInit();
            this.pnlCinsiyet.SuspendLayout();
            this.pnlMedeniHal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonelResmi)).BeginInit();
            this.contextMenuStripResimIslemleri.SuspendLayout();
            this.contextMenuStripListView.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(140, 25);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 26);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KontrolluHarfAl);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(14, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // grbPersonelBilgileri
            // 
            this.grbPersonelBilgileri.Controls.Add(this.btnSilinenleriGoster);
            this.grbPersonelBilgileri.Controls.Add(this.btnIptal);
            this.grbPersonelBilgileri.Controls.Add(this.btnKaydet);
            this.grbPersonelBilgileri.Controls.Add(this.nudCocukSayisi);
            this.grbPersonelBilgileri.Controls.Add(this.chbE);
            this.grbPersonelBilgileri.Controls.Add(this.chbC);
            this.grbPersonelBilgileri.Controls.Add(this.chbB);
            this.grbPersonelBilgileri.Controls.Add(this.chbA2);
            this.grbPersonelBilgileri.Controls.Add(this.chbA1);
            this.grbPersonelBilgileri.Controls.Add(this.pnlCinsiyet);
            this.grbPersonelBilgileri.Controls.Add(this.pnlMedeniHal);
            this.grbPersonelBilgileri.Controls.Add(this.pcbPersonelResmi);
            this.grbPersonelBilgileri.Controls.Add(this.dtpIseBaslamaTarihi);
            this.grbPersonelBilgileri.Controls.Add(this.dtpDogumTarihi);
            this.grbPersonelBilgileri.Controls.Add(this.cmbDepartmanlar);
            this.grbPersonelBilgileri.Controls.Add(this.mtxtTelefon);
            this.grbPersonelBilgileri.Controls.Add(this.txtAdres);
            this.grbPersonelBilgileri.Controls.Add(this.lblAdres);
            this.grbPersonelBilgileri.Controls.Add(this.txtEmail);
            this.grbPersonelBilgileri.Controls.Add(this.lblEmail);
            this.grbPersonelBilgileri.Controls.Add(this.lblTelefon);
            this.grbPersonelBilgileri.Controls.Add(this.txtSoyad);
            this.grbPersonelBilgileri.Controls.Add(this.lblCinsiyet);
            this.grbPersonelBilgileri.Controls.Add(this.lblCocukSayisi);
            this.grbPersonelBilgileri.Controls.Add(this.lblEhliyet);
            this.grbPersonelBilgileri.Controls.Add(this.lblMedeniHal);
            this.grbPersonelBilgileri.Controls.Add(this.lblIseBaslamaTarihi);
            this.grbPersonelBilgileri.Controls.Add(this.lblDogumTarihi);
            this.grbPersonelBilgileri.Controls.Add(this.lblSoyad);
            this.grbPersonelBilgileri.Controls.Add(this.txtAd);
            this.grbPersonelBilgileri.Controls.Add(this.lblDepartman);
            this.grbPersonelBilgileri.Controls.Add(this.lblAd);
            this.grbPersonelBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonelBilgileri.Location = new System.Drawing.Point(4, 5);
            this.grbPersonelBilgileri.Name = "grbPersonelBilgileri";
            this.grbPersonelBilgileri.Size = new System.Drawing.Size(900, 337);
            this.grbPersonelBilgileri.TabIndex = 2;
            this.grbPersonelBilgileri.TabStop = false;
            this.grbPersonelBilgileri.Text = "Personel Bilgileri";
            this.grbPersonelBilgileri.Enter += new System.EventHandler(this.grbPersonelBilgileri_Enter);
            // 
            // btnSilinenleriGoster
            // 
            this.btnSilinenleriGoster.Location = new System.Drawing.Point(6, 304);
            this.btnSilinenleriGoster.Name = "btnSilinenleriGoster";
            this.btnSilinenleriGoster.Size = new System.Drawing.Size(156, 27);
            this.btnSilinenleriGoster.TabIndex = 12;
            this.btnSilinenleriGoster.Text = "Silinenleri Göster";
            this.btnSilinenleriGoster.UseVisualStyleBackColor = true;
            this.btnSilinenleriGoster.Click += new System.EventHandler(this.btnSilinenleriGoster_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(611, 249);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(127, 53);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(744, 249);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(127, 53);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nudCocukSayisi
            // 
            this.nudCocukSayisi.Location = new System.Drawing.Point(551, 160);
            this.nudCocukSayisi.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCocukSayisi.Name = "nudCocukSayisi";
            this.nudCocukSayisi.Size = new System.Drawing.Size(52, 26);
            this.nudCocukSayisi.TabIndex = 9;
            // 
            // chbE
            // 
            this.chbE.AutoSize = true;
            this.chbE.Location = new System.Drawing.Point(672, 129);
            this.chbE.Name = "chbE";
            this.chbE.Size = new System.Drawing.Size(39, 24);
            this.chbE.TabIndex = 8;
            this.chbE.Text = "E";
            this.chbE.UseVisualStyleBackColor = true;
            // 
            // chbC
            // 
            this.chbC.AutoSize = true;
            this.chbC.Location = new System.Drawing.Point(627, 128);
            this.chbC.Name = "chbC";
            this.chbC.Size = new System.Drawing.Size(39, 24);
            this.chbC.TabIndex = 8;
            this.chbC.Text = "C";
            this.chbC.UseVisualStyleBackColor = true;
            // 
            // chbB
            // 
            this.chbB.AutoSize = true;
            this.chbB.Location = new System.Drawing.Point(582, 128);
            this.chbB.Name = "chbB";
            this.chbB.Size = new System.Drawing.Size(39, 24);
            this.chbB.TabIndex = 8;
            this.chbB.Text = "B";
            this.chbB.UseVisualStyleBackColor = true;
            // 
            // chbA2
            // 
            this.chbA2.AutoSize = true;
            this.chbA2.Location = new System.Drawing.Point(528, 128);
            this.chbA2.Name = "chbA2";
            this.chbA2.Size = new System.Drawing.Size(48, 24);
            this.chbA2.TabIndex = 8;
            this.chbA2.Text = "A2";
            this.chbA2.UseVisualStyleBackColor = true;
            // 
            // chbA1
            // 
            this.chbA1.AutoSize = true;
            this.chbA1.Location = new System.Drawing.Point(474, 128);
            this.chbA1.Name = "chbA1";
            this.chbA1.Size = new System.Drawing.Size(48, 24);
            this.chbA1.TabIndex = 8;
            this.chbA1.Text = "A1";
            this.chbA1.UseVisualStyleBackColor = true;
            // 
            // pnlCinsiyet
            // 
            this.pnlCinsiyet.Controls.Add(this.rdbDiger);
            this.pnlCinsiyet.Controls.Add(this.rdbKadin);
            this.pnlCinsiyet.Controls.Add(this.rdbErkek);
            this.pnlCinsiyet.Location = new System.Drawing.Point(140, 122);
            this.pnlCinsiyet.Name = "pnlCinsiyet";
            this.pnlCinsiyet.Size = new System.Drawing.Size(220, 26);
            this.pnlCinsiyet.TabIndex = 7;
            // 
            // rdbDiger
            // 
            this.rdbDiger.AutoSize = true;
            this.rdbDiger.Location = new System.Drawing.Point(150, 3);
            this.rdbDiger.Name = "rdbDiger";
            this.rdbDiger.Size = new System.Drawing.Size(65, 24);
            this.rdbDiger.TabIndex = 6;
            this.rdbDiger.TabStop = true;
            this.rdbDiger.Text = "Diğer";
            this.rdbDiger.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(77, 3);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(67, 24);
            this.rdbKadin.TabIndex = 6;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(3, 3);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(68, 24);
            this.rdbErkek.TabIndex = 6;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // pnlMedeniHal
            // 
            this.pnlMedeniHal.Controls.Add(this.rdbEvli);
            this.pnlMedeniHal.Controls.Add(this.rdbBekar);
            this.pnlMedeniHal.Location = new System.Drawing.Point(548, 90);
            this.pnlMedeniHal.Name = "pnlMedeniHal";
            this.pnlMedeniHal.Size = new System.Drawing.Size(142, 26);
            this.pnlMedeniHal.TabIndex = 7;
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(88, 3);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(51, 24);
            this.rdbEvli.TabIndex = 6;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "Evli";
            this.rdbEvli.UseVisualStyleBackColor = true;
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Location = new System.Drawing.Point(13, 3);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(69, 24);
            this.rdbBekar.TabIndex = 6;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "Bekar";
            this.rdbBekar.UseVisualStyleBackColor = true;
            // 
            // pcbPersonelResmi
            // 
            this.pcbPersonelResmi.BackgroundImage = global::_04_PersonelTakipUygulamasi.Properties.Resources.user;
            this.pcbPersonelResmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPersonelResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPersonelResmi.ContextMenuStrip = this.contextMenuStripResimIslemleri;
            this.pcbPersonelResmi.Location = new System.Drawing.Point(754, 25);
            this.pcbPersonelResmi.Name = "pcbPersonelResmi";
            this.pcbPersonelResmi.Size = new System.Drawing.Size(140, 165);
            this.pcbPersonelResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPersonelResmi.TabIndex = 5;
            this.pcbPersonelResmi.TabStop = false;
            this.toolTipBilgi.SetToolTip(this.pcbPersonelResmi, "Resmi yüklemek için bu alana tıklayınız.");
            // 
            // contextMenuStripResimIslemleri
            // 
            this.contextMenuStripResimIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.degistirToolStripMenuItem,
            this.kaldirToolStripMenuItem});
            this.contextMenuStripResimIslemleri.Name = "contextMenuStripResimIslemleri";
            this.contextMenuStripResimIslemleri.Size = new System.Drawing.Size(115, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // degistirToolStripMenuItem
            // 
            this.degistirToolStripMenuItem.Name = "degistirToolStripMenuItem";
            this.degistirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.degistirToolStripMenuItem.Text = "Değiştir";
            this.degistirToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // kaldirToolStripMenuItem
            // 
            this.kaldirToolStripMenuItem.Name = "kaldirToolStripMenuItem";
            this.kaldirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.kaldirToolStripMenuItem.Text = "Kaldir";
            this.kaldirToolStripMenuItem.Click += new System.EventHandler(this.kaldirToolStripMenuItem_Click);
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.CustomFormat = "";
            this.dtpIseBaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(551, 54);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(122, 26);
            this.dtpIseBaslamaTarihi.TabIndex = 4;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CustomFormat = "";
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(140, 90);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(122, 26);
            this.dtpDogumTarihi.TabIndex = 4;
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(551, 20);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(187, 28);
            this.cmbDepartmanlar.TabIndex = 3;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(140, 156);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(122, 26);
            this.mtxtTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(140, 220);
            this.txtAdres.MaxLength = 200;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 82);
            this.txtAdres.TabIndex = 0;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(14, 223);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 20);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(140, 188);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(14, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(14, 159);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(62, 20);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(140, 57);
            this.txtSoyad.MaxLength = 30;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 26);
            this.txtSoyad.TabIndex = 0;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KontrolluHarfAl);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(14, 127);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(64, 20);
            this.lblCinsiyet.TabIndex = 1;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblCocukSayisi
            // 
            this.lblCocukSayisi.AutoSize = true;
            this.lblCocukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCocukSayisi.Location = new System.Drawing.Point(398, 162);
            this.lblCocukSayisi.Name = "lblCocukSayisi";
            this.lblCocukSayisi.Size = new System.Drawing.Size(99, 20);
            this.lblCocukSayisi.TabIndex = 1;
            this.lblCocukSayisi.Text = "Çocuk Sayısı";
            // 
            // lblEhliyet
            // 
            this.lblEhliyet.AutoSize = true;
            this.lblEhliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEhliyet.Location = new System.Drawing.Point(397, 129);
            this.lblEhliyet.Name = "lblEhliyet";
            this.lblEhliyet.Size = new System.Drawing.Size(56, 20);
            this.lblEhliyet.TabIndex = 1;
            this.lblEhliyet.Text = "Ehliyet";
            // 
            // lblMedeniHal
            // 
            this.lblMedeniHal.AutoSize = true;
            this.lblMedeniHal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedeniHal.Location = new System.Drawing.Point(398, 95);
            this.lblMedeniHal.Name = "lblMedeniHal";
            this.lblMedeniHal.Size = new System.Drawing.Size(88, 20);
            this.lblMedeniHal.TabIndex = 1;
            this.lblMedeniHal.Text = "MedeniHali";
            // 
            // lblIseBaslamaTarihi
            // 
            this.lblIseBaslamaTarihi.AutoSize = true;
            this.lblIseBaslamaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIseBaslamaTarihi.Location = new System.Drawing.Point(397, 59);
            this.lblIseBaslamaTarihi.Name = "lblIseBaslamaTarihi";
            this.lblIseBaslamaTarihi.Size = new System.Drawing.Size(139, 20);
            this.lblIseBaslamaTarihi.TabIndex = 1;
            this.lblIseBaslamaTarihi.Text = "İşe Başlama Tarihi";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(14, 95);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(103, 20);
            this.lblDogumTarihi.TabIndex = 1;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(14, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(54, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartman.Location = new System.Drawing.Point(397, 28);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(89, 20);
            this.lblDepartman.TabIndex = 1;
            this.lblDepartman.Text = "Departman";
            // 
            // lstPersoneller
            // 
            this.lstPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAd,
            this.chSoyad,
            this.chDogumTarihi,
            this.chTelefon,
            this.chEmail,
            this.chDepartman});
            this.lstPersoneller.ContextMenuStrip = this.contextMenuStripListView;
            this.lstPersoneller.FullRowSelect = true;
            this.lstPersoneller.GridLines = true;
            this.lstPersoneller.Location = new System.Drawing.Point(4, 348);
            this.lstPersoneller.Name = "lstPersoneller";
            this.lstPersoneller.Size = new System.Drawing.Size(909, 219);
            this.lstPersoneller.TabIndex = 3;
            this.lstPersoneller.UseCompatibleStateImageBehavior = false;
            this.lstPersoneller.View = System.Windows.Forms.View.Details;
            this.lstPersoneller.DoubleClick += new System.EventHandler(this.lstPersoneller_DoubleClick);
            // 
            // chAd
            // 
            this.chAd.Text = "Ad";
            this.chAd.Width = 107;
            // 
            // chSoyad
            // 
            this.chSoyad.Text = "Soyad";
            this.chSoyad.Width = 134;
            // 
            // chDogumTarihi
            // 
            this.chDogumTarihi.Text = "Doğum Tarihi";
            this.chDogumTarihi.Width = 155;
            // 
            // chTelefon
            // 
            this.chTelefon.Text = "Telefon";
            this.chTelefon.Width = 158;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 195;
            // 
            // chDepartman
            // 
            this.chDepartman.Text = "Departman";
            this.chDepartman.Width = 156;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // notifyIconIK
            // 
            this.notifyIconIK.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconIK.BalloonTipText = "Uygulama Çalışmaya Başladı";
            this.notifyIconIK.BalloonTipTitle = "Bilgi";
            this.notifyIconIK.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconIK.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconIK.Icon")));
            this.notifyIconIK.Text = "Personel Uygulamasi";
            this.notifyIconIK.Visible = true;
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamEkranToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(130, 48);
            // 
            // tamEkranToolStripMenuItem
            // 
            this.tamEkranToolStripMenuItem.Name = "tamEkranToolStripMenuItem";
            this.tamEkranToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tamEkranToolStripMenuItem.Text = "Tam Ekran";
            this.tamEkranToolStripMenuItem.Click += new System.EventHandler(this.tamEkranToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialogResim
            // 
            this.openFileDialogResim.Filter = "Personel Resmi|*.jpg;*.png;*.jpeg|Tüm Dosyalar|*.*";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 567);
            this.Controls.Add(this.lstPersoneller);
            this.Controls.Add(this.grbPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPersonel";
            this.ShowIcon = false;
            this.Text = "Personel Takip";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.grbPersonelBilgileri.ResumeLayout(false);
            this.grbPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocukSayisi)).EndInit();
            this.pnlCinsiyet.ResumeLayout(false);
            this.pnlCinsiyet.PerformLayout();
            this.pnlMedeniHal.ResumeLayout(false);
            this.pnlMedeniHal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonelResmi)).EndInit();
            this.contextMenuStripResimIslemleri.ResumeLayout(false);
            this.contextMenuStripListView.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grbPersonelBilgileri;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.PictureBox pcbPersonelResmi;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.Label lblIseBaslamaTarihi;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.Label lblMedeniHal;
        private System.Windows.Forms.Panel pnlCinsiyet;
        private System.Windows.Forms.RadioButton rdbDiger;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Panel pnlMedeniHal;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.CheckBox chbA2;
        private System.Windows.Forms.CheckBox chbA1;
        private System.Windows.Forms.Label lblEhliyet;
        private System.Windows.Forms.ToolTip toolTipBilgi;
        private System.Windows.Forms.ListView lstPersoneller;
        private System.Windows.Forms.NotifyIcon notifyIconIK;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown nudCocukSayisi;
        private System.Windows.Forms.CheckBox chbE;
        private System.Windows.Forms.CheckBox chbC;
        private System.Windows.Forms.CheckBox chbB;
        private System.Windows.Forms.Label lblCocukSayisi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem tamEkranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ColumnHeader chSoyad;
        private System.Windows.Forms.ColumnHeader chDogumTarihi;
        private System.Windows.Forms.ColumnHeader chTelefon;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chDepartman;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripResimIslemleri;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem degistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaldirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogResim;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnSilinenleriGoster;
    }
}

