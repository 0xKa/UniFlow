using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniFlow.Shared.DTOs;

namespace UniFlow.Desktop.People
{
    public partial class PersonCardControl : UserControl
    {
        public PersonCardControl()
        {
            InitializeComponent();
        }

        public PersonDTO SelectedPerson = new();


        private void _FillCard()
        {
            lblPersonID.Text = SelectedPerson.ID.ToString();
            lblFullName.Text = SelectedPerson.FirstName + " " + SelectedPerson.LastName;
            lblNationalID.Text = SelectedPerson.NationalID;
            lblDateOfBirth.Text = SelectedPerson.DateOfBirth.ToString("dd/MMM/yyyy");
            lblPhone.Text = SelectedPerson.Phone;
            lblAddress.Text = SelectedPerson.Address;
            lblGender.Text = SelectedPerson.Gender == 'M' ? "Male" : "Female";

            if (string.IsNullOrEmpty(SelectedPerson.ImagePath))
                pbPersonImage.Image = SelectedPerson.Gender == 'M' ? Properties.Resources.default_male : Properties.Resources.default_female;
            else
                pbPersonImage.ImageLocation = SelectedPerson.ImagePath;

        }

        public void LoadPersonInfo(PersonDTO Person)
        {
            if (Person != null)
            {
                SelectedPerson = Person;
                _FillCard();
                EnableEditDetailsButton = true;
            }
            else
                MessageBox.Show("Person Was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool EnableEditDetailsButton
        {
            set { llEditPersonInfo.Enabled = value; }
        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm frm = new AddEditPersonForm(SelectedPerson, Shared.Util.enMode.Update);
            
            frm.OnPersonUpdated += (personDto) =>
            {
                SelectedPerson = personDto;
                _FillCard();
            };

            frm.ShowDialog();
        }

    }
}
