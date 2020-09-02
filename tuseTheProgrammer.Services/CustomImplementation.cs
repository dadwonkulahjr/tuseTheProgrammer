using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tuseTheProgrammer.Models;

namespace tuseTheProgrammer.Services
{
    public class CustomImplementation : IRepository
    {
        private List<Employee> _listOfEmployeesObjects;
        public CustomImplementation()
        {
            _listOfEmployeesObjects = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Mike",
                    Email = "mike@gmail.com",
                    Gender = new Gender(){Id=1, Sex = Sex.Male},
                    Department = new Department(){Id = 1, Dept = Dept.IT},
                    Salary = 5000
                },
                 new Employee()
                {
                    Id = 2,
                    Name = "Mary",
                    Email = "mary@yahoo.com",
                    Gender = new Gender(){Id=2, Sex= Sex.Female},
                    Department = new Department(){Id = 2, Dept = Dept.HR},
                    Salary = 2500
                },
                new Employee()
                {
                    Id = 3,
                    Name = "John",
                    Email = "john@outlook.com",
                    Gender = new Gender(){Id=1, Sex= Sex.Male},
                    Department = new Department(){Id=3, Dept = Dept.Finance},
                    Salary = 6000
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Patricia",
                    Email = "patricia@hotmail.com",
                    Gender = new Gender(){Id=2, Sex= Sex.Female},
                    Department = new Department(){Id=2, Dept = Dept.HR},
                    Salary = 1500
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Sam",
                    Email = "sam@gmail.com",
                    Gender = new Gender(){Id=3, Sex= Sex.Male},
                    Department = new Department(){Id=1,Dept = Dept.Finance},
                    Salary = 3400
                },
                new Employee()
                {
                    Id = 6,
                    Name = "Alicia",
                    Email = "alicia@gmail.com",
                    Gender = new Gender(){Id=2, Sex= Sex.Female},
                    Department = new Department(){Id=1, Dept= Dept.IT},
                    Salary = 2500
                }
            };
        }

        public Employee AddNewEmployee(Employee newEmployee)
        {
            newEmployee.Id = _listOfEmployeesObjects.Max((emp) => emp.Id) + 1;
            _listOfEmployeesObjects.Add(newEmployee);
            return newEmployee;
        }

        public Employee DeleteExistingEmployee(int id)
        {
            Employee employee = _listOfEmployeesObjects.FirstOrDefault((emp) => emp.Id == id);
            if(employee != null)
            {
                _listOfEmployeesObjects.Remove(employee);
            }

            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            return _listOfEmployeesObjects.FirstOrDefault((emp) => emp.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _listOfEmployeesObjects;
        }

        public Employee UpdateExistingEmployee(Employee employeeChanges)
        {
            Employee employee = _listOfEmployeesObjects.FirstOrDefault((emp) => emp.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Salary = employeeChanges.Salary;
                employee.Gender.Sex = employeeChanges.Gender.Sex;
                employee.Department = new Department() { Id = employeeChanges.Id, Dept = employeeChanges.Department.Dept };
            }
            return employee;
        }
    }
}
