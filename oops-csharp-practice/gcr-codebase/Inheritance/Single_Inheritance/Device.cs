using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Single_Inheritance
{
    internal class Device
    {
        public string DeviceId;
        public string Status;

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Device ID: " + DeviceId);
            Console.WriteLine("Status: " + Status);
        }
    }

    class Thermostat : Device
    {
        public int TemperatureSetting;

        public Thermostat(string deviceId, string status, int temperature)
            : base(deviceId, status)
        {
            TemperatureSetting = temperature;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
        }
    }

    class SmartHomeTest
    {
        static void Main()
        {
            Thermostat thermostat = new Thermostat("TH101", "ON", 24);
            thermostat.DisplayStatus();
        }
    }
}
