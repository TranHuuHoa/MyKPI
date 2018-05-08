//========================================================================================================
//  MyKPI - Job KPI Assessment BLL
// Change logs:
// May 7 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities;
using MyKPI.JobKpiAssessment.DAL;
#endregion

namespace MyKPI.JobKpiAssessment.BLL
{
    public class JobKpiAssessmentBLL
    {
        JobKpiAssessmentDAL jobKpiAssessmentDAL;
        public JobKpiAssessmentBLL()
        {
            jobKpiAssessmentDAL = new JobKpiAssessmentDAL();
        }
        public void AddProject(ProjectEntity _Project)
        {
            jobKpiAssessmentDAL.Add(_Project);
        }

        public void EditProject(ProjectEntity _Project, int ID)
        {
            jobKpiAssessmentDAL.Edit(_Project, ID);
        }

        public void DeleteProject(int ID)
        {
            jobKpiAssessmentDAL.Delete(ID);
        }

        public DataTable LoadAllProject()
        {
            return JobKpiAssessmentDAL.LoadAll();
        }
    }
}
