//========================================================================================================
//  MyKPI - Job KPI Assessment BLL
// Change logs:
// May 7 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Collections.Generic;
using System.Data;
using MyKPI.Entities;
using MyKPI.JobKpiAssessment.DAL;
using MyKPI.EmployeeManagment.BLL;
using System;
using MyKPI.Common;
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

        public int AddJobKpiAssessment(JobKpiEntity _jobKpiAssessment)
        {
            jobKpiAssessmentDAL.Add(_jobKpiAssessment);
            return jobKpiAssessmentDAL.GetLatestID();
        }

        public void EditJobKpiAssessment(JobKpiEntity _jobKpiAssessment, int ID)
        {
            jobKpiAssessmentDAL.Edit(_jobKpiAssessment, ID);
        }

        public void DeleteJobKpiAssessment(int ID)
        {
            jobKpiAssessmentDAL.Delete(ID);
        }

        public List<JobKpiEntity> LoadAllJobKpiAssessmentList()
        {
            List<JobKpiEntity> JobKpiAssessmentList = new List<JobKpiEntity>();
            DataTable JobKpiAssessmentDataTable = JobKpiAssessmentDAL.LoadAll();
            EmployeeBLL employeeBLL = new EmployeeBLL();

            foreach (DataRow row in JobKpiAssessmentDataTable.Rows)
            {
                JobKpiEntity jobKpiEntity = new JobKpiEntity();
                jobKpiEntity.ID = (int)row[0];
                jobKpiEntity.Employee = employeeBLL.LoadOnePerID((int)row[1]);
                jobKpiEntity.CreatedDate = (DateTime)row[2];
                jobKpiEntity.RoleInAssessment = (JobRankValue)row[3];
                jobKpiEntity.Status = (AssessmentStatusValue)row[4];
                JobKpiAssessmentList.Add(jobKpiEntity);
            }

            return JobKpiAssessmentList;

        }

        public DataTable LoadAllJobKpiAssessmentDataTable()
        {
            return JobKpiAssessmentDAL.LoadAll(); 
        }
    }
}
