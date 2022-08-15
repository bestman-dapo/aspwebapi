using System.Collections.Generic;
using aspwebapi.Models;
using System;
 
namespace aspwebapi.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();
         
        Employee GetEmployee(Guid id);

        Employee UppdateEmployee(Employee employee);

        Employee AddEmployee(Employee employee);

        Employee DeleteEmployee(Employee employee);
    }
}
