using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerCrud.Models;

namespace BlazorServerCrud.Services
{
    public interface IEmployeeService
    {
        void Create(Employee employee);
        void Delete(int id);
        Task<Employee> Details(int id);
        void Edit(Employee employee);
        Task<List<Cities>> GetCities();
        Task<List<Employee>> GetEmployeeList();
    }
}