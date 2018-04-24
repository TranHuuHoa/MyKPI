using System;
using System.Windows.Forms;

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class JobKpiAssessmentManagementForm : Form
    {
        public JobKpiAssessmentManagementForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddJobKpiAssessment_Click(object sender, EventArgs e)
        {
            DetailedJobKpiAssessmentForm detailedJobKpiAssessmentForm = new DetailedJobKpiAssessmentForm();
            detailedJobKpiAssessmentForm.ShowDialog();
        }
    }
}
