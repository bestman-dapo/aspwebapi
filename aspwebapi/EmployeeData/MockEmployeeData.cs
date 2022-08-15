using aspwebapi.Models;
using System;
using System.Collections.Generic;

namespace aspwebapi.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee one",
                Age = 21
            },

            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee two",
                Age = 20
            },
        };

        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee UppdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
