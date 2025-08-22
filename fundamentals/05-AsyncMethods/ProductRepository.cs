using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBases.fundamentals._05_AsyncMethods
{
    public class ProductRepository
    {
        public Product GetProduct(int id)
        {
            Product product = new Product("Simulated Product", 250000);

            return product;
        }

        public async Task<Product> GetProductAsync(int id)
        {
            WriteLine("\nSearching product...");
            await Task.Delay(2000);

            return new Product("Simulated product 2", 255000);
        }
    }
}
