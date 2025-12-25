using System;

class GeometryCalculator{
    static void Main(string[] args){
		
        //user input for first
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        //user input for second
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        //calculate Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance between the points: " + distance);

        //calculate equation of line
        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine("Slope (m): " + lineEquation[0]);
        Console.WriteLine("Y-Intercept (b): " + lineEquation[1]);
        Console.WriteLine("Equation of the line: y = " + lineEquation[0] + "x + " + lineEquation[1]);
    }

    //method to calculate Euclidean distance
    public static double CalculateDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    //method to find equation of line 
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2){
        double m = (y2 - y1) / (x2 - x1);   // slope
        double b = y1 - (m * x1);           // y-intercept

        return new double[] { m, b };
    }
}
