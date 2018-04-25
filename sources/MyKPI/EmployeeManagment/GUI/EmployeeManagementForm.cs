using System;
using System.Windows.Forms;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Common;

namespace MyKPI.EmployeeManagment.GUI
{
    public partial class EmployeeManagementForm : Form
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        public EmployeeManagementForm()
        {
            InitializeComponent();
        }

        private void load()
        {
            grcEmployee.DataSource = employeeBLL.LoadAllEmployee();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void grvEmployee_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Sex")
                    if (e.Value != null)
                    {
                        switch (e.Value)
                        {
                            case 0:
                                e.DisplayText = SexValue.Male.ToString();
                                break;
                            case 1:
                                e.DisplayText = SexValue.Female.ToString();
                                break;
                            case 2:
                                e.DisplayText = SexValue.Others.ToString();
                                break;                          
                        }
                    }

                if (e.Column.FieldName == "JobRank")                  
                    {
                        var datarow = grvEmployee.GetDataRow(e.ListSourceRowIndex);
                        switch (datarow["JobRankType"])
                        {
                            case 0:
                                e.DisplayText = JobRankValue.ProjectManager.ToString() + " " + datarow["JobRankLevel"];
                                break;
                            case 1:
                                e.DisplayText = JobRankValue.Developer.ToString() + " " + datarow["JobRankLevel"]; ;
                                break;
                            case 2:
                                e.DisplayText = JobRankValue.Tester.ToString() + " " + datarow["JobRankLevel"]; ;
                                break;
                            case 3:
                                e.DisplayText = JobRankValue.SolutionArchitect.ToString() + " " + datarow["JobRankLevel"]; ;
                                break;
                            case 4:
                                e.DisplayText = JobRankValue.BussinessAnalyst.ToString() + " " + datarow["JobRankLevel"]; ;
                                break;
                    }
                    }
                if (e.Column.FieldName == "Salary")                   
                    {
                        var datarow = grvEmployee.GetDataRow(e.ListSourceRowIndex);
                        e.DisplayText = datarow["SalaryLevel"].ToString() +"."+ datarow["SalarySubLevel"];
                    }
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("Error:" + exp.ToString());
                //  LogService.LogError("Error", ex);
            }
        }
    }
}
