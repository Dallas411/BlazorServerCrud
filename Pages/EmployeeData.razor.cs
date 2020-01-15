﻿using BlazorServerCrud.Models;
using BlazorServerCrud.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCrud.Pages
{
    public partial class EmployeeData : ComponentBase
    {
        [Inject]
        protected EmployeeService employeeService { get; set; }
        protected Employee employee = new Employee();
        protected List<Employee> empList;
        protected List<Cities> cityList = new List<Cities>();
        protected Employee emp = new Employee();
        protected string modalTitle { get; set; }
        protected Boolean isDelete = false;
        protected Boolean isAdd = false;

        protected string SearchString { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetCities();
            await GetEmployee();
        }

        protected async Task GetCities()
        {
            cityList = await employeeService.GetCities();
        }

        protected async Task GetEmployee()
        {
            empList = await employeeService.GetEmployeeList();
        }

        protected async Task FilterEmp()
        {
            await GetEmployee();
            if (SearchString != "")
            {
                empList = empList.Where(x => x.Name.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
        }

        protected void AddEmp()
        {
            emp = new Employee();
            this.modalTitle = "Add Employee";
            this.isAdd = true;
        }

        protected async Task EditEmployee(int empID)
        {
            emp = await employeeService.Details(empID);
            this.modalTitle = "Edit Employee";
            this.isAdd = true;
        }

        protected async Task SaveEmployee()
        {
            if (emp.EmployeeId != 0)
            {
                await Task.Run(() =>
                {
                    employeeService.Edit(emp);
                });
            }
            else
            {
                await Task.Run(() =>
                {
                    employeeService.Create(emp);
                });
            }
            this.isAdd = false;
            await GetEmployee();
        }

        protected async Task DeleteConfirm(int empID)
        {
            emp = await employeeService.Details(empID);
            this.isDelete = true;
        }

        protected async Task DeleteEmployee(int empID)
        {
            await Task.Run(() =>
            {
                employeeService.Delete(empID);
            });
            this.isDelete = false;
            await GetEmployee();
        }
        protected void closeModal()
        {
            this.isAdd = false;
            this.isDelete = false;
        }

        protected async Task HandleValidSubmit()
        {
            await SaveEmployee();
        }
    }
}
