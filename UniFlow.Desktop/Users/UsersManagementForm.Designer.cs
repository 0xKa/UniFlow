namespace UniFlow.Desktop.Users
{
    partial class UsersManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagementForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pnlErrorPanel = new Panel();
            btnRefresh = new Button();
            imageList1 = new ImageList(components);
            notificationBox = new ReaLTaiizor.Controls.ForeverNotification();
            btnAddNew = new Button();
            pnlFilter = new Panel();
            pnlActivitySelection = new Panel();
            rbInactive = new ReaLTaiizor.Controls.MetroRadioButton();
            rbActive = new ReaLTaiizor.Controls.MetroRadioButton();
            cbSearchOptions = new ReaLTaiizor.Controls.MetroComboBox();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            pnlSearchBar = new Panel();
            btnClear = new ReaLTaiizor.Controls.MetroButton();
            txbSearchTerm = new ReaLTaiizor.Controls.MetroTextBox();
            lblTotalRecords = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            dgvUsers = new DataGridView();
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
            toolStripMenuItem3 = new ToolStripSeparator();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            pnlErrorPanel.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlActivitySelection.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            metroContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlErrorPanel);
            panel1.Controls.Add(btnAddNew);
            panel1.Controls.Add(pnlFilter);
            panel1.Controls.Add(lblTotalRecords);
            panel1.Controls.Add(metroLabel1);
            panel1.Controls.Add(dgvUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 660);
            panel1.TabIndex = 0;
            // 
            // pnlErrorPanel
            // 
            pnlErrorPanel.Controls.Add(btnRefresh);
            pnlErrorPanel.Controls.Add(notificationBox);
            pnlErrorPanel.Location = new Point(12, 201);
            pnlErrorPanel.Name = "pnlErrorPanel";
            pnlErrorPanel.Size = new Size(916, 69);
            pnlErrorPanel.TabIndex = 34;
            pnlErrorPanel.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(87, 70, 70);
            btnRefresh.FlatAppearance.BorderSize = 2;
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
            notificationBox.Size = new Size(860, 42);
            notificationBox.TabIndex = 21;
            notificationBox.Text = "Failed to load data. ";
            notificationBox.Visible = false;
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
            btnAddNew.TabIndex = 33;
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(pnlActivitySelection);
            pnlFilter.Controls.Add(cbSearchOptions);
            pnlFilter.Controls.Add(metroLabel2);
            pnlFilter.Controls.Add(pnlSearchBar);
            pnlFilter.Location = new Point(12, 61);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(427, 101);
            pnlFilter.TabIndex = 32;
            // 
            // pnlActivitySelection
            // 
            pnlActivitySelection.Controls.Add(rbInactive);
            pnlActivitySelection.Controls.Add(rbActive);
            pnlActivitySelection.Location = new Point(146, 62);
            pnlActivitySelection.Name = "pnlActivitySelection";
            pnlActivitySelection.Size = new Size(278, 39);
            pnlActivitySelection.TabIndex = 29;
            pnlActivitySelection.Visible = false;
            // 
            // rbInactive
            // 
            rbInactive.BackgroundColor = Color.FromArgb(30, 30, 30);
            rbInactive.BorderColor = Color.FromArgb(155, 155, 155);
            rbInactive.Checked = false;
            rbInactive.CheckSignColor = Color.FromArgb(65, 177, 225);
            rbInactive.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            rbInactive.DisabledBorderColor = Color.FromArgb(85, 85, 85);
            rbInactive.Font = new Font("Microsoft Sans Serif", 10F);
            rbInactive.Group = 0;
            rbInactive.IsDerivedStyle = true;
            rbInactive.Location = new Point(81, 14);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(80, 17);
            rbInactive.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            rbInactive.StyleManager = null;
            rbInactive.TabIndex = 1;
            rbInactive.Text = "Inactive";
            rbInactive.ThemeAuthor = "Taiizor";
            rbInactive.ThemeName = "MetroDark";
            rbInactive.CheckedChanged += rbInactive_CheckedChanged;
            // 
            // rbActive
            // 
            rbActive.BackgroundColor = Color.FromArgb(30, 30, 30);
            rbActive.BorderColor = Color.FromArgb(155, 155, 155);
            rbActive.Checked = false;
            rbActive.CheckSignColor = Color.FromArgb(65, 177, 225);
            rbActive.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            rbActive.DisabledBorderColor = Color.FromArgb(85, 85, 85);
            rbActive.Font = new Font("Microsoft Sans Serif", 10F);
            rbActive.Group = 0;
            rbActive.IsDerivedStyle = true;
            rbActive.Location = new Point(9, 14);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(66, 17);
            rbActive.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            rbActive.StyleManager = null;
            rbActive.TabIndex = 0;
            rbActive.Text = "Active";
            rbActive.ThemeAuthor = "Taiizor";
            rbActive.ThemeName = "MetroDark";
            rbActive.CheckedChanged += rbActive_CheckedChanged;
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
            // lblTotalRecords
            // 
            lblTotalRecords.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotalRecords.IsDerivedStyle = true;
            lblTotalRecords.Location = new Point(114, 628);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(162, 23);
            lblTotalRecords.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lblTotalRecords.StyleManager = null;
            lblTotalRecords.TabIndex = 26;
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
            metroLabel1.TabIndex = 25;
            metroLabel1.Text = "Total Records:";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroDark";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(25, 25, 25);
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 35, 35);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 27;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.LightGray;
            dgvUsers.Location = new Point(12, 168);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowHeadersWidth = 23;
            dgvUsers.ScrollBars = ScrollBars.Vertical;
            dgvUsers.Size = new Size(916, 457);
            dgvUsers.TabIndex = 24;
            dgvUsers.DoubleClick += dgvUsers_DoubleClick;
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
            metroContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showInfoToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, addNewPersonToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, sendMessageToolStripMenuItem, toolStripMenuItem3, refreshToolStripMenuItem });
            metroContextMenuStrip1.Name = "metroContextMenuStrip1";
            metroContextMenuStrip1.Size = new Size(163, 176);
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
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(162, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Image = Properties.Resources.add;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(162, 22);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
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
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // sendMessageToolStripMenuItem
            // 
            sendMessageToolStripMenuItem.Image = Properties.Resources.message1;
            sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            sendMessageToolStripMenuItem.Size = new Size(162, 22);
            sendMessageToolStripMenuItem.Text = "Send Message";
            sendMessageToolStripMenuItem.Click += sendMessageToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(159, 6);
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Image = Properties.Resources.refresh;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(162, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // UsersManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(940, 660);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersManagementForm";
            Text = "Users Management";
            Load += UsersManagementForm_Load;
            panel1.ResumeLayout(false);
            pnlErrorPanel.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlActivitySelection.ResumeLayout(false);
            pnlSearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            metroContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MetroLabel lblTotalRecords;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn Column1;
        private Panel pnlErrorPanel;
        private Button btnRefresh;
        private ReaLTaiizor.Controls.ForeverNotification notificationBox;
        private Button btnAddNew;
        private Panel pnlFilter;
        private Panel pnlActivitySelection;
        private ReaLTaiizor.Controls.MetroRadioButton rbInactive;
        private ReaLTaiizor.Controls.MetroRadioButton rbActive;
        private ReaLTaiizor.Controls.MetroComboBox cbSearchOptions;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private Panel pnlSearchBar;
        private ReaLTaiizor.Controls.MetroButton btnClear;
        private ReaLTaiizor.Controls.MetroTextBox txbSearchTerm;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MetroContextMenuStrip metroContextMenuStrip1;
        private ToolStripMenuItem showInfoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem sendMessageToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}