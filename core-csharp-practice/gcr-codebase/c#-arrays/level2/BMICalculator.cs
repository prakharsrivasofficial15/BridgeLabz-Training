using System;

class BMICalculator{
    static void Main(string[] args){
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        //Input height and weight
        for (int i=0; i<n; i++){
            weight[i] = double.Parse(Console.ReadLine());   //enter weight in kg
            height[i] = double.Parse(Console.ReadLine());   //enter height 
        }

        for (int i=0; i<n; i++){
            double heightMeters = height[i] / 100;
            bmi[i] = weight[i] / (heightMeters * heightMeters); //calculate BMI

            if (bmi[i] <= 18.4)
                status[i] = "Underweight";
            else if (bmi[i] <= 24.9)
                status[i] = "Normal";
            else if (bmi[i] <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        for (int i=0; i<n; i++){
            Console.WriteLine("Height (cm): " + height[i]);
            Console.WriteLine("Weight (kg): " + weight[i]);
            Console.WriteLine("BMI: " + bmi[i]);
            Console.WriteLine("Status: " + status[i]);
        }
    }
}
