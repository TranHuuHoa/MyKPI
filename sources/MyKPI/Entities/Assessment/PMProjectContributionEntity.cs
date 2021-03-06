﻿//========================================================================================================
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
    public class PMProjectContributionEntity : ProjectContributionEntity, IProjectContribution
    {      
        public PMRoleAndResponsibilityValue PMRoleAndResponsibility { get; set; }
        public bool SofwareDevelopmentActivitites { get; set; }
        public bool Complexity_InternationalProject { get; set; }
        public bool Complexity_GloballyAdvancedTechnologyProject { get; set; }
        public bool Complexity_ComplicatedContractConditions { get; set; }
        public bool Complexity_ArchitectureRequirement { get; set; }
        public bool Complexity_SystemDesign { get; set; }
        public bool Complexity_ApplicationRequirement { get; set; }
        public bool Complexity_ProjectStructure { get; set; }
        public int TeamSizeAverage { get; set; }
        public int PhaseDuration { get; set; }

    }
}
