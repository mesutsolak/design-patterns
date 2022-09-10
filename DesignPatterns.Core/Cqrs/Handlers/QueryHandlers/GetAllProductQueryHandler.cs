public class GetAllProductQueryHandler
{
    private readonly IUnitOfWork _unitOfWork;
    public GetAllProductQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IEnumerable<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
    {
        var products = _unitOfWork.ProductRepository.GetAll();
        return products.Select(product => new GetAllProductQueryResponse
        {
            Id = product.Id,
            Name = product.Name,
            CategoryId = product.CategoryId,
            Description = product.Description
        });
    }
}