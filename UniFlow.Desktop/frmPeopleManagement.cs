using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniFlow.Desktop.ApiService;

namespace UniFlow.Desktop
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private static List<UniFlow.DTOs.PersonDTO> _people = new();

        private async Task _LoadDGV()
        {
            this.Cursor = Cursors.WaitCursor;

            dgvPeople.Columns.Clear();
            dgvPeople.DataSource = _people;
            _people = await new PersonApi().GetAllAsync();

            if (_people.Count == 0)
                notificationBox.Visible = true;
            else
                dgvPeople.DataSource = _people;


            this.Cursor = Cursors.Default;
        }

        private async void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            await _LoadDGV();

            
        }
    }
}
