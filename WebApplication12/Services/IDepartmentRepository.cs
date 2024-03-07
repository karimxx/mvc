using WebApplication12.Models;

namespace WebApplication12.Services
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetALL();
        Department Details(int id);
        void Add(Department dep);
        void Delete(int id);
        void Update(Department dep);
        void Save();
    }
}
