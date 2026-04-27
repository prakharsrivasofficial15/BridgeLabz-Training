using System;

class TimeZones{
    static void Main(){
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine("GMT Time: " + utcTime);
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, ist));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, pst));
    }
}
