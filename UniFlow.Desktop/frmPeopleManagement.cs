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
using UniFlow.DTOs;

namespace UniFlow.Desktop
{
    public partial class frmPeopleManagement : Form
    {
        public frmPeopleManagement()
        {
            InitializeComponent();
        }

        private BindingSource _bindingSource = new BindingSource();
        private static List<PersonViewDTO> _allPeople = new();

        private async Task _LoadDGV()
        {
            this.Cursor = Cursors.WaitCursor;


            dgvPeople.Columns.Clear();
            dgvPeople.DataSource = _allPeople;

            _allPeople = await new PersonApi().GetAllFromViewAsync();
            _bindingSource.DataSource = _allPeople;

            if (_allPeople.Count == 0)
                notificationBox.Visible = true;
            else
                dgvPeople.DataSource = _bindingSource;

            lblTotalRecords.Text = _allPeople.Count.ToString();
            this.Cursor = Cursors.Default;
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
            if (dgvPeople.RowCount > 0)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                dgvPeople.Columns["FullName"].Width = 200;
                dgvPeople.Columns["PersonId"].HeaderText = "ID";
                dgvPeople.Columns["FullName"].HeaderText = "Full Name";
                dgvPeople.Columns["NationalID"].HeaderText = "National ID";
                dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";

            }
        }



        private async void frmPeopleManagement_Load(object sender, EventArgs e)
        {
            await _LoadDGV();
            _EditDGV();
            _InitializeSearchOptions();

        }

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
    
    }
}
