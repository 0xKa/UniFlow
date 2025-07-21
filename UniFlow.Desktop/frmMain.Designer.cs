namespace UniFlow.Desktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDashboard = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.FromArgb(40, 40, 40);
            pnlSidebar.Controls.Add(tableLayoutPanel1);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(254, 661);
            pnlSidebar.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 0, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 4);
            tableLayoutPanel1.Controls.Add(button7, 0, 7);
            tableLayoutPanel1.Controls.Add(button6, 0, 6);
            tableLayoutPanel1.Controls.Add(button5, 0, 5);
            tableLayoutPanel1.Location = new Point(0, 262);
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
            tableLayoutPanel1.Size = new Size(254, 399);
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
            btnDashboard.Size = new Size(248, 43);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = SystemColors.MenuText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 52);
            button1.Name = "button1";
            button1.Size = new Size(248, 43);
            button1.TabIndex = 11;
            button1.Text = "People";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = SystemColors.MenuText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Black;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 101);
            button2.Name = "button2";
            button2.Size = new Size(248, 43);
            button2.TabIndex = 10;
            button2.Text = "Users";
            button2.UseVisualStyleBackColor = true;
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
            button3.Location = new Point(3, 150);
            button3.Name = "button3";
            button3.Size = new Size(248, 43);
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
            button4.Location = new Point(3, 199);
            button4.Name = "button4";
            button4.Size = new Size(248, 43);
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
            button7.Location = new Point(3, 346);
            button7.Name = "button7";
            button7.Size = new Size(248, 50);
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
            button6.Location = new Point(3, 297);
            button6.Name = "button6";
            button6.Size = new Size(248, 43);
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
            button5.Location = new Point(3, 248);
            button5.Name = "button5";
            button5.Size = new Size(248, 43);
            button5.TabIndex = 5;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(30, 30, 30);
            pnlMain.Location = new Point(260, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(924, 661);
            pnlMain.TabIndex = 8;
            // 
            // frmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 661);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            Load += frmMain_Load;
            pnlSidebar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnDashboard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel pnlMain;
    }
}
