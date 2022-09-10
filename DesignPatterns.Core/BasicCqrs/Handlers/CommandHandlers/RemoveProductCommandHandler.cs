public class RemoveProductCommandHandler
{
    private readonly IUnitOfWork _unitOfWork;
    public RemoveProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public RemoveProductCommandResponse RemoveProduct(RemoveProductCommandRequest removeProductCommandRequest)
    {
        _unitOfWork.ProductRepository.Remove(removeProductCommandRequest.Id);

        var affectedLine = _unitOfWork.SaveChanges();

        return new RemoveProductCommandResponse
        {
            IsSuccess = affectedLine > 0,
        };
    }
}