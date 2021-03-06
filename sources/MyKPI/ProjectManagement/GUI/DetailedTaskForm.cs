﻿//========================================================================================================
//  MyKPI - Detail Task Form
// Change logs:
// May 6 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Entities;
using MyKPI.Common;
#endregion

namespace MyKPI.ProjectManagement.GUI
{
    public partial class DetailedTaskForm : Form
    {
        #region class parameters
        TaskBLL taskBLL = new TaskBLL();
        ProjectEmployeeBLL projectEmployeeBLL = new ProjectEmployeeBLL();
        int mode = 0;
        int ID = 0;
        int projectID = 0;
        #endregion

        #region Init ComboBox
        private void InitComboBox()
        {
            cbxAssignee.DataSource = projectEmployeeBLL.LoadActiveProjectEmployee(projectID);
            cbxAssignee.DisplayMember = "EmployeeName";
            cbxAssignee.ValueMember = "ID";

            cbxReporter.DataSource = projectEmployeeBLL.LoadActiveProjectEmployee(projectID);
            cbxReporter.DisplayMember = "EmployeeName";
            cbxReporter.ValueMember = "ID";

            cbxStatus.Items.Clear();
            cbxStatus.Items.Add(TaskStatusValue.ToDo);
            cbxStatus.Items.Add(TaskStatusValue.InProgress);
            cbxStatus.Items.Add(TaskStatusValue.ReadyForQA);
            cbxStatus.Items.Add(TaskStatusValue.InQA);
            cbxStatus.Items.Add(TaskStatusValue.Done);
            cbxStatus.Items.Add(TaskStatusValue.Rejected);
            cbxStatus.Items.Add(TaskStatusValue.Blocked);
            cbxStatus.SelectedIndex = 0;

            cbxPriority.Items.Clear();
            cbxPriority.Items.Add(PriorityValue.High);
            cbxPriority.Items.Add(PriorityValue.Medium);
            cbxPriority.Items.Add(PriorityValue.Low);
            cbxPriority.SelectedIndex = 0;

            cbxTaskType.Items.Clear();
            cbxTaskType.Items.Add(TaskTypeValue.UserStory);
            cbxTaskType.Items.Add(TaskTypeValue.Bug);
            cbxTaskType.SelectedIndex = 0;
        }
        private bool InputValidation()
        {
            Boolean Result = true;
            if (txtTaskCode.Text == String.Empty)
            {
                lblTaskCodeNotification.Visible = true;
                Result = false;
            }
            else
            {
                lblTaskCodeNotification.Visible = false;
            }

            if (txtTaskName.Text == String.Empty)
            {
                lblTaskNameNotification.Visible = true;
                Result = false;
            }
            else
            {
                lblTaskNameNotification.Visible = false;
            }

            if (txtDescription.Text == String.Empty)
            {
                lblDescriptionNotification.Visible = true;
                Result = false;
            }
            else
            {
                lblDescriptionNotification.Visible = false;
            }
            return Result;

        }
        #endregion

        #region Methods
        public DetailedTaskForm(int _projectID)
        {
            InitializeComponent();
            projectID = _projectID;
            InitComboBox();
            mode = 0;
        }

        public DetailedTaskForm(TaskEntity _task, int _projectID)
        {
            InitializeComponent();
            projectID = _projectID;
            InitComboBox();
            mode = 1;
            ID = _task.ID;
            txtTaskCode.Text = _task.TaskCode;
            txtTaskName.Text = _task.TaskName;
            txtDescription.Text = _task.Description;
            cbxAssignee.SelectedValue = _task.Assignee.ID;
            cbxPriority.SelectedItem = _task.Priority;
            cbxStatus.SelectedItem = _task.Status;
            cbxReporter.SelectedValue = _task.Reporter.ID;
            cbxTaskType.SelectedItem = _task.TaskType;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!InputValidation()) return;
            TaskEntity taskEntity = new TaskEntity();
            taskEntity.TaskCode = txtTaskCode.Text;
            taskEntity.TaskName = txtTaskName.Text;
            taskEntity.Description = txtDescription.Text;
            var assignee = new EmployeeEntity();
            assignee.ID = (int)cbxAssignee.SelectedValue;
            taskEntity.Assignee = assignee;
            var reporter = new EmployeeEntity();
            reporter.ID = (int)cbxReporter.SelectedValue;
            taskEntity.Reporter = reporter;
            taskEntity.Status = (TaskStatusValue)cbxStatus.SelectedItem;
            taskEntity.Priority = (PriorityValue)cbxPriority.SelectedItem;
            taskEntity.TaskType = (TaskTypeValue)cbxTaskType.SelectedItem;
            ProjectEntity projectEntity = new ProjectEntity();
            projectEntity.ID = projectID;
            taskEntity.Project = projectEntity;

            if (mode == 0)
            {
                taskBLL.AddTask(taskEntity);
            }
            if (mode == 1)
            {
                taskBLL.EditTask(taskEntity, ID);
            }


            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
