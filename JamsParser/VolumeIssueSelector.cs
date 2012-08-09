using System;
using System.Configuration;
using System.Windows.Forms;

namespace JamsParser
{
    public partial class VolumeIssueSelector : Form
    {
        public VolumeIssueSelector()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            new Parser("http://api.springer.com/metadata/pam", ConfigurationManager.AppSettings["apiKey"]).Execute(new VolumeIssueQuery(Volume.Text.ToNullableInt(), Issue.Text.ToNullableInt()));
        }
    }
}