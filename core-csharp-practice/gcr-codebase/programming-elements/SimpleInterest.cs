
class SimpleInterest {
    static void Main(String[] args) {
        //take input from user
        double pri = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());
        double si = (pri * rate * time) / 100;//cal simple interset
        Console.WriteLine(si);

    }
}
