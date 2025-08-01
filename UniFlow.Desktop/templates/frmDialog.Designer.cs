namespace UniFlow.Desktop.templates
{
    partial class frmDialog
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
            spaceForm1 = new ReaLTaiizor.Forms.SpaceForm();
            spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            btnClear = new ReaLTaiizor.Controls.MetroButton();
            spaceForm1.SuspendLayout();
            SuspendLayout();
            // 
            // spaceForm1
            // 
            spaceForm1.BackColor = Color.FromArgb(42, 42, 42);
            spaceForm1.BorderStyle = FormBorderStyle.None;
            spaceForm1.Controls.Add(btnClear);
            spaceForm1.Controls.Add(spaceClose1);
            spaceForm1.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
            spaceForm1.Dock = DockStyle.Fill;
            spaceForm1.Font = new Font("Verdana", 8F);
            spaceForm1.Image = null;
            spaceForm1.Location = new Point(0, 0);
            spaceForm1.MinimumSize = new Size(200, 25);
            spaceForm1.Movable = true;
            spaceForm1.Name = "spaceForm1";
            spaceForm1.NoRounding = true;
            spaceForm1.Padding = new Padding(5, 25, 5, 5);
            spaceForm1.Sizable = false;
            spaceForm1.Size = new Size(850, 450);
            spaceForm1.SmartBounds = false;
            spaceForm1.StartPosition = FormStartPosition.CenterParent;
            spaceForm1.TabIndex = 0;
            spaceForm1.Text = "frmDialog";
            spaceForm1.TransparencyKey = Color.Purple;
            spaceForm1.Transparent = false;
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
            btnClear.Location = new Point(704, 398);
            btnClear.Name = "btnClear";
            btnClear.NormalBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.NormalColor = Color.FromArgb(30, 30, 30);
            btnClear.NormalTextColor = Color.White;
            btnClear.PressBorderColor = Color.FromArgb(224, 224, 224);
            btnClear.PressColor = Color.Silver;
            btnClear.PressTextColor = Color.White;
            btnClear.Size = new Size(134, 44);
            btnClear.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            btnClear.StyleManager = null;
            btnClear.TabIndex = 30;
            btnClear.Text = "Save";
            btnClear.ThemeAuthor = "Taiizor";
            btnClear.ThemeName = "MetroDark";
            // 
            // frmDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(850, 450);
            Controls.Add(spaceForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(200, 25);
            Name = "frmDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDialog";
            TransparencyKey = Color.Purple;
            spaceForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm spaceForm1;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private ReaLTaiizor.Controls.MetroButton btnClear;
    }
}