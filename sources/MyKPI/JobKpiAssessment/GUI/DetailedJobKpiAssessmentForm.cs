//========================================================================================================
//  MyKPI - Detailed Job KPI Assessment  Form
// Change logs:
// May 12 2018 - TrungTH - init pages 
// May 13 2018 - HoaTH - update
// May 17 2018 - TrungTH - update new features
// May 18 2018 - HoaTH - upgrade and optimize code
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
        private int jobKpiAssessmentID = 0;
        private int developerProjectContributionID = 0;

        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;
        private DetailedFormMode projectDetailedFormMode = DetailedFormMode.Add;
        
        private FormState UpdateJobKpiAssessmentState = FormState.preProcess;
        private FormState developerProjectContributionState = FormState.preProcess;

        private JobKpiEntity jobKpiEntity = new JobKpiEntity();
        private JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();                                 
        private DeveloperProjectContributionBLL developerProjectContributionBLL = new DeveloperProjectContributionBLL();
        #endregion

        #region private functions
        // common
        private void init()
        {
            InitializeComponent();
            InitCombobox();           
        }
        private void load()
        {
            if (detailedFormMode == DetailedFormMode.Add)
            {
                gbxAssessmentinDetails.Enabled = false;
            }
            else
            {
                if (UpdateJobKpiAssessmentState == FormState.preProcess)
                {
                    enableGeneralInformation(false);
                    btnConfirm.Text = "Update Job KPI general information";
                    btnCancel.Text = "Exit";
                    gbxAssessmentinDetails.Enabled = true;

                    switch (tclProject.SelectedIndex)
                    {
                        case 0:
                            jobKpiEntity.ProjectContribution1 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 1);
                            var developerProjectContribution = (jobKpiEntity.ProjectContribution1 as DeveloperProjectContributionEntity);
                            loadPerProjectContributionTab(developerProjectContribution, grbProject1, cbxProject1, cbxTeamRole1, cbxImplementDesign1, cbxImplementCode1, cbxImplementUnitTest1,txtProjectCode1,txtStartedEnd1,txtScopeMM1);
                            break;
                        case 1:
                            jobKpiEntity.ProjectContribution2 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 2);
                            developerProjectContribution = (jobKpiEntity.ProjectContribution2 as DeveloperProjectContributionEntity);
                            loadPerProjectContributionTab(developerProjectContribution, grbProject2, cbxProject2, cbxTeamRole2, cbxImplementDesign2, cbxImplementCode2, cbxImplementUnitTest2, txtProjectCode2, txtStartedEnd2, txtScopeMM2);
                            break;
                        case 2:
                            jobKpiEntity.ProjectContribution3 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 3);
                            developerProjectContribution = (jobKpiEntity.ProjectContribution3 as DeveloperProjectContributionEntity);
                            loadPerProjectContributionTab(developerProjectContribution, grbProject3, cbxProject3, cbxTeamRole3, cbxImplementDesign3, cbxImplementCode3, cbxImplementUnitTest3, txtProjectCode3, txtStartedEnd3, txtScopeMM3);
                            break;
                    }
                }
                else
                {
                    enableGeneralInformation(true);
                    btnConfirm.Text = "Confirm";
                    btnCancel.Text = "Cancel";
                    gbxAssessmentinDetails.Enabled = false;
                }

            }
        }
        private void loadPerProjectContributionTab(DeveloperProjectContributionEntity developerProjectContributionEntity, GroupBox grbProject, ComboBox cbxProject, ComboBox cbxTeamRole, ComboBox cbxImplementDesign, ComboBox cbxImplementCode, ComboBox cbxImplementUnitTest, TextBox txtProjectCode, TextBox txtStartedEnd, TextBox txtScopeMM)
        {          
            if (developerProjectContributionState == FormState.preProcess)
            {
                grbProject.Enabled = false;

                if (developerProjectContributionEntity != null)
                {
                    projectDetailedFormMode = DetailedFormMode.Update;
                    projectInitComboBox(cbxProject, cbxTeamRole, cbxImplementDesign, cbxImplementCode, cbxImplementUnitTest);
                    cbxProject.SelectedValue = developerProjectContributionEntity.Project.ID;
                    var row = (DataRowView)cbxProject.SelectedItem;
                    loadProjectContributionInDetails(developerProjectContributionEntity, row, txtProjectCode, txtStartedEnd, txtScopeMM, cbxImplementCode, cbxImplementDesign, cbxImplementUnitTest);
                }
                else
                {
                    projectDetailedFormMode = DetailedFormMode.Add;
                    projectClearCommboBox(cbxProject, cbxTeamRole, cbxImplementDesign, cbxImplementCode, cbxImplementUnitTest);
                }
                gbxGeneralInformation.Enabled = true;
            }
            else
            {
                grbProject.Enabled = true;
                projectInitComboBox(cbxProject, cbxTeamRole, cbxImplementDesign, cbxImplementCode, cbxImplementUnitTest);

                if (developerProjectContributionEntity != null)
                {
                    projectDetailedFormMode = DetailedFormMode.Update;
                    var row = (DataRowView)cbxProject.SelectedItem;
                    loadProjectContributionInDetails(developerProjectContributionEntity, row, txtProjectCode, txtStartedEnd, txtScopeMM, cbxImplementCode, cbxImplementDesign, cbxImplementUnitTest);
                }
                else
                {
                    projectDetailedFormMode = DetailedFormMode.Add;
                }

                gbxGeneralInformation.Enabled = false;
            }
            loadTextOfButtonsAssessmentInDetails(0);
        }
        // general information
        private void InitCombobox()
        {
            reloadEmployeeData();

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
        private void enableGeneralInformation(bool enable)
        {
            cbxEmployee.Enabled = enable;
            cbxRoleInAssessment.Enabled = enable;
            dtmCreatedDate.Enabled = enable;
            cbxStatus.Enabled = enable;
        }
        private void reloadEmployeeData()
        {
            var employeeBLL = new EmployeeBLL();
            cbxEmployee.DataSource = employeeBLL.LoadAllEmployee();
            cbxEmployee.DisplayMember = "EmployeeName";
            cbxEmployee.ValueMember = "ID";
        }

        // Assessments in details
        private void loadProjectContributionInDetails(DeveloperProjectContributionEntity developerProjectContributionEntity, DataRowView row, TextBox txtProjectCode, TextBox txtStartedEnd, TextBox txtScopeMM, ComboBox cbxImplementCode, ComboBox cbxImplementDesign, ComboBox cbxImplementUnitTest)
        {
            developerProjectContributionID = developerProjectContributionEntity.ID;
            txtProjectCode.Text = row[1].ToString();
            txtStartedEnd.Text = Convert.ToDateTime(row[3]).ToShortDateString() + "--" + Convert.ToDateTime(row[4]).ToShortDateString();
            txtScopeMM.Text = row[5].ToString();

            cbxImplementCode.SelectedItem = developerProjectContributionEntity.ImplementCode;
            cbxImplementDesign.SelectedItem = developerProjectContributionEntity.ImplementDesign;
            cbxImplementUnitTest.SelectedItem = developerProjectContributionEntity.ImplementUnitTest;
            
        }
        private void loadTextOfButtonsAssessmentInDetails(int currentTabIndex)
        {
            string project = string.Empty;

            switch (currentTabIndex)
            {
                case 0:
                    project = "PROJECT 1";                    
                    break;
                case 1:
                    project = "PROJECT 2";
                    break;
                case 2:
                    project = "PROJECT 3";
                    break;
            }
            if (developerProjectContributionState == FormState.preProcess)
            {
                if (projectDetailedFormMode == DetailedFormMode.Update) btnConfirmProject.Text = String.Format("UPDATE NEW {0}'S CONTRIBUTION", project);
                else btnConfirmProject.Text = String.Format("ADD NEW {0}'S CONTRIBUTION", project);
                btnProjectCancel.Text = "EXIT";
            }
            else
            {

            }                    
        }       
        private void projectClearCommboBox(ComboBox cbxProject, ComboBox cbxTeamRole, ComboBox cbxImplementDesign, ComboBox cbxImplementCode, ComboBox cbxImplementUnitTest)
        {
            cbxProject.DataSource = null;
            cbxTeamRole.Items.Clear();
            cbxImplementDesign.Items.Clear();
            cbxImplementCode.Items.Clear();
            cbxImplementUnitTest.Items.Clear();

        }  
        private void projectInitComboBox(ComboBox cbxProject, ComboBox cbxTeamRole, ComboBox cbxImplementDesign, ComboBox cbxImplementCode, ComboBox cbxImplementUnitTest)
        {
            reloadProjectComboBox(cbxProject);

            cbxTeamRole.Items.Clear();
            cbxTeamRole.Items.Add(TeamRoleValue.Member);
            cbxTeamRole.Items.Add(TeamRoleValue.TechnicalExpert);
            cbxTeamRole.Items.Add(TeamRoleValue.TechnicalLead);
            cbxTeamRole.Items.Add(TeamRoleValue.TeamLead);
            cbxTeamRole.SelectedIndex = 0;

            cbxImplementDesign.Items.Add(WorkingResultValue.NotWork);
            cbxImplementDesign.Items.Add(WorkingResultValue.Normal);
            cbxImplementDesign.Items.Add(WorkingResultValue.Good);
            cbxImplementDesign.Items.Add(WorkingResultValue.Exelent);
            cbxImplementDesign.SelectedIndex = 0;

            cbxImplementCode.Items.Add(WorkingResultValue.NotWork);
            cbxImplementCode.Items.Add(WorkingResultValue.Normal);
            cbxImplementCode.Items.Add(WorkingResultValue.Good);
            cbxImplementCode.Items.Add(WorkingResultValue.Exelent);
            cbxImplementCode.SelectedIndex = 0;

            cbxImplementUnitTest.Items.Add(WorkingResultValue.NotWork);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Normal);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Good);
            cbxImplementUnitTest.Items.Add(WorkingResultValue.Exelent);
            cbxImplementUnitTest.SelectedIndex = 0;

        }
        private void reloadProjectComboBox(ComboBox cbxProject)
        {
            ProjectBLL projectBLL = new ProjectBLL();
            cbxProject.DataSource = projectBLL.LoadAllProject();
            cbxProject.DisplayMember = "ProjectName";
            cbxProject.ValueMember = "ID";
        }            
        #endregion

        #region Form constructors
        public DetailedJobKpiAssessmentForm()
        {
            init();
            load();
        }

        public DetailedJobKpiAssessmentForm(JobKpiEntity _jobKpiEntity)
        {
            init();
            
            detailedFormMode = DetailedFormMode.Update;
            jobKpiAssessmentID = _jobKpiEntity.ID;
            cbxEmployee.SelectedValue = _jobKpiEntity.Employee.ID;
            cbxRoleInAssessment.SelectedItem = _jobKpiEntity.RoleInAssessment;
            cbxStatus.SelectedItem = _jobKpiEntity.Status;
            dtmCreatedDate.Value = _jobKpiEntity.CreatedDate;

            load();
        }
        #endregion

        #region general information group box events
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
                if (CommonFunctions.ShowQuestionDialog("Do you want continue to work with this kpi assessment?", "Question") == DialogResult.Yes)
                {
                    detailedFormMode = DetailedFormMode.Update;
                    UpdateJobKpiAssessmentState = FormState.preProcess;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (UpdateJobKpiAssessmentState == FormState.preProcess)
                {
                    UpdateJobKpiAssessmentState = FormState.Process;                                       
                }
                else
                {
                    jobKpiAssessmentBLL.EditJobKpiAssessment(jobKpiEntity, jobKpiAssessmentID);
                    UpdateJobKpiAssessmentState = FormState.preProcess;
                }
            }

            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UpdateJobKpiAssessmentState == FormState.preProcess)
            {
                this.Close();
            }           
            else
            {
                UpdateJobKpiAssessmentState = FormState.preProcess;
                load();
            }
        }
        #endregion

        #region Assessment in Details group box events

        private void btnConfirmProject_Click(object sender, EventArgs e)
        {
            switch (tclProject.SelectedIndex)
            {
                case 0:
                    if (developerProjectContributionState == FormState.preProcess)
                    {
                        developerProjectContributionState = FormState.Process;
                    }
                    else
                    {
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

                        if (projectDetailedFormMode == DetailedFormMode.Add)
                        {
                            developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity1);
                        }
                        else
                        {
                            developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity1, developerProjectContributionID);
                        }
                        developerProjectContributionState = FormState.preProcess;
                    }

                    break;
                case 1:
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

                    if (projectDetailedFormMode == DetailedFormMode.Add)
                    {
                        developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity2);
                    }
                    if (projectDetailedFormMode == DetailedFormMode.Update)
                    {
                        developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity2, developerProjectContributionID);
                    }
                    break;
                case 2:
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

                    if (projectDetailedFormMode == DetailedFormMode.Add)
                    {
                        developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity3);
                    }
                    if (projectDetailedFormMode == DetailedFormMode.Update)
                    {
                        developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity3, developerProjectContributionID);
                    }
                    break;
            }

            load();
        }
        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tclProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
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
        private void cbxProject3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProject3.DataSource != null)
            {
                var row = (DataRowView)cbxProject3.SelectedItem;
                txtProjectCode3.Text = row[1].ToString();
                txtStartedEnd3.Text = Convert.ToDateTime(row[3]).ToShortDateString() + "--" + Convert.ToDateTime(row[4]).ToShortDateString();
                txtScopeMM3.Text = row[5].ToString();
            }

        }
        #endregion


    }
}
