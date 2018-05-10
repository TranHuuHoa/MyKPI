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

        public void AddJobKpiAssessment(JobKpiEntity _jobKpiAssessment)
        {
            jobKpiAssessmentDAL.Add(_jobKpiAssessment);
        }

        public void EditJobKpiAssessment(JobKpiEntity _jobKpiAssessment, int ID)
        {
            jobKpiAssessmentDAL.Edit(_jobKpiAssessment, ID);
        }

        public void DeleteJobKpiAssessment(int ID)
        {
            jobKpiAssessmentDAL.Delete(ID);
        }

        public DataTable LoadAllJobKpiAssessment()
        {
            return JobKpiAssessmentDAL.LoadAll();
        }
    }
}
