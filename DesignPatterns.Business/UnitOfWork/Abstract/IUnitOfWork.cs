public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; set; }
    int SaveChanges();
}