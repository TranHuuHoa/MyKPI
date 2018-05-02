using System.Data;
using MyKPI.Entities;
using MyKPI.EmployeeManagment.DAL;

namespace MyKPI.EmployeeManagment.BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL employeeDAL;
        public EmployeeBLL()
        {
            employeeDAL = new EmployeeDAL();
        }
        public void AddEmployee(EmployeeEntity _employee)
        {
            employeeDAL.Add(_employee);
        }

        public void EditEmployee(EmployeeEntity _employee, int ID)
        {
            employeeDAL.Edit(_employee, ID);
        }

        public void DeleteEmployee(int ID)
        {
            employeeDAL.Delete(ID);
        }

        public DataTable LoadAllEmployee()
        {
            return EmployeeDAL.LoadAll();
        }
    }
}
