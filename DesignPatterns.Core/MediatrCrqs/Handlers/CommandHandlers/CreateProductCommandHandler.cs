public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest createProductCommandRequest, CancellationToken cancellationToken)
    {
        Product product = new()
        {
            CategoryId = createProductCommandRequest.CategoryId,
            Description = createProductCommandRequest.Description,
            Name = createProductCommandRequest.Name,
        };

        _unitOfWork.ProductRepository.Add(product);
        var affectedLine = _unitOfWork.SaveChanges();

        return Task.FromResult(new CreateProductCommandResponse
        {
            IsSuccess = affectedLine > 0,
            ProductId = product.Id
        });
    }
}