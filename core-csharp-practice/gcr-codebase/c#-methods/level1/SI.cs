using System;

class SI{
    static void Main(string[] args){
	
        // user inputs
        Console.Write("Enter the Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time: ");
        double time = double.Parse(Console.ReadLine());

        // Calling method
        double simpleInterest = CalculateSI(principal, rate, time);

        Console.WriteLine("The Simple Interest is " + simpleInterest +" for Principal " + principal +", Rate of Interest " + rate +" and Time " + time);
    }

    // Method
    static double CalculateSI(double principal, double rate, double time){
        return (principal * rate * time) / 100;
    }
}
