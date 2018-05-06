using System;
using MyKPI.Common;
using MyKPI.Entities.Assessment;

namespace MyKPI.Entities
{
    class JobKpiEntity
    {
        EmployeeEntity Employee { get; set; }
        JobRankValue RoleInAssessment { get; set; }
        DateTime CreatedDate { get; set; }
        AssessmentStatusValue Status { get; set; }
        IProjectContribution ProjectContribution1 { get; set; }
        IProjectContribution ProjectContribution2 { get; set; }
        IProjectContribution ProjectContribution3 { get; set; }
        IProfessionalContribution ProfessionalContribution { get; set; }
        ISkillAssessment SkillAssessment { get; set; }

    }
}
