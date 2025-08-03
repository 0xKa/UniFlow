using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniFlow.DTOs;
using UniFlow.Shared;

namespace UniFlow.Desktop.People
{
    public partial class AddEditPersonForm : Form
    {
        public AddEditPersonForm()
        {
            InitializeComponent();
        }

        private Util.enMode _Mode = Util.enMode.AddNew;
        private PersonDTO? _person;

        private void AddEditPersonForm_Load(object sender, EventArgs e)
        {
        }
    }
}
