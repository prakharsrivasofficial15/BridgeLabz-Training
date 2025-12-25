using System;

class Quadratic{
    static void Main(string[] args){
		
        //user input
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        //method for find roots
        double[] roots = FindRoots(a, b, c);

        if(roots.Length == 0){
            Console.WriteLine("No real roots (delta negative)");
        }
        else if(roots.Length == 1){
            Console.WriteLine("Only one root: " + roots[0]);
        }
        else{
            Console.WriteLine("Root 1: " + roots[0]);
            Console.WriteLine("Root 2: " + roots[1]);
        }
    }

    // Method to find roots
    public static double[] FindRoots(double a, double b, double c){
        // Calculate delta
        double delta = Math.Pow(b, 2) - 4 * a * c;

        // If delta is negative
        if(delta < 0){
            return new double[0];
        }
        // If delta is zero
        if(delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }
		
        // If delta is positive
        double sqrtDelta = Math.Sqrt(delta);

        double root1 = (-b + sqrtDelta) / (2 * a);
        double root2 = (-b - sqrtDelta) / (2 * a);

        return new double[] { root1, root2 };
    }
}
