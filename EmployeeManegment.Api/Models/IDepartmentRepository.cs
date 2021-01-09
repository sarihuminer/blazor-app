using EmployeeMenagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManegment.Api.Models
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetDepartments();
        public Department GetDepartment(int departmentId);
    }
}
