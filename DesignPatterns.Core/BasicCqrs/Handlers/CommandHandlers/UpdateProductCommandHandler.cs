public class UpdateProductCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;
    public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public UpdateProductCommandResponse UpdateProduct(UpdateProductCommandRequest updateProductCommandRequest)
    {
        _unitOfWork.ProductRepository.Update(new Product
        {
            CategoryId = updateProductCommandRequest.CategoryId,
            Id = updateProductCommandRequest.Id,
            Description = updateProductCommandRequest.Description,
            Name = updateProductCommandRequest.Name
        });

        var affectedLine = _unitOfWork.SaveChanges();

        return new UpdateProductCommandResponse
        {
            IsSuccess = affectedLine > 0,
        };
    }
}