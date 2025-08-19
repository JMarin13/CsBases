class Program
{
    static void Main()
    {
        /*
         * Data types
        */

        // Explicit types
        string description = "Rice";
        int quantity = 2;
        double price = 5500;

        WriteLine($"Product: {description} \nQuantity: {quantity} \nPrice: ${price}");

        // Var types
        var name = "Johny Marin";
        var age = 26;
        var isHappy = true;

        WriteLine($"\nName: {name} \nAge: {age} \nIs Happy: {isHappy}");
    }
}
