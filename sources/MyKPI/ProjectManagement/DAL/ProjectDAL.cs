//========================================================================================================
//  MyKPI - Project DAL
// Change logs:
// May 6 2018 - TrungTH - update 
//
//=========================================================================================================
#region
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.ProjectManagement.DAL
{
    class ProjectDAL : ICommonDAL
    {
        #region Add
        public bool Add(ICommonEntity _project)
        {
            var project = (_project as ProjectEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblproject (ProjectCode, ProjectName, StartedDate, EndDate, ScopeMM, CustomerName,Status) values ('{0}','{1}','{2}','{3}',{4},'{5}',{6}) ",
                project.ProjectCode,
                project.ProjectName,
                project.StartedDate.ToString("yyyy-MM-dd"),
                project.EndDate.ToString("yyyy-MM-dd"),
                project.ScopeMM,
                project.CustomerName,
                (int)project.Status             
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
                str = string.Format(@"delete from tblproject where ID = {0}", ID);
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
        public bool Edit(ICommonEntity _project, int ID)
        {
            var project = (_project as ProjectEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblproject  set ProjectCode = '{0}',ProjectName= '{1}',StartedDate ='{2}',EndDate = '{3}',ScopeMM = {4},CustomerName = '{5}',Status={6} where ID = {7}",
                project.ProjectCode,
                project.ProjectName,
                project.StartedDate.ToString("yyyy-MM-dd"),
                project.EndDate.ToString("yyyy-MM-dd"),
                project.ScopeMM,
                project.CustomerName,
                (int)project.Status,     
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
            string str = @"select * from tblProject";
            return DBManager.InstantDBManger.GetData(str);
        }
        #endregion
    }
}
