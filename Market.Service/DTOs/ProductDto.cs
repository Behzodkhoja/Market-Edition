using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
