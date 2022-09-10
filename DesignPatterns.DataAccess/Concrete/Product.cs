public sealed class Product : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
}