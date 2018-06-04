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
    public class DeveloperProjectContributionEntity : IProjectContribution
    {

        public int ID { get; set; }
        public int ProjectSeq { get; set; }
        public ProjectEntity Project { get; set; }
        public TeamRoleValue TeamRole { get; set; }
        public WorkingResultValue ImplementDesign { get; set; }
        public WorkingResultValue ImplementCode { get; set; }
        public WorkingResultValue ImplementUnitTest { get; set; }
        public JobKpiEntity JobKpiAssessment { get; set; }
    }
}
