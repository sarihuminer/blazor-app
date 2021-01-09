using EmployeeMenagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManegment.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDBContext appDBContext;

        public DepartmentRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public  Department GetDepartment(int departmentId)
        {
            return appDBContext.Departments.FirstOrDefault(dpr => dpr.DepartmentId == departmentId);

        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDBContext.Departments;
        }
    }
}
