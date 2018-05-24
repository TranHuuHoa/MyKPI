//========================================================================================================
//  MyKPI - Developer Professional Contribution DAL
// Change logs:
// May 22 2018 - TrungTH - creat
//
//=========================================================================================================

#region using 
using System;
using System.Data;
using MyKPI.Common;

using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.DeveloperProfessionalContribution.DAL
{
    public class DeveloperProfessionalContributionDAL
    {
        #region Add
        public bool Add(IProfessionalContribution _developerProfessionalContribution)
        {
            var developerProfessionalContribution = (_developerProfessionalContribution as DeveloperProfessionalContributionEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblDeveloperProfessionalContribution (MasterProgrammingLanguages,MasterUnitTesting,MasterClientFramework, MasterSofwareDevelopmentFramework,IntructorAtCompany,SharingAtWorkshop,DevelopTrainningCourse,SubmissionImprovementProposal,ActivitesInComunity,DevelopsSubordinates,JobKpiAssessment) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})",
                developerProfessionalContribution.ID,
                (int)developerProfessionalContribution.MasterProgrammingLanguages,
                (int)developerProfessionalContribution.MasterUnitTesting,
                (int)developerProfessionalContribution.MasterClientFramework,
                (int)developerProfessionalContribution.MasterSofwareDevelopmentFramework,
                (bool)developerProfessionalContribution.IntructorAtCompany,
                (bool)developerProfessionalContribution.SharingAtWorkshop,
                (bool)developerProfessionalContribution.DevelopTrainningCourse,
                (bool)developerProfessionalContribution.SubmissionImprovementProposal,
                (bool)developerProfessionalContribution.ActivitesInComunity,
                (bool)developerProfessionalContribution.DevelopsSubordinates,
                developerProfessionalContribution.JobKpiAssessment.ID
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
                str = string.Format(@"delete from tblDeveloperProfessionalContribution where ID = {0}", ID);
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
        public bool Edit(IProfessionalContribution _developerProfessionalContribution, int ID)
        {
            var developerProfessionalContribution = (_developerProfessionalContribution as DeveloperProfessionalContributionEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tbldeveloperprojectcontribution  set MasterProgrammingLanguages = {0},MasterUnitTesting= {1},MasterClientFramework ={2},MasterSofwareDevelopmentFramework = {3},IntructorAtCompany ={4},SharingAtWorkshop ={5},DevelopTrainningCourse ={6},SubmissionImprovementProposal ={7},ActivitesInComunity ={8},DevelopsSubordinates ={9},JobKpiAssessment ={10},, where ID = {11}",
                developerProfessionalContribution.ID,
                (int)developerProfessionalContribution.MasterProgrammingLanguages,
                (int)developerProfessionalContribution.MasterUnitTesting,
                (int)developerProfessionalContribution.MasterClientFramework,
                (int)developerProfessionalContribution.MasterSofwareDevelopmentFramework,
                (bool)developerProfessionalContribution.IntructorAtCompany,
                (bool)developerProfessionalContribution.SharingAtWorkshop,
                (bool)developerProfessionalContribution.DevelopTrainningCourse,
                (bool)developerProfessionalContribution.SubmissionImprovementProposal,
                (bool)developerProfessionalContribution.ActivitesInComunity,
                (bool)developerProfessionalContribution.DevelopsSubordinates,
                developerProfessionalContribution.JobKpiAssessment.ID,
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
            string str = string.Format(@"SELECT * FROM mykpi.tbldeveloperprofessionalcontribution where JobKpiAssessmentID = {0}",
                                        JobKpiAssessmentID                            
                                        );
            return DBManager.InstantDBManger.GetData(str);
        }

        #endregion
    }
}

