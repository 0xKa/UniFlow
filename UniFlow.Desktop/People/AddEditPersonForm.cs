using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UniFlow.Desktop.ApiService;
using UniFlow.Shared.DTOs;
using UniFlow.Shared;
using static UniFlow.Shared.Util;

namespace UniFlow.Desktop.People
{
    public partial class AddEditPersonForm : Form
    {
        private PersonDTO? _person;

        private Util.enMode _mode = Util.enMode.AddNew;
        private ErrorProvider _errorProvider = new();

        public event Action<PersonDTO>? OnPersonAdded;
        public event Action<PersonDTO>? OnPersonUpdated;


        // Shared private constructor logic
        private AddEditPersonForm(Util.enMode mode)
        {
            InitializeComponent();
            _mode = mode;
            _SetDefaultValues();
        }

        // Constructor that takes Person ID
        public AddEditPersonForm(int personID, Util.enMode mode) : this(mode)
        {
            this.Load += async (s, e) =>
            {
                if (_mode == Util.enMode.Update)
                {
                    _person = await new PersonApi().GetByIdAsync(personID);
                    _FillPersonInfo();
                }
                else
                    _person = new PersonDTO();

            };
        }

        // Constructor that takes PersonDTO
        public AddEditPersonForm(PersonDTO personDto, Util.enMode mode) : this(mode)
        {
            if (_mode == Util.enMode.Update)
            {
                _person = personDto;
                _FillPersonInfo();
            }
            else
                _person = new PersonDTO();
        }

        

        private void _ClearValidationErrors()
        {
            _errorProvider.SetError(txbFirstName, string.Empty);
            _errorProvider.SetError(txbLastName, string.Empty);
            _errorProvider.SetError(txbNationalID, string.Empty);
            _errorProvider.SetError(txbPhone, string.Empty);
            _errorProvider.SetError(dtpDateOfBirth, string.Empty);
        }
        private void _ClearControlsValue()
        {
            if (_mode == enMode.AddNew)
                txbNationalID.Text = string.Empty;

            txbFirstName.Text = string.Empty;
            txbLastName.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbAddress.Text = string.Empty;
            rbMale.Checked = true;
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            _ClearValidationErrors();
        }
        private void _SetDefaultValues()
        {
            _errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

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

        private void _FillPersonInfo()
        {
            
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
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbFemale.Checked = true;
                    rbMale.Checked = false;
                }

                //handle image
                if (string.IsNullOrEmpty(_person.ImagePath))
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.default_male : Properties.Resources.default_female;
                else
                { pbPersonImage.ImageLocation = _person.ImagePath; llRemoveImage.Visible = true; }

                txbNationalID.Enabled = false;
            }
            else
                MessageBox.Show($"Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool _ValidateForm()
        {
            bool isValid = true;
            _ClearValidationErrors();

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txbFirstName.Text))
            {
                _errorProvider.SetError(txbFirstName, "First name is required.");
                isValid = false;
            }
            else if (txbFirstName.Text.Length < 2 || txbFirstName.Text.Length > 50)
            {
                _errorProvider.SetError(txbFirstName, "First name must be between 2 and 50 characters.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txbFirstName.Text, @"^[a-zA-Z\s\-]+$"))
            {
                _errorProvider.SetError(txbFirstName, "First name can only contain letters, spaces, and dashes.");
                isValid = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txbLastName.Text))
            {
                _errorProvider.SetError(txbLastName, "Last name is required.");
                isValid = false;
            }
            else if (txbLastName.Text.Length < 2 || txbLastName.Text.Length > 50)
            {
                _errorProvider.SetError(txbLastName, "Last name must be between 2 and 50 characters.");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txbLastName.Text, @"^[a-zA-Z\s\-]+$"))
            {
                _errorProvider.SetError(txbLastName, "Last name can only contain letters and spaces, and dashes.");
                isValid = false;
            }

            // Validate National ID
            if (string.IsNullOrWhiteSpace(txbNationalID.Text))
            {
                _errorProvider.SetError(txbNationalID, "National ID is required.");
                isValid = false;
            }
            else if (!Validation.IsValidNationalID(txbNationalID.Text))
            {
                _errorProvider.SetError(txbNationalID, "National ID format is invalid. Must be 2-14 digits.");
                isValid = false;
            }

            // Validate Phone
            if (string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                _errorProvider.SetError(txbPhone, "Phone number is required.");
                isValid = false;
            }
            else if (!Validation.IsValidPhoneNumber(txbPhone.Text))
            {
                _errorProvider.SetError(txbPhone, "Phone number format is invalid. Example: +1234567890 or 0123456789");
                isValid = false;
            }

            // Validate Date of Birth
            if (!Validation.IsValidDateOfBirth(dtpDateOfBirth.Value))
            {
                _errorProvider.SetError(dtpDateOfBirth, "Age must be between 18 and 100 years.");
                isValid = false;
            }

            return isValid;
        }

        private void _HandlePersonImage()
        {
            if (_person == null)
                return;

            string? currentImageLocation = pbPersonImage.ImageLocation;
            string? existingImagePath = _person.ImagePath;

            // If no change in image, do nothing
            if (string.Equals(currentImageLocation, existingImagePath, StringComparison.OrdinalIgnoreCase))
                return;

            string? oldImagePathToDelete = null;

            // Prepare for cleanup only if we're changing from an existing image
            if (!string.IsNullOrEmpty(existingImagePath) &&
                !string.Equals(currentImageLocation, existingImagePath, StringComparison.OrdinalIgnoreCase))
            {
                oldImagePathToDelete = existingImagePath;
            }

            try
            {
                // Handle new image
                if (!string.IsNullOrEmpty(currentImageLocation))
                {
                    string? newImagePath = Util.SaveNewImage(currentImageLocation);
                    if (string.IsNullOrEmpty(newImagePath))
                    {
                        MessageBox.Show($"Failed to save old image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _person.ImagePath = newImagePath;
                }
                else
                    _person.ImagePath = null;

                // Only delete old image after successful save/update
                if (!string.IsNullOrEmpty(oldImagePathToDelete) && File.Exists(oldImagePathToDelete))
                {
                    try
                    {
                        File.Delete(oldImagePathToDelete);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete old image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to handle person image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _FillPersonObject()
        {
            if (_person == null)
                return;

            _person.ID = _mode == enMode.Update ? int.Parse(lblPersonID.Text) : 0; // set ID only in update 
            _person.FirstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txbFirstName.Text.ToLower()); // first letter capitalized
            _person.LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txbLastName.Text.ToLower());
            _person.NationalID = txbNationalID.Text;
            _person.DateOfBirth = dtpDateOfBirth.Value;
            _person.Gender = rbMale.Checked ? 'M' : 'F';
            _person.Phone = txbPhone.Text;
            _person.Address = txbAddress.Text;

            _HandlePersonImage();
        }
        private async Task<bool> _SavePersonAsync()
        {
            if (_person == null)
                return false;

            try
            {
                var personApi = new PersonApi();

                if (_mode == enMode.AddNew)
                {
                    var addedPerson = await personApi.AddAsync(_person);
                    if (addedPerson != null)
                    {
                        MessageBox.Show("Person added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _person = addedPerson; // Update the local _person with the added person details (like id)
                        OnPersonAdded?.Invoke(addedPerson);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else // Update mode
                {
                    bool success = await personApi.UpdateAsync(_person.ID, _person);
                    if (success)
                    {
                        MessageBox.Show("Person updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnPersonUpdated?.Invoke(_person);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update person. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void _ChangeFormMode()
        {
            _mode = enMode.Update;
            pbModeIcon.Image = Properties.Resources.edit;

            spaceForm.Text = "Update Person";
            this.Text = "Update Person";

            lblPersonID.Text = _person?.ID.ToString();
            txbNationalID.Enabled = false;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("Please correct the validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FillPersonObject();

            if (await _SavePersonAsync())
            {
                if (_mode == enMode.AddNew)
                    _ChangeFormMode();
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
