using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.WinApp.Statics;

namespace NZZ.TSIM.WinApp
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        public FormSettings(ServiceSettings serviceSettings)
            : this()
        {
            ServiceSettings = serviceSettings;
        }

        private ServiceSettings ServiceSettings { get; init; }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Program.HandleException(ex);
            }
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnAbort_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
