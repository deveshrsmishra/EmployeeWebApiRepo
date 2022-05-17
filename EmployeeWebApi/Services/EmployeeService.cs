using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Models;

namespace EmployeeWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        public static readonly List<Employee> employees = new List<Employee>()
      {
          new Employee{EmployeeId = "01" , EmployeeName = "devesh", EmployeeGender = "M", EmployeeEmail = "devesh@gmail.com", EmployeeContact = 9988776655, EmployeeUsername = "Devesh", EmployeePassword = "devesh@123"},
          new Employee {EmployeeId = "02" , EmployeeName = "Anis", EmployeeGender = "M", EmployeeEmail = "anis@gmail.com", EmployeeContact = 9988446633, EmployeeUsername = "Anis", EmployeePassword = "Anis@123"}

      };



        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return employees;
        }

        public async Task<Employee> GetEmployeeById(string employeeId)
        {
            return employees.FirstOrDefault(a => a.EmployeeId == employeeId);
        }

        public async Task<Employee> CreateEmployee(Employee employeeObj)
        {


            employees.Add(employeeObj);

            return employeeObj;
        }

        public async Task<Employee> DeleteEmployee(string employeeId)
        {
            var result = employees.FirstOrDefault(a => a.EmployeeId == employeeId);
            if (result != null)
            {
                employees.Remove(result);

            }
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employeeObj)
        {
            var result = employees.FirstOrDefault(a => a.EmployeeId == employeeObj.EmployeeId);

            if (result != null)
            {
                result.EmployeeName = employeeObj.EmployeeName;
                result.EmployeeGender = employeeObj.EmployeeGender;
                result.EmployeeEmail = employeeObj.EmployeeEmail;
                result.EmployeeContact = employeeObj.EmployeeContact;
                result.EmployeeUsername = employeeObj.EmployeeUsername;
                result.EmployeePassword = employeeObj.EmployeePassword;

                return result;
            }
            return null;
        }
    }
}
