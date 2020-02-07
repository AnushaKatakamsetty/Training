using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDManagement.Models;

namespace EmployeeDManagement.Data
{
    public class EmployeeDManagementContext : DbContext
    {
        public EmployeeDManagementContext (DbContextOptions<EmployeeDManagementContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDManagement.Models.Employee> Employee { get; set; }
    }
}
