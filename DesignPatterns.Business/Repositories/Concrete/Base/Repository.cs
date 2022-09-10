public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
{
    public void Add(TEntity entity)
    {

    }

    public TEntity Get(int id)
    {
        return new TEntity();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return Enumerable.Empty<TEntity>();
    }

    public void Remove(int id)
    {

    }

    public void Update(TEntity entity)
    {

    }
}