//========================================================================================================
//  MyKPI - PersonalSkillsEntity 
// Change logs:
// May 30 2018 - TrungTH - create
//
//=========================================================================================================
#region using
using MyKPI.Common;
using MyKPI.Entities.Assessment;
#endregion


namespace MyKPI.Entities.Assessment
{
    public class DeveloperPersonalSkillsEntity : IPersonalSkills
    {
        public int ID { get; set; }       
        public PersonalSkillsValue Leadership { get; set; }
        public PersonalSkillsValue Communication { get; set; }
        public PersonalSkillsValue TimeManagement { get; set; }
        public PersonalSkillsValue Counselling { get; set; }
        public PersonalSkillsValue Teamwork { get; set; }
        public PersonalSkillsValue ObjectOrientedDesign { get; set; }
        public PersonalSkillsValue StructuredDesign { get; set; }
        public PersonalSkillsValue ArchitecturalPattern { get; set; }
        public PersonalSkillsValue DesignPattern { get; set; }
        public PersonalSkillsValue ObjectOrientedAnalysis { get; set; }
        public PersonalSkillsValue UML { get; set; }
        public PersonalSkillsValue ApplicationArchitectureDesign { get; set; }
        public PersonalSkillsValue ExternalDesignJP { get; set; }
        public PersonalSkillsValue DetailedDesign { get; set; }
        public JobKpiEntity JobKpiAssessment { get; set; }
    }
}
