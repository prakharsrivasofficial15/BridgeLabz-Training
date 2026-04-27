using System;

class Fees
{
    static void Main(string[] args)
    {
        int studentFee = 125000;
        double discountRate = 0.10;   // 10% discount

        double discountAmount = studentFee * discountRate;
        double finalFee = studentFee - discountAmount;

        Console.WriteLine("The discount amount is INR: " + discountAmount);
        Console.WriteLine("Final discounted fee is INR: " + finalFee);
    }
}
