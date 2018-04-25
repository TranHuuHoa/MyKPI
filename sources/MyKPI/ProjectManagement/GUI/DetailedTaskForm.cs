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
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var task = new TaskEntity
            {
                TaskCode = "KMF-1",
                TaskName = "Design software architecture",
                Description = "Design software architecture"
            };
            var reporter = new EmployeeEntity
            {
                ID = 1
            };
            task.Reporter = reporter;
            var assignee = new EmployeeEntity
            {
                ID = 2
            };
            task.Assignee = assignee;

            taskBLL.AddTask(task);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
