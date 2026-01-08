using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class AC:Appliances, IControllable
    {
        private int temperatureSetting;
        public AC(int applianceId, string applianceName, string location, int temperatureSetting)
            : base(applianceId, applianceName, location)
        {
            this.temperatureSetting = temperatureSetting;
        }
        public void TurnOn()
        {
            Console.WriteLine("Set Temperature");
            temperatureSetting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("AC is turned ON with temperature setting " + temperatureSetting + "C");
        }
        public void TurnOff()
        {
            Console.WriteLine("AC is turned OFF");
        }
        public override string ToString()
        {
            return base.ToString() + ", Temperature Setting: " + temperatureSetting + "C";
        }
    }
}
