using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCarTransport.Models;

namespace TrainCarTransport.Repo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private List<Employee> employees;

        public EmployeeRepo() { employees = new List<Employee>(); }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetEmployeeByName(string name)
        {
            return employees.FirstOrDefault(e => e.Name.Equals(name));
        }
    }
}
