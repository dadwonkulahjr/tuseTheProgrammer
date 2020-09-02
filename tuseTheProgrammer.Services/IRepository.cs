using System;
using System.Collections.Generic;
using tuseTheProgrammer.Models;

namespace tuseTheProgrammer.Services
{
    public interface IRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        Employee UpdateExistingEmployee(Employee employeeChanges);
        Employee DeleteExistingEmployee(int id);
        Employee AddNewEmployee(Employee newEmployee);
    }
}
