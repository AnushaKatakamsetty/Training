using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDManagement.Models
{
    public enum Dept
    {
        IT,Finance,HealthCare
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public Dept dep { get; set; }
    }
}
