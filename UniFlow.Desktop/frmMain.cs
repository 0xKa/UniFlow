using UniFlow.Desktop.ApiService;
using UniFlow.DTOs;
namespace UniFlow.Desktop;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void _LoadForm(Form frm)
    {
        pnlMain.Controls.Clear();

        frm.TopLevel = false;
        frm.Dock = DockStyle.Fill;

        pnlMain.Controls.Add(frm);
        pnlMain.Tag = frm;
        frm.Show();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {


    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
        _LoadForm(new frmDashboard());
    }
}
