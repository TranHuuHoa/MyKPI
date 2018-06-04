//========================================================================================================
//  MyKPI - PM Project Contribution Entity
// Change logs:
// June 3 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using MyKPI.Common;
#endregion

namespace MyKPI.Entities.Assessment
{
    public class PMProjectContributionEntity : IProjectContribution
    {
        int ID { get; set; }
        int ProjectSeq { get; set; }
        ProjectEntity Project { get; set; }
        JobKpiEntity JobKpiAssessment { get; set; }
        public PMRoleAndResponsibilityValue PMRoleAndResponsibility { get; set; }
        public bool SofwareDevelopmentActivitites { get; set; }
        public bool Complexity_InternationalProject { get; set; }
        public bool Complexity_GloballyAdvancedTechnologyProject { get; set; }
        public bool Complexity_ComplicatedContractConditions { get; set; }
        public bool Complexity_ArchitectureRequirement { get; set; }
        public bool Complexity_SystemDesign { get; set; }
        public bool Complexity_ComplexApplicationRequirement { get; set; }
        public bool Complexity_ComplexProjectStructure { get; set; }
        public int TeamSizeAverage { get; set; }
        public int PhaseDuration { get; set; }

    }
}
