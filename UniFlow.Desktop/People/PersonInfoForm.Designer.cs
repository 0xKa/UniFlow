namespace UniFlow.Desktop.People
{
    partial class PersonInfoForm
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
            personCardControl1 = new PersonCardControl();
            spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            spaceForm1.SuspendLayout();
            SuspendLayout();
            // 
            // spaceForm1
            // 
            spaceForm1.BackColor = Color.FromArgb(42, 42, 42);
            spaceForm1.BorderStyle = FormBorderStyle.None;
            spaceForm1.Controls.Add(personCardControl1);
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
            spaceForm1.Size = new Size(703, 371);
            spaceForm1.SmartBounds = true;
            spaceForm1.StartPosition = FormStartPosition.CenterParent;
            spaceForm1.TabIndex = 0;
            spaceForm1.Text = "spaceForm1";
            spaceForm1.TransparencyKey = Color.Purple;
            spaceForm1.Transparent = false;
            // 
            // personCardControl1
            // 
            personCardControl1.BackColor = Color.FromArgb(25, 25, 25);
            personCardControl1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personCardControl1.Location = new Point(12, 45);
            personCardControl1.Name = "personCardControl1";
            personCardControl1.Size = new Size(650, 300);
            personCardControl1.TabIndex = 1;
            // 
            // spaceClose1
            // 
            spaceClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            spaceClose1.DefaultAnchor = true;
            spaceClose1.DefaultLocation = true;
            spaceClose1.Font = new Font("Verdana", 8F);
            spaceClose1.Image = null;
            spaceClose1.Location = new Point(677, 3);
            spaceClose1.Name = "spaceClose1";
            spaceClose1.NoRounding = false;
            spaceClose1.Size = new Size(23, 21);
            spaceClose1.TabIndex = 0;
            spaceClose1.Text = "x";
            spaceClose1.Transparent = false;
            // 
            // PersonInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 371);
            Controls.Add(spaceForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonInfoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "PersonInfoForm";
            TransparencyKey = Color.Purple;
            spaceForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm spaceForm1;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private PersonCardControl personCardControl1;
    }
}