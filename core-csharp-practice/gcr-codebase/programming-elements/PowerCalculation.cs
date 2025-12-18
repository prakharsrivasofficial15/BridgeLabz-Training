
class PowerCalculation {
    static void Main(String[] args) {
        //take input from user
        double baseval = Convert.ToDouble(Console.ReadLine());
        double ex = Convert.ToDouble(Console.ReadLine());
        double r =  Math.Pow(baseval,ex);//cal power
        Console.WriteLine(r);
    }
}
