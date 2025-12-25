using System;

class TrigonometryCal{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        //Calling method
        double[] result = CalculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine value: " + result[0]);
        Console.WriteLine("Cosine value: " + result[1]);
        Console.WriteLine("Tangent value: " + result[2]);
    }

    // Method 
    public static double[] CalculateTrigonometricFunctions(double angle){
        
		//converting degrees to radians
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
