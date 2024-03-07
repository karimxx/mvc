using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication12.Data;
using WebApplication12.Models;

namespace WebApplication12.Services
{
    public class EmpolyeeRepoService : IEmpolyeeRepository
    {
        private readonly ApplicationDbContext context;
        public EmpolyeeRepoService(ApplicationDbContext context ) 
        { 
        this.context = context;
        }
        public IEnumerable<Employee> GetALL()
        {
            return context.Employees.ToList();
        }

        public Employee Details(int id)
        {
            return context.Employees.Find(id);
        }

        public void Add(Employee Employee)
        {
            context.Employees.Add(Employee);
        }

        public void Delete(int EmployeeID)
        {
            Employee Employee = context.Employees.Find(EmployeeID);
            context.Employees.Remove(Employee);
        }

        public void Update(Employee Employee)
        {
            context.Entry(Employee).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }


    }
}
