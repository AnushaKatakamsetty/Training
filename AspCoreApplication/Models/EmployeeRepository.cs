using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApplication
{
    public class EmployeeRepository:EmployeeManagement
    {
        public List<Employee> elist;
        public EmployeeRepository()
        {
            elist = new List<Employee>() { new Employee(1, "SK",Models.Dept.it), new Employee(2, "MS", Models.Dept.accounts) };
        }
        public Employee GetEmployee(int id1)
        {
            Employee el = elist.FirstOrDefault(e => e.id == id1);
            //foreach(Employee x in e) 
            //{
            //    if (x.id == id)
            //        return x;
            //}
            return el;
        }
        public List<Employee> DisplayDetails()
        {
            return elist;
        }
        public bool AddEmployee(Employee emp5)
        {
            emp5.id = elist.Max(e => e.id) + 1;
            elist.Add(emp5);
            return true;
        }
    }
}
