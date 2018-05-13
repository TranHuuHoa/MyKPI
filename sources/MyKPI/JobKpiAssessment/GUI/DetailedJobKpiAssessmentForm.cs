//========================================================================================================
//  MyKPI - Detailed Job KPI Assessment  Form
// Change logs:
// May 12 2018 - TrungTH - init pages 
// May 13 2018 - HoaTH - update
//
//=========================================================================================================
#region using
using System;
using System.Data;
using System.Windows.Forms;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.ProjectManagement.BLL;
using MyKPI.JobKpiAssessment.BLL;
using MyKPI.DeveloperProjectContribution.BLL;
using MyKPI.Common;
using MyKPI.Entities;
using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class DetailedJobKpiAssessmentForm : Form
    {

        #region common
        private void load()
        {
            InitCombobox();

            if (detailedFormMode == DetailedFormMode.Add)
            {
                gbxAssessmentinDetails.Enabled = false;
            }

            if (detailedFormMode == DetailedFormMode.Update)
            {
                gbxAssessmentinDetails.Enabled = true;
                projectInitComboBox();
                loadProjectContributionInDetails();
            }
            
        }

        public DetailedJobKpiAssessmentForm()
        {
            InitializeComponent();          
            detailedFormMode = DetailedFormMode.Add;
            load();
        }

        public DetailedJobKpiAssessmentForm(JobKpiEntity _jobKpiEntity)
        {
            InitializeComponent();
            detailedFormMode = DetailedFormMode.Update;
            load();
            jobKpiAssessmentID = _jobKpiEntity.ID;
            cbxEmployee.SelectedValue = _jobKpiEntity.Employee.ID;
            cbxRoleInAssessment.SelectedItem = _jobKpiEntity.RoleInAssessment;
            cbxStatus.SelectedItem = _jobKpiEntity.Status;
            dtmCreatedDate.Value = _jobKpiEntity.CreatedDate;
        }
        #endregion

        #region general information group box
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
                load();
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
        #endregion

        #region Assessment in Details group box

        #region project global parameters
        DeveloperProjectContributionBLL developerProjectContributionBLL = new DeveloperProjectContributionBLL();
        private DetailedFormMode project1DetailedFormMode = DetailedFormMode.Add;
        private int developerProjectContributionID = 0;
        
        #endregion

        private void projectInitComboBox()
        {
            ProjectBLL projectBLL = new ProjectBLL();
            cbxProject.DataSource = projectBLL.LoadAllProject();
            cbxProject.DisplayMember = "ProjectName";
            cbxProject.ValueMember = "ID";

            cbxTeamRole.Items.Clear();
            cbxTeamRole.Items.Add(TeamRoleValue.Member);
            cbxTeamRole.Items.Add(TeamRoleValue.TechnicalExpert);
            cbxTeamRole.Items.Add(TeamRoleValue.TechnicalLead);
            cbxTeamRole.Items.Add(TeamRoleValue.TeamLead);
            cbxTeamRole.SelectedIndex = 0;

            cbxImplementDesign.Items.Clear();
            cbxImplementDesign.Items.Add(WorkingResultValue.NotWork);
            cbxImplementDesign.Items.Add(WorkingResultValue.Normal);
            cbxImplementDesign.Items.Add(WorkingResultValue.Good);
            cbxImplementDesign.Items.Add(WorkingResultValue.Exelent);
            cbxImplementDesign.SelectedIndex = 0;

            cbxImplementCode.Items.Clear();
            cbxImplementCode.Items.Add(WorkingResultValue.NotWork);
            cbxImplementCode.Items.Add(WorkingResultValue.Normal);
            cbxImplementCode.Items.Add(WorkingResultValue.Good);
            cbxImplementCode.Items.Add(WorkingResultValue.Exelent);
            cbxImplementCode.SelectedIndex = 0;

            cbxImplementUnitTest.Items.Clear();
            cbxImplementUnitTest.Items.Add(WorkingResultValue.NotWork);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Normal);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Good);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Exelent);
            cbxImplementUnitTest.SelectedIndex = 0;

        }

        private void loadProjectContributionInDetails()
        {
            DeveloperProjectContributionEntity developerProjectContributionEntity1 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 1);
            if (developerProjectContributionEntity1 == null)
            {
                btnConfirmProject.Text = "ADD NEW PROJECT 1'S CONTRIBUTION";
                grbProject1.Enabled = false;
            }
            else
            {
                btnConfirmProject.Text = "UPDATE NEW PROJECT 1'S CONTRIBUTION";
                grbProject1.Enabled = true;
            }
        }
        private void btnConfirmProject_Click(object sender, EventArgs e)
        {
            DeveloperProjectContributionEntity developerProjectContributionEntity = new DeveloperProjectContributionEntity();

            // developerProjectContributionEntity.ID = ;
            ProjectEntity projectEntity = new ProjectEntity();
            projectEntity.ID = (int)cbxProject.SelectedValue;
            developerProjectContributionEntity.Project = projectEntity;
            
            developerProjectContributionEntity.ProjectSeq = tclProject.SelectedIndex + 1;
            developerProjectContributionEntity.TeamRole = (TeamRoleValue)cbxTeamRole.SelectedItem;
            developerProjectContributionEntity.ImplementCode = (WorkingResultValue)cbxImplementCode.SelectedItem;
            developerProjectContributionEntity.ImplementDesign = (WorkingResultValue)cbxImplementDesign.SelectedItem;
            developerProjectContributionEntity.ImplementUnitTest = (WorkingResultValue)cbxImplementUnitTest.SelectedItem;

            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = jobKpiAssessmentID;
            developerProjectContributionEntity.JobKpiAssessment = jobKpiEntity;

            if (project1DetailedFormMode == DetailedFormMode.Add)
            {
                developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity);
            }
            if (project1DetailedFormMode == DetailedFormMode.Update)
            {
                developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity, developerProjectContributionID);
            }
        }

        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = (DataRowView)cbxProject.SelectedItem;
            txtProjectCode.Text = row[1].ToString();
        }

        #endregion


    }
}
