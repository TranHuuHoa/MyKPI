//========================================================================================================
//  MyKPI - Developer Project Contribution Entity
// Change logs:
// May 10 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using MyKPI.Common;
#endregion

namespace MyKPI.Entities.Assessment
{
    public class DeveloperProjectContributionEntity : ProjectContributionEntity, IProjectContribution
    {      
        public TeamRoleValue TeamRole { get; set; }
        public WorkingResultValue ImplementDesign { get; set; }
        public WorkingResultValue ImplementCode { get; set; }
        public WorkingResultValue ImplementUnitTest { get; set; }        
    }
}
