using CsBases.fundamentals;
using CsBases.fundamentals._03_AdapterPattern;
using CsBases.fundamentals._04_DependencyInjection;
using CsBases.fundamentals._05_AsyncMethods;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Creating Product Object
        var laptop = new Product("Asus TUF Gaming A15", 3500000);
        WriteLine(laptop.GetDescription());

        // Creating ServiceProduct Object
        var support = new ServiceProduct("Technical Support", 50000, 30);
        WriteLine(support.GetDescription());

        // Creating Product Object (Adapter Pattern)
        var mouse = new Product("Mouse Gamer", 200000);
        var mouseDto = ProductAdapter.ToDto(mouse);
        WriteLine($"\n{mouseDto.Name} - ${mouseDto.Price} - Code: {mouseDto.Code}");

        // dependency injection
        ILabelService labelService = new LabelService();
        var managerMonitor = new ProductManager(labelService);

        var monitor = new Product("Samsung Monitor 32'", 1000000);
        var instalation = new ServiceProduct("Monitor Instalation", 56000, 30);

        managerMonitor.PrintLabel(monitor);
        managerMonitor.PrintLabel(instalation);

        // Sync methods
        var firstProduct = new ProductRepository().GetProduct(1);
        WriteLine($"\n{firstProduct.Name} - Price: ${firstProduct.Price}");

        // Async methods
        var secondProduct = await new ProductRepository().GetProductAsync(1);
        WriteLine($"\n{secondProduct.Name} - Price: ${secondProduct.Price}");

    }
}
