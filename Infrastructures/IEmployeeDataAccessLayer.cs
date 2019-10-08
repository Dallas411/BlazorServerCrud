using System.Collections.Generic;
using BlazorServerCrud.Models;

namespace BlazorServerCrud.Infrastructures
{
    public interface IEmployeeDataAccessLayer
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        List<Cities> GetCityData();
        Employee GetEmployeeData(int id);
        void UpdateEmployee(Employee employee);
    }
}