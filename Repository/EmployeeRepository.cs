using Emp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Emp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public AppDbContext db;
        public EmployeeRepository(AppDbContext _db)
        {
            db = _db;
        }
        public Employee Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            var emp = db.Employees.Find(id);
            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();

            }
            return emp;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return db.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return db.Employees.Find(id);

        }

        public Employee Update(Employee employee)
        {
            var emp = db.Employees.Attach(employee);
            emp.State = EntityState.Modified;
            db.SaveChanges();
            return employee;
        }
    }
}
