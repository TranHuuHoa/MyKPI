﻿//========================================================================================================
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
using MyKPI.DeveloperProfessionalContribution.BLL;
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
        private int developerProfessionalContributionID = 0;

        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;
        private DetailedFormMode projectDetailedFormMode = DetailedFormMode.Add;
        private DetailedFormMode professionalDetailedFormMode = DetailedFormMode.Add;

        private FormState UpdateJobKpiAssessmentState = FormState.preProcess;
        private FormState developerProjectContributionState = FormState.preProcess;
        private FormState developerProfessionalContributionState = FormState.preProcess;

        private JobKpiEntity jobKpiEntity = new JobKpiEntity();
        private JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();                                 
        private DeveloperProjectContributionBLL developerProjectContributionBLL = new DeveloperProjectContributionBLL();
        private DeveloperProfessionalContributionBLL developerProfessionalContributionBLL = new DeveloperProfessionalContributionBLL();
        #endregion

        #region private functions
        // common
        private void init()
        {
            InitializeComponent();
            InitCombobox();
            professionalContributionInitComboBox();
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
                    btnConfirm.Text = "UPDATE JOB KPI GENERAL INFORMATION";
                    btnCancel.Text = "EXIT";
                    gbxAssessmentinDetails.Enabled = true;


                    switch (tclAssessmentInDetails.SelectedIndex)
                    {
                        case 0:
                            switch (tclProject.SelectedIndex)
                            {
                                case 0:
                                    jobKpiEntity.ProjectContribution1 = developerProjectContributionBLL.LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(jobKpiAssessmentID, 1);
                                    var developerProjectContribution = (jobKpiEntity.ProjectContribution1 as DeveloperProjectContributionEntity);
                                    loadPerProjectContributionTab(developerProjectContribution, grbProject1, cbxProject1, cbxTeamRole1, cbxImplementDesign1, cbxImplementCode1, cbxImplementUnitTest1, txtProjectCode1, txtStartedEnd1, txtScopeMM1);
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
                            break;
                        case 1:
                            jobKpiEntity.ProfessionalContribution = developerProfessionalContributionBLL.LoadPerJobKpiAssessmentID(jobKpiAssessmentID);
                            var developerProfessionalContribution = (jobKpiEntity.ProfessionalContribution as DeveloperProfessionalContributionEntity);
                            
                            loadPerProfessionalContributionTab(developerProfessionalContribution);
                            break;
                        case 2:
                            break;
                    }

                    
                }
                else
                {
                    enableGeneralInformation(true);
                    btnConfirm.Text = "CONFIRM";
                    btnCancel.Text = "CANCEL";
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
                    loadProjectContributionInDetails(developerProjectContributionEntity, row, txtProjectCode, txtStartedEnd, txtScopeMM,cbxTeamRole,cbxImplementCode, cbxImplementDesign, cbxImplementUnitTest);
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
                    loadProjectContributionInDetails(developerProjectContributionEntity, row, txtProjectCode, txtStartedEnd, txtScopeMM, cbxTeamRole, cbxImplementCode, cbxImplementDesign, cbxImplementUnitTest);
                }
                else
                {
                    projectDetailedFormMode = DetailedFormMode.Add;
                }

                gbxGeneralInformation.Enabled = false;
            }
            loadTextOfButtonsAssessmentInDetails();
        }

        private void loadPerProfessionalContributionTab(DeveloperProfessionalContributionEntity developerProfessionalContributionEntity)
        {
            if (developerProfessionalContributionState == FormState.preProcess)
            {
                grbProfessionalContribution.Enabled = false;

                if (developerProfessionalContributionEntity != null)
                {
                    professionalDetailedFormMode = DetailedFormMode.Update;
                    professionalContributionInitComboBox();
                    developerProfessionalContributionID = developerProfessionalContributionEntity.ID;
                    cbxMasterProgrammingLanguages.SelectedItem = developerProfessionalContributionEntity.MasterProgrammingLanguages;
                    cbxMasterUnitTesting.SelectedItem = developerProfessionalContributionEntity.MasterUnitTesting;
                    cbxMasterClientFramework.SelectedItem = developerProfessionalContributionEntity.MasterClientFramework;
                    cbxMasterSofwareDevelopmentFramework.SelectedItem = developerProfessionalContributionEntity.MasterSofwareDevelopmentFramework;
                    lstSoftwareDevelopment.SetItemChecked(0, developerProfessionalContributionEntity.IntructorAtCompany);
                    lstSoftwareDevelopment.SetItemChecked(1, developerProfessionalContributionEntity.SharingAtWorkshop);
                    lstSoftwareDevelopment.SetItemChecked(2, developerProfessionalContributionEntity.DevelopTrainningCourse);
                    lstSoftwareDevelopment.SetItemChecked(3, developerProfessionalContributionEntity.SubmissionImprovementProposal);
                    lstSoftwareDevelopment.SetItemChecked(4, developerProfessionalContributionEntity.ActivitesInComunity);
                    chkDevelopsSubordinates.Checked = developerProfessionalContributionEntity.DevelopsSubordinates;
                    btnConfirmProfessional.Text = "EDIT";
                    btnCancelProfessional.Text = "EXIT";
                    
                }
                else
                {
                    professionalDetailedFormMode = DetailedFormMode.Add;
                    professionalClearCommboBox();
                    btnConfirmProfessional.Text = "ADD";
                    btnCancelProfessional.Text = "EXIT";
                }
                gbxGeneralInformation.Enabled = true;
            }
            else
            {
                grbProfessionalContribution.Enabled = true;
                professionalContributionInitComboBox();

                if (developerProfessionalContributionEntity != null)
                {
                    professionalDetailedFormMode = DetailedFormMode.Update;
                    professionalContributionInitComboBox();
                    developerProfessionalContributionID = developerProfessionalContributionEntity.ID;
                    cbxMasterProgrammingLanguages.SelectedItem = developerProfessionalContributionEntity.MasterProgrammingLanguages;
                    cbxMasterUnitTesting.SelectedItem = developerProfessionalContributionEntity.MasterUnitTesting;
                    cbxMasterClientFramework.SelectedItem = developerProfessionalContributionEntity.MasterClientFramework;
                    cbxMasterSofwareDevelopmentFramework.SelectedItem = developerProfessionalContributionEntity.MasterSofwareDevelopmentFramework;
                    lstSoftwareDevelopment.SetItemChecked(0, developerProfessionalContributionEntity.IntructorAtCompany);
                    lstSoftwareDevelopment.SetItemChecked(1, developerProfessionalContributionEntity.SharingAtWorkshop);
                    lstSoftwareDevelopment.SetItemChecked(2, developerProfessionalContributionEntity.DevelopTrainningCourse);
                    lstSoftwareDevelopment.SetItemChecked(3, developerProfessionalContributionEntity.SubmissionImprovementProposal);
                    lstSoftwareDevelopment.SetItemChecked(4, developerProfessionalContributionEntity.ActivitesInComunity);
                    chkDevelopsSubordinates.Checked = developerProfessionalContributionEntity.DevelopsSubordinates;
                }
                else
                {
                    projectDetailedFormMode = DetailedFormMode.Add;
                }

                gbxGeneralInformation.Enabled = false;
                btnConfirmProfessional.Text = "COMFIRM";
                btnCancelProfessional.Text = "CANCEL";
            }          
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
        private void loadProjectContributionInDetails(DeveloperProjectContributionEntity developerProjectContributionEntity, DataRowView row, TextBox txtProjectCode, TextBox txtStartedEnd, TextBox txtScopeMM,ComboBox cbxTeamRole, ComboBox cbxImplementCode, ComboBox cbxImplementDesign, ComboBox cbxImplementUnitTest)
        {
            developerProjectContributionID = developerProjectContributionEntity.ID;
            txtProjectCode.Text = row[1].ToString();
            txtStartedEnd.Text = Convert.ToDateTime(row[3]).ToShortDateString() + "--" + Convert.ToDateTime(row[4]).ToShortDateString();
            txtScopeMM.Text = row[5].ToString();

            cbxTeamRole.SelectedItem = developerProjectContributionEntity.TeamRole;
            cbxImplementCode.SelectedItem = developerProjectContributionEntity.ImplementCode;
            cbxImplementDesign.SelectedItem = developerProjectContributionEntity.ImplementDesign;
            cbxImplementUnitTest.SelectedItem = developerProjectContributionEntity.ImplementUnitTest;
            
        }
        private void loadTextOfButtonsAssessmentInDetails()
        {
            string project = string.Empty;

            switch (tclProject.SelectedIndex)
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
                btnConfirmProject.Text = "CONFIRM";
                btnProjectCancel.Text = "CANCEL";
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
            projectClearCommboBox(cbxProject, cbxTeamRole, cbxImplementDesign, cbxImplementCode, cbxImplementUnitTest);

            reloadProjectComboBox(cbxProject);

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

        private void ProcessConfrimProject(int ProjectSeq, ComboBox cbxProject, ComboBox cbxTeamRole, ComboBox cbxImplementDesign, ComboBox cbxImplementCode, ComboBox cbxImplementUnitTest)
        {
            var developerProjectContributionEntity = new DeveloperProjectContributionEntity();

            developerProjectContributionEntity.ID = developerProjectContributionID;
            var projectEntity = new ProjectEntity();
            projectEntity.ID = (int)cbxProject.SelectedValue;
            developerProjectContributionEntity.Project = projectEntity;
            developerProjectContributionEntity.ProjectSeq = ProjectSeq;
            developerProjectContributionEntity.TeamRole = (TeamRoleValue)cbxTeamRole.SelectedItem;
            developerProjectContributionEntity.ImplementCode = (WorkingResultValue)cbxImplementCode.SelectedItem;
            developerProjectContributionEntity.ImplementDesign = (WorkingResultValue)cbxImplementDesign.SelectedItem;
            developerProjectContributionEntity.ImplementUnitTest = (WorkingResultValue)cbxImplementUnitTest.SelectedItem;
            var jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = jobKpiAssessmentID;
            developerProjectContributionEntity.JobKpiAssessment = jobKpiEntity;

            if (projectDetailedFormMode == DetailedFormMode.Add)
            {
                developerProjectContributionBLL.AddDeveloperProjectContribution(developerProjectContributionEntity);
            }
            else
            {
                developerProjectContributionBLL.EditDeveloperProjectContribution(developerProjectContributionEntity, developerProjectContributionID);
            }
            developerProjectContributionState = FormState.preProcess;
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
                jobKpiAssessmentID = jobKpiAssessmentBLL.AddJobKpiAssessment(jobKpiEntity);
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
                        ProcessConfrimProject(1, cbxProject1, cbxTeamRole1, cbxImplementDesign1, cbxImplementCode1, cbxImplementUnitTest1);
                    }
                    break;
                case 1:
                    if (developerProjectContributionState == FormState.preProcess)
                    {
                        developerProjectContributionState = FormState.Process;
                    }
                    else
                    {
                        ProcessConfrimProject(2, cbxProject2, cbxTeamRole2, cbxImplementDesign2, cbxImplementCode2, cbxImplementUnitTest2);
                    }
                    break;
                case 2:
                    if (developerProjectContributionState == FormState.preProcess)
                    {
                        developerProjectContributionState = FormState.Process;
                    }
                    else
                    {
                        ProcessConfrimProject(3, cbxProject3, cbxTeamRole3, cbxImplementDesign3, cbxImplementCode3, cbxImplementUnitTest3);
                    }
                    break;
            }

            load();
        }
        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            if (developerProjectContributionState == FormState.preProcess)
            {
                this.Close();
            }
            else
            {
                developerProjectContributionState = FormState.preProcess;
                load();
            }
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

        #region Professional Contribution
        private void professionalClearCommboBox()
        {
            cbxMasterProgrammingLanguages.Items.Clear();
            cbxMasterUnitTesting.Items.Clear();
            cbxMasterClientFramework.Items.Clear();
            cbxMasterSofwareDevelopmentFramework.Items.Clear();
        }

        private void professionalContributionInitComboBox()
        {
            professionalClearCommboBox();

            cbxMasterProgrammingLanguages.Items.Add(ProfessionalValue.NoKnowledge);
            cbxMasterProgrammingLanguages.Items.Add(ProfessionalValue.Junior);
            cbxMasterProgrammingLanguages.Items.Add(ProfessionalValue.Senior);
            cbxMasterProgrammingLanguages.Items.Add(ProfessionalValue.Expert);
            cbxMasterProgrammingLanguages.Items.Add(ProfessionalValue.Master);
            cbxMasterProgrammingLanguages.SelectedIndex = 0;

            cbxMasterUnitTesting.Items.Add(ProfessionalValue.NoKnowledge);
            cbxMasterUnitTesting.Items.Add(ProfessionalValue.Junior);
            cbxMasterUnitTesting.Items.Add(ProfessionalValue.Senior);
            cbxMasterUnitTesting.Items.Add(ProfessionalValue.Expert);
            cbxMasterUnitTesting.Items.Add(ProfessionalValue.Master);
            cbxMasterUnitTesting.SelectedIndex = 0;

            cbxMasterClientFramework.Items.Add(ProfessionalValue.NoKnowledge);
            cbxMasterClientFramework.Items.Add(ProfessionalValue.Junior);
            cbxMasterClientFramework.Items.Add(ProfessionalValue.Senior);
            cbxMasterClientFramework.Items.Add(ProfessionalValue.Expert);
            cbxMasterClientFramework.Items.Add(ProfessionalValue.Master);
            cbxMasterClientFramework.SelectedIndex = 0;

            cbxMasterSofwareDevelopmentFramework.Items.Add(ProfessionalValue.NoKnowledge);
            cbxMasterSofwareDevelopmentFramework.Items.Add(ProfessionalValue.Junior);
            cbxMasterSofwareDevelopmentFramework.Items.Add(ProfessionalValue.Senior);
            cbxMasterSofwareDevelopmentFramework.Items.Add(ProfessionalValue.Expert);
            cbxMasterSofwareDevelopmentFramework.Items.Add(ProfessionalValue.Master);
            cbxMasterSofwareDevelopmentFramework.SelectedIndex = 0;
        }

        private void btnConfirmProfessional_Click(object sender, EventArgs e)
        {
            if (developerProfessionalContributionState == FormState.preProcess)
            {
                developerProfessionalContributionState = FormState.Process;              
            }
            else
            {
                DeveloperProfessionalContributionEntity developerProfessionalContributionEntity = new DeveloperProfessionalContributionEntity();

                developerProfessionalContributionEntity.MasterProgrammingLanguages = (ProfessionalValue)cbxMasterProgrammingLanguages.SelectedItem;
                developerProfessionalContributionEntity.MasterUnitTesting = (ProfessionalValue)cbxMasterUnitTesting.SelectedItem;
                developerProfessionalContributionEntity.MasterClientFramework = (ProfessionalValue)cbxMasterClientFramework.SelectedItem;
                developerProfessionalContributionEntity.MasterSofwareDevelopmentFramework = (ProfessionalValue)cbxMasterSofwareDevelopmentFramework.SelectedItem;
                developerProfessionalContributionEntity.IntructorAtCompany = Convert.ToBoolean(lstSoftwareDevelopment.GetItemCheckState(0));
                developerProfessionalContributionEntity.SharingAtWorkshop = Convert.ToBoolean(lstSoftwareDevelopment.GetItemCheckState(1));
                developerProfessionalContributionEntity.DevelopTrainningCourse = Convert.ToBoolean(lstSoftwareDevelopment.GetItemCheckState(2));
                developerProfessionalContributionEntity.SubmissionImprovementProposal = Convert.ToBoolean(lstSoftwareDevelopment.GetItemCheckState(3));
                developerProfessionalContributionEntity.ActivitesInComunity = Convert.ToBoolean(lstSoftwareDevelopment.GetItemCheckState(4));
                developerProfessionalContributionEntity.DevelopsSubordinates = Convert.ToBoolean(chkDevelopsSubordinates.Checked);
                var jobKpiEntity = new JobKpiEntity();
                jobKpiEntity.ID = jobKpiAssessmentID;
                developerProfessionalContributionEntity.JobKpiAssessment = jobKpiEntity;
                if (professionalDetailedFormMode == DetailedFormMode.Add)
                {
                    developerProfessionalContributionBLL.AddDeveloperProfessionalContribution(developerProfessionalContributionEntity);
                }
                else
                {
                    developerProfessionalContributionBLL.EditDeveloperProfessionalContribution(developerProfessionalContributionEntity,developerProfessionalContributionID);
                }
                developerProfessionalContributionState = FormState.preProcess;
            }
            load();
        }

       
        private void btnCancelProfessional_Click(object sender, EventArgs e)
        {
            if (developerProfessionalContributionState == FormState.preProcess)
            {
                this.Close();
            }
            else
            {
                developerProfessionalContributionState = FormState.preProcess;
                load();
            }
        }

        #endregion

        #region Persional Skill
        private void btnConfirmPersonalSkills_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelPersonalSkills_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void tclAssessmentInDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
