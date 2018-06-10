//========================================================================================================
//  MyKPI - DeveloperPersonalSkillsDAL
// Change logs:
// May 30 2018 - TrungTH - create
//
//=========================================================================================================

#region using 
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;
using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.DeveloperPersonalSkills.DAL
{
    public class DeveloperPersonalSkillsDAL
    {
        #region Add
        public bool Add(IPersonalSkills _personalSkills)
        {
            var personalSkills = (_personalSkills as DeveloperPersonalSkillsEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblDeveloperPersonalSkills (Leadership,Communication,TimeManagement,
                                    Counselling,Teamwork,ObjectOrientedDesign,StructuredDesign,ArchitecturalPattern,
                                    DesignPattern,ObjectOrientedAnalysis,UML,ApplicationArchitectureDesign,ExternalDesignJP,DetailedDesign,JobKpiAssessmentID)
                                    values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14})",
                (int)personalSkills.Leadership,
                (int)personalSkills.Communication,
                (int)personalSkills.TimeManagement,
                (int)personalSkills.Counselling,
                (int)personalSkills.Teamwork,
                (int)personalSkills.ObjectOrientedDesign,
                (int)personalSkills.StructuredDesign,
                (int)personalSkills.ArchitecturalPattern, 
                (int)personalSkills.DesignPattern,
                (int)personalSkills.ObjectOrientedAnalysis,
                (int)personalSkills.UML,
                (int)personalSkills.ApplicationArchitectureDesign,
                (int)personalSkills.ExternalDesignJP,
                (int)personalSkills.DetailedDesign,
                personalSkills.JobKpiAssessment.ID
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Delete
        public bool Delete(int ID)
        {
            string str = string.Empty;
            try
            {
                str = string.Format(@"delete from tblDeveloperPersonalSkills where ID = {0}", ID);
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Edit
        public bool Edit(IPersonalSkills _personalSkills, int ID)
        {
            var personalSkills = (_personalSkills as DeveloperPersonalSkillsEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblDeveloperPersonalSkills  set Leadership = {0},Communication= {1},TimeManagement ={2},
                                Counselling = {3},Teamwork ={4},ObjectOrientedDesign ={5},StructuredDesign ={6},ArchitecturalPattern ={7},
                                DesignPattern ={8},ObjectOrientedAnalysis ={9},ObjectOrientedAnalysis ={9},UML ={10},ApplicationArchitectureDesign ={11},
                                ExternalDesignJP ={12},DetailedDesign ={12},JobKpiAssessmentID ={13} where ID = {14}",
                (int)personalSkills.Leadership,
                (int)personalSkills.Communication,
                (int)personalSkills.TimeManagement,
                (int)personalSkills.Counselling,
                (int)personalSkills.Teamwork,
                (int)personalSkills.ObjectOrientedDesign,
                (int)personalSkills.StructuredDesign,
                (int)personalSkills.ArchitecturalPattern,
                (int)personalSkills.DesignPattern,
                (int)personalSkills.ObjectOrientedAnalysis,
                (int)personalSkills.UML,
                (int)personalSkills.ApplicationArchitectureDesign,
                (int)personalSkills.ExternalDesignJP,
                (int)personalSkills.DetailedDesign,
                personalSkills.JobKpiAssessment.ID,
                ID
                );
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }
        #endregion

        #region Load
        public DataTable Load(int JobKpiAssessmentID)
        {
            string str = string.Format(@"SELECT * FROM mykpi.tblDeveloperPersonalSkills where JobKpiAssessmentID = {0}",
                                        JobKpiAssessmentID
                                        );
            return DBManager.InstantDBManger.GetData(str);
        }

        #endregion
    }
}

