//========================================================================================================
//  MyKPI - Detailed Job KPI Assessment  Form
// Change logs:
// May 10 2018 - TrungTH - init pages 
// 
//
//=========================================================================================================
#region using
using System;
using System.Windows.Forms;
using MyKPI.JobKpiAssessment.BLL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.JobKpiAssessment.GUI
{
    public partial class JobKpiAssessmentManagementForm : Form
    {
        JobKpiAssessmentBLL jobKpiAssessmentBLL = new JobKpiAssessmentBLL();
        public JobKpiAssessmentManagementForm()
        {
            InitializeComponent();
        }

        private void load()
        {
            grcJobKpiAssessment.DataSource = jobKpiAssessmentBLL.LoadAllJobKpiAssessmentDataTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddJobKpiAssessment_Click(object sender, EventArgs e)
        {
            DetailedJobKpiAssessmentForm detailedJobKpiAssessmentForm = new DetailedJobKpiAssessmentForm();
            detailedJobKpiAssessmentForm.ShowDialog();
            load();
        }

        private void JobKpiAssessmentManagementForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void grvJobKpiAssessment_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Status")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = AssessmentStatusValue.Started.ToString();
                                break;
                            case 1:
                                e.DisplayText = AssessmentStatusValue.Processing.ToString();
                                break;
                            case 2:
                                e.DisplayText = AssessmentStatusValue.Commit.ToString();
                                break;
                            case 3:
                                e.DisplayText = AssessmentStatusValue.Approving.ToString();
                                break;
                            case 4:
                                e.DisplayText = AssessmentStatusValue.Approved.ToString();
                                break;                       
                        }
                    }
                if (e.Column.FieldName == "RoleInAssessment")
                    if (e.Value != null)
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
                CommonFunctions.ShowErrorDialog("Display error:" + exp.ToString());
                //  LogService.LogError("Error", ex);
            }
        }

        private void btnDUJobKpiAssessment_Click(object sender, EventArgs e)
        {
            // lay du lieu vao entity
            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID= (int)grvJobKpiAssessment.GetDataRow(grvJobKpiAssessment.GetSelectedRows()[0]).ItemArray[0];
            jobKpiEntity.Employee = new EmployeeEntity();
            jobKpiEntity.Employee.ID = (int)grvJobKpiAssessment.GetDataRow(grvJobKpiAssessment.GetSelectedRows()[0]).ItemArray[1];
            jobKpiEntity.CreatedDate=(DateTime)grvJobKpiAssessment.GetDataRow(grvJobKpiAssessment.GetSelectedRows()[0]).ItemArray[2];
            jobKpiEntity.RoleInAssessment=(JobRankValue)grvJobKpiAssessment.GetDataRow(grvJobKpiAssessment.GetSelectedRows()[0]).ItemArray[3];
            jobKpiEntity.Status=(AssessmentStatusValue)grvJobKpiAssessment.GetDataRow(grvJobKpiAssessment.GetSelectedRows()[0]).ItemArray[4];
            // dua len form detail
            DetailedJobKpiAssessmentForm detailedJobKpiAssessmentForm = new DetailedJobKpiAssessmentForm(jobKpiEntity);
            detailedJobKpiAssessmentForm.ShowDialog();

            // load lai form chinh
            load();
        }
    }
}
