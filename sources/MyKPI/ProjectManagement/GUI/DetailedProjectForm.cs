//========================================================================================================
//  MyKPI - Detailed Project Form
// Change logs:
// May 2 2018 - HoaTH - init pages 
// May 3 2018 - TrungTH - update functions
//
//=========================================================================================================
#region using
using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.ProjectManagement.GUI
{
    public partial class DetailedProjectForm : Form
    {
        #region class parameters
        private TaskBLL taskBLL = new TaskBLL();
        private ProjectBLL projectBLL = new ProjectBLL();
        private ProjectEmployeeBLL projectEmployeeBLL = new ProjectEmployeeBLL();
        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;
        private FormState AddProjectMemberState = FormState.preProcess;
        private FormState UpdateProjectMemberState = FormState.preProcess;
        private int projectID = 0;
        private int ProjectEmployeeID = 0;
        #endregion

        #region private methods
        private void InitComboBox()
        {
            cbxProjectStatus.Items.Clear();
            cbxProjectStatus.Items.Add(ProjectStatusValue.NotStart);
            cbxProjectStatus.Items.Add(ProjectStatusValue.PreProcessing);
            cbxProjectStatus.Items.Add(ProjectStatusValue.Processing);
            cbxProjectStatus.Items.Add(ProjectStatusValue.UAT);
            cbxProjectStatus.Items.Add(ProjectStatusValue.Released);
            cbxProjectStatus.Items.Add(ProjectStatusValue.Closed);
            cbxProjectStatus.SelectedIndex = 0;
        }

        private void updateDetailedProjectMember()
        {
            if ((grcProjectMember.DataSource != null) && (grvProjectMember.GetSelectedRows().Length>0))
            {
                ProjectEmployeeID = (int)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[0];
                cbxProjectMember.SelectedValue = ProjectEmployeeID;
                dtmPMStartedDate.Value = (DateTime)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[3];
                dtmPMEndDate.Value = (DateTime)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[4];
                cbxRole.SelectedItem = (JobRankValue)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[5];
            }
        }

        private void load()
        {
            if (detailedFormMode == DetailedFormMode.Add)
            {
                gbxProjectMemberManagement.Enabled = false;
                gbxProjectTaskManagement.Enabled = false;
            }
            if (detailedFormMode == DetailedFormMode.Update)
            {
                gbxProjectMemberManagement.Enabled = true;
                gbxProjectTaskManagement.Enabled = true;

                grcTask.DataSource = taskBLL.LoadAllTaskPerProject(projectID);
                grcProjectMember.DataSource = projectEmployeeBLL.LoadProjectEmployee(projectID);
                if (grcProjectMember.DataSource != null)
                {
                    grvProjectMember.SelectRow(0);
                }
                
                cbxProjectMember.DataSource = projectEmployeeBLL.LoadProjectEmployee(projectID);
                cbxProjectMember.DisplayMember = "EmployeeName";
                cbxProjectMember.ValueMember = "ID";
               
                cbxRole.Items.Clear();
                cbxRole.Items.Add(JobRankValue.ProjectManager);
                cbxRole.Items.Add(JobRankValue.Developer);
                cbxRole.Items.Add(JobRankValue.Tester);
                cbxRole.Items.Add(JobRankValue.SolutionArchitect);
                cbxRole.Items.Add(JobRankValue.BussinessAnalyst);

                updateDetailedProjectMember();

                AddProjectMemberState = FormState.preProcess;
                UpdateProjectMemberState = FormState.preProcess;
                btnAddNewProjectMember.Enabled = true;
                btnAddNewProjectMember.Text = "ADD NEW MEMBER";
                btnUpdateProjectMemberInformation.Enabled = true;
                btnUpdateProjectMemberInformation.Text = "UPDATE INFORMATION";
                btnChangeActiveProjectMember.Enabled = true;
                btnPECancel.Enabled = false;
                grcProjectMember.Enabled = true;
                cbxProjectMember.Enabled = true;
            }
        }
        #endregion

        #region Form methods
        public DetailedProjectForm()
        {
            InitializeComponent();
            InitComboBox();
            detailedFormMode = DetailedFormMode.Add;
        }

        public DetailedProjectForm(ProjectEntity _project)
        {
            InitializeComponent();
            InitComboBox();
            detailedFormMode = DetailedFormMode.Update;
            projectID = _project.ID;
            txtProjectCode.Text = _project.ProjectCode;
            txtProjectName.Text = _project.ProjectName;
            txtScopeMM.Text = _project.ScopeMM.ToString();
            cbxProjectStatus.SelectedItem = _project.Status;
            dtmStartedDate.Value = _project.StartedDate;
            dtmEndDate.Value = _project.EndDate;
            txtCustomerName.Text = _project.CustomerName;

        }

        private void DetailedProjectForm_Load(object sender, EventArgs e)
        {
            load();
        }
        #endregion

        #region project general information group
        private void btnConfirmProject_Click(object sender, EventArgs e)
        {
            ProjectEntity projectEntity = new ProjectEntity();
            projectEntity.ProjectCode = txtProjectCode.Text;
            projectEntity.ProjectName = txtProjectName.Text;
            projectEntity.ScopeMM = Int32.Parse(txtScopeMM.Text);
            projectEntity.Status = (ProjectStatusValue)cbxProjectStatus.SelectedItem;
            projectEntity.StartedDate = dtmStartedDate.Value;
            projectEntity.EndDate = dtmEndDate.Value;
            projectEntity.CustomerName = txtCustomerName.Text;

            if (detailedFormMode == DetailedFormMode.Add)
            {
                projectBLL.AddProject(projectEntity);
            }
            if (detailedFormMode == DetailedFormMode.Update)
            {
                projectBLL.EditProject(projectEntity, projectID);
            }

            if (CommonFunctions.ShowQuestionDialog("Do you want continue to work with this project?", "Question") == DialogResult.OK)
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

        #region project member group
        private void grvProjectMember_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Active")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = ActiveValue.Active.ToString();
                                break;
                            case 1:
                                e.DisplayText = ActiveValue.DeActive.ToString();
                                break;
                        }
                    }

                if (e.Column.FieldName == "Role")
                {
                    switch (e.Value)
                    {
                        case 0:
                            e.DisplayText = JobRankValue.ProjectManager.ToString();
                            break;
                        case 1:
                            e.DisplayText = JobRankValue.Developer.ToString();
                            break;
                        case 2:
                            e.DisplayText = JobRankValue.Tester.ToString();
                            break;
                        case 3:
                            e.DisplayText = JobRankValue.SolutionArchitect.ToString();
                            break;
                        case 4:
                            e.DisplayText = JobRankValue.BussinessAnalyst.ToString();
                            break;
                    }
                }
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("Error:" + exp.ToString());
                //  LogService.LogError("Error", ex);
            }
        }

        private void grvProjectMember_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            updateDetailedProjectMember();
        }

        private void btnAddNewProjectMember_Click(object sender, EventArgs e)
        {
            if (AddProjectMemberState == FormState.preProcess)
            {
                AddProjectMemberState = FormState.Process;
                btnAddNewProjectMember.Text = "CONFIRM";
                btnUpdateProjectMemberInformation.Enabled = false;
                btnChangeActiveProjectMember.Enabled = false;
                btnPECancel.Enabled = true;
                grcProjectMember.Enabled = false;

                cbxProjectMember.DataSource = projectEmployeeBLL.LoadEmployeeNameOutSideProject(projectID);
                cbxProjectMember.DisplayMember = "EmployeeName";
                cbxProjectMember.ValueMember = "ID";
            }
            else
            if (AddProjectMemberState == FormState.Process)
            {
                var projectEmployee = new ProjectEmployeeEntity();
                ProjectEntity projectEntity = new ProjectEntity();
                projectEntity.ID = projectID;
                projectEmployee.Project = projectEntity;
                EmployeeEntity employeeEntity = new EmployeeEntity();
                employeeEntity.ID = (int)cbxProjectMember.SelectedValue;
                projectEmployee.Employee = employeeEntity;
                projectEmployee.StartedDate = dtmPMStartedDate.Value;
                projectEmployee.EndDate = dtmPMEndDate.Value;
                projectEmployee.Role = (JobRankValue)cbxRole.SelectedItem;
                projectEmployee.Active = ActiveValue.Active;

                projectEmployeeBLL.AddProjectEmployee(projectEmployee);
                load();
            }                     
        }

        private void btnUpdateProjectMemberInformation_Click(object sender, EventArgs e)
        {
            if (UpdateProjectMemberState == FormState.preProcess)
            {
                UpdateProjectMemberState = FormState.Process;
                btnUpdateProjectMemberInformation.Text = "CONFIRM";
                btnAddNewProjectMember.Enabled = false;
                btnChangeActiveProjectMember.Enabled = false;
                btnPECancel.Enabled = true;
                cbxProjectMember.Enabled = false;
                grcProjectMember.Enabled = false;
                ProjectEmployeeID = (int)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[0];
            }
            else
            if (UpdateProjectMemberState == FormState.Process)
            {
                var projectEmployee = new ProjectEmployeeEntity();
                ProjectEntity projectEntity = new ProjectEntity();
                projectEntity.ID = projectID;
                projectEmployee.Project = projectEntity;
                EmployeeEntity employeeEntity = new EmployeeEntity();
                employeeEntity.ID = (int)cbxProjectMember.SelectedValue;
                projectEmployee.Employee = employeeEntity;
                projectEmployee.StartedDate = dtmPMStartedDate.Value;
                projectEmployee.EndDate = dtmPMEndDate.Value;
                projectEmployee.Role = (JobRankValue)cbxRole.SelectedItem;
                projectEmployee.Active = ActiveValue.Active;

                projectEmployeeBLL.EditProjectEmployee(projectEmployee, ProjectEmployeeID);
                load();
            }

        }

        private void btnChangeActiveProjectMember_Click(object sender, EventArgs e)
        {
            ProjectEmployeeID = (int)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[0];
            ActiveValue active = (ActiveValue)grvProjectMember.GetDataRow(grvProjectMember.GetSelectedRows()[0]).ItemArray[6];
            if (active == ActiveValue.Active) active = ActiveValue.DeActive;
            else active = ActiveValue.Active;

            projectEmployeeBLL.ChangeProjectMemberActive(active, ProjectEmployeeID);
            load();

        }

        private void btnPECancel_Click(object sender, EventArgs e)
        {
            load();
        }
        #endregion

        #region task group
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvTask_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Status")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = TaskStatusValue.ToDo.ToString();
                                break;
                            case 1:
                                e.DisplayText = TaskStatusValue.InProgress.ToString();
                                break;
                            case 2:
                                e.DisplayText = TaskStatusValue.ReadyForQA.ToString();
                                break;
                            case 3:
                                e.DisplayText = TaskStatusValue.InQA.ToString();
                                break;
                            case 4:
                                e.DisplayText = TaskStatusValue.Done.ToString();
                                break;
                            case 5:
                                e.DisplayText = TaskStatusValue.Rejected.ToString();
                                break;
                            case 6:
                                e.DisplayText = TaskStatusValue.Blocked.ToString();
                                break;
                        }
                    }

                if (e.Column.FieldName == "Priority")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = PriorityValue.High.ToString();
                                break;
                            case 1:
                                e.DisplayText = PriorityValue.Medium.ToString();
                                break;
                            case 2:
                                e.DisplayText = PriorityValue.Low.ToString();
                                break;
                        }
                    }
                if (e.Column.FieldName == "TaskType")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = TaskTypeValue.UserStory.ToString();
                                break;
                            case 1:
                                e.DisplayText = TaskTypeValue.Bug.ToString();
                                break;
                        }
                    }
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                //  LogService.LogError("Error", ex);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DetailedTaskForm detailedTaskForm = new DetailedTaskForm(projectID);
            detailedTaskForm.ShowDialog();
            load();
        }

        private void btnDUTask_Click(object sender, EventArgs e)
        {        
            TaskEntity taskEntity = new TaskEntity();
           
            taskEntity.ID = (int)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[0];
            taskEntity.TaskCode = grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[1].ToString();
            taskEntity.TaskName = grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[2].ToString();
            taskEntity.Description = grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[3].ToString();

            var assignee = new EmployeeEntity();
            assignee.ID = (int)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[4];
            taskEntity.Assignee = assignee;
            var reporter = new EmployeeEntity();
            reporter.ID = (int)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[5];
            taskEntity.Reporter = reporter;
            taskEntity.Status = (TaskStatusValue)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[6];
            taskEntity.Priority = (PriorityValue)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[7];
            taskEntity.TaskType = (TaskTypeValue)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[8];

            DetailedTaskForm detailedTaskForm = new DetailedTaskForm(taskEntity,projectID);
            detailedTaskForm.ShowDialog();
            load();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            int ID = (int)grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray[0];

            if (CommonFunctions.ShowQuestionDialog("Are you sure ?", "Confirmation") == DialogResult.OK)
            {
                taskBLL.DeleteTask(ID);
                load();
            }          
        }




        #endregion

       
    }
}
