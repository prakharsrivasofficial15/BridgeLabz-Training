using System;

class SpringSeason{
    static void Main(string[] args){
        
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        // Check if it is Spring season
        bool isSpring = CheckSpring(month, day);

        if (isSpring)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    // Method to check Spring Season: March 20 to June 20
    static bool CheckSpring(int month, int day){
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20)){
            return true;
        }
        else{
            return false;
        }
    }
}
