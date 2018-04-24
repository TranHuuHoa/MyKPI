using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.Common;

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
            if (detailedFormMode == DetailedFormMode.Update)
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

        private void btnConfirmProject_Click(object sender, EventArgs e)
        {
            
        }
    }
}
