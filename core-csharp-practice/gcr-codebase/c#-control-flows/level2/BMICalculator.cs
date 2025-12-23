using System;

class BMICalculator{
    static void Main(string[] args){
	
        Console.Write("Enter weight(kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height(cm): ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine("BMI: " + bmi);

        if (bmi <= 18.4)
            Console.WriteLine("Underweight");
        else if (bmi <= 24.9)
            Console.WriteLine("Normal");
        else if (bmi <= 39.9)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
