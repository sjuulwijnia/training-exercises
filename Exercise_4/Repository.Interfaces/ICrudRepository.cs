using System.Linq;

namespace Repository.Interfaces
{
    public interface ICrudRepository<T> where T : class, new()
    {
        IQueryable<T> Get();
        T GetById(int id);
        bool Insert(T inserted);
        bool Update(T updated);
        bool Delete(int id);
    }
}
