using System;

class ChocolateDistribution{
    static void Main(string[] args){
        int numberOfChocolates = int.Parse(Console.ReadLine());
        int numberOfChildren = int.Parse(Console.ReadLine());

        int eachStudent = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets is " + eachStudent);
		Console.WriteLine("number of remaining chocolates: " + remainingChocolates);
    }
}
