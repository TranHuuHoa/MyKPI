using System;
using System.Windows.Forms;
using MyKPI.JobKpiAssessment.BLL;

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class JobKpiAssessmentManagementForm : Form
    {
        JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();
        public JobKpiAssessmentManagementForm()
        {
            InitializeComponent();
        }

        private void load()
        {
            grcJobKpiAssessment.DataSource = jobKpiAssessmentBLL.LoadAllJobKpiAssessmentDataTable();
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

        private void JobKpiAssessmentManagementForm_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
