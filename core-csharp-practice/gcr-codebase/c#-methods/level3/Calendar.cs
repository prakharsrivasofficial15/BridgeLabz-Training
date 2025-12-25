using System;

class Calendar{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DisplayCalendar(month, year);
    }

    //method to get the name od the month
    public static string GetMonthName(int month){
        string[] months ={"January", "February", "March", "April","May", "June", "July", "August","September", "October", "November", "December"};
        return months[month - 1];
    }

    //method to check leap year
    public static bool IsLeapYear(int year){
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    //Method to get number of days in a month
    public static int GetDaysInMonth(int month, int year){
        int[] daysInMonth ={31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        if (month == 2 && IsLeapYear(year))
            return 29;

        return daysInMonth[month - 1];
    }

    //Method to get first day of the month
    public static int GetFirstDay(int month, int year){
        int d = 1;
        int m = month;
        int y = year;

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        return d0;
    }

    //Method to display the calendar
    public static void DisplayCalendar(int month, int year){
        Console.WriteLine(GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int daysInMonth = GetDaysInMonth(month, year);

        //Print initial spaces
        for(int i = 0; i < firstDay; i++){
            Console.Write("    ");
        }

        //Print days of the month
        for(int day = 1; day <= daysInMonth; day++){
            Console.Write("{0,3} ", day);

            // Move to next line after Saturday
            if ((day + firstDay) % 7 == 0){
                Console.WriteLine();
			}
        }

        Console.WriteLine();
    }
}
