using System.Data;
using UniFlow.Desktop.ApiService;
using UniFlow.Desktop.People;
using UniFlow.Shared.DTOs;

namespace UniFlow.Desktop
{
    public partial class PeopleManagementForm : Form
    {
        public PeopleManagementForm()
        {
            InitializeComponent();
        }

        private BindingSource _bindingSource = new BindingSource();
        private static List<PersonViewDTO> _allPeople = new();

        private async Task _LoadDGV()
        {
            dgvPeople.DataSource = _allPeople;

            _allPeople = await new PersonApi().GetAllFromViewAsync();
            _bindingSource.DataSource = _allPeople;

            if (_allPeople.Count == 0)
                pnlErrorPanel.Visible = true;
            else
                dgvPeople.DataSource = _bindingSource;

            lblTotalRecords.Text = _allPeople.Count.ToString();
        }
        private void _InitializeSearchOptions()
        {
            cbSearchOptions.Items.Clear();
            cbSearchOptions.Items.Add("None");

            // Get from DataGridView columns
            foreach (DataGridViewColumn column in dgvPeople.Columns)
            {
                cbSearchOptions.Items.Add(column.HeaderText);
            }

            cbSearchOptions.SelectedIndex = 0;
        }
        private void _EditDGV()
        {

            dgvPeople.Columns.Clear();
            dgvPeople.DataSource = _allPeople;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            dgvPeople.Columns["FullName"].Width = 200;
            dgvPeople.Columns["PersonId"].HeaderText = "ID";
            dgvPeople.Columns["FullName"].HeaderText = "Full Name";
            dgvPeople.Columns["NationalID"].HeaderText = "National ID";
            dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
        }
        private async Task _RefreshDataAsync()
        {

            btnAddNew.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            pnlErrorPanel.Visible = false;
            notificationBox.Visible = true;

            _allPeople.Clear();

            _EditDGV();
            await _LoadDGV();
            _InitializeSearchOptions();

            this.Cursor = Cursors.Default;
            btnAddNew.Enabled = true;
        }



        private async void frmPeopleManagement_Load(object sender, EventArgs e)
        => await _RefreshDataAsync();
        private async void btnRefresh_Click(object sender, EventArgs e)
        => await _RefreshDataAsync();


        private void cbSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbSearchOptions.SelectedItem)
            {

                case "None":
                    pnlSearchBar.Visible = false;
                    pnlGenderSelection.Visible = false;
                    break;

                case "Gender":
                    pnlSearchBar.Visible = false;
                    pnlGenderSelection.Visible = true;
                    pnlGenderSelection.Focus();
                    rbFemale.Checked = false;
                    rbMale.Checked = false;
                    break;

                default:
                    pnlSearchBar.Visible = true;
                    pnlGenderSelection.Visible = false;
                    pnlSearchBar.Focus();

                    break;
            }

            btnClear_Click(sender, e);
        }

        private void _ApplyFilter()
        {
            string searchTerm = txbSearchTerm.Text.Trim();
            string selectedColumn = cbSearchOptions.SelectedItem.ToString() ?? "";

            if (selectedColumn == "None" || string.IsNullOrWhiteSpace(selectedColumn))
            {
                _bindingSource.DataSource = _allPeople;
                lblTotalRecords.Text = _allPeople.Count.ToString();
                return;
            }

            var filteredPeople = _allPeople.Where(p =>
            {
                return selectedColumn switch
                {
                    "ID" => p.PersonID.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                    "National ID" => p.NationalID?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Full Name" => p.FullName?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Phone" => p.Phone?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    //"Gender" => p.Gender.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                    "Age" => p.Age.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                    "Date Of Birth" => p.DateOfBirth.ToString("d").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    _ => false
                };
            }).ToList();

            _bindingSource.DataSource = filteredPeople;
            lblTotalRecords.Text = filteredPeople.Count.ToString();
        }
        private void txbSearchTerm_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }


        private void _ApplyGenderFilter(string gender)
        {
            var filteredPeople = _allPeople.Where(p => p.Gender == gender).ToList();

            _bindingSource.DataSource = filteredPeople;
            lblTotalRecords.Text = filteredPeople.Count.ToString();
        }
        private void rbMale_CheckedChanged(object sender) => _ApplyGenderFilter("Male");
        private void rbFemale_CheckedChanged(object sender) => _ApplyGenderFilter("Female");

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbSearchTerm.Text = string.Empty;
            txbSearchTerm.Focus();
            _bindingSource.DataSource = _allPeople;
            lblTotalRecords.Text = _allPeople.Count.ToString();
        }

        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            await _RefreshDataAsync();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();

            if (dgvPeople.CurrentRow?.Cells[0]?.Value is int personId)
            {
                PersonInfoForm frm = new(personId);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No person is selected or the selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPeople_DoubleClick(object sender, EventArgs e) => showInfoToolStripMenuItem.PerformClick();

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddEditPersonForm frm = new(-1, Shared.Util.enMode.AddNew);
            frm.OnPersonAdded += async (personDTO) => await _RefreshDataAsync();
            frm.OnPersonUpdated += async (personDTO) => await _RefreshDataAsync();
            frm.ShowDialog();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e) => btnAddNew.PerformClick();

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();

            if (dgvPeople.CurrentRow?.Cells[0]?.Value is int personId)
            {
                AddEditPersonForm frm = new(personId, Shared.Util.enMode.Update);
                frm.OnPersonUpdated += async (personDTO) => await _RefreshDataAsync();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No person is selected or the selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            if (dgvPeople.CurrentRow?.Cells[0]?.Value is int personId)
            {
                if (MessageBox.Show($"Are you sure you want to delete the person with ID: {personId}?",
                    "Delete Person",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (await new PersonApi().DeleteAsync(personId))
                    {
                        await _RefreshDataAsync();
                        MessageBox.Show($"Person with ID: {personId} has been deleted successfully.", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"This Person Cannot be Deleted. ", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            MessageBox.Show("This feature is not implemented yet.", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            MessageBox.Show("This feature is not implemented yet.", "Send Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
