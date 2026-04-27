using System;

class LeapYear{
    static void Main(string[] args){
	
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582){
            Console.WriteLine("Year should be 1582 or later in the Gregorian Calendar.");
        }
        else{
            if (year % 400 == 0)
            {
                Console.WriteLine("The Year is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The Year is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("The Year is a Leap Year");
            }
            else
            {
                Console.WriteLine("The Year is not a Leap Year");
            }
        }
    }
}
