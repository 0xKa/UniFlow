using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniFlow.Desktop
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }
        private void _LoadForm(Form frm, Bitmap mainImage)
        {

            pbMainIcon.Image = mainImage;
            pbMainIcon.Refresh(); // Force immediate repaint to ensure the image is displayed early

            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(frm);
            pnlMain.Tag = frm;

            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e) 
            => _LoadForm(new DashboardForm(), Properties.Resources.dashboard);
        private void btnPeople_Click(object sender, EventArgs e) 
            => _LoadForm(new PeopleManagementForm(), Properties.Resources.people);
    
    }
}
