using System;

class Fees
{
    static void Main(string[] args)
    {
        Console.Write("Enter the student fee (INR): ");
		int studentFee = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the discount rate: ");
        double discountRate = double.Parse(Console.ReadLine());   // 10% discount

        double discountAmount = studentFee * discountRate;
        double finalFee = studentFee - discountAmount;

        Console.WriteLine("The discount amount is INR: " + discountAmount);
        Console.WriteLine("Final discounted fee is INR: " + finalFee);
    }
}

