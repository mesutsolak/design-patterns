public interface IRepository<TEntity>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(int id);
    IEnumerable<TEntity> GetAll();
    TEntity Get(int id);
}