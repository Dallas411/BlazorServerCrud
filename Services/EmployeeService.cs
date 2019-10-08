using BlazorServerCrud.Infrastructures;
using BlazorServerCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCrud.Services
{
    public class EmployeeService : IEmployeeService
    {

        //EmployeeDataAccessLayer employeeDal = new EmployeeDataAccessLayer();

        private readonly EmployeeDataAccessLayer employeeDal;

        public EmployeeService(EmployeeDataAccessLayer employeeDal)
        {
            this.employeeDal = employeeDal;
        }
        public Task<List<Employee>> GetEmployeeList()
        {
            return Task.FromResult(employeeDal.GetAllEmployees());
        }

        public void Create(Employee employee)
        {
            employeeDal.AddEmployee(employee);
        }
        public Task<Employee> Details(int id)
        {
            return Task.FromResult(employeeDal.GetEmployeeData(id));
        }

        public void Edit(Employee employee)
        {
            employeeDal.UpdateEmployee(employee);
        }
        public void Delete(int id)
        {
            employeeDal.DeleteEmployee(id);
        }
        public Task<List<Cities>> GetCities()
        {
            return Task.FromResult(employeeDal.GetCityData());
        }
    }
}
