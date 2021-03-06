﻿//========================================================================================================
//  MyKPI - Task DAL
// Change logs:
// May 6 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;
#endregion

namespace MyKPI.ProjectManagement.DAL
{
    public class TaskDAL : ICommonDAL
    {
        #region Add
        public bool Add(ICommonEntity _task)
        {
            var task = (_task as TaskEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"insert into tblTask (TaskCode,TaskName,Description,Assignee,Reporter,Status,Priority,TaskType,ProjectID) values ('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8}) ",
                task.TaskCode,
                task.TaskName,
                task.Description,
                task.Assignee.ID,
                task.Reporter.ID,
                (int)task.Status,
                (int)task.Priority,
                (int)task.TaskType,
                task.Project.ID
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
                str = string.Format(@"delete from tblTask where ID = {0}", ID);
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
        public bool Edit(ICommonEntity _task, int ID)
        {
            var task = (_task as TaskEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblTask  set TaskCode = '{0}',TaskName= '{1}',Description ='{2}',Assignee = {3},Reporter = {4},Status = {5},Priority={6},TaskType={7} where ID = {8}",
                task.TaskCode,
                task.TaskName,
                task.Description,
                task.Assignee.ID,
                task.Reporter.ID,
                (int)task.Status,
                (int)task.Priority,
                (int)task.TaskType,
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
            string str = @"select t.*, CONCAT_WS(' ',e1.EmployeeFirstName, e1.EmployeeLastName) as AssigneeName, 
                            CONCAT_WS(' ', e2.EmployeeFirstName, e2.EmployeeLastName) as ReporterName 
                            from tbltask t, tblemployee e1, tblemployee e2 where t.Assignee = e1.ID and t.Reporter = e2.ID";
            return DBManager.InstantDBManger.GetData(str);
        }

        public DataTable LoadAllPerProject(int _projectID)
        {
            string str = @"select t.*, CONCAT_WS(' ',e1.EmployeeFirstName, e1.EmployeeLastName) as AssigneeName, 
                            CONCAT_WS(' ', e2.EmployeeFirstName, e2.EmployeeLastName) as ReporterName 
                            from tbltask t, tblemployee e1, tblemployee e2 where t.Assignee = e1.ID and t.Reporter = e2.ID and t.projectID = "+_projectID;
            return DBManager.InstantDBManger.GetData(str);
        }
        #endregion
    }
}
