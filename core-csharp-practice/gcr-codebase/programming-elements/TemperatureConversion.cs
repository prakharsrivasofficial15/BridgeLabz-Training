
class TemperatureConversion {
    static void Main(String[] args){
        double cel = Convert.ToDouble(Console.ReadLine());//taking input
        double fah = (cel * 9/5) + 32;//conversion
        Console.WriteLine(fah);//printing the converted output
    }
}
