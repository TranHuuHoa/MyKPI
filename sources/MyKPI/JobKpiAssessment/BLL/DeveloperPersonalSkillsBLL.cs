//======================================================================================================
//  MyKPI - DeveloperPersonalSkillsBLL
// Change logs:
// May 30 2018 - TrungTH - create
//
//=========================================================================================================
#region using
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.DeveloperPersonalSkills.DAL;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.DeveloperPersonalSkills.BLL
{
    public class DeveloperPersonalSkillsBLL
    {
        DeveloperPersonalSkillsDAL developerPersonalSkillsDAL;
        public DeveloperPersonalSkillsBLL()
        {
            developerPersonalSkillsDAL = new DeveloperPersonalSkillsDAL();
        }
        public void AddDeveloperPersonalSkills(DeveloperPersonalSkillsEntity _developerPersonalSkills)
        {
            developerPersonalSkillsDAL.Add(_developerPersonalSkills);
        }

       public void EditDeveloperPersonalSkills(DeveloperPersonalSkillsEntity _developerPersonalSkills,int ID)
        {
            developerPersonalSkillsDAL.Edit(_developerPersonalSkills, ID);
        }

        public void DeleteDeveloperPersonalSkills(int ID)
        {
            developerPersonalSkillsDAL.Delete(ID);
        }

        public DeveloperPersonalSkillsEntity LoadPerJobKpiAssessmentID(int JobKpiAssessmentID)
        {
            DataTable dataTable = developerPersonalSkillsDAL.Load(JobKpiAssessmentID);
            if (dataTable.Rows.Count == 0) return null;

            DeveloperPersonalSkillsEntity DeveloperPersonalSkillsEntity = new DeveloperPersonalSkillsEntity();
            DeveloperPersonalSkillsEntity.ID = (int)dataTable.Rows[0].ItemArray[0];
            DeveloperPersonalSkillsEntity.Leadership = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[1];
            DeveloperPersonalSkillsEntity.Communication = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[2];
            DeveloperPersonalSkillsEntity.TimeManagement = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[3];
            DeveloperPersonalSkillsEntity.Counselling = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[4];
            DeveloperPersonalSkillsEntity.Teamwork = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[5];
            DeveloperPersonalSkillsEntity.ObjectOrientedDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[6];
            DeveloperPersonalSkillsEntity.StructuredDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[7];
            DeveloperPersonalSkillsEntity.ArchitecturalPattern = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[8];
            DeveloperPersonalSkillsEntity.DesignPattern = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[9];
            DeveloperPersonalSkillsEntity.ObjectOrientedAnalysis = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[10];
            DeveloperPersonalSkillsEntity.UML = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[11];
            DeveloperPersonalSkillsEntity.ApplicationArchitectureDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[12];
            DeveloperPersonalSkillsEntity.ExternalDesignJP = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[13];
            DeveloperPersonalSkillsEntity.DetailedDesign = (PersonalSkillsValue)dataTable.Rows[0].ItemArray[14];

            JobKpiEntity jobKpiEntity = new JobKpiEntity();
            jobKpiEntity.ID = (int)dataTable.Rows[0].ItemArray[15];
            DeveloperPersonalSkillsEntity.JobKpiAssessment = jobKpiEntity;

            return DeveloperPersonalSkillsEntity;
        }
    }
}
