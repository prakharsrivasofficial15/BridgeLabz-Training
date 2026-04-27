using System;

class Gcd{
    static int GCD(int a, int b){
        while(b != 0){
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static int LCM(int a, int b){
        return (a * b) / GCD(a, b);
    }

    static void Main(){
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(a, b));
        Console.WriteLine("LCM: " + LCM(a, b));
    }
}
