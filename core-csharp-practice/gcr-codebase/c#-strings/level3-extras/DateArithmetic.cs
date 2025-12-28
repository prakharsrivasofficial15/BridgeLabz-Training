using System;

class DateArithmetic{
    static void Main(){
        Console.Write("Enter a date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime result = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);   // 3 weeks

        Console.WriteLine("Final Date: " + result.ToShortDateString());
    }
}
