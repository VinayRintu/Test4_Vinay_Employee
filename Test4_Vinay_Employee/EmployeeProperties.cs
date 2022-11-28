using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Vinay_Employee
{
    internal class EmployeeProperties
    {        


        public int EmpID { get; set; }
        public string? EmpName { get; set; }
        public int EmpAge { get; set; }
        public char EmpGender { get; set; }
        public int DeptID { get; set; }
    }
}
