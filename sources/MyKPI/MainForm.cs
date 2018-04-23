using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.GUI;

namespace MyKPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProjectManagement_Click(object sender, EventArgs e)
        {
            ProjectManagementForm projectManagementForm = new ProjectManagementForm();
            projectManagementForm.ShowDialog();
        }
    }
}
