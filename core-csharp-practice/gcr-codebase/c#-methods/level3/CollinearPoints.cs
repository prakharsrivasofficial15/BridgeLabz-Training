using System;

class CollinearPoints{
    static void Main(string[] args){
        
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        Console.WriteLine("Points:");
        Console.WriteLine("A (" + x1 + ", " + y1 + ")");
        Console.WriteLine("B (" + x2 + ", " + y2 + ")");
        Console.WriteLine("C (" + x3 + ", " + y3 + ")");

        // Check using slope formula
        bool slopeResult = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);

        // Check using area
        bool areaResult = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Using Slope Formula: " + (slopeResult ? "Points are Collinear" : "Points are NOT Collinear"));

        Console.WriteLine("Using Area of Triangle Formula: " + (areaResult ? "Points are Collinear" : "Points are NOT Collinear"));
    }

    //Method to check collinearity using slope formula
    public static bool AreCollinearUsingSlope(double x1, double y1,double x2, double y2,double x3, double y3){
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    //method to check collinearity using area of triangle
    public static bool AreCollinearUsingArea(double x1, double y1,double x2, double y2, double x3, double y3){
        double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}
