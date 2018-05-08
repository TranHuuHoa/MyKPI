//========================================================================================================
//  MyKPI - Project Employee DAL
// Change logs:
// May 6 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.ProjectManagement.DAL
{
    class ProjectEmployeeDAL : ICommonDAL
    {
        #region Add
        public bool Add(ICommonEntity _projectEmployee)
        {
            var projectEmployee = (_projectEmployee as ProjectEmployeeEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into project_employee (ProjectID, EmployeeID, StartedDate, EndDate, Role, Active) values ({0},{1},'{2}','{3}',{4},{5}) ",
                projectEmployee.Project.ID,
                projectEmployee.Employee.ID,
                projectEmployee.StartedDate.ToString("yyyy-MM-dd"),
                projectEmployee.EndDate.ToString("yyyy-MM-dd"),
                (int)projectEmployee.Role,
                (int)projectEmployee.Active              
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Delete
        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ICommonEntity _projectEmployee, int ID)
        {

            var projectEmployee = (_projectEmployee as ProjectEmployeeEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update project_employee  set ProjectID = {0},EmployeeID= {1},StartedDate ='{2}',EndDate = '{3}',Role = {4},Active = {5} where ID = {6}",
                projectEmployee.Project.ID,
                projectEmployee.Employee.ID,
                projectEmployee.StartedDate.ToString("yyyy-MM-dd"),
                projectEmployee.EndDate.ToString("yyyy-MM-dd"),
                (int)projectEmployee.Role,
                (int)projectEmployee.Active,
                ID
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Active/Deactive
        public bool ChangeProjectMemberActive(ActiveValue active, int ID)
        {          
            string str = string.Empty;
            try
            {
                str = string.Format(@"update project_employee  set Active = {0} where ID = {1}",
                (int)active,
                ID
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Load
        public DataTable Load(int _projectID)
        {
            string str = string.Format(@"select pe.*, CONCAT_WS(' ',e.EmployeeFirstName, e.EmployeeLastName) as EmployeeName
                                from project_employee pe, tblemployee e where pe.EmployeeID = e.ID and pe.ProjectID = {0}", _projectID);
            return DBManager.InstantDBManger.GetData(str);
        }

        public DataTable LoadActive(int _projectID)
        {
            string str = string.Format(@"select pe.*, CONCAT_WS(' ',e.EmployeeFirstName, e.EmployeeLastName) as EmployeeName
                                from project_employee pe, tblemployee e where pe.EmployeeID = e.ID and pe.Active = 0 and pe.ProjectID = {0}", _projectID);
            return DBManager.InstantDBManger.GetData(str);
        }

        public DataTable LoadEmployeeNameOutSideProject(int _projectID)
        {
            string str = string.Format(@"select e.ID, CONCAT_WS(' ',e.EmployeeFirstName, e.EmployeeLastName) as EmployeeName
                                from tblemployee e where e.ID not in (select EmployeeID from Project_Employee where ProjectID = {0})", _projectID);
            return DBManager.InstantDBManger.GetData(str);
        }
        #endregion
    }
}
