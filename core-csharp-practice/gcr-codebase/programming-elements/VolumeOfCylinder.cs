
class VolumeOfCylinder {
    static void Main(String[] args){
        double rad = Convert.ToDouble(Console.ReadLine()); // taking radius input
        double h = Convert.ToDouble(Console.ReadLine()); // taking height input
        double vol = 3.14 * rad * rad * h; // calculating volume
        Console.WriteLine(vol); // printing the volume
    }
}
