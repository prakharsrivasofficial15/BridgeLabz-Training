using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class Fan:Appliances, IControllable
    {
        private int speedLevel;
        public Fan(int applianceId, string applianceName, string location, int speedLevel)
            : base(applianceId, applianceName, location)
        {
            this.speedLevel = speedLevel;
        }
        public void TurnOn()
        {
            Console.WriteLine("Choose Fan Speed");
            Console.WriteLine("1. Low");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. High");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    speedLevel = 1;
                    break;
                case 2:
                    speedLevel = 2;
                    break;
                case 3:
                    speedLevel = 3;
                    break;
                default:
                    Console.WriteLine("Invalid choice, setting speed to Medium");
                    speedLevel = 2;
                    break;
            }
            Console.WriteLine("Fan is turned ON with speed level: " + speedLevel);
        }
        public void TurnOff()
        {
            speedLevel = 0;
            Console.WriteLine("Fan is turned OFF");
        }
        public override string ToString()
        {
            return base.ToString() + ", Speed Level: " + speedLevel;
        }
    }
}
