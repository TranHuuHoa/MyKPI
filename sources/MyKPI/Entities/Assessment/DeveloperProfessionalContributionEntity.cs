//========================================================================================================
//  MyKPI - Developer Professional Contribution Entity
// Change logs:
// May 20 2018 - TrungTH - create
//
//=========================================================================================================
#region using
using MyKPI.Common;
#endregion


namespace MyKPI.Entities.Assessment
{
    public class DeveloperProfessionalContributionEntity: IProfessionalContribution
    {
        public int ID { get; set; }
        public ProfessionalValue MasterProgrammingLanguages { get; set; }
        public ProfessionalValue MasterUnitTesting { get; set; }
        public ProfessionalValue MasterClientFramework { get; set; }
        public ProfessionalValue MasterSofwareDevelopmentFramework { get; set; }
        public bool IntructorAtCompany { get; set; }
        public bool SharingAtWorkshop { get; set; }
        public bool DevelopTrainningCourse { get; set; }
        public bool SubmissionImprovementProposal { get; set; }
        public bool ActivitesInComunity { get; set; }
        public bool DevelopsSubordinates { get; set; }
        public JobKpiEntity JobKpiAssessment { get; set; }
    }
}
