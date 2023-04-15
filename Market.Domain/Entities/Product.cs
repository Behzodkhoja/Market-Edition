using Market.Domain.Commons;

namespace Market.Domain.Entities
{
    public class Product : Auditable
    {
        public string FullName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
