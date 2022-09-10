public class GetByFilterQueryHandler : IRequestHandler<GetByFilterQueryRequest, IEnumerable<GetByFilterQueryResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    public GetByFilterQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<GetByFilterQueryResponse>> Handle(GetByFilterQueryRequest getByFilterQueryRequest, CancellationToken cancellationToken)
    {
        var filteredProducts = _unitOfWork.ProductRepository.GetFilter(product => product.CategoryId == getByFilterQueryRequest.CategoryId);

        return await Task.FromResult(filteredProducts.Select(filteredProduct => new GetByFilterQueryResponse
        {
            Description = filteredProduct.Description,
            Id = filteredProduct.Id,
            Name = filteredProduct.Name
        }));
    }
}