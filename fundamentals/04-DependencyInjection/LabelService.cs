using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._04_DependencyInjection
{
    public class LabelService : ILabelService
    {
        public string GenerateLabel(Product product)
        {
            return $"{product.Name} - Price: ${product.Price} - Code: {product.GetType().Name}-{product.GetHashCode()}";
        }
    }
}
