public class GetByFilterQueryRequest : IRequest<IEnumerable<GetByFilterQueryResponse>>
{
    public int CategoryId { get; set; }
}