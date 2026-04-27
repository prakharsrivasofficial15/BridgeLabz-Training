using System;

class PurchasePrice
{
    static void Main()
    {
        Console.Write("Enter unit price in INR: ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR: " + totalPrice);
		Console.WriteLine("Quantity: " + quantity);
		Console.WriteLine("Unit price is INR: " + unitPrice);
    }
}
