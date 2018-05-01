using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.EmployeeManagment.DAL
{
    class EmployeeDAL : ICommonDAL
    {
        public bool Add(ICommonEntity _employee)
        {
            var employee = (_employee as EmployeeEntity);
 
            try
            {
                var str = string.Format(@"insert into tblEmployee (EmployeeNumber,EmployeeFirstName, 
                                            EmployeeLastName,Address,IDCard,DOB,Sex,JobRankType,JobRankLevel, 
                                            SalaryLevel, SalarySubLevel) 
                                            values ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},{8},{9},{10})",
                employee.EmployeeNumber,
                employee.EmployeeFirstName,
                employee.EmployeeLastName,
                employee.Address,
                employee.IDCard,
                employee.DOB.ToString("yyyy-MM-dd"),
                (int)employee.Sex,
                (int)employee.JobRankType,
                (int)employee.JobRankLevel,
                (int)employee.SalaryLevel,
                employee.SalarySubLevel
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
       

        public bool Delete(int ID)
        {
            string str = string.Empty;
            try
            {
                str = string.Format(@"delete from tblEmployee where ID = {0}", ID);
                DBManager.InstantDBManger.QueryExecutionWithTransaction(str);
                return true;
            }
            catch (Exception exp)
            {
                CommonFunctions.ShowErrorDialog("SQL error:" + exp.ToString());
                return false;
            }
        }

        public bool Edit(ICommonEntity _employee, int ID)
        {

            var employee = (_employee as EmployeeEntity);
            string str = string.Empty;
            try
            {
                str = string.Format(@"update tblEmployee  set EmployeeNumber = '{0}',EmployeeFirstName= '{1}',EmployeeLastName ='{2}',Address = '{3}',IDCard = '{4}',DOB = '{5}',JobRankType={6},JobRankLevel={7},SalaryLevel={8}, SalarySubLevel={9} where ID = {10}",
                employee.EmployeeNumber,
                employee.EmployeeFirstName,
                employee.EmployeeLastName,
                employee.Address,
                employee.IDCard,
                employee.DOB.ToString("yyyy-MM-dd"),
                (int)employee.JobRankType,
                (int)employee.JobRankLevel,
                (int)employee.SalaryLevel,
                employee.SalarySubLevel,
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

        public static DataTable LoadAll()
        {
            string str = @"select *,concat_ws(' ',EmployeeFirstName,EmployeeLastName) as EmployeeName from tblEmployee";
            return DBManager.InstantDBManger.GetData(str);
        }

        public static DataTable LoadEmployeeName()
        {
            string str = @"SELECT ID, CONCAT_WS(' ',EmployeeFirstName, EmployeeLastName) as EmployeeName FROM tblemployee";
            return DBManager.InstantDBManger.GetData(str);
        }
    }
}
