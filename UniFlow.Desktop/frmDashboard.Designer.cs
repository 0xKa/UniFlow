namespace UniFlow.Desktop
{
    partial class frmDashboard
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
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            SuspendLayout();
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton1.Location = new Point(668, 12);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(120, 40);
            aloneButton1.TabIndex = 0;
            aloneButton1.Text = "aloneButton1";
            // 
            // hopeButton1
            // 
            hopeButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton1.Font = new Font("Segoe UI", 12F);
            hopeButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton1.Location = new Point(668, 58);
            hopeButton1.Name = "hopeButton1";
            hopeButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton1.Size = new Size(120, 40);
            hopeButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton1.TabIndex = 1;
            hopeButton1.Text = "hopeButton1";
            hopeButton1.TextColor = Color.White;
            hopeButton1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 212);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Location = new Point(218, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 212);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Location = new Point(424, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 212);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 40, 40);
            panel4.Location = new Point(424, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 212);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(40, 40, 40);
            panel5.Location = new Point(218, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 212);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(40, 40, 40);
            panel6.Location = new Point(12, 230);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 212);
            panel6.TabIndex = 3;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(hopeButton1);
            Controls.Add(aloneButton1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(190, 40);
            Name = "frmDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}