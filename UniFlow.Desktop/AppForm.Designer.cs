namespace UniFlow.Desktop
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            titleBar = new ReaLTaiizor.Forms.HopeForm();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            pnlMain = new Panel();
            pnlSidebar = new Panel();
            pbMainIcon = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDashboard = new Button();
            btnPeople = new Button();
            btnUsers = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            titleBar.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainIcon).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.ControlBox = false;
            titleBar.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            titleBar.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            titleBar.ControlBoxColorN = Color.White;
            titleBar.Controls.Add(metroControlBox1);
            titleBar.Dock = DockStyle.Top;
            titleBar.Font = new Font("Segoe UI", 12F);
            titleBar.ForeColor = Color.FromArgb(242, 246, 252);
            titleBar.Image = Properties.Resources.uniflow_app_icon_png;
            titleBar.Location = new Point(0, 0);
            titleBar.Name = "titleBar";
            titleBar.Size = new Size(1200, 40);
            titleBar.TabIndex = 0;
            titleBar.Text = "UniFlow";
            titleBar.ThemeColor = Color.FromArgb(42, 42, 42);
            // 
            // metroControlBox1
            // 
            metroControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox1.CloseHoverForeColor = Color.White;
            metroControlBox1.CloseNormalForeColor = Color.Gray;
            metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox1.DisabledForeColor = Color.Silver;
            metroControlBox1.IsDerivedStyle = true;
            metroControlBox1.Location = new Point(1097, 3);
            metroControlBox1.MaximizeBox = false;
            metroControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroControlBox1.MinimizeBox = true;
            metroControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroControlBox1.Name = "metroControlBox1";
            metroControlBox1.Size = new Size(100, 25);
            metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroControlBox1.StyleManager = null;
            metroControlBox1.TabIndex = 0;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroDark";
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(32, 32, 32);
            pnlMain.Location = new Point(260, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(940, 660);
            pnlMain.TabIndex = 11;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 25, 25);
            pnlSidebar.Controls.Add(pbMainIcon);
            pnlSidebar.Controls.Add(tableLayoutPanel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 40);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(254, 660);
            pnlSidebar.TabIndex = 10;
            // 
            // pbMainIcon
            // 
            pbMainIcon.Image = Properties.Resources.dashboard;
            pbMainIcon.Location = new Point(41, 15);
            pbMainIcon.Name = "pbMainIcon";
            pbMainIcon.Size = new Size(173, 151);
            pbMainIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbMainIcon.TabIndex = 6;
            pbMainIcon.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPeople, 0, 1);
            tableLayoutPanel1.Controls.Add(btnUsers, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 4);
            tableLayoutPanel1.Controls.Add(button7, 0, 7);
            tableLayoutPanel1.Controls.Add(button6, 0, 6);
            tableLayoutPanel1.Controls.Add(button5, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 181);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(254, 479);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderColor = SystemColors.MenuText;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.CheckedBackColor = Color.Black;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.Black;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(248, 53);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPeople
            // 
            btnPeople.Dock = DockStyle.Fill;
            btnPeople.FlatAppearance.BorderColor = SystemColors.MenuText;
            btnPeople.FlatAppearance.BorderSize = 0;
            btnPeople.FlatAppearance.CheckedBackColor = Color.Black;
            btnPeople.FlatAppearance.MouseDownBackColor = Color.Black;
            btnPeople.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnPeople.FlatStyle = FlatStyle.Flat;
            btnPeople.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPeople.ForeColor = Color.White;
            btnPeople.Location = new Point(3, 62);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(248, 53);
            btnPeople.TabIndex = 11;
            btnPeople.Text = "People";
            btnPeople.UseVisualStyleBackColor = true;
            btnPeople.Click += btnPeople_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderColor = SystemColors.MenuText;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.CheckedBackColor = Color.Black;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.Black;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(3, 121);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(248, 53);
            btnUsers.TabIndex = 10;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = SystemColors.MenuText;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Black;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 180);
            button3.Name = "button3";
            button3.Size = new Size(248, 53);
            button3.TabIndex = 9;
            button3.Text = "Departments";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = SystemColors.MenuText;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 239);
            button4.Name = "button4";
            button4.Size = new Size(248, 53);
            button4.TabIndex = 8;
            button4.Text = "Students";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderColor = SystemColors.MenuText;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.CheckedBackColor = Color.Black;
            button7.FlatAppearance.MouseDownBackColor = Color.Black;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(3, 416);
            button7.Name = "button7";
            button7.Size = new Size(248, 60);
            button7.TabIndex = 7;
            button7.Text = "Settings";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderColor = SystemColors.MenuText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.CheckedBackColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 357);
            button6.Name = "button6";
            button6.Size = new Size(248, 53);
            button6.TabIndex = 6;
            button6.Text = "...";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderColor = SystemColors.MenuText;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.CheckedBackColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 298);
            button5.Name = "button5";
            button5.Size = new Size(248, 53);
            button5.TabIndex = 5;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(1200, 700);
            ControlBox = false;
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(titleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(190, 40);
            Name = "AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UniFlow";
            Load += AppForm_Load;
            titleBar.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMainIcon).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm titleBar;
        private Panel pnlMain;
        private Panel pnlSidebar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDashboard;
        private Button btnPeople;
        private Button btnUsers;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private PictureBox pbMainIcon;
    }
}