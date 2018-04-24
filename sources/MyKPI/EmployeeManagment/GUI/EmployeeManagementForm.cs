using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
