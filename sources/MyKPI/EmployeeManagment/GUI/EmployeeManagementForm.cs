using System;
using System.Windows.Forms;
using MyKPI.EmployeeManagment.BLL;
using MyKPI.Common;
using MyKPI.Entities;

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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DetailedEmployeeForm detailedEmployeeForm = new DetailedEmployeeForm();
            detailedEmployeeForm.ShowDialog();
            load();
        }

        private void btnDUEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.ID = (int)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[0];
            employeeEntity.EmployeeNumber = grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[1].ToString();
            employeeEntity.EmployeeFirstName = grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[2].ToString();
            employeeEntity.EmployeeLastName = grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[3].ToString();
            employeeEntity.Address = grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[4].ToString();
            employeeEntity.IDCard = grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[5].ToString();
            employeeEntity.DOB = (DateTime)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[6];
            employeeEntity.Sex = (SexValue)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[7];
            employeeEntity.JobRankType = (JobRankValue) grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[8];
            employeeEntity.JobRankLevel = (JobRankLevelValue)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[9];
            employeeEntity.SalaryLevel = (SalaryLevelValue)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[10];
            employeeEntity.SalarySubLevel = (int)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[11];
            DetailedEmployeeForm detailedEmployeeForm = new DetailedEmployeeForm(employeeEntity);
            detailedEmployeeForm.ShowDialog();
            load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int ID = (int)grvEmployee.GetDataRow(grvEmployee.GetSelectedRows()[0]).ItemArray[0];
         //   DialogResult = MessageBox.Show("Are you sure ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
          //  if (DialogResult == DialogResult.OK)
          //  {
                employeeBLL.DeleteEmployee(ID);
                load();
          //  }
            
        }
    }
}
