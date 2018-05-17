//========================================================================================================
//  MyKPI - Developer Project Contribution DAL
// Change logs:
// May 11 2018 - TrungTH - creat
//
//=========================================================================================================

#region using 
using System;
using System.Data;
using MyKPI.Common;

using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.DeveloperProjectContribution.DAL
{
        public class DeveloperProjectContributionDAL
        {
            #region Add
            public bool Add(IProjectContribution _developerProjectContribution)
            {
                var developerProjectContribution = (_developerProjectContribution as DeveloperProjectContributionEntity);
                string str = string.Empty;
                try
                {
                    str = string.Format(@"insert into tblDeveloperProjectContribution (ProjectSeq, ProjectID, TeamRole, ImplementDesign, ImplementCode, ImplementUnitTest, JobKpiAssessmentID) values ({0},{1},{2},{3},{4},{5},{6})",
                    developerProjectContribution.ProjectSeq,
                    developerProjectContribution.Project.ID,
                    (int)developerProjectContribution.TeamRole,
                    (int)developerProjectContribution.ImplementDesign,
                    (int)developerProjectContribution.ImplementCode,
                    (int)developerProjectContribution.ImplementUnitTest,
                    developerProjectContribution.JobKpiAssessment.ID
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
                    str = string.Format(@"delete from tblDeveloperProjectContribution where ID = {0}", ID);
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
            public bool Edit(IProjectContribution _developerProjectContribution, int ID)
            {
                var developerProjectContribution = (_developerProjectContribution as DeveloperProjectContributionEntity);
                string str = string.Empty;
                try
                {
                    str = string.Format(@"update tbldeveloperprojectcontribution  set ProjectSeq = {0},ProjectID= {1},TeamRole ={2},ImplementDesign = {3},ImplementCode ={4},ImplementUnitTest ={5},JobKpiAssessmentID ={6} where ID = {7}",
                    developerProjectContribution.ProjectSeq,
                    developerProjectContribution.Project.ID,
                    (int)developerProjectContribution.TeamRole,
                    (int)developerProjectContribution.ImplementDesign,
                    (int)developerProjectContribution.ImplementCode,
                    (int)developerProjectContribution.ImplementUnitTest,
                    developerProjectContribution.JobKpiAssessment.ID,
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
            public DataTable LoadPerKpiAssessmentAndSeq(int JobKpiAssessmentID, int ProjectSeq)
            {
                string str = string.Format(@"SELECT * FROM mykpi.tbldeveloperprojectcontribution where JobKpiAssessmentID = {0} and ProjectSeq = {1}",
                                            JobKpiAssessmentID,
                                            ProjectSeq
                                            );
                return DBManager.InstantDBManger.GetData(str);
            }
            #endregion
        }
}
    
