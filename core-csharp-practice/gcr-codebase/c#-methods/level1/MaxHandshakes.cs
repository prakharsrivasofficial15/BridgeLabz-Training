using System;

class MaxHandshakes{
    static void Main(string[] args){
        // user input
        Console.Write("Enter the number of students: ");
        int students = int.Parse(Console.ReadLine());

        //method calling
        int handshakes = CalculateHandshakes(students);

        Console.WriteLine("The maximum number of handshakes among " +students + " students is " + handshakes);
    }

    // Method
    static int CalculateHandshakes(int n){
        return (n * (n - 1)) / 2;
    }
}
