using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class Appliances
    {
        private int applianceId;
        private string applianceName;
        private string location;

        public Appliances(int applianceId, string applianceName, string location)
        {
            this.applianceId = applianceId;
            this.applianceName = applianceName;
            this.location = location;
        }

        public override string ToString()
        {
            return "Appliance ID:"+ applianceId+", Name: "+applianceName+", Location: "+location;
        }
    }
}
