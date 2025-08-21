using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._04_DependencyInjection
{
    public class ProductManager
    {
        private readonly ILabelService _labelService;

        public ProductManager(ILabelService labelService)
        {
            _labelService = labelService;
        }

        public void PrintLabel(Product product)
        {
            WriteLine("\n" + _labelService.GenerateLabel(product));
        }
    }
}
