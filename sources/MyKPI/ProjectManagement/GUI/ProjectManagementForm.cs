﻿using System;
using System.Windows.Forms;
using MyKPI.ProjectManagement.BLL;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.ProjectManagement.GUI
{
    public partial class ProjectManagementForm : Form
    {
        ProjectBLL projectBLL = new ProjectBLL();
        ProjectEntity projectEntity = new ProjectEntity();
        DetailedFormMode detailedFormMode;
        public ProjectManagementForm()
        {
            InitializeComponent();
            detailedFormMode = DetailedFormMode.Add;
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
            // lay duoc du lieu cua  selected row vao 1 cai projectEntity
            ProjectEntity projectEntity = new ProjectEntity();
            // Object[] a = grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray;
            projectEntity.ID = (int)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[0];
            projectEntity.ProjectCode = grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[1].ToString();
            projectEntity.ProjectName = grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[2].ToString();
            projectEntity.StartedDate = (DateTime)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[3];
            projectEntity.EndDate = (DateTime)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[4];
            projectEntity.ScopeMM = (int)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[5];
            projectEntity.CustomerName = grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[6].ToString();
            projectEntity.Status = (ProjectStatusValue)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[7];
            DetailedProjectForm detailedProjectForm = new DetailedProjectForm(projectEntity);
            detailedProjectForm.ShowDialog();
            load();
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

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            int ID = (int)grvProject.GetDataRow(grvProject.GetSelectedRows()[0]).ItemArray[0];
            DialogResult = MessageBox.Show("Are you sure ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                load();
            }
            projectBLL.DeleteProject(ID);
            load();
        }
    }
}
