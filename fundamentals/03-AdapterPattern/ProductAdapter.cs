using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._03_AdapterPattern
{
    public class ProductAdapter
    {
        public static ProductDto ToDto(Product product)
        {
            ProductDto productDto = new ProductDto
            {
                Name = product.Name ?? "Without name",
                Price = product.Price,
                Code = $"{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
            };

            return productDto;
        }
    }
}
