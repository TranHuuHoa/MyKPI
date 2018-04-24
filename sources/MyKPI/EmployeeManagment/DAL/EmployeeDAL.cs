using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entity;

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
                employee.DOB,
                (int)employee.Sex,
                (int)employee.JobRankType,
                employee.JobRankLevel,
                employee.SalaryLevel,
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
            throw new NotImplementedException();
        }

        public bool Edit(ICommonEntity commonEntity, int ID)
        {
            throw new NotImplementedException();
        }

        public static DataTable LoadAll()
        {
            string str = @"select *,concat_ws(' ',EmployeeFirstName,EmployeeLastName) as EmployeeName from tblEmployee";
            return DBManager.InstantDBManger.GetData(str);
        }
    }
}
