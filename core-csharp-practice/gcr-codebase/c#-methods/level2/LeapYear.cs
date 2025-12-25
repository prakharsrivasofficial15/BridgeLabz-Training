using System;

class LeapYear{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        //check Gregorian calendar condition
        if (year < 1582){
            Console.WriteLine("Year should be 1582 or later");
            return;
        }

        //calling method to check leap year
        bool isLeap = IsLeapYear(year);

        if (isLeap)
            Console.WriteLine("Year is a Leap Year");
        else
            Console.WriteLine("Year is not a Leap Year");
    }

    // Method
    public static bool IsLeapYear(int year){
        if(year % 400 == 0){
            return true;
		}
        else if(year % 100 == 0){
            return false;
		}
        else if(year % 4 == 0){
            return true;
		}
        else{
            return false;
		}
    }
}
