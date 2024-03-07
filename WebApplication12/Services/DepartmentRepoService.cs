using Microsoft.EntityFrameworkCore;
using WebApplication12.Data;
using WebApplication12.Models;

namespace WebApplication12.Services
{
    public class DepartmentRepoService : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;
    
        public DepartmentRepoService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> GetALL()
        {
            return context.Departments.ToList();
        }

        public Department Details(int id)
        {
            return context.Departments.Find(id);
        }

        public void Add(Department Department)
        {
            context.Departments.Add(Department);
        }

        public void Delete(int DepartmentID)
        {
            Department Department = context.Departments.Find(DepartmentID);
            context.Departments.Remove(Department);
            context.SaveChanges();
        }

        public void Update(Department Department)
        {
            context.Entry(Department).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
