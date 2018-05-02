using System.Data;
using MyKPI.Entities;
using MyKPI.ProjectManagement.DAL;
using MyKPI.Common;

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

        public void ChangeProjectMemberActive(ActiveValue active ,int ID)
        {
            projectEmployeeDAL.ChangeProjectMemberActive(active, ID);
        }

        public void DeleteProjectEmployee(int ID)
        {
            projectEmployeeDAL.Delete(ID);
        }

        public DataTable LoadProjectEmployee(int _projectID)
        {
            return projectEmployeeDAL.Load( _projectID);
        }

        public DataTable LoadActiveProjectEmployee(int _projectID)
        {
            return projectEmployeeDAL.LoadActive(_projectID);
        }

        public DataTable LoadEmployeeNameOutSideProject(int _projectID)
        {
            return projectEmployeeDAL.LoadEmployeeNameOutSideProject(_projectID);
        }

        
    }
}
