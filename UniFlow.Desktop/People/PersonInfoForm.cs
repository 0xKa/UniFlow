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

namespace UniFlow.Desktop.People
{
    public partial class PersonInfoForm : Form
    {
        public int PersonID = -1;

        public PersonInfoForm(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        => this.Activated += PersonInfoForm_Activated;
        

        private async void PersonInfoForm_Activated(object? sender, EventArgs e)
        {
            var person = await new PersonApi().GetByIdAsync(PersonID);
            if (person != null)
            {
                personCardControl1.LoadPersonInfo(person);
            }
        }
    }
}
