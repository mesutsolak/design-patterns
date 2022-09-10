public sealed class BasicCqrsController : BaseController
{
    AddProductCommandHandler _addProductCommandHandler;
    RemoveProductCommandHandler _removeProductCommandHandler;
    UpdateProductCommandHandler _updateProductCommandHandler;
    GetAllProductQueryHandler _getAllProductQueryHandler;
    GetByIdProductQueryHandler _getByIdProductQueryHandler;

    public BasicCqrsController(
        AddProductCommandHandler addProductCommandHandler,
        RemoveProductCommandHandler removeProductCommandHandler,
        UpdateProductCommandHandler updateProductCommandHandler,
        GetAllProductQueryHandler getAllProductQueryHandler,
        GetByIdProductQueryHandler getByIdProductQueryHandler)
    {
        _addProductCommandHandler = addProductCommandHandler;
        _removeProductCommandHandler = removeProductCommandHandler;
        _updateProductCommandHandler = updateProductCommandHandler;
        _getAllProductQueryHandler = getAllProductQueryHandler;
        _getByIdProductQueryHandler = getByIdProductQueryHandler;
    }

    [HttpGet]
    public IActionResult Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
    {
        var allProducts = _getAllProductQueryHandler.GetAllProduct(getAllProductQueryRequest);
        return Ok(allProducts);
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromQuery] GetByIdProductQueryRequest getByIdProductQueryRequest)
    {
        GetByIdProductQueryResponse product = _getByIdProductQueryHandler.GetByIdProduct(getByIdProductQueryRequest);
        return Ok(product);
    }

    [HttpPost]
    public IActionResult Post([FromBody] AddProductCommandRequest addProductCommandRequest)
    {
        var addProductCommandResponse = _addProductCommandHandler.AddProduct(addProductCommandRequest);
        return Ok(addProductCommandResponse);
    }

    [HttpPut]
    public IActionResult Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
    {
        var updateProductCommandResponse = _updateProductCommandHandler.UpdateProduct(updateProductCommandRequest);
        return Ok(updateProductCommandResponse);
    }

    [HttpDelete("{id}")]
    public IActionResult Remove([FromQuery] RemoveProductCommandRequest removeProductCommandRequest)
    {
        var removeProductCommandResponse = _removeProductCommandHandler.RemoveProduct(removeProductCommandRequest);
        return Ok(removeProductCommandResponse);
    }
}