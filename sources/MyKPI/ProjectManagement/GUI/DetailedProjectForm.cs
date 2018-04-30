﻿using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.ProjectManagement.GUI
{
    public partial class DetailedProjectForm : Form
    {
        private TaskBLL taskBLL = new TaskBLL();
        private ProjectBLL projectBLL = new ProjectBLL();
        private ProjectEmployeeBLL projectEmployeeBLL = new ProjectEmployeeBLL();
        private DetailedFormMode detailedFormMode = DetailedFormMode.Add;      
        private int projectID = 0;

        public DetailedProjectForm()
        {
            InitializeComponent();
            InitComboBox();
            detailedFormMode = DetailedFormMode.Add;
        }

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
    
        public DetailedProjectForm(ProjectEntity _project)
        {
            InitializeComponent();
            InitComboBox();
            detailedFormMode = DetailedFormMode.Update;
            projectID = _project.ID;
            txtProjectCode.Text = _project.ProjectCode;
            txtProjectName.Text = _project.ProjectName ;
            txtScopeMM.Text = _project.ScopeMM.ToString();
            cbxProjectStatus.SelectedItem = _project.Status;
            dtmStartedDate.Value = _project.StartedDate;
            dtmEndDate.Value = _project.EndDate;
            txtCustomerName.Text = _project.CustomerName;

        }

        private void load()
        {
            if (detailedFormMode == DetailedFormMode.Update)
            {
                grcTask.DataSource = taskBLL.LoadAllTask();
                grcProjectMember.DataSource = projectEmployeeBLL.LoadProjectEmployee(projectID);

                cbxProjectMember.DataSource = projectEmployeeBLL.LoadEmployeeNameOutSideProject(projectID);
                cbxProjectMember.DisplayMember = "EmployeeName";
                cbxProjectMember.ValueMember = "ID";

                cbxRole.Items.Clear();
                cbxRole.Items.Add(JobRankValue.ProjectManager);
                cbxRole.Items.Add(JobRankValue.Developer);
                cbxRole.Items.Add(JobRankValue.Tester);
                cbxRole.Items.Add(JobRankValue.SolutionArchitect);
                cbxRole.Items.Add(JobRankValue.BussinessAnalyst);
                cbxRole.SelectedIndex = 0;

            }
            

        }

        private void DetailedProjectForm_Load(object sender, EventArgs e)
        {
            load();
        }

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
            // lay duoc du lieu cua  selected row vao 1 cai taskentity
            TaskEntity taskEntity = new TaskEntity();
            // Object[] a = grvTask.GetDataRow(grvTask.GetSelectedRows()[0]).ItemArray;
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
            DialogResult = MessageBox.Show("Are you sure ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                load();
            }
            taskBLL.DeleteTask(ID);
            load();
        }

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
            
            if (detailedFormMode== DetailedFormMode.Add)
            {
                projectBLL.AddProject(projectEntity);
            }
            if (detailedFormMode==DetailedFormMode.Update)
            {
                projectBLL.EditProject(projectEntity,projectID);
            }
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnAddNewProjectMember_Click(object sender, EventArgs e)
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
}
