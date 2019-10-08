using BlazorServerCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCrud.Infrastructures
{
    public class EmployeeDataAccessLayer : IEmployeeDataAccessLayer
    {
        //SampleContext db = new SampleContext();

        private readonly SampleContext db;

        public EmployeeDataAccessLayer(SampleContext db)
        {
            this.db = db;
        }

        //To Get all employees details     
        public List<Employee> GetAllEmployees()
        {
            try
            {
                return db.Employee.AsNoTracking().ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record       
        public void AddEmployee(Employee employee)
        {
            try
            {
                db.Employee.Add(employee);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee      
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee      
        public Employee GetEmployeeData(int id)
        {
            try
            {
                var employee = db.Employee.Find(id);
                db.Entry(employee).State = EntityState.Detached;
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee      
        public void DeleteEmployee(int id)
        {
            try
            {
                Employee emp = db.Employee.Find(id);
                db.Employee.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // To get the list of Cities
        public List<Cities> GetCityData()
        {
            try
            {
                return db.Cities.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
