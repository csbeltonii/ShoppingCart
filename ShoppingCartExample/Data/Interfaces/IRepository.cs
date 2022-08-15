namespace ShoppingCartExample.Data.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> Get(string id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
