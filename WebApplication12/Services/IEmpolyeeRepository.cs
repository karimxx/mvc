using WebApplication12.Models;

namespace WebApplication12.Services
{
    public interface IEmpolyeeRepository
    {
        IEnumerable<Employee> GetALL();
        Employee Details(int id);
        void Add(Employee emp);
        void Delete(int id);
        void Update(Employee emp);
        void Save();

    }
}
