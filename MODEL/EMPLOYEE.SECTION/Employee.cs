using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.EMPLOYEE.SECTION
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName {get;set;}
        //public string? MiddleName {get;set;}
        //public string? LastName {get;set;}
        public DateTime DOB { get;set;}
        #region Navigation


        #endregion Navigation
    }
}
