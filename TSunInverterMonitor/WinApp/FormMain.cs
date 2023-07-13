using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.WinApp.Statics;

namespace NZZ.TSIM.WinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private LoginCredentials LoginCredentials { get; set; }
        private ServiceSettings ServiceSettings { get; set; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                LoginCredentials = new LoginCredentials
                {
                    UserName = Properties.Settings.Default.LastUserName,
                    Password = Properties.Settings.Default.LastPassword
                };

                ServiceSettings = ConfigFile.LoadSettings();
            }
            catch (Exception ex)
            {
                Program.HandleException(ex);
            }
        }

        private void BtnOpenSettings_Click(object sender, EventArgs e)
        {
            new FormSettings(ServiceSettings).ShowDialog(this);
        }
    }
}