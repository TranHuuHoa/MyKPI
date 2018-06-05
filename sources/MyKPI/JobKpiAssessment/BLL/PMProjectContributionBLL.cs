//========================================================================================================
//  MyKPI - PM Project Contribution BLL
// Change logs:
// June 4 2018 - TrungTH - creat
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.PMProjectContribution.DAL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.PMProjectContribution.BLL
{
    public class PMProjectContributionBLL
    {
        PMProjectContributionDAL pmProjectContributionDAL;
        public PMProjectContributionBLL()
        {
            pmProjectContributionDAL = new PMProjectContributionDAL();
        }
        public void AddPMProjectContribution(PMProjectContributionEntity _pmProjectContributiont)
        {
            pmProjectContributionDAL.Add(_pmProjectContributiont);
        }

        public void EditPMProjectContribution(PMProjectContributionEntity _pmProjectContributiont, int ID)
        {
            pmProjectContributionDAL.Edit(_pmProjectContributiont, ID);
        }

        public void DeletePMProjectContribution(int ID)
        {
            pmProjectContributionDAL.Delete(ID);
        }

        public PMProjectContributionEntity LoadPMProjectContributionPerKpiAssessmentAndProjectSeq(int JobKpiAssessmentID, int ProjectSeq)
        {
            DataTable dataTable = pmProjectContributionDAL.LoadPerKpiAssessmentAndSeq(JobKpiAssessmentID, ProjectSeq);
            if (dataTable.Rows.Count == 0) return null;

            PMProjectContributionEntity pmProjectContributionEntity = new PMProjectContributionEntity();
            pmProjectContributionEntity.ID = (int)dataTable.Rows[0].ItemArray[0];
            pmProjectContributionEntity.ProjectSeq = (int)dataTable.Rows[0].ItemArray[1];
            ProjectEntity projectEntity = new ProjectEntity();
            projectEntity.ID = (int)dataTable.Rows[0].ItemArray[2];
            pmProjectContributionEntity.Project = projectEntity;
            pmProjectContributionEntity.PMRoleAndResponsibility = (PMRoleAndResponsibilityValue)dataTable.Rows[0].ItemArray[3];
            pmProjectContributionEntity.SofwareDevelopmentActivitites = (bool)dataTable.Rows[0].ItemArray[4];
            pmProjectContributionEntity.Complexity_InternationalProject = (bool)dataTable.Rows[0].ItemArray[5];
            pmProjectContributionEntity.Complexity_GloballyAdvancedTechnologyProject = (bool)dataTable.Rows[0].ItemArray[6];
            pmProjectContributionEntity.Complexity_ComplicatedContractConditions = (bool)dataTable.Rows[0].ItemArray[7];
            pmProjectContributionEntity.Complexity_ArchitectureRequirement = (bool)dataTable.Rows[0].ItemArray[8];
            pmProjectContributionEntity.Complexity_SystemDesign = (bool)dataTable.Rows[0].ItemArray[9];
            pmProjectContributionEntity.Complexity_ApplicationRequirement = (bool)dataTable.Rows[0].ItemArray[10];
            pmProjectContributionEntity.Complexity_ProjectStructure = (bool)dataTable.Rows[0].ItemArray[11];
            pmProjectContributionEntity.TeamSizeAverage = (int)dataTable.Rows[0].ItemArray[12];
            pmProjectContributionEntity.PhaseDuration = (int)dataTable.Rows[0].ItemArray[13];
            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = (int)dataTable.Rows[0].ItemArray[7];
            pmProjectContributionEntity.JobKpiAssessment = jobKpiEntity;

            return pmProjectContributionEntity;
        }
    }
}
