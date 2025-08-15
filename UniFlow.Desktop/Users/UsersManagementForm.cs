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
using UniFlow.Shared.DTOs;

namespace UniFlow.Desktop.Users
{
    public partial class UsersManagementForm : Form
    {
        public UsersManagementForm()
        {
            InitializeComponent();
        }

        private BindingSource _bindingSource = new BindingSource();
        private static List<UserViewDTO> _allUsers = new();

        private async Task _LoadDGV()
        {
            dgvUsers.DataSource = _allUsers;

            _allUsers = await new UserApi().GetAllFromViewAsync();
            _bindingSource.DataSource = _allUsers;

            if (_allUsers.Count == 0)
                pnlErrorPanel.Visible = true;
            else
                dgvUsers.DataSource = _bindingSource;

            lblTotalRecords.Text = _allUsers.Count.ToString();
        }
        private void _InitializeSearchOptions()
        {
            cbSearchOptions.Items.Clear();
            cbSearchOptions.Items.Add("None");

            // Get from DataGridView columns
            foreach (DataGridViewColumn column in dgvUsers.Columns)
            {
                if (column.Visible)
                    cbSearchOptions.Items.Add(column.HeaderText);
            }

            cbSearchOptions.SelectedIndex = 0;
        }
        private void _EditDGV()
        {

            dgvUsers.Columns.Clear();
            dgvUsers.DataSource = _allUsers;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            dgvUsers.Columns["RoleId"].Visible = false;
            dgvUsers.Columns["PersonId"].Visible = false;
            dgvUsers.Columns["Email"].Visible = false;
            
            dgvUsers.Columns["UserId"].HeaderText = "ID";
            dgvUsers.Columns["FullName"].Width = 200;
            dgvUsers.Columns["FullName"].HeaderText = "Full Name";
            dgvUsers.Columns["RoleName"].HeaderText = "Role Name";
            dgvUsers.Columns["IsActive"].HeaderText = "Is Active?";

            dgvUsers.Columns["LastLogin"].HeaderText = "Last Login";
            dgvUsers.Columns["LastLogin"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            dgvUsers.Columns["LastLogin"].Width = 150;
            
            dgvUsers.Columns["AccountCreated"].HeaderText = "Account Creation";
            dgvUsers.Columns["AccountCreated"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            dgvUsers.Columns["AccountCreated"].Width = 150;

        }
        private async Task _RefreshDataAsync()
        {

            btnAddNew.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            pnlErrorPanel.Visible = false;
            notificationBox.Visible = true;

            _allUsers.Clear();

            _EditDGV();
            await _LoadDGV();
            _InitializeSearchOptions();

            this.Cursor = Cursors.Default;
            btnAddNew.Enabled = true;
        }



        private async void UsersManagementForm_Load(object sender, EventArgs e)
        => await _RefreshDataAsync();
        private async void btnRefresh_Click(object sender, EventArgs e)
        => await _RefreshDataAsync();


        private void cbSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbSearchOptions.SelectedItem)
            {

                case "None":
                    pnlSearchBar.Visible = false;
                    pnlActivitySelection.Visible = false;
                    break;

                case "Is Active?":
                    pnlSearchBar.Visible = false;
                    pnlActivitySelection.Visible = true;
                    pnlActivitySelection.Focus();
                    rbInactive.Checked = false;
                    rbActive.Checked = false;
                    break;

                default:
                    pnlSearchBar.Visible = true;
                    pnlActivitySelection.Visible = false;
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
                _bindingSource.DataSource = _allUsers;
                lblTotalRecords.Text = _allUsers.Count.ToString();
                return;
            }

            var filteredUsers = _allUsers.Where(u =>
            {
                return selectedColumn switch
                {
                    "ID" => u.UserId.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase),
                    "Full Name" => u.FullName?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Username" => u.Username?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Role Name" => u.RoleName?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Last Login" => u.LastLogin?.ToString("d").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    "Account Creation" => u.AccountCreated.ToString("d").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) == true,
                    _ => false
                };
            }).ToList();

            _bindingSource.DataSource = filteredUsers;
            lblTotalRecords.Text = filteredUsers.Count.ToString();
        }
        private void txbSearchTerm_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }


        private void _ApplyIsActiveFilter(bool isActive)
        {
            var filteredUsers = _allUsers.Where(p => p.IsActive == isActive).ToList();

            _bindingSource.DataSource = filteredUsers;
            lblTotalRecords.Text = filteredUsers.Count.ToString();
        }
        private void rbActive_CheckedChanged(object sender) => _ApplyIsActiveFilter(true);
        private void rbInactive_CheckedChanged(object sender) => _ApplyIsActiveFilter(false);

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbSearchTerm.Text = string.Empty;
            txbSearchTerm.Focus();
            _bindingSource.DataSource = _allUsers;
            lblTotalRecords.Text = _allUsers.Count.ToString();
        }

        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            await _RefreshDataAsync();
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();

            //if (dgvUsers.CurrentRow?.Cells[0]?.Value is int userId)
            //{
            //    UserInfoForm frm = new(userId);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("No user is selected or the selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void dgvUsers_DoubleClick(object sender, EventArgs e) => showInfoToolStripMenuItem.PerformClick();

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //AddEditUserForm frm = new(-1, Shared.Util.enMode.AddNew);
            //frm.OnUserAdded += async (userDTO) => await _RefreshDataAsync();
            //frm.OnUserUpdated += async (userDTO) => await _RefreshDataAsync();
            //frm.ShowDialog();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e) => btnAddNew.PerformClick();

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();

            //if (dgvUsers.CurrentRow?.Cells[0]?.Value is int userId)
            //{
            //    AddEditUserForm frm = new(userId, Shared.Util.enMode.Update);
            //    frm.OnUserUpdated += async (userDTO) => await _RefreshDataAsync();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("No user is selected or the selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroContextMenuStrip1.Close();
            if (dgvUsers.CurrentRow?.Cells[0]?.Value is int userId)
            {
                if (MessageBox.Show($"Are you sure you want to delete the user with ID: {userId}?",
                    "Delete User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (await new UserApi().DeleteAsync(userId))
                    {
                        await _RefreshDataAsync();
                        MessageBox.Show($"User with ID: {userId} has been deleted successfully.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"This User Cannot be Deleted. ", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
