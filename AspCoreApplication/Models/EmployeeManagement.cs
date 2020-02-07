using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApplication
{
    public interface EmployeeManagement
    {
        Employee GetEmployee(int id);
        List<Employee> DisplayDetails();
        bool AddEmployee(Employee employee);

        
    }
}
