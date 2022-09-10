public class MediatrCrqsController : BaseController
{
    private readonly IMediator _mediator;

    public MediatrCrqsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetByFilterQueryRequest getByFilterQueryRequest)
    {
        var filteredProducts = await _mediator.Send(getByFilterQueryRequest);
        return Ok(filteredProducts);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest createProductCommandRequest)
    {
        var createdProductCommandResponse = await _mediator.Send(createProductCommandRequest);
        return Ok(createdProductCommandResponse);
    }
}