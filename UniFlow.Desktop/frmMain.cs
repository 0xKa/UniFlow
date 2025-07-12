using UniFlow.Desktop.ApiService;
using UniFlow.DTOs;
namespace UniFlow.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private readonly PersonApi _personApi = new();
        private List<PersonDTO> _people = new();

        private async void frmMain_Load(object sender, EventArgs e)
        {

            try
            {
                _people =  await _personApi.GetAllAsync();
                dataGridView1.DataSource = _people;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data: {ex.Message}");
            }

        }
    }
}
