﻿using EmployeeManagementModels;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase: ComponentBase
    {
        public IEnumerable<Employee> Employees{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "/Images/JohnJameson.jpg"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "/Images/JennyMarks.jpg"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "/Images/MaleDefault.jpg"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "/Images/NoahRobinson.jpg"
            };
            Employee e5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 5,
                PhotoPath = "/Images/OliviaMills.jpg"
            };
            Employee e6 = new Employee
            {
                EmployeeId = 6,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 6,
                PhotoPath = "/Images/Profile5_Woman.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4, e5, e6 };
        }
    }
}
