using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.EMPLOYEE.SECTION
{
    public class Designation
    {
        public int DesignationId { get; set; }
        public string? DepartmentName { get; set; }


        #region Navigation
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        #endregion Navigation
    }
}
