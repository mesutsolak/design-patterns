public class AddProductCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;
    public AddProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public AddProductCommandResponse AddProduct(AddProductCommandRequest addProductCommandRequest)
    {
        Product product = new()
        {
            CategoryId = addProductCommandRequest.CategoryId,
            Description = addProductCommandRequest.Description,
            Name = addProductCommandRequest.Name
        };

        _unitOfWork.ProductRepository.Add(product);

        var affectedLine = _unitOfWork.SaveChanges();

        return new AddProductCommandResponse
        {
            IsSuccess = affectedLine > 0,
            ProductId = affectedLine > 0 ? product.Id : 0
        };
    }
}