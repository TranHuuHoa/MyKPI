using System.Data;
using MyKPI.Entities;
using MyKPI.EmployeeManagment.DAL;
using System.Collections.Generic;

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

        public EmployeeEntity LoadOnePerID(int ID)
        {
            return employeeDAL.LoadOnePerID(ID);
        }

        public void DeleteEmployee(int ID)
        {
            employeeDAL.Delete(ID);
        }

        public List<EmployeeEntity> LoadAllEmployeeList()
        {
            List<EmployeeEntity> EmployeeList = new List<EmployeeEntity>();
            DataTable employeeDataTable = EmployeeDAL.LoadAll();
            EmployeeBLL employeeBLL = new EmployeeBLL();

            foreach (DataRow row in employeeDataTable.Rows)
            {
                EmployeeEntity employeeEntity = new EmployeeEntity();
                employeeEntity.ID = (int)row[0];
                employeeEntity.EmployeeNumber = row[1].ToString();
            }
            return EmployeeList;
        }

        public DataTable LoadAllEmployee()
        {
            return EmployeeDAL.LoadAll();
        }
    }
}
