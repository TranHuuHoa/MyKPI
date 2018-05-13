//========================================================================================================
//  MyKPI - Project BLL
// Change logs:
// May 6 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities;
using MyKPI.ProjectManagement.DAL;
#endregion

namespace MyKPI.ProjectManagement.BLL
{
    public class ProjectBLL
    {
        ProjectDAL projectDAL;
        public ProjectBLL()
        {
            projectDAL = new ProjectDAL();
        }
        public void AddProject(ProjectEntity _jobKpiAssessment)
        {
            projectDAL.Add(_jobKpiAssessment);
        }

        public void EditProject(ProjectEntity _Project, int ID)
        {
            projectDAL.Edit(_Project, ID);
        }

        public void DeleteProject(int ID)
        {
            projectDAL.Delete(ID);
        }

        public DataTable LoadAllProject()
        {
            return ProjectDAL.LoadAll();
        }        

    }
}
