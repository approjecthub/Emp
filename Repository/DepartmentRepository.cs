using Emp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public AppDbContext db;
        public DepartmentRepository(AppDbContext _db)
        {
            db = _db;
        }

        public Department Add(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return department;
        }

        public Department Delete(int id)
        {
            var dep = db.Departments.Find(id);
            if (dep != null)
            {
                db.Departments.Remove(dep);
                db.SaveChanges();

            }
            return dep;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return db.Departments;
        }

        public Department GetDepartment(int id)
        {
            return db.Departments.Find(id);
        }

        public Department Update(Department department)
        {
            var dep = db.Departments.Attach(department);
            dep.State = EntityState.Modified;
            db.SaveChanges();
            return department;
        }
    }
}
