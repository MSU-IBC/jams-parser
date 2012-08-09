using System;
using System.Configuration;
using System.Windows.Forms;

namespace JamsParser
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void VolumeIssue_Click(object sender, EventArgs e)
        {
            new VolumeIssueSelector().Show();
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            new Parser("http://api.springer.com/metadata/pam", ConfigurationManager.AppSettings["apiKey"]).Execute(new AllArticlesQuery());
        }
    }
}