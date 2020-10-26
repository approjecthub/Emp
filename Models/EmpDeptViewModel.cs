using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Models
{
    public class EmpDeptViewModel
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public int DId { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public Department Department { get; set; }
        public EmpDeptViewModel()
        {
            Id = 0;
        }
        public EmpDeptViewModel(Employee employee)
        {
            Id = employee.Id;
            EName = employee.EName;
            DId = employee.DId;
        }
    }
}
