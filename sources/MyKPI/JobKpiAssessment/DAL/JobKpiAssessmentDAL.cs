//========================================================================================================
//  MyKPI - Job KPI Assessment BLL
// Change logs:
// May 7 2018 - TrungTH - update 
//
//=========================================================================================================

#region using
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.JobKpiAssessment.DAL
{
    class JobKpiAssessmentDAL : ICommonDAL
    {
        #region Add
        public bool Add(ICommonEntity _jobKpiAssessment)
        {
            var jobKpiAssessment = (_jobKpiAssessment as JobKpiEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblJobKpiAssessment (EmployeeID, CreatedDate, RoleInAssessment, Status) values ({0},'{1}',{2},{3}) ",
                jobKpiAssessment.Employee.ID,      
                jobKpiAssessment.CreatedDate.ToString("yyyy-MM-dd"),
                (int)jobKpiAssessment.RoleInAssessment,
                (int)jobKpiAssessment.Status
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
                str = string.Format(@"delete from tblJobKpiAssessment where ID = {0}", ID);
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
        public bool Edit(ICommonEntity _jobKpiAssessment, int ID)
        {
            var jobKpiAssessment = (_jobKpiAssessment as JobKpiEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblJobKpiAssessment  set EmployeeID = {0},CreatedDate= '{1}',RoleInAssessment ={2},Status = {3} where ID = {4}",
                jobKpiAssessment.Employee.ID,
                jobKpiAssessment.CreatedDate.ToString("yyyy-MM-dd"),
                (int)jobKpiAssessment.RoleInAssessment,
                (int)jobKpiAssessment.Status,
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
        public static DataTable LoadAll()
        {
            string str = @"select k.*,  concat_ws(' ',e.EmployeeFirstName,e.EmployeeLastName) as EmployeeName, e.EmployeeNumber 
                            from  tbljobkpiassessment k, tblemployee e where k.EmployeeID = e.ID";
            return DBManager.InstantDBManger.GetData(str);
        }
        #endregion
    }
}
