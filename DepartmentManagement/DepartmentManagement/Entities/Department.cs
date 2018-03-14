using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Entities
{
    public class Department
    {
        public string DName { get; set; }
        public int DNumber { get; set; }
        public decimal MgrSSN { get; set; }
        public DateTime MgrStartDate { get; set; }
    }
}
