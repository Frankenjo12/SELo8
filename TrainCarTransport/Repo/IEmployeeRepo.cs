using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCarTransport.Models;

namespace TrainCarTransport.Repo
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetAll();
        public Employee GetEmployeeByName(string name);
        public void AddEmployee(Employee employee);
    }
}
