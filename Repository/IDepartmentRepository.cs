using Emp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Repository
{
    interface IDepartmentRepository
    {
        Department GetDepartment(int id);
        IEnumerable<Department> GetAllDepartment();
        Department Add(Department department);
        Department Update(Department department);
        Department Delete(int id);
    }
}
