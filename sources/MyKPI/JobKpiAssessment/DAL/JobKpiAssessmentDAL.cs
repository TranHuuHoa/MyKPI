using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.JobKpiAssessment.DAL
{
    class JobKpiAssessmentDAL : ICommonDAL
    {
        public bool Add(ICommonEntity commonEntity)
        {
            throw new NotImplementedException();
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
            string str = @"select k.*,  concat_ws(' ',e.EmployeeFirstName,e.EmployeeLastName) as EmployeeName, e.EmployeeNumber 
                            from  tbljobkpiassessment k, tblemployee e where k.EmployeeID = e.ID;";
            return DBManager.InstantDBManger.GetData(str);
        }
    }
}
