public sealed class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IProductRepository productRepository)
    {
        ProductRepository = productRepository;
    }

    public IProductRepository ProductRepository { get; set; }

    public int SaveChanges()
    {
        return 1;
    }
}