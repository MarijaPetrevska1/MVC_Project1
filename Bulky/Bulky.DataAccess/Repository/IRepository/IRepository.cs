using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        // Generic Repository
        // all of the methods we want to have here
        // T - Category
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity); // we pass the objects that needs to be added
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
}
