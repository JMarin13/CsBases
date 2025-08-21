using CsBases.fundamentals;

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
    }
}
