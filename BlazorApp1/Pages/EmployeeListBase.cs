using BlazorApp1.services;
using EmployeeMenagment.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmplyeeService { get; set; }
        public IEnumerable<Employee> Employess { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // await Task.Run(LoadEmployees);
            Employess = (await EmplyeeService.GetEmployees()).ToList();
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "jon",
                LastName = "yuooo",
                Email = "dshajkashk@nsg.co.il",
                DateOfBirth = new DateTime(1900, 02, 01),
                Gender = Gender.Male,
                PhotoPath = "images/1540445753.png",
                DepartmentId = 1,
                //Department = new Department { DepartmentId = 1, DepartmentName = "haitech" }
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "bosh",
                LastName = "yuooo",
                Email = "kljj@nsg.co.il",
                DateOfBirth = new DateTime(1980, 03, 14),
                Gender = Gender.Male,
                PhotoPath = "images/computers.png",
                DepartmentId = 1
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "kobi",
                LastName = "sharon",
                Email = "kk@nsg.co.il",
                DateOfBirth = new DateTime(1999, 02, 01),
                Gender = Gender.Male,
                PhotoPath = "images/man-sitting-laptop-publicdomain.jpg",
                DepartmentId = 1
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 4,
                FirstName = "robert",
                LastName = "kazarov",
                Email = "rk@nsg.co.il",
                DateOfBirth = new DateTime(1888, 12, 01),
                Gender = Gender.Male,
                PhotoPath = "images/man-surfing-on-internet-publicdomain.jpg",
                DepartmentId=1
            };
            Employee e5 = new Employee()
            {
                EmployeeId = 5,
                FirstName = "BOB",
                LastName = "yuooo",
                Email = "BB@nsg.co.il",
                DateOfBirth = new DateTime(2000, 02, 04),
                Gender = Gender.Male,
                PhotoPath = "images/programmer.png",
                DepartmentId = 1
            };
            Employess = new List<Employee> { e1, e2, e3, e4, e5 };
        }
        
    }
}
