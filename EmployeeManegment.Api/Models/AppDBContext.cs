using EmployeeMenagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManegment.Api.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //department table
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //employe table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "jon",
                LastName = "yuooo",
                Email = "dshajkashk@nsg.co.il",
                DateOfBirth = new DateTime(1900, 02, 01),
                Gender = Gender.Male,
                PhotoPath = "images/1540445753.png",
                DepartmentId = 1,
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "bosh",
                LastName = "yuooo",
                Email = "kljj@nsg.co.il",
                DateOfBirth = new DateTime(1980, 03, 14),
                Gender = Gender.Male,
                PhotoPath = "images/computers.png",
                DepartmentId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "kobi",
                LastName = "sharon",
                Email = "kk@nsg.co.il",
                DateOfBirth = new DateTime(1999, 02, 01),
                Gender = Gender.Male,
                PhotoPath = "images/man-sitting-laptop-publicdomain.jpg",
                DepartmentId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "robert",
                LastName = "kazarov",
                Email = "rk@nsg.co.il",
                DateOfBirth = new DateTime(1888, 12, 01),
                Gender = Gender.Male,
                PhotoPath = "images/man-surfing-on-internet-publicdomain.jpg",
                DepartmentId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "BOB",
                LastName = "yuooo",
                Email = "BB@nsg.co.il",
                DateOfBirth = new DateTime(2000, 02, 04),
                Gender = Gender.Male,
                PhotoPath = "images/programmer.png",
                DepartmentId = 1
            });


        }
    }
}
