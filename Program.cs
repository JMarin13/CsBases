using CsBases.fundamentals;
using CsBases.fundamentals._03_AdapterPattern;
using CsBases.fundamentals._04_DependencyInjection;

class Program
{
    static void Main()
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

    }
}
