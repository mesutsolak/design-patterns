﻿public class GetAllProductQueryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreateTime { get; set; }
    public int TotalCount { get; set; }
}