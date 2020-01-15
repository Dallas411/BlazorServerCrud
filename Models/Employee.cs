using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerCrud.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }

        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}
