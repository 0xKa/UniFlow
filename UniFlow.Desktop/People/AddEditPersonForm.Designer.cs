namespace UniFlow.Desktop.People
{
    partial class AddEditPersonForm
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
            spaceForm = new ReaLTaiizor.Forms.SpaceForm();
            btnClear = new ReaLTaiizor.Controls.MetroButton();
            pictureBox3 = new PictureBox();
            pbModeIcon = new PictureBox();
            lblPersonID = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            panel1 = new Panel();
            llRemoveImage = new ReaLTaiizor.Controls.NightLinkLabel();
            llSetImage = new ReaLTaiizor.Controls.NightLinkLabel();
            txbAddress = new ReaLTaiizor.Controls.MetroTextBox();
            dtpDateOfBirth = new ReaLTaiizor.Controls.PoisonDateTime();
            pnlGenderSelection = new Panel();
            rbFemale = new ReaLTaiizor.Controls.MetroRadioButton();
            rbMale = new ReaLTaiizor.Controls.MetroRadioButton();
            txbLastName = new ReaLTaiizor.Controls.MetroTextBox();
            txbPhone = new ReaLTaiizor.Controls.MetroTextBox();
            txbFirstName = new ReaLTaiizor.Controls.MetroTextBox();
            txbNationalID = new ReaLTaiizor.Controls.MetroTextBox();
            pbPersonImage = new PictureBox();
            metroLabel9 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel8 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel7 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel6 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel5 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel4 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            btnSave = new ReaLTaiizor.Controls.MetroButton();
            spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            ImageSelectorDialog = new OpenFileDialog();
            spaceForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbModeIcon).BeginInit();
            panel1.SuspendLayout();
            pnlGenderSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // spaceForm
            // 
            spaceForm.BackColor = Color.FromArgb(42, 42, 42);
            spaceForm.BorderStyle = FormBorderStyle.None;
            spaceForm.Controls.Add(btnClear);
            spaceForm.Controls.Add(pictureBox3);
            spaceForm.Controls.Add(pbModeIcon);
            spaceForm.Controls.Add(lblPersonID);
            spaceForm.Controls.Add(metroLabel2);
            spaceForm.Controls.Add(panel1);
            spaceForm.Controls.Add(btnSave);
            spaceForm.Controls.Add(spaceClose1);
            spaceForm.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
            spaceForm.Dock = DockStyle.Fill;
            spaceForm.Font = new Font("Verdana", 8F);
            spaceForm.Image = null;
            spaceForm.Location = new Point(0, 0);
            spaceForm.MinimumSize = new Size(200, 25);
            spaceForm.Movable = true;
            spaceForm.Name = "spaceForm";
            spaceForm.NoRounding = true;
            spaceForm.Padding = new Padding(5, 25, 5, 5);
            spaceForm.Sizable = false;
            spaceForm.Size = new Size(850, 450);
            spaceForm.SmartBounds = false;
            spaceForm.StartPosition = FormStartPosition.CenterParent;
            spaceForm.TabIndex = 0;
            spaceForm.Text = "Add / Edit Person";
            spaceForm.TransparencyKey = Color.Purple;
            spaceForm.Transparent = false;
            // 
            // btnClear
            // 
            btnClear.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnClear.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnClear.DisabledForeColor = Color.Gray;
            btnClear.Font = new Font("Microsoft Sans Serif", 10F);
            btnClear.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnClear.HoverColor = Color.FromArgb(95, 207, 255);
            btnClear.HoverTextColor = Color.White;
            btnClear.IsDerivedStyle = false;
            btnClear.Location = new Point(8, 398);
            btnClear.Name = "btnClear";
            btnClear.NormalBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.NormalColor = Color.FromArgb(30, 30, 30);
            btnClear.NormalTextColor = Color.White;
            btnClear.PressBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.PressColor = Color.Silver;
            btnClear.PressTextColor = Color.White;
            btnClear.Size = new Size(196, 44);
            btnClear.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            btnClear.StyleManager = null;
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.ThemeAuthor = "Taiizor";
            btnClear.ThemeName = "MetroDark";
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.save;
            pictureBox3.Location = new Point(609, 398);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pbModeIcon
            // 
            pbModeIcon.Image = Properties.Resources.add;
            pbModeIcon.Location = new Point(609, 422);
            pbModeIcon.Name = "pbModeIcon";
            pbModeIcon.Size = new Size(27, 20);
            pbModeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbModeIcon.TabIndex = 10;
            pbModeIcon.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.Font = new Font("Verdana", 14F);
            lblPersonID.IsDerivedStyle = true;
            lblPersonID.Location = new Point(120, 43);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(117, 40);
            lblPersonID.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lblPersonID.StyleManager = null;
            lblPersonID.TabIndex = 35;
            lblPersonID.Text = "-1";
            lblPersonID.TextAlign = ContentAlignment.MiddleLeft;
            lblPersonID.ThemeAuthor = "Taiizor";
            lblPersonID.ThemeName = "MetroDark";
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Verdana", 14F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(8, 43);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(117, 40);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "Person ID:";
            metroLabel2.TextAlign = ContentAlignment.MiddleLeft;
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroDark";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 42, 42);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(llRemoveImage);
            panel1.Controls.Add(llSetImage);
            panel1.Controls.Add(txbAddress);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(pnlGenderSelection);
            panel1.Controls.Add(txbLastName);
            panel1.Controls.Add(txbPhone);
            panel1.Controls.Add(txbFirstName);
            panel1.Controls.Add(txbNationalID);
            panel1.Controls.Add(pbPersonImage);
            panel1.Controls.Add(metroLabel9);
            panel1.Controls.Add(metroLabel8);
            panel1.Controls.Add(metroLabel7);
            panel1.Controls.Add(metroLabel6);
            panel1.Controls.Add(metroLabel5);
            panel1.Controls.Add(metroLabel4);
            panel1.Controls.Add(metroLabel1);
            panel1.Location = new Point(8, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 294);
            panel1.TabIndex = 34;
            // 
            // llRemoveImage
            // 
            llRemoveImage.ActiveLinkColor = Color.FromArgb(85, 197, 245);
            llRemoveImage.AutoSize = true;
            llRemoveImage.BackColor = Color.Transparent;
            llRemoveImage.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llRemoveImage.LinkBehavior = LinkBehavior.HoverUnderline;
            llRemoveImage.LinkColor = Color.FromArgb(45, 157, 205);
            llRemoveImage.Location = new Point(702, 192);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(91, 15);
            llRemoveImage.TabIndex = 37;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove Image";
            llRemoveImage.Visible = false;
            llRemoveImage.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.ActiveLinkColor = Color.FromArgb(85, 197, 245);
            llSetImage.AutoSize = true;
            llSetImage.BackColor = Color.Transparent;
            llSetImage.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llSetImage.LinkBehavior = LinkBehavior.HoverUnderline;
            llSetImage.LinkColor = Color.FromArgb(45, 157, 205);
            llSetImage.Location = new Point(712, 171);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(70, 15);
            llSetImage.TabIndex = 16;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // txbAddress
            // 
            txbAddress.AutoCompleteCustomSource = null;
            txbAddress.AutoCompleteMode = AutoCompleteMode.None;
            txbAddress.AutoCompleteSource = AutoCompleteSource.None;
            txbAddress.BorderColor = Color.FromArgb(110, 110, 110);
            txbAddress.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbAddress.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbAddress.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbAddress.Font = new Font("Verdana", 10F);
            txbAddress.HoverColor = Color.FromArgb(65, 177, 225);
            txbAddress.Image = null;
            txbAddress.IsDerivedStyle = true;
            txbAddress.Lines = null;
            txbAddress.Location = new Point(312, 223);
            txbAddress.MaxLength = 32767;
            txbAddress.Multiline = true;
            txbAddress.Name = "txbAddress";
            txbAddress.ReadOnly = false;
            txbAddress.Size = new Size(515, 68);
            txbAddress.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbAddress.StyleManager = null;
            txbAddress.TabIndex = 14;
            txbAddress.TextAlign = HorizontalAlignment.Left;
            txbAddress.ThemeAuthor = "Taiizor";
            txbAddress.ThemeName = "MetroDark";
            txbAddress.UseSystemPasswordChar = false;
            txbAddress.WatermarkText = "Enter your address";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarFont = new Font("Verdana", 10F);
            dtpDateOfBirth.Font = new Font("Verdana", 10F);
            dtpDateOfBirth.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpDateOfBirth.Location = new Point(312, 153);
            dtpDateOfBirth.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.MinimumSize = new Size(0, 27);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(251, 27);
            dtpDateOfBirth.TabIndex = 15;
            dtpDateOfBirth.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            dtpDateOfBirth.UseCustomFont = true;
            dtpDateOfBirth.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // pnlGenderSelection
            // 
            pnlGenderSelection.BackColor = Color.FromArgb(17, 17, 17);
            pnlGenderSelection.BorderStyle = BorderStyle.FixedSingle;
            pnlGenderSelection.Controls.Add(rbFemale);
            pnlGenderSelection.Controls.Add(rbMale);
            pnlGenderSelection.Font = new Font("Verdana", 10F);
            pnlGenderSelection.Location = new Point(18, 153);
            pnlGenderSelection.Name = "pnlGenderSelection";
            pnlGenderSelection.Size = new Size(251, 30);
            pnlGenderSelection.TabIndex = 30;
            // 
            // rbFemale
            // 
            rbFemale.BackgroundColor = Color.FromArgb(30, 30, 30);
            rbFemale.BorderColor = Color.FromArgb(155, 155, 155);
            rbFemale.Checked = false;
            rbFemale.CheckSignColor = Color.FromArgb(65, 177, 225);
            rbFemale.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            rbFemale.DisabledBorderColor = Color.FromArgb(85, 85, 85);
            rbFemale.Font = new Font("Verdana", 10F);
            rbFemale.Group = 0;
            rbFemale.IsDerivedStyle = true;
            rbFemale.Location = new Point(81, 6);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(86, 17);
            rbFemale.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            rbFemale.StyleManager = null;
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            rbFemale.ThemeAuthor = "Taiizor";
            rbFemale.ThemeName = "MetroDark";
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.BackgroundColor = Color.FromArgb(30, 30, 30);
            rbMale.BorderColor = Color.FromArgb(155, 155, 155);
            rbMale.Checked = false;
            rbMale.CheckSignColor = Color.FromArgb(65, 177, 225);
            rbMale.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            rbMale.DisabledBorderColor = Color.FromArgb(85, 85, 85);
            rbMale.Font = new Font("Verdana", 10F);
            rbMale.Group = 0;
            rbMale.IsDerivedStyle = true;
            rbMale.Location = new Point(9, 6);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(66, 17);
            rbMale.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            rbMale.StyleManager = null;
            rbMale.TabIndex = 0;
            rbMale.Text = "Male";
            rbMale.ThemeAuthor = "Taiizor";
            rbMale.ThemeName = "MetroDark";
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // txbLastName
            // 
            txbLastName.AutoCompleteCustomSource = null;
            txbLastName.AutoCompleteMode = AutoCompleteMode.None;
            txbLastName.AutoCompleteSource = AutoCompleteSource.None;
            txbLastName.BorderColor = Color.FromArgb(110, 110, 110);
            txbLastName.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbLastName.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbLastName.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbLastName.Font = new Font("Verdana", 10F);
            txbLastName.HoverColor = Color.FromArgb(65, 177, 225);
            txbLastName.Image = null;
            txbLastName.IsDerivedStyle = true;
            txbLastName.Lines = null;
            txbLastName.Location = new Point(312, 83);
            txbLastName.MaxLength = 32767;
            txbLastName.Multiline = false;
            txbLastName.Name = "txbLastName";
            txbLastName.ReadOnly = false;
            txbLastName.Size = new Size(251, 28);
            txbLastName.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbLastName.StyleManager = null;
            txbLastName.TabIndex = 12;
            txbLastName.TextAlign = HorizontalAlignment.Left;
            txbLastName.ThemeAuthor = "Taiizor";
            txbLastName.ThemeName = "MetroDark";
            txbLastName.UseSystemPasswordChar = false;
            txbLastName.WatermarkText = "Enter your last name";
            // 
            // txbPhone
            // 
            txbPhone.AutoCompleteCustomSource = null;
            txbPhone.AutoCompleteMode = AutoCompleteMode.None;
            txbPhone.AutoCompleteSource = AutoCompleteSource.None;
            txbPhone.BorderColor = Color.FromArgb(110, 110, 110);
            txbPhone.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbPhone.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbPhone.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbPhone.Font = new Font("Verdana", 10F);
            txbPhone.HoverColor = Color.FromArgb(65, 177, 225);
            txbPhone.Image = null;
            txbPhone.IsDerivedStyle = true;
            txbPhone.Lines = null;
            txbPhone.Location = new Point(18, 223);
            txbPhone.MaxLength = 32767;
            txbPhone.Multiline = false;
            txbPhone.Name = "txbPhone";
            txbPhone.ReadOnly = false;
            txbPhone.Size = new Size(251, 28);
            txbPhone.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbPhone.StyleManager = null;
            txbPhone.TabIndex = 13;
            txbPhone.TextAlign = HorizontalAlignment.Left;
            txbPhone.ThemeAuthor = "Taiizor";
            txbPhone.ThemeName = "MetroDark";
            txbPhone.UseSystemPasswordChar = false;
            txbPhone.WatermarkText = "Enter your phone number";
            // 
            // txbFirstName
            // 
            txbFirstName.AutoCompleteCustomSource = null;
            txbFirstName.AutoCompleteMode = AutoCompleteMode.None;
            txbFirstName.AutoCompleteSource = AutoCompleteSource.None;
            txbFirstName.BorderColor = Color.FromArgb(110, 110, 110);
            txbFirstName.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbFirstName.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbFirstName.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbFirstName.Font = new Font("Verdana", 10F);
            txbFirstName.HoverColor = Color.FromArgb(65, 177, 225);
            txbFirstName.Image = null;
            txbFirstName.IsDerivedStyle = true;
            txbFirstName.Lines = null;
            txbFirstName.Location = new Point(18, 83);
            txbFirstName.MaxLength = 32767;
            txbFirstName.Multiline = false;
            txbFirstName.Name = "txbFirstName";
            txbFirstName.ReadOnly = false;
            txbFirstName.Size = new Size(251, 28);
            txbFirstName.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbFirstName.StyleManager = null;
            txbFirstName.TabIndex = 11;
            txbFirstName.TextAlign = HorizontalAlignment.Left;
            txbFirstName.ThemeAuthor = "Taiizor";
            txbFirstName.ThemeName = "MetroDark";
            txbFirstName.UseSystemPasswordChar = false;
            txbFirstName.WatermarkText = "Enter your first name";
            // 
            // txbNationalID
            // 
            txbNationalID.AutoCompleteCustomSource = null;
            txbNationalID.AutoCompleteMode = AutoCompleteMode.None;
            txbNationalID.AutoCompleteSource = AutoCompleteSource.None;
            txbNationalID.BorderColor = Color.FromArgb(110, 110, 110);
            txbNationalID.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbNationalID.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbNationalID.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbNationalID.Font = new Font("Verdana", 10F);
            txbNationalID.HoverColor = Color.FromArgb(65, 177, 225);
            txbNationalID.Image = null;
            txbNationalID.IsDerivedStyle = true;
            txbNationalID.Lines = null;
            txbNationalID.Location = new Point(112, 11);
            txbNationalID.MaxLength = 32767;
            txbNationalID.Multiline = false;
            txbNationalID.Name = "txbNationalID";
            txbNationalID.ReadOnly = false;
            txbNationalID.Size = new Size(451, 28);
            txbNationalID.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbNationalID.StyleManager = null;
            txbNationalID.TabIndex = 10;
            txbNationalID.TextAlign = HorizontalAlignment.Left;
            txbNationalID.ThemeAuthor = "Taiizor";
            txbNationalID.ThemeName = "MetroDark";
            txbNationalID.UseSystemPasswordChar = false;
            txbNationalID.WatermarkText = "Enter your national ID";
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.default_male;
            pbPersonImage.Location = new Point(667, 3);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(160, 160);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 9;
            pbPersonImage.TabStop = false;
            // 
            // metroLabel9
            // 
            metroLabel9.Font = new Font("Verdana", 11F);
            metroLabel9.IsDerivedStyle = true;
            metroLabel9.Location = new Point(4, 13);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new Size(101, 23);
            metroLabel9.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel9.StyleManager = null;
            metroLabel9.TabIndex = 8;
            metroLabel9.Text = "National ID:";
            metroLabel9.ThemeAuthor = "Taiizor";
            metroLabel9.ThemeName = "MetroDark";
            // 
            // metroLabel8
            // 
            metroLabel8.Font = new Font("Verdana", 11F);
            metroLabel8.IsDerivedStyle = true;
            metroLabel8.Location = new Point(300, 197);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(113, 23);
            metroLabel8.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel8.StyleManager = null;
            metroLabel8.TabIndex = 7;
            metroLabel8.Text = "Address";
            metroLabel8.ThemeAuthor = "Taiizor";
            metroLabel8.ThemeName = "MetroDark";
            // 
            // metroLabel7
            // 
            metroLabel7.Font = new Font("Verdana", 11F);
            metroLabel7.IsDerivedStyle = true;
            metroLabel7.Location = new Point(4, 197);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new Size(113, 23);
            metroLabel7.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel7.StyleManager = null;
            metroLabel7.TabIndex = 6;
            metroLabel7.Text = "Phone";
            metroLabel7.ThemeAuthor = "Taiizor";
            metroLabel7.ThemeName = "MetroDark";
            // 
            // metroLabel6
            // 
            metroLabel6.Font = new Font("Verdana", 11F);
            metroLabel6.IsDerivedStyle = true;
            metroLabel6.Location = new Point(4, 127);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(113, 23);
            metroLabel6.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel6.StyleManager = null;
            metroLabel6.TabIndex = 5;
            metroLabel6.Text = "Gender";
            metroLabel6.ThemeAuthor = "Taiizor";
            metroLabel6.ThemeName = "MetroDark";
            // 
            // metroLabel5
            // 
            metroLabel5.Font = new Font("Verdana", 11F);
            metroLabel5.IsDerivedStyle = true;
            metroLabel5.Location = new Point(300, 127);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(113, 23);
            metroLabel5.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel5.StyleManager = null;
            metroLabel5.TabIndex = 4;
            metroLabel5.Text = "Date of Birth";
            metroLabel5.ThemeAuthor = "Taiizor";
            metroLabel5.ThemeName = "MetroDark";
            // 
            // metroLabel4
            // 
            metroLabel4.Font = new Font("Verdana", 11F);
            metroLabel4.IsDerivedStyle = true;
            metroLabel4.Location = new Point(300, 57);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(113, 23);
            metroLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel4.StyleManager = null;
            metroLabel4.TabIndex = 3;
            metroLabel4.Text = "Last Name";
            metroLabel4.ThemeAuthor = "Taiizor";
            metroLabel4.ThemeName = "MetroDark";
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Verdana", 11F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(4, 57);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(113, 23);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "First Name";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroDark";
            // 
            // btnSave
            // 
            btnSave.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSave.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSave.DisabledForeColor = Color.Gray;
            btnSave.Font = new Font("Microsoft Sans Serif", 10F);
            btnSave.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSave.HoverColor = Color.FromArgb(95, 207, 255);
            btnSave.HoverTextColor = Color.White;
            btnSave.IsDerivedStyle = false;
            btnSave.Location = new Point(642, 398);
            btnSave.Name = "btnSave";
            btnSave.NormalBorderColor = Color.FromArgb(224, 224, 224);
            btnSave.NormalColor = Color.FromArgb(30, 30, 30);
            btnSave.NormalTextColor = Color.White;
            btnSave.PressBorderColor = Color.FromArgb(224, 224, 224);
            btnSave.PressColor = Color.Silver;
            btnSave.PressTextColor = Color.White;
            btnSave.Size = new Size(196, 44);
            btnSave.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            btnSave.StyleManager = null;
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.ThemeAuthor = "Taiizor";
            btnSave.ThemeName = "MetroDark";
            btnSave.Click += btnSave_Click;
            // 
            // spaceClose1
            // 
            spaceClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            spaceClose1.DefaultAnchor = true;
            spaceClose1.DefaultLocation = true;
            spaceClose1.Font = new Font("Verdana", 8F);
            spaceClose1.Image = null;
            spaceClose1.Location = new Point(824, 3);
            spaceClose1.Name = "spaceClose1";
            spaceClose1.NoRounding = false;
            spaceClose1.Size = new Size(23, 21);
            spaceClose1.TabIndex = 0;
            spaceClose1.Text = "x";
            spaceClose1.Transparent = false;
            // 
            // ImageSelectorDialog
            // 
            ImageSelectorDialog.FileName = "openFileDialog1";
            ImageSelectorDialog.Title = "Select a Valid Person Image";
            // 
            // AddEditPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(850, 450);
            Controls.Add(spaceForm);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(200, 25);
            Name = "AddEditPersonForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddEditPerson";
            TransparencyKey = Color.Purple;
            spaceForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbModeIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlGenderSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm spaceForm;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private ReaLTaiizor.Controls.MetroButton btnSave;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroLabel lblPersonID;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private PictureBox pbPersonImage;
        private ReaLTaiizor.Controls.MetroLabel metroLabel9;
        private ReaLTaiizor.Controls.MetroLabel metroLabel8;
        private ReaLTaiizor.Controls.MetroLabel metroLabel7;
        private ReaLTaiizor.Controls.MetroLabel metroLabel6;
        private ReaLTaiizor.Controls.MetroLabel metroLabel5;
        private ReaLTaiizor.Controls.MetroLabel metroLabel4;
        private PictureBox pbModeIcon;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.MetroTextBox txbLastName;
        private ReaLTaiizor.Controls.MetroTextBox txbPhone;
        private ReaLTaiizor.Controls.MetroTextBox txbFirstName;
        private ReaLTaiizor.Controls.MetroTextBox txbNationalID;
        private Panel pnlGenderSelection;
        private ReaLTaiizor.Controls.MetroRadioButton rbFemale;
        private ReaLTaiizor.Controls.MetroRadioButton rbMale;
        private ReaLTaiizor.Controls.PoisonDateTime dtpDateOfBirth;
        private ReaLTaiizor.Controls.MetroTextBox txbAddress;
        private ReaLTaiizor.Controls.NightLinkLabel llRemoveImage;
        private ReaLTaiizor.Controls.NightLinkLabel llSetImage;
        private OpenFileDialog ImageSelectorDialog;
        private ReaLTaiizor.Controls.MetroButton btnClear;
    }
}