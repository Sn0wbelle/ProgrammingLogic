using System;

class Program
{
    static void Main()
    {
        string item_name;
        int quantity;
        double unit_price, total_price;

        Console.Write("Enter name of item: ");
        item_name = Console.ReadLine();

        Console.Write("Enter quantity of item: ");
        quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter unit price of item: ");
        unit_price = double.Parse(Console.ReadLine());

        total_price = quantity * unit_price;

        total_price = total_price + (total_price * 0.07);

        Console.WriteLine("\nItem Summary:");
        Console.WriteLine("Name of item: " + item_name);
        Console.WriteLine("Quantity of item: " + quantity);
        Console.WriteLine("Unit price of item: " + unit_price.ToString("C"));
        Console.WriteLine("Total price of item (after tax): " + total_price.ToString("C"));
    }
}
