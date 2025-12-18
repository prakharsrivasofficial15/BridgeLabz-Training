using System;

class Perimeter
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int peri = 2 * (m + n);

        Console.WriteLine(peri);
    }
}
