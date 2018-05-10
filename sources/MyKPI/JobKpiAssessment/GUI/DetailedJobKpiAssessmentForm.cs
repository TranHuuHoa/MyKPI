//========================================================================================================
//  MyKPI - Detailed Job KPI Assessment  Form
// Change logs:
// May 6 2018 - TrungTH - init pages 
// 
//
//=========================================================================================================
#region using
using System;
using System.Windows.Forms;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.JobKpiAssessment.BLL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class DetailedJobKpiAssessmentForm : Form
    {
        private JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();
        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;
        private int jobKpiAssessmentID = 0;

        private void InitCombobox()
        {
            var employeeBLL = new EmployeeBLL();
            cbxEmployee.DataSource = employeeBLL.LoadAllEmployee();
            cbxEmployee.DisplayMember = "EmployeeName";
            cbxEmployee.ValueMember = "ID";

            cbxRoleInAssessment.Items.Clear();
            cbxRoleInAssessment.Items.Add(JobRankValue.ProjectManager);
            cbxRoleInAssessment.Items.Add(JobRankValue.Developer);
            cbxRoleInAssessment.Items.Add(JobRankValue.Tester);
            cbxRoleInAssessment.Items.Add(JobRankValue.SolutionArchitect);
            cbxRoleInAssessment.Items.Add(JobRankValue.BussinessAnalyst);
            cbxRoleInAssessment.SelectedIndex = 0;

            cbxStatus.Items.Clear();
            cbxStatus.Items.Add(AssessmentStatusValue.Started);
            cbxStatus.Items.Add(AssessmentStatusValue.Processing);
            cbxStatus.Items.Add(AssessmentStatusValue.Commit);
            cbxStatus.Items.Add(AssessmentStatusValue.Approving);
            cbxStatus.Items.Add(AssessmentStatusValue.Approved);
            cbxStatus.SelectedIndex = 0;
        }

        public DetailedJobKpiAssessmentForm()
        {
            InitializeComponent();
            InitCombobox();
            detailedFormMode = DetailedFormMode.Add;
        }

        public DetailedJobKpiAssessmentForm(JobKpiEntity _jobKpiEntity)
        {
            InitializeComponent();
            InitCombobox();
            detailedFormMode = DetailedFormMode.Update;
            jobKpiAssessmentID = _jobKpiEntity.ID;
            cbxEmployee.SelectedValue = _jobKpiEntity.Employee.ID;
            cbxRoleInAssessment.SelectedItem = _jobKpiEntity.RoleInAssessment;
            cbxStatus.SelectedItem = _jobKpiEntity.Status;
            dtmCreatedDate.Value = _jobKpiEntity.CreatedDate;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            
            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.ID = (int)cbxEmployee.SelectedValue;
            jobKpiEntity.Employee = employeeEntity;
            jobKpiEntity.RoleInAssessment = (JobRankValue)cbxRoleInAssessment.SelectedItem;
            jobKpiEntity.CreatedDate = dtmCreatedDate.Value;
            jobKpiEntity.Status = (AssessmentStatusValue)cbxStatus.SelectedItem;
         
            if (detailedFormMode == DetailedFormMode.Add)
            {
                jobKpiAssessmentBLL.AddJobKpiAssessment(jobKpiEntity);
            }
            if (detailedFormMode == DetailedFormMode.Update)
            {
                jobKpiAssessmentBLL.EditJobKpiAssessment(jobKpiEntity, jobKpiAssessmentID);
            }

            if (CommonFunctions.ShowQuestionDialog("Do you want continue to work with this kpi assessment?", "Question") == DialogResult.OK)
            {
                detailedFormMode = DetailedFormMode.Update;
               // load();
            }
            else
            {
                this.Close();
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        #region Assessment in Details
        private void btnConfirmProject_Click(object sender, EventArgs e)
        {

        }

        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        
    }
}
