//======================================================================================================
//  MyKPI - PersonalSkillsBLL
// Change logs:
// May 30 2018 - TrungTH - create
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.PersonalSkills.DAL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.PersonalSkills.BLL
{
    public class PersonalSkillsBLL
    {
        PersonalSkillsDAL personalSkillsDAL;
        public PersonalSkillsBLL()
        {
            personalSkillsDAL = new PersonalSkillsDAL();
        }
        public void AddPersonalSkills(PersonalSkillsEntity _personalSkills)
        {
            personalSkillsDAL.Add(_personalSkills);
        }

       public void EditPersonalSkills(PersonalSkillsEntity _personalSkills,int ID)
        {
            personalSkillsDAL.Edit(_personalSkills, ID);
        }

        public void DeletePersonalSkills(int ID)
        {
            personalSkillsDAL.Delete(ID);
        }

        public PersonalSkillsEntity LoadPerJobKpiAssessmentID(int JobKpiAssessmentID)
        {
            DataTable dataTable = personalSkillsDAL.Load(JobKpiAssessmentID);
            if (dataTable.Rows.Count == 0) return null;

            PersonalSkillsEntity personalSkillsEntity = new PersonalSkillsEntity();
            personalSkillsEntity.ID = (int)dataTable.Rows[0].ItemArray[0];
            personalSkillsEntity.Leadership = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[1];
            personalSkillsEntity.Communication = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[2];
            personalSkillsEntity.TimeManagement = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[3];
            personalSkillsEntity.Counselling = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[4];
            personalSkillsEntity.Teamwork = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[5];
            personalSkillsEntity.ObjectOrientedDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[6];
            personalSkillsEntity.StructuredDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[7];
            personalSkillsEntity.ArchitecturalPattern = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[8];
            personalSkillsEntity.DesignPattern = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[9];
            personalSkillsEntity.ObjectOrientedAnalysis = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[10];
            personalSkillsEntity.UML = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[11];
            personalSkillsEntity.ApplicationArchitectureDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[12];
            personalSkillsEntity.ExternalDesignJP = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[13];
            personalSkillsEntity.DetailedDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[14];

            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = (int)dataTable.Rows[0].ItemArray[15];
            personalSkillsEntity.JobKpiAssessment = jobKpiEntity;

            return personalSkillsEntity;
        }
    }
}
