using System;

class Income{
    static void Main(string[] args){
        double salary = double.Parse(Console.ReadLine());
        double bonus = double.Parse(Console.ReadLine());

        double totalIncome = salary + bonus;

        Console.WriteLine("Total Income is INR: " + totalIncome);
    }
}
