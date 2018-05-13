//========================================================================================================
//  MyKPI - Developer Project Contribution BLL
// Change logs:
// May 7 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.DeveloperProjectContribution.DAL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.DeveloperProjectContribution.BLL
{
    public class DeveloperProjectContributionBLL
    {
        DeveloperProjectContributionDAL developerProjectContributionDAL;
        public DeveloperProjectContributionBLL()
        {
            developerProjectContributionDAL = new DeveloperProjectContributionDAL();
        }
        public void AddDeveloperProjectContribution(DeveloperProjectContributionEntity _developerProjectContributiont)
        {
            developerProjectContributionDAL.Add(_developerProjectContributiont);
        }

        public void EditDeveloperProjectContribution(DeveloperProjectContributionEntity _developerProjectContributiont, int ID)
        {
            developerProjectContributionDAL.Edit(_developerProjectContributiont, ID);
        }

        public void DeleteDeveloperProjectContribution(int ID)
        {
            developerProjectContributionDAL.Delete(ID);
        }

        public DeveloperProjectContributionEntity LoadDeveloperProjectContributionPerKpiAssessmentAndProjectSeq(int JobKpiAssessmentID, int ProjectSeq)
        {
            DataTable dataTable = developerProjectContributionDAL.LoadPerKpiAssessmentAndSeq(JobKpiAssessmentID, ProjectSeq);
            if (dataTable.Rows.Count == 0) return null;

            DeveloperProjectContributionEntity developerProjectContributionEntity = new DeveloperProjectContributionEntity();
            developerProjectContributionEntity.ID = (int)dataTable.Rows[0].ItemArray[0];
            developerProjectContributionEntity.ProjectSeq = (int)dataTable.Rows[0].ItemArray[1];
            ProjectEntity projectEntity = new ProjectEntity();
            projectEntity.ID = (int)dataTable.Rows[0].ItemArray[2];
            developerProjectContributionEntity.Project = projectEntity;       
            developerProjectContributionEntity.TeamRole = (TeamRoleValue)dataTable.Rows[0].ItemArray[3];
            developerProjectContributionEntity.ImplementCode = (WorkingResultValue)dataTable.Rows[0].ItemArray[4];
            developerProjectContributionEntity.ImplementDesign = (WorkingResultValue)dataTable.Rows[0].ItemArray[5];
            developerProjectContributionEntity.ImplementUnitTest = (WorkingResultValue)dataTable.Rows[0].ItemArray[6];
            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = (int)dataTable.Rows[0].ItemArray[7];
            developerProjectContributionEntity.JobKpiAssessment = jobKpiEntity;

            return developerProjectContributionEntity;
        }
    }
}
