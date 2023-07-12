using NZZ.TSIM.Contracts.Models;

namespace NZZ.TSIM.WinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private LoginCredentials loginCredentials;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            loginCredentials = new LoginCredentials
            {
                UserName = Properties.Settings.Default.ServiceUserName,
                Password = Properties.Settings.Default.ServicePassword,
            };

            if (string.IsNullOrEmpty(loginCredentials.UserName))
                new FormSettings().ShowDialog(this);
        }
    }
}
