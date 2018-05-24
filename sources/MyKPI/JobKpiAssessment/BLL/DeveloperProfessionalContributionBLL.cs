//========================================================================================================
//  MyKPI - Developer Professional Contribution BLL
// Change logs:
// May 22 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.DeveloperProfessionalContribution.DAL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.DeveloperProfessionalContribution.BLL
{
    public class DeveloperProfessionalContributionBLL
    {
        DeveloperProfessionalContributionDAL developerProfessionalContributionDAL;
        public DeveloperProfessionalContributionBLL()
        {
            developerProfessionalContributionDAL = new DeveloperProfessionalContributionDAL();
        }
        public void AddDeveloperProfessionalContribution(DeveloperProfessionalContributionEntity _developerProfessionalContributiont)
        {
            developerProfessionalContributionDAL.Add(_developerProfessionalContributiont);
        }

        public void EditDeveloperProfessionalContribution(DeveloperProfessionalContributionEntity _developerProfessionalContributiont, int ID)
        {
            developerProfessionalContributionDAL.Edit(_developerProfessionalContributiont, ID);
        }

        public void DeleteDeveloperProfessionalContribution(int ID)
        {
            developerProfessionalContributionDAL.Delete(ID);
        }

        public DeveloperProfessionalContributionEntity LoadPerJobKpiAssessmentID(int JobKpiAssessmentID)
        {
            DataTable dataTable = developerProfessionalContributionDAL.Load(JobKpiAssessmentID);
            if (dataTable.Rows.Count == 0) return null;

            DeveloperProfessionalContributionEntity developerProfessionalContributionEntity = new DeveloperProfessionalContributionEntity();
            developerProfessionalContributionEntity.ID = (int)dataTable.Rows[0].ItemArray[0];
            developerProfessionalContributionEntity.MasterProgrammingLanguages = (ProfessionalValue)dataTable.Rows[0].ItemArray[1];
            developerProfessionalContributionEntity.MasterUnitTesting = (ProfessionalValue)dataTable.Rows[0].ItemArray[2];
            developerProfessionalContributionEntity.MasterClientFramework = (ProfessionalValue)dataTable.Rows[0].ItemArray[3];
            developerProfessionalContributionEntity.MasterSofwareDevelopmentFramework = (ProfessionalValue)dataTable.Rows[0].ItemArray[4];
            developerProfessionalContributionEntity.IntructorAtCompany =    (bool)dataTable.Rows[0].ItemArray[5];
            developerProfessionalContributionEntity.SharingAtWorkshop = (bool)dataTable.Rows[0].ItemArray[6];
            developerProfessionalContributionEntity.DevelopTrainningCourse = (bool)dataTable.Rows[0].ItemArray[7];
            developerProfessionalContributionEntity.SubmissionImprovementProposal = (bool)dataTable.Rows[0].ItemArray[8];
            developerProfessionalContributionEntity.ActivitesInComunity = (bool)dataTable.Rows[0].ItemArray[9];
            developerProfessionalContributionEntity.DevelopsSubordinates = (bool)dataTable.Rows[0].ItemArray[10];
            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = (int)dataTable.Rows[0].ItemArray[11];
            developerProfessionalContributionEntity.JobKpiAssessment = jobKpiEntity;

            return developerProfessionalContributionEntity;
        }
    }
}
