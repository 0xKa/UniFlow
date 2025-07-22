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
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            metroTextBox1 = new ReaLTaiizor.Controls.MetroTextBox();
            moonTextBox1 = new ReaLTaiizor.Controls.MoonTextBox();
            poisonTextBox1 = new ReaLTaiizor.Controls.PoisonTextBox();
            SuspendLayout();
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 10F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(540, 192);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 20;
            cyberTextBox1.Size = new Size(213, 40);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 5;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "Cyber Text";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
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
            metroTextBox1.Location = new Point(540, 155);
            metroTextBox1.MaxLength = 32767;
            metroTextBox1.Multiline = false;
            metroTextBox1.Name = "metroTextBox1";
            metroTextBox1.ReadOnly = false;
            metroTextBox1.Size = new Size(213, 31);
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
            // moonTextBox1
            // 
            moonTextBox1.AutoCompleteCustomSource.AddRange(new string[] { "hello", "reda" });
            moonTextBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            moonTextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            moonTextBox1.BackColor = Color.FromArgb(235, 235, 235);
            moonTextBox1.BorderColor = Color.LightGray;
            moonTextBox1.BorderStyle = BorderStyle.FixedSingle;
            moonTextBox1.Font = new Font("Microsoft Sans Serif", 8F);
            moonTextBox1.ForeColor = Color.Gray;
            moonTextBox1.Location = new Point(540, 109);
            moonTextBox1.Name = "moonTextBox1";
            moonTextBox1.PlaceholderText = "moon";
            moonTextBox1.Size = new Size(213, 20);
            moonTextBox1.TabIndex = 19;
            // 
            // poisonTextBox1
            // 
            // 
            // 
            // 
            poisonTextBox1.CustomButton.Image = null;
            poisonTextBox1.CustomButton.Location = new Point(149, 2);
            poisonTextBox1.CustomButton.Name = "";
            poisonTextBox1.CustomButton.Size = new Size(61, 61);
            poisonTextBox1.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonTextBox1.CustomButton.TabIndex = 1;
            poisonTextBox1.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            poisonTextBox1.CustomButton.UseSelectable = true;
            poisonTextBox1.CustomButton.Visible = false;
            poisonTextBox1.Location = new Point(540, 12);
            poisonTextBox1.MaxLength = 32767;
            poisonTextBox1.Name = "poisonTextBox1";
            poisonTextBox1.PasswordChar = '\0';
            poisonTextBox1.PromptText = "poison";
            poisonTextBox1.ScrollBars = ScrollBars.None;
            poisonTextBox1.SelectedText = "";
            poisonTextBox1.SelectionLength = 0;
            poisonTextBox1.SelectionStart = 0;
            poisonTextBox1.ShortcutsEnabled = true;
            poisonTextBox1.Size = new Size(213, 66);
            poisonTextBox1.TabIndex = 21;
            poisonTextBox1.UseSelectable = true;
            poisonTextBox1.WaterMark = "poison";
            poisonTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
            poisonTextBox1.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // frmPeopleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(poisonTextBox1);
            Controls.Add(moonTextBox1);
            Controls.Add(metroTextBox1);
            Controls.Add(cyberTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeopleManagement";
            Text = "frmPeopleManagement";
            Load += frmPeopleManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.MetroTextBox metroTextBox1;
        private ReaLTaiizor.Controls.MoonTextBox moonTextBox1;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox1;
    }
}