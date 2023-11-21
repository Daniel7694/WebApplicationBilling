using System.Collections;

namespace WebApplicationBilling.Reposiroty.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable> GetAllAsync(string url);

        Task<T> GetByIdAsync(string Url, int id);

        Task<bool> PostAsync(string Url, T entity);

        Task<bool> UpdateAsync(string Url, T entity);

        Task<bool> DeleteAsync(string Url, int id);
    }
}
