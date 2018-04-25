using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.Common;

namespace MyKPI.ProjectManagement.GUI
{
    public partial class ProjectManagementForm : Form
    {
        ProjectBLL projectBLL = new ProjectBLL();
        public ProjectManagementForm()
        {
            InitializeComponent();
        }

        private void load()
        {
            grcProject.DataSource = projectBLL.LoadAllProject();
        }
       
        private void ProjectManagementForm_Load(object sender, System.EventArgs e)
        {
            load();
            //   btnAddProject_Click(sender,e);
            //   this.Close();

        }

        private void btnDUProject_Click(object sender, System.EventArgs e)
        {
            
        }

        private void grvProject_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Status")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = ProjectStatusValue.NotStart.ToString();
                                break;
                            case 1:
                                e.DisplayText = ProjectStatusValue.PreProcessing.ToString();
                                break;
                            case 2:
                                e.DisplayText = ProjectStatusValue.Processing.ToString();
                                break;
                            case 3:
                                e.DisplayText = ProjectStatusValue.UAT.ToString();
                                break;
                            case 4:
                                e.DisplayText = ProjectStatusValue.Released.ToString();
                                break;
                            case 5:
                                e.DisplayText = ProjectStatusValue.Closed.ToString();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            DetailedProjectForm detailedProjectForm = new DetailedProjectForm();
            detailedProjectForm.ShowDialog();
            load();
        }
    }
}
