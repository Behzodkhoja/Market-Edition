using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Service.DTOs
{
    public class ProductCreationDto
    {
        public string FullName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
