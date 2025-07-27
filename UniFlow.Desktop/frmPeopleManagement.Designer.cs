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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            metroTextBox1 = new ReaLTaiizor.Controls.MetroTextBox();
            dgvPeople = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            notificationBox = new ReaLTaiizor.Controls.ForeverNotification();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // metroTextBox1
            // 
            metroTextBox1.AutoCompleteCustomSource = null;
            metroTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            metroTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            metroTextBox1.BorderColor = Color.FromArgb(110, 110, 110);
            metroTextBox1.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroTextBox1.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            metroTextBox1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroTextBox1.Font = new Font("Microsoft Sans Serif", 10F);
            metroTextBox1.HoverColor = Color.FromArgb(65, 177, 225);
            metroTextBox1.Image = null;
            metroTextBox1.IsDerivedStyle = true;
            metroTextBox1.Lines = null;
            metroTextBox1.Location = new Point(12, 128);
            metroTextBox1.MaxLength = 32767;
            metroTextBox1.Multiline = false;
            metroTextBox1.Name = "metroTextBox1";
            metroTextBox1.ReadOnly = false;
            metroTextBox1.Size = new Size(110, 34);
            metroTextBox1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            metroTextBox1.StyleManager = null;
            metroTextBox1.TabIndex = 18;
            metroTextBox1.Text = "hello";
            metroTextBox1.TextAlign = HorizontalAlignment.Left;
            metroTextBox1.ThemeAuthor = "Taiizor";
            metroTextBox1.ThemeName = "MetroDark";
            metroTextBox1.UseSystemPasswordChar = false;
            metroTextBox1.WatermarkText = "metro";
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
            dgvPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
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
            dgvPeople.Size = new Size(916, 480);
            dgvPeople.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(metroTextBox1);
            panel1.Controls.Add(notificationBox);
            panel1.Controls.Add(dgvPeople);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 660);
            panel1.TabIndex = 20;
            // 
            // notificationBox
            // 
            notificationBox.BackColor = Color.FromArgb(60, 70, 73);
            notificationBox.Close = true;
            notificationBox.Font = new Font("Segoe UI", 10F);
            notificationBox.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            notificationBox.Location = new Point(12, 198);
            notificationBox.Name = "notificationBox";
            notificationBox.Size = new Size(916, 42);
            notificationBox.TabIndex = 21;
            notificationBox.Text = "People Not Found";
            notificationBox.Visible = false;
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MetroTextBox metroTextBox1;
        private DataGridView dgvPeople;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private ReaLTaiizor.Controls.ForeverNotification notificationBox;
    }
}