public class GetByIdProductQueryHandler
{
    private readonly IUnitOfWork _unitOfWork;
    public GetByIdProductQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
    {
        var product = _unitOfWork.ProductRepository.Get(getByIdProductQueryRequest.Id);
        return new GetByIdProductQueryResponse
        {
            Id = product.Id,
            Name = product.Name,
            CategoryId = product.CategoryId,
            Description = product.Description
        };
    }
}