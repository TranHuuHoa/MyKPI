using System.Data;
using MyKPI.Entity;
using MyKPI.EmployeeManagment.DAL;

namespace MyKPI.EmployeeManagment.BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL EmployeeDAL;
        public EmployeeBLL()
        {
            EmployeeDAL = new EmployeeDAL();
        }
        public void AddEmployee(EmployeeEntity _employee)
        {
            EmployeeDAL.Add(_employee);
        }

        public void EditEmployee(EmployeeEntity _employee, int ID)
        {
            EmployeeDAL.Edit(_employee, ID);
        }

        public void DeleteEmployee(int ID)
        {
            EmployeeDAL.Delete(ID);
        }

        public DataTable LoadAllEmployee()
        {
            return EmployeeDAL.LoadAll();
        }

        //public DataTable LoadEmployeeName()
        //{
        //    return EmployeeDAL.LoadEmployeeName();
        //}
    }
}
