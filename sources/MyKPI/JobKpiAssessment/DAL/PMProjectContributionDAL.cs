//========================================================================================================
//  MyKPI - PM Project Contribution DAL
// Change logs:
// May 5 2018 - TrungTH - create
//
//=========================================================================================================

#region using 
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities.Assessment;
#endregion

namespace MyKPI.PMProjectContribution.DAL
{
    public class PMProjectContributionDAL
    {
        #region Add
        public bool Add(IProjectContribution _pmProjectContribution)
        {
            var pmProjectContribution = (_pmProjectContribution as PMProjectContributionEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblPMProjectContribution (ProjectSeq, ProjectID, PMRoleAndResponsibility, SofwareDevelopmentActivitites,
                                    Complexity_InternationalProject, Complexity_GloballyAdvancedTechnologyProject, Complexity_ComplicatedContractConditions,
                                    Complexity_ArchitectureRequirement,Complexity_SystemDesign,Complexity_ApplicationRequirement,Complexity_ProjectStructure,
                                    TeamSizeAverage,PhaseDuration,JobKpiAssessmentID) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})",
                pmProjectContribution.ProjectSeq,
                pmProjectContribution.Project.ID,
                (int)pmProjectContribution.PMRoleAndResponsibility,
                pmProjectContribution.SofwareDevelopmentActivitites,
                (bool)pmProjectContribution.Complexity_InternationalProject,
                (bool)pmProjectContribution.Complexity_GloballyAdvancedTechnologyProject,
                (bool)pmProjectContribution.Complexity_ComplicatedContractConditions,
                (bool)pmProjectContribution.Complexity_ArchitectureRequirement,
                (bool)pmProjectContribution.Complexity_SystemDesign,
                (bool)pmProjectContribution.Complexity_ApplicationRequirement,
                (bool)pmProjectContribution.Complexity_ProjectStructure,
                (int)pmProjectContribution.TeamSizeAverage,
                (int)pmProjectContribution.PhaseDuration,
                pmProjectContribution.JobKpiAssessment.ID
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
                str = string.Format(@"delete from tblPMProjectContribution where ID = {0}", ID);
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
        public bool Edit(IProjectContribution _pmProjectContribution, int ID)
        {
            var pmProjectContribution = (_pmProjectContribution as PMProjectContributionEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblPMProjectContribution  set ProjectSeq = {0},ProjectID = {1},PMRoleAndResponsibility= {2},SofwareDevelopmentActivitites ={3},
                                Complexity_InternationalProject ={4},Complexity_GloballyAdvancedTechnologyProject ={5},Complexity_ComplicatedContractConditions ={6},
                                Complexity_ArchitectureRequirement ={7},Complexity_SystemDesign ={8},Complexity_ApplicationRequirement ={9},Complexity_ProjectStructure ={10},
                                TeamSizeAverage ={11},PhaseDuration ={12},haseDuration ={13},JobKpiAssessmentID ={14} where ID = {14}",
                pmProjectContribution.ProjectSeq,
                pmProjectContribution.Project.ID,
                (int)pmProjectContribution.PMRoleAndResponsibility,
                pmProjectContribution.SofwareDevelopmentActivitites,
                (bool)pmProjectContribution.Complexity_InternationalProject,
                (bool)pmProjectContribution.Complexity_GloballyAdvancedTechnologyProject,
                (bool)pmProjectContribution.Complexity_ComplicatedContractConditions,
                (bool)pmProjectContribution.Complexity_ArchitectureRequirement,
                (bool)pmProjectContribution.Complexity_SystemDesign,
                (bool)pmProjectContribution.Complexity_ApplicationRequirement,
                (bool)pmProjectContribution.Complexity_ProjectStructure,
                (int)pmProjectContribution.TeamSizeAverage,
                (int)pmProjectContribution.PhaseDuration,
                pmProjectContribution.JobKpiAssessment.ID,
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
            string str = string.Format(@"SELECT * FROM mykpi.tblpmprojectcontribution where JobKpiAssessmentID = {0} and ProjectSeq = {1}",
                                        JobKpiAssessmentID,
                                        ProjectSeq
                                        );
            return DBManager.InstantDBManger.GetData(str);
        }
        #endregion
    }
}

