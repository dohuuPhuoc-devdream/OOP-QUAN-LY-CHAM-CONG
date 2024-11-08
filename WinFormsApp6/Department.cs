using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Department
    {
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department(string departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }
    }

}
