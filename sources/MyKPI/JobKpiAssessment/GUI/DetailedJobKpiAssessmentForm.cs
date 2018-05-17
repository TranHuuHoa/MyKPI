//========================================================================================================
//  MyKPI - Detailed Job KPI Assessment  Form
// Change logs:
// May 12 2018 - TrungTH - init pages 
// May 13 2018 - HoaTH - update
// May 17 2018 - TrungTH - update new features
//=========================================================================================================
#region using
using MyKPI.Common;
using MyKPI.DeveloperProjectContribution.BLL;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Entities;
using MyKPI.Entities.Assessment;
using MyKPI.JobKpiAssessment.BLL;
using MyKPI.ProjectManagement.BLL;
using System;
using System.Data;
using System.Windows.Forms;
#endregion

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class DetailedJobKpiAssessmentForm : Form
    {
        #region class parameters
        private JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();
        private JobKpiEntity jobKpiEntity = new JobKpiEntity();
        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;
        private int jobKpiAssessmentID = 0;
        #endregion

        #region common
        private void load()
        {           
            if (detailedFormMode == DetailedFormMode.Add)
            {
                gbxAssessmentinDetails.Enabled = false;
            }

            if (detailedFormMode == DetailedFormMode.Update)
            {
                gbxAssessmentinDetails.Enabled = true;
                
                project1ClearCommboBox();
                jobKpiEntity.ProjectContribution1 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 1);
                bool enable = (jobKpiEntity.ProjectContribution1 != null);
                if (enable)
                {
                    project1InitComboBox();
                    loadProjectContributionInDetails(tclProject.SelectedIndex, enable);
                }

                project1ClearCommboBox();
                jobKpiEntity.ProjectContribution2 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 2);
                enable = (jobKpiEntity.ProjectContribution2 != null);
                if (enable)
                {
                    project2InitComboBox();
                    loadProjectContributionInDetails(tclProject.SelectedIndex, enable);
                } 

                enable = (developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 3) != null);
                if (enable)
                {
                    project3InitComboBox();
                    loadProjectContributionInDetails(tclProject.SelectedIndex, enable);
                }
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
            InitCombobox();
            detailedFormMode = DetailedFormMode.Update;
            
            jobKpiAssessmentID = _jobKpiEntity.ID;
            cbxEmployee.SelectedValue = _jobKpiEntity.Employee.ID;
            cbxRoleInAssessment.SelectedItem = _jobKpiEntity.RoleInAssessment;
            cbxStatus.SelectedItem = _jobKpiEntity.Status;
            dtmCreatedDate.Value = _jobKpiEntity.CreatedDate;

            load();
        }
        #endregion

        #region general information group box
        

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

        #region project class parameters
        DeveloperProjectContributionBLL developerProjectContributionBLL = new DeveloperProjectContributionBLL();
        private DetailedFormMode project1DetailedFormMode = DetailedFormMode.Add;
        private DetailedFormMode project2DetailedFormMode = DetailedFormMode.Add;
        private DetailedFormMode project3DetailedFormMode = DetailedFormMode.Add;
        private int developerProjectContributionID = 0;
        private FormState addDeveloperProjectContributionState = FormState.preProcess;
        #endregion

        private void tclProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }

        private void project1ClearCommboBox()
        {
            cbxProject1.DataSource = null;
            cbxImplementDesign1.Items.Clear();
            cbxImplementCode1.Items.Clear();
            cbxImplementUnitTest1.Items.Clear();
        }
        private void project1InitComboBox()
        {
            ProjectBLL projectBLL = new ProjectBLL();
            cbxProject1.DataSource = projectBLL.LoadAllProject();
            cbxProject1.DisplayMember = "ProjectName";
            cbxProject1.ValueMember = "ID";

            cbxTeamRole1.Items.Clear();
            cbxTeamRole1.Items.Add(TeamRoleValue.Member);
            cbxTeamRole1.Items.Add(TeamRoleValue.TechnicalExpert);
            cbxTeamRole1.Items.Add(TeamRoleValue.TechnicalLead);
            cbxTeamRole1.Items.Add(TeamRoleValue.TeamLead);
            cbxTeamRole1.SelectedIndex = 0;
          
            cbxImplementDesign1.Items.Add(WorkingResultValue.NotWork);
            cbxImplementDesign1.Items.Add(WorkingResultValue.Normal);
            cbxImplementDesign1.Items.Add(WorkingResultValue.Good);
            cbxImplementDesign1.Items.Add(WorkingResultValue.Exelent);
            cbxImplementDesign1.SelectedIndex = 0;
          
            cbxImplementCode1.Items.Add(WorkingResultValue.NotWork);
            cbxImplementCode1.Items.Add(WorkingResultValue.Normal);
            cbxImplementCode1.Items.Add(WorkingResultValue.Good);
            cbxImplementCode1.Items.Add(WorkingResultValue.Exelent);
            cbxImplementCode1.SelectedIndex = 0;
          
            cbxImplementUnitTest1.Items.Add(WorkingResultValue.NotWork);
            cbxImplementUnitTest1.Items.Add(WorkingResultValue.Normal);
            cbxImplementUnitTest1.Items.Add(WorkingResultValue.Good);
            cbxImplementUnitTest1.Items.Add(WorkingResultValue.Exelent);
            cbxImplementUnitTest1.SelectedIndex = 0;

        }
        private void project2InitComboBox()
        {
            ProjectBLL projectBLL = new ProjectBLL();
            cbxProject2.DataSource = projectBLL.LoadAllProject();
            cbxProject2.DisplayMember = "ProjectName";
            cbxProject2.ValueMember = "ID";

            cbxTeamRole2.Items.Clear();
            cbxTeamRole2.Items.Add(TeamRoleValue.Member);
            cbxTeamRole2.Items.Add(TeamRoleValue.TechnicalExpert);
            cbxTeamRole2.Items.Add(TeamRoleValue.TechnicalLead);
            cbxTeamRole2.Items.Add(TeamRoleValue.TeamLead);
            cbxTeamRole2.SelectedIndex = 0;

            cbxImplementDesign2.Items.Clear();
            cbxImplementDesign2.Items.Add(WorkingResultValue.NotWork);
            cbxImplementDesign2.Items.Add(WorkingResultValue.Normal);
            cbxImplementDesign2.Items.Add(WorkingResultValue.Good);
            cbxImplementDesign2.Items.Add(WorkingResultValue.Exelent);
            cbxImplementDesign2.SelectedIndex = 0;

            cbxImplementCode2.Items.Clear();
            cbxImplementCode2.Items.Add(WorkingResultValue.NotWork);
            cbxImplementCode2.Items.Add(WorkingResultValue.Normal);
            cbxImplementCode2.Items.Add(WorkingResultValue.Good);
            cbxImplementCode2.Items.Add(WorkingResultValue.Exelent);
            cbxImplementCode2.SelectedIndex = 0;

            cbxImplementUnitTest2.Items.Clear();
            cbxImplementUnitTest2.Items.Add(WorkingResultValue.NotWork);
            cbxImplementUnitTest2.Items.Add(WorkingResultValue.Normal);
            cbxImplementUnitTest2.Items.Add(WorkingResultValue.Good);
            cbxImplementUnitTest2.Items.Add(WorkingResultValue.Exelent);
            cbxImplementUnitTest2.SelectedIndex = 0;

        }
        private void project3InitComboBox()
        {
            ProjectBLL projectBLL = new ProjectBLL();
            cbxProject3.DataSource = projectBLL.LoadAllProject();
            cbxProject3.DisplayMember = "ProjectName";
            cbxProject3.ValueMember = "ID";

            cbxTeamRole3.Items.Clear();
            cbxTeamRole3.Items.Add(TeamRoleValue.Member);
            cbxTeamRole3.Items.Add(TeamRoleValue.TechnicalExpert);
            cbxTeamRole3.Items.Add(TeamRoleValue.TechnicalLead);
            cbxTeamRole3.Items.Add(TeamRoleValue.TeamLead);
            cbxTeamRole3.SelectedIndex = 0;

            cbxImplementDesign3.Items.Clear();
            cbxImplementDesign3.Items.Add(WorkingResultValue.NotWork);
            cbxImplementDesign3.Items.Add(WorkingResultValue.Normal);
            cbxImplementDesign3.Items.Add(WorkingResultValue.Good);
            cbxImplementDesign3.Items.Add(WorkingResultValue.Exelent);
            cbxImplementDesign3.SelectedIndex = 0;

            cbxImplementCode3.Items.Clear();
            cbxImplementCode3.Items.Add(WorkingResultValue.NotWork);
            cbxImplementCode3.Items.Add(WorkingResultValue.Normal);
            cbxImplementCode3.Items.Add(WorkingResultValue.Good);
            cbxImplementCode3.Items.Add(WorkingResultValue.Exelent);
            cbxImplementCode3.SelectedIndex = 0;

            cbxImplementUnitTest3.Items.Clear();
            cbxImplementUnitTest3.Items.Add(WorkingResultValue.NotWork);
            cbxImplementUnitTest3.Items.Add(WorkingResultValue.Normal);
            cbxImplementUnitTest3.Items.Add(WorkingResultValue.Good);
            cbxImplementUnitTest3.Items.Add(WorkingResultValue.Exelent);
            cbxImplementUnitTest3.SelectedIndex = 0;

        }

        private void loadProjectContributionInDetails(int currentTabIndex, bool grbProjectEnable)
        {
            addDeveloperProjectContributionState = FormState.preProcess;
            
            btnConfirmProject.Text = "ADD NEW PROJECT 1'S CONTRIBUTION";
            string project = string.Empty;
            switch (currentTabIndex)
            {
                case 0:
                    project = "PROJECT 1";
                    grbProject1.Enabled = grbProjectEnable;
                    cbxProject1.SelectedValue = (jobKpiEntity.ProjectContribution1 as DeveloperProjectContributionEntity).ID;
                    
                    break;
                case 1:
                    project = "PROJECT 2";
                    grbProject2.Enabled = grbProjectEnable;
                    cbxProject2.SelectedValue = (jobKpiEntity.ProjectContribution2 as DeveloperProjectContributionEntity).ID;
                    break;
                case 2:
                    project = "PROJECT 3";
                    grbProject3.Enabled = grbProjectEnable;
                    cbxProject3.SelectedValue = (jobKpiEntity.ProjectContribution3 as DeveloperProjectContributionEntity).ID;
                    break;
            }
            string btnConfirmProjectText = string.Empty;
            if (grbProjectEnable) btnConfirmProjectText = String.Format("UPDATE NEW {0}'S CONTRIBUTION", project);
            else btnConfirmProjectText = String.Format("ADD NEW {0}'S CONTRIBUTION", project);        
        }

        private void btnConfirmProject_Click(object sender, EventArgs e)
        {
            //1
            DeveloperProjectContributionEntity developerProjectContributionEntity1 = new DeveloperProjectContributionEntity();

            developerProjectContributionEntity1.ID = developerProjectContributionID;
            ProjectEntity projectEntity1 = new ProjectEntity();
            projectEntity1.ID = (int)cbxProject1.SelectedValue;
            developerProjectContributionEntity1.Project = projectEntity1;
            developerProjectContributionEntity1.ProjectSeq = tclProject.SelectedIndex + 1;
            developerProjectContributionEntity1.TeamRole = (TeamRoleValue)cbxTeamRole1.SelectedItem;
            developerProjectContributionEntity1.ImplementCode = (WorkingResultValue)cbxImplementCode1.SelectedItem;
            developerProjectContributionEntity1.ImplementDesign = (WorkingResultValue)cbxImplementDesign1.SelectedItem;
            developerProjectContributionEntity1.ImplementUnitTest = (WorkingResultValue)cbxImplementUnitTest1.SelectedItem;
            JobKpiEntity jobKpiEntity1 = new JobKpiEntity();
            jobKpiEntity1.ID = jobKpiAssessmentID;
            developerProjectContributionEntity1.JobKpiAssessment = jobKpiEntity1;

            if (project1DetailedFormMode == DetailedFormMode.Add)
            {
                developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity1);
            }
            if (project1DetailedFormMode == DetailedFormMode.Update)
            {
                developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity1, developerProjectContributionID);
            }
            //
            //2
            DeveloperProjectContributionEntity developerProjectContributionEntity2 = new DeveloperProjectContributionEntity();

            developerProjectContributionEntity2.ID = developerProjectContributionID;
            ProjectEntity projectEntity2 = new ProjectEntity();
            projectEntity2.ID = (int)cbxProject2.SelectedValue;
            developerProjectContributionEntity2.Project = projectEntity2;
            developerProjectContributionEntity2.ProjectSeq = tclProject.SelectedIndex + 1;
            developerProjectContributionEntity2.TeamRole = (TeamRoleValue)cbxTeamRole2.SelectedItem;
            developerProjectContributionEntity2.ImplementCode = (WorkingResultValue)cbxImplementCode2.SelectedItem;
            developerProjectContributionEntity2.ImplementDesign = (WorkingResultValue)cbxImplementDesign2.SelectedItem;
            developerProjectContributionEntity2.ImplementUnitTest = (WorkingResultValue)cbxImplementUnitTest2.SelectedItem;
            JobKpiEntity jobKpiEntity2 = new JobKpiEntity();
            jobKpiEntity2.ID = jobKpiAssessmentID;
            developerProjectContributionEntity2.JobKpiAssessment = jobKpiEntity2;

            if (project1DetailedFormMode == DetailedFormMode.Add)
            {
                developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity2);
            }
            if (project1DetailedFormMode == DetailedFormMode.Update)
            {
                developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity2, developerProjectContributionID);
            }
            //
            //3
            DeveloperProjectContributionEntity developerProjectContributionEntity3 = new DeveloperProjectContributionEntity();

            developerProjectContributionEntity3.ID = developerProjectContributionID;
            ProjectEntity projectEntity3 = new ProjectEntity();
            projectEntity3.ID = (int)cbxProject3.SelectedValue;
            developerProjectContributionEntity3.Project = projectEntity3;
            developerProjectContributionEntity3.ProjectSeq = tclProject.SelectedIndex + 1;
            developerProjectContributionEntity3.TeamRole = (TeamRoleValue)cbxTeamRole3.SelectedItem;
            developerProjectContributionEntity3.ImplementCode = (WorkingResultValue)cbxImplementCode3.SelectedItem;
            developerProjectContributionEntity3.ImplementDesign = (WorkingResultValue)cbxImplementDesign3.SelectedItem;
            developerProjectContributionEntity3.ImplementUnitTest = (WorkingResultValue)cbxImplementUnitTest3.SelectedItem;
            JobKpiEntity jobKpiEntity3 = new JobKpiEntity();
            jobKpiEntity3.ID = jobKpiAssessmentID;
            developerProjectContributionEntity3.JobKpiAssessment = jobKpiEntity3;

            if (project1DetailedFormMode == DetailedFormMode.Add)
            {
                developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity3);
            }
            if (project1DetailedFormMode == DetailedFormMode.Update)
            {
                developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity3, developerProjectContributionID);
            }
            //
        }

        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void cbxProject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProject1.DataSource != null)
            {
                var row = (DataRowView)cbxProject1.SelectedItem;
                txtProjectCode1.Text = row[1].ToString();
                txtStartedEnd1.Text =  Convert.ToDateTime(row[3]).ToShortDateString() +"--"+ Convert.ToDateTime(row[4]).ToShortDateString();
                txtScopeMM1.Text = row[5].ToString();
            }          
        }

        private void cbxProject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProject2.DataSource != null)
            {
                var row = (DataRowView)cbxProject2.SelectedItem;
                txtProjectCode2.Text = row[1].ToString();
                txtStartedEnd2.Text = Convert.ToDateTime(row[3]).ToShortDateString() + "--" + Convert.ToDateTime(row[4]).ToShortDateString();
                txtScopeMM2.Text = row[5].ToString();
            }
        }


        #endregion


    }
}
