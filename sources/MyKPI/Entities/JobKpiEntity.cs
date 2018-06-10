//========================================================================================================
//  MyKPI - Job KPI Entity BLL
// Change logs:
// May 10 2018 - TrungTH - update 
//
//=========================================================================================================

#region using
using System;
using MyKPI.Common;
using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.Entities
{
    public class JobKpiEntity: ICommonEntity
    {
        public int ID { get; set; }
        public EmployeeEntity Employee { get; set; }
        public JobRankValue RoleInAssessment { get; set; }
        public DateTime CreatedDate { get; set; }
        public AssessmentStatusValue Status { get; set; }
        public IProjectContribution ProjectContribution1 { get; set; }
        public IProjectContribution ProjectContribution2 { get; set; }
        public IProjectContribution ProjectContribution3 { get; set; }
        public IProfessionalContribution ProfessionalContribution { get; set; }
        public IPersonalSkills DeveloperPersonalSkills { get; set; }

    }
}
