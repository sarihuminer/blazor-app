using EmployeeMenagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.services
{
 public   interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
