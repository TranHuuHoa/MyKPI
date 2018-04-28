using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.ProjectManagement.GUI
{
    public partial class DetailedProjectForm : Form
    {
        TaskBLL taskBLL = new TaskBLL();
        DetailedFormMode detailedFormMode;
        public DetailedProjectForm()
        {
            InitializeComponent();
            detailedFormMode = DetailedFormMode.Add;
        }

        private void load()
        {
           // if (detailedFormMode == DetailedFormMode.Update)
            {
                grcTask.DataSource = taskBLL.LoadAllTask();
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
            DetailedTaskForm detailedTaskForm = new DetailedTaskForm();
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

            DetailedTaskForm detailedTaskForm = new DetailedTaskForm(taskEntity);
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
    }
}
