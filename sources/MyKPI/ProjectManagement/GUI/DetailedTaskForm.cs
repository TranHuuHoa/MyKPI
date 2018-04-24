using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Entities;
using MyKPI.Common;

namespace MyKPI.ProjectManagement.GUI
{
    public partial class DetailedTaskForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        int mode = 0;
        int ID = 0;

        private void InitComboBox()
        {           
            cbxAssignee.DataSource = employeeBLL.LoadEmployeeName();
            cbxAssignee.DisplayMember = "EmployeeName";
            cbxAssignee.ValueMember = "ID";

            cbxReporter.DataSource = employeeBLL.LoadEmployeeName();
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

            cbxTaskType.Items.Clear();
            cbxTaskType.Items.Add(TaskTypeValue.UserStory);
            cbxTaskType.Items.Add(TaskTypeValue.Bug);

        }
        public DetailedTaskForm()
        {
            InitializeComponent();
            InitComboBox();
            mode = 0;
        }

        public DetailedTaskForm(TaskEntity _task)
        {
            InitializeComponent();
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

        private void DetailedTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
