using System;
using System.Data;
using MyKPI.Common;
using MyKPI.Entities;

namespace MyKPI.ProjectManagement.DAL
{
    class ProjectDAL : ICommonDAL
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
            string str = @"select * from tblProject";
            return DBManager.InstantDBManger.GetData(str);
        }
    }
}
