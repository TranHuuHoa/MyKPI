using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.ProjectManagement.DAL
{
    class ProjectEmployeeDAL : ICommonDAL
    {
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

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ICommonEntity commonEntity, int ID)
        {
            throw new NotImplementedException();
        }

        public DataTable Load(int _projectID)
        {
            string str = string.Format(@"select pe.*, CONCAT_WS(' ',e.EmployeeFirstName, e.EmployeeLastName) as EmployeeName
                                from project_employee pe, tblemployee e where pe.EmployeeID = e.ID and pe.ProjectID = {0}", _projectID);
            return DBManager.InstantDBManger.GetData(str);
        }

        public DataTable LoadEmployeeNameOutSideProject(int _projectID)
        {
            string str = string.Format(@"select e.ID, CONCAT_WS(' ',e.EmployeeFirstName, e.EmployeeLastName) as EmployeeName
                                from tblemployee e where e.ID not in (select EmployeeID from Project_Employee where ProjectID = {0})", _projectID);
            return DBManager.InstantDBManger.GetData(str);
        }

        
    }
}
