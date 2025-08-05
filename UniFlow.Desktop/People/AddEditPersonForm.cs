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
using UniFlow.Shared;
using static UniFlow.Shared.Util;

namespace UniFlow.Desktop.People
{
    public partial class AddEditPersonForm : Form
    {
        private Util.enMode _mode = Util.enMode.AddNew;
        private PersonDTO? _person;

        public AddEditPersonForm(int personID, Util.enMode mode)
        {
            InitializeComponent();

            _mode = mode;

            _SetDefaultValues();
            if (_mode == Util.enMode.Update)
                _LoadPersonAsync(personID);
        }

        private void _ClearControlsValue()
        {
            txbFirstName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbNationalID.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbAddress.Text = string.Empty;
            rbMale.Checked = true;
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
        }
        private void _SetDefaultValues()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            if (_mode == enMode.AddNew)
            {
                spaceForm.Text = "Add New Person";
                pbModeIcon.Image = Properties.Resources.add;
                this.Text = "Add New Person";
            }
            else
            {
                spaceForm.Text = "Update Person";
                pbModeIcon.Image = Properties.Resources.edit;
                this.Text = "Update Person";
            }

            ImageSelectorDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            _ClearControlsValue();
        }

        private async void _LoadPersonAsync(int personID)
        {
            _person = await new PersonApi().GetByIdAsync(personID);
            if (_person != null)
            {
                lblPersonID.Text = _person.ID.ToString();
                txbFirstName.Text = _person.FirstName;
                txbLastName.Text = _person.LastName;
                txbNationalID.Text = _person.NationalID;
                txbPhone.Text = _person.Phone;
                txbAddress.Text = _person.Address;
                dtpDateOfBirth.Value = _person.DateOfBirth;

                //handle gender
                if (_person.Gender == 'M')
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                //handle image
                if (string.IsNullOrEmpty(_person.ImagePath))
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.default_male : Properties.Resources.default_female;
                else
                { pbPersonImage.ImageLocation = _person.ImagePath; llRemoveImage.Visible = true; }

                txbNationalID.Enabled = false;
            }
            else
                MessageBox.Show($"Person with ID {personID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e) => _ClearControlsValue();

        private void _LoadDefaultImage()
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                pbPersonImage.Image = rbMale.Checked ? Properties.Resources.default_male : Properties.Resources.default_female;
        }
        private void rbMale_CheckedChanged(object sender) => _LoadDefaultImage();
        private void rbFemale_CheckedChanged(object sender) => _LoadDefaultImage();

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            { 
                if (ImageSelectorDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(ImageSelectorDialog.FileName).ToLower();
                    if (fileExtension == ".png" || fileExtension == ".jpg" || fileExtension == ".jpeg")
                    {
                        pbPersonImage.Load(ImageSelectorDialog.FileName);
                        llRemoveImage.Visible = true;
                    }
                    else
                        MessageBox.Show("Only PNG, JPG, and JPEG files are allowed.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("The selected file is not a valid image.\nFile must be in (.jpg), (.jpeg), or (.png) format", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llRemoveImage.Visible = false;
            pbPersonImage.ImageLocation = null;
            _LoadDefaultImage();
        }
    }
}
