namespace UniFlow.Desktop
{
    partial class frmPeopleManagement
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleManagement));
            txbSearchTerm = new ReaLTaiizor.Controls.MetroTextBox();
            dgvPeople = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            metroContextMenuStrip1 = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            sendMessageToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pnlErrorPanel = new Panel();
            btnRefresh = new Button();
            imageList1 = new ImageList(components);
            notificationBox = new ReaLTaiizor.Controls.ForeverNotification();
            btnAddNew = new Button();
            pnlFilter = new Panel();
            pnlGenderSelection = new Panel();
            rbFemale = new ReaLTaiizor.Controls.MetroRadioButton();
            rbMale = new ReaLTaiizor.Controls.MetroRadioButton();
            cbSearchOptions = new ReaLTaiizor.Controls.MetroComboBox();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            pnlSearchBar = new Panel();
            btnClear = new ReaLTaiizor.Controls.MetroButton();
            lblTotalRecords = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            metroContextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pnlErrorPanel.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGenderSelection.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // txbSearchTerm
            // 
            txbSearchTerm.AutoCompleteCustomSource = null;
            txbSearchTerm.AutoCompleteMode = AutoCompleteMode.None;
            txbSearchTerm.AutoCompleteSource = AutoCompleteSource.None;
            txbSearchTerm.BorderColor = Color.FromArgb(110, 110, 110);
            txbSearchTerm.DisabledBackColor = Color.FromArgb(80, 80, 80);
            txbSearchTerm.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            txbSearchTerm.DisabledForeColor = Color.FromArgb(109, 109, 109);
            txbSearchTerm.Font = new Font("Microsoft Sans Serif", 10F);
            txbSearchTerm.HoverColor = Color.FromArgb(65, 177, 225);
            txbSearchTerm.Image = null;
            txbSearchTerm.IsDerivedStyle = true;
            txbSearchTerm.Lines = null;
            txbSearchTerm.Location = new Point(3, 10);
            txbSearchTerm.MaxLength = 32767;
            txbSearchTerm.Multiline = false;
            txbSearchTerm.Name = "txbSearchTerm";
            txbSearchTerm.ReadOnly = false;
            txbSearchTerm.Size = new Size(158, 26);
            txbSearchTerm.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            txbSearchTerm.StyleManager = null;
            txbSearchTerm.TabIndex = 18;
            txbSearchTerm.TextAlign = HorizontalAlignment.Left;
            txbSearchTerm.ThemeAuthor = "Taiizor";
            txbSearchTerm.ThemeName = "MetroDark";
            txbSearchTerm.UseSystemPasswordChar = false;
            txbSearchTerm.WatermarkText = "Search the records";
            txbSearchTerm.TextChanged += txbSearchTerm_TextChanged;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.BackgroundColor = Color.FromArgb(25, 25, 25);
            dgvPeople.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.ColumnHeadersHeight = 27;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvPeople.ContextMenuStrip = metroContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPeople.EnableHeadersVisualStyles = false;
            dgvPeople.GridColor = Color.LightGray;
            dgvPeople.Location = new Point(12, 168);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPeople.RowHeadersWidth = 23;
            dgvPeople.ScrollBars = ScrollBars.Vertical;
            dgvPeople.Size = new Size(916, 457);
            dgvPeople.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // metroContextMenuStrip1
            // 
            metroContextMenuStrip1.IsDerivedStyle = true;
            metroContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, addNewPersonToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, sendMessageToolStripMenuItem });
            metroContextMenuStrip1.Name = "metroContextMenuStrip1";
            metroContextMenuStrip1.Size = new Size(163, 148);
            metroContextMenuStrip1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroContextMenuStrip1.StyleManager = null;
            metroContextMenuStrip1.ThemeAuthor = "Taiizor";
            metroContextMenuStrip1.ThemeName = "MetroDark";
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Image = Properties.Resources.info;
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(162, 22);
            showInfoToolStripMenuItem.Text = "Show Info";
            showInfoToolStripMenuItem.Click += showInfoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(162, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(162, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.add;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(162, 22);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.email;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(162, 22);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // sendMessageToolStripMenuItem
            // 
            sendMessageToolStripMenuItem.Image = Properties.Resources.message1;
            sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            sendMessageToolStripMenuItem.Size = new Size(162, 22);
            sendMessageToolStripMenuItem.Text = "Send Message";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlErrorPanel);
            panel1.Controls.Add(btnAddNew);
            panel1.Controls.Add(pnlFilter);
            panel1.Controls.Add(lblTotalRecords);
            panel1.Controls.Add(metroLabel1);
            panel1.Controls.Add(dgvPeople);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 660);
            panel1.TabIndex = 20;
            // 
            // pnlErrorPanel
            // 
            pnlErrorPanel.Controls.Add(btnRefresh);
            pnlErrorPanel.Controls.Add(notificationBox);
            pnlErrorPanel.Location = new Point(12, 201);
            pnlErrorPanel.Name = "pnlErrorPanel";
            pnlErrorPanel.Size = new Size(916, 69);
            pnlErrorPanel.TabIndex = 31;
            pnlErrorPanel.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 70, 70);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ImageKey = "refresh.png";
            btnRefresh.ImageList = imageList1;
            btnRefresh.Location = new Point(866, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(50, 42);
            btnRefresh.TabIndex = 32;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add.png");
            imageList1.Images.SetKeyName(1, "refresh.png");
            // 
            // notificationBox
            // 
            notificationBox.BackColor = Color.FromArgb(60, 70, 73);
            notificationBox.Close = false;
            notificationBox.Font = new Font("Segoe UI", 10F);
            notificationBox.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            notificationBox.Location = new Point(0, 0);
            notificationBox.Name = "notificationBox";
            notificationBox.Size = new Size(916, 42);
            notificationBox.TabIndex = 21;
            notificationBox.Text = "Failed to load data. ";
            // 
            // btnAddNew
            // 
            btnAddNew.FlatAppearance.BorderSize = 0;
            btnAddNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 65, 177, 225);
            btnAddNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.ImageKey = "add.png";
            btnAddNew.ImageList = imageList1;
            btnAddNew.Location = new Point(878, 113);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(50, 50);
            btnAddNew.TabIndex = 29;
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(pnlGenderSelection);
            pnlFilter.Controls.Add(cbSearchOptions);
            pnlFilter.Controls.Add(metroLabel2);
            pnlFilter.Controls.Add(pnlSearchBar);
            pnlFilter.Location = new Point(12, 61);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(427, 101);
            pnlFilter.TabIndex = 28;
            // 
            // pnlGenderSelection
            // 
            pnlGenderSelection.Controls.Add(rbFemale);
            pnlGenderSelection.Controls.Add(rbMale);
            pnlGenderSelection.Location = new Point(146, 60);
            pnlGenderSelection.Name = "pnlGenderSelection";
            pnlGenderSelection.Size = new Size(278, 39);
            pnlGenderSelection.TabIndex = 29;
            pnlGenderSelection.Visible = false;
            // 
            // rbFemale
            // 
            rbFemale.BackgroundColor = Color.FromArgb(30, 30, 30);
            rbFemale.BorderColor = Color.FromArgb(155, 155, 155);
            rbFemale.Checked = false;
            rbFemale.CheckSignColor = Color.FromArgb(65, 177, 225);
            rbFemale.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            rbFemale.DisabledBorderColor = Color.FromArgb(85, 85, 85);
            rbFemale.Font = new Font("Microsoft Sans Serif", 10F);
            rbFemale.Group = 0;
            rbFemale.IsDerivedStyle = true;
            rbFemale.Location = new Point(81, 14);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(66, 17);
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
            rbMale.Font = new Font("Microsoft Sans Serif", 10F);
            rbMale.Group = 0;
            rbMale.IsDerivedStyle = true;
            rbMale.Location = new Point(9, 14);
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
            // cbSearchOptions
            // 
            cbSearchOptions.AllowDrop = true;
            cbSearchOptions.ArrowColor = Color.FromArgb(110, 110, 110);
            cbSearchOptions.BackColor = Color.Transparent;
            cbSearchOptions.BackgroundColor = Color.FromArgb(34, 34, 34);
            cbSearchOptions.BorderColor = Color.FromArgb(110, 110, 110);
            cbSearchOptions.CausesValidation = false;
            cbSearchOptions.DisabledBackColor = Color.FromArgb(80, 80, 80);
            cbSearchOptions.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            cbSearchOptions.DisabledForeColor = Color.FromArgb(109, 109, 109);
            cbSearchOptions.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchOptions.Font = new Font("Microsoft Sans Serif", 11F);
            cbSearchOptions.IsDerivedStyle = true;
            cbSearchOptions.ItemHeight = 20;
            cbSearchOptions.Location = new Point(3, 72);
            cbSearchOptions.Name = "cbSearchOptions";
            cbSearchOptions.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            cbSearchOptions.SelectedItemForeColor = Color.White;
            cbSearchOptions.Size = new Size(137, 26);
            cbSearchOptions.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            cbSearchOptions.StyleManager = null;
            cbSearchOptions.TabIndex = 24;
            cbSearchOptions.ThemeAuthor = "Taiizor";
            cbSearchOptions.ThemeName = "MetroDark";
            cbSearchOptions.SelectedIndexChanged += cbSearchOptions_SelectedIndexChanged;
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(3, 52);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(105, 17);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 25;
            metroLabel2.Text = "Filter By:";
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroDark";
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.Controls.Add(btnClear);
            pnlSearchBar.Controls.Add(txbSearchTerm);
            pnlSearchBar.Location = new Point(146, 62);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Size = new Size(278, 39);
            pnlSearchBar.TabIndex = 30;
            pnlSearchBar.Visible = false;
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
            btnClear.Location = new Point(164, 10);
            btnClear.Name = "btnClear";
            btnClear.NormalBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.NormalColor = Color.FromArgb(30, 30, 30);
            btnClear.NormalTextColor = Color.White;
            btnClear.PressBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.PressColor = Color.Silver;
            btnClear.PressTextColor = Color.White;
            btnClear.Size = new Size(72, 26);
            btnClear.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            btnClear.StyleManager = null;
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.ThemeAuthor = "Taiizor";
            btnClear.ThemeName = "MetroDark";
            btnClear.Click += btnClear_Click;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotalRecords.IsDerivedStyle = true;
            lblTotalRecords.Location = new Point(114, 628);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(162, 23);
            lblTotalRecords.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lblTotalRecords.StyleManager = null;
            lblTotalRecords.TabIndex = 23;
            lblTotalRecords.Text = "0";
            lblTotalRecords.ThemeAuthor = "Taiizor";
            lblTotalRecords.ThemeName = "MetroDark";
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(12, 628);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(105, 23);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 22;
            metroLabel1.Text = "Total Records:";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroDark";
            // 
            // frmPeopleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(940, 660);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeopleManagement";
            Text = "frmPeopleManagement";
            Load += frmPeopleManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            metroContextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlErrorPanel.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlGenderSelection.ResumeLayout(false);
            pnlSearchBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion



        private ReaLTaiizor.Controls.MetroTextBox txbSearchTerm;
        private DataGridView dgvPeople;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private ReaLTaiizor.Controls.ForeverNotification notificationBox;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.MetroLabel lblTotalRecords;
        private ReaLTaiizor.Controls.MetroComboBox cbSearchOptions;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private GroupBox groupBox1;
        private Panel pnlFilter;
        private ReaLTaiizor.Controls.MetroButton btnClear;
        private Panel pnlGenderSelection;
        private ReaLTaiizor.Controls.MetroRadioButton rbMale;
        private ReaLTaiizor.Controls.MetroRadioButton rbFemale;
        private Panel pnlSearchBar;
        private ReaLTaiizor.Controls.MetroContextMenuStrip metroContextMenuStrip1;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem sendMessageToolStripMenuItem;
        private Button btnAddNew;
        private ImageList imageList1;
        private Panel pnlErrorPanel;
        private Button btnRefresh;
    }
}