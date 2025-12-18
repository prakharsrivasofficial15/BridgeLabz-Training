

class CanvertKiloToMiles {
    static void Main(String[] args) {
        //take input from user
        double kilo = Convert.ToDouble(Console.ReadLine());
        double miles = kilo * 0.621371;//convert kilo to miles
        Console.WriteLine(miles);
    }
}
