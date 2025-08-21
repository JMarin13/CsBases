using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._03_AdapterPattern
{
    public class ProductDto
    { 
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Code { get; set; } = string.Empty;
    }
}
