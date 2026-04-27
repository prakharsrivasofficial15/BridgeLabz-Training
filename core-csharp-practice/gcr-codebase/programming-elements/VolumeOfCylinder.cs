using System;

class VolumeOfCylinder {
    static void Main(String[] args){
        double radius = Convert.ToDouble(Console.ReadLine()); // taking radius input
        double hgt = Convert.ToDouble(Console.ReadLine()); // taking height input
        double vol = 3.14 * radius * radius * hgt; // calculating volume
        Console.WriteLine(vol); // printing the volume
    }
}
