using System.Data;
using MyKPI.Entities;
using MyKPI.ProjectManagement.DAL;

namespace MyKPI.ProjectManagement.BLL
{
    class ProjectEmployeeBLL
    {
        ProjectEmployeeDAL projectEmployeeDAL;
        public ProjectEmployeeBLL()
        {
            projectEmployeeDAL = new ProjectEmployeeDAL();
        }
        public void AddProjectEmployee(ProjectEmployeeEntity _projectEmployee)
        {
            projectEmployeeDAL.Add(_projectEmployee);
        }

        public void EditProjectEmployee(ProjectEmployeeEntity _projectEmployee, int ID)
        {
            projectEmployeeDAL.Edit(_projectEmployee, ID);
        }

        public void DeleteProjectEmployee(int ID)
        {
            projectEmployeeDAL.Delete(ID);
        }

        public DataTable LoadProjectEmployee(int _projectID)
        {
            return projectEmployeeDAL.Load( _projectID);
        }
    }
}
