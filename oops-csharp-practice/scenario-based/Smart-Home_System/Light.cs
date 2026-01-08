using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class Light:Appliances, IControllable
    {
        private int brightnessLevel;
        public Light(int applianceId, string applianceName, string location, int brightnessLevel)
            : base(applianceId, applianceName, location)
        {
            this.brightnessLevel = brightnessLevel;
        }
        public void TurnOn()
        {
            Console.WriteLine("Choose Brightness");
            Console.WriteLine("1. Low");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. High");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    brightnessLevel = 30;
                    break;
                case 2:
                    brightnessLevel = 60;
                    break;
                case 3:
                    brightnessLevel = 100;
                    break;
                default:
                    Console.WriteLine("Invalid choice, setting brightness to Medium");
                    brightnessLevel = 60;
                    break;
            }
            Console.WriteLine("Light is turned ON with brightness level: " + brightnessLevel);
        }
        public void TurnOff()
        {
            brightnessLevel = 0;
            Console.WriteLine("Light is turned OFF");
        }
        public override string ToString()
        {
            return base.ToString() + ", Brightness Level: " + brightnessLevel;
        }
    }
}
