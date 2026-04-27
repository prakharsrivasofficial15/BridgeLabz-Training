using System;

class FriendsComparison{
    static void Main(string[] args){
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height(cm): ");
        int amarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height(cm): ");
        int akbarHeight = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height(cm): ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Youngest
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        if (youngestAge == amarAge)
            Console.WriteLine("Youngest friend: Amar");
        else if (youngestAge == akbarAge)
            Console.WriteLine("Youngest friend: Akbar");
        else
            Console.WriteLine("Youngest friend: Anthony");

        // Tallest
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        if (tallestHeight == amarHeight)
            Console.WriteLine("Tallest friend: Amar");
        else if (tallestHeight == akbarHeight)
            Console.WriteLine("Tallest friend: Akbar");
        else
            Console.WriteLine("Tallest friend: Anthony");
    }
}
