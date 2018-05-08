using System;
using MyKPI.Common;
using MyKPI.Entities.Assessment;

namespace MyKPI.Entities
{
    public class JobKpiEntity
    {
        public EmployeeEntity Employee { get; set; }
        public JobRankValue RoleInAssessment { get; set; }
        public DateTime CreatedDate { get; set; }
        public AssessmentStatusValue Status { get; set; }
        IProjectContribution ProjectContribution1 { get; set; }
        IProjectContribution ProjectContribution2 { get; set; }
        IProjectContribution ProjectContribution3 { get; set; }
        IProfessionalContribution ProfessionalContribution { get; set; }
        ISkillAssessment SkillAssessment { get; set; }

    }
}
