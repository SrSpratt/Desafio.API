namespace Desafio.API.AbstractModels
{
    public interface IRepository<T> where T : class, IEntity
    {
        //operações que devem existir no repositório de dados
        Task<List<T>> GetAll();
        Task<T> Get(int id);

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);
    }
}
