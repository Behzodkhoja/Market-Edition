namespace Market.Service.DTOs
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
