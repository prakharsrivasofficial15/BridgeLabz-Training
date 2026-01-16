using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    abstract class Vehicle
    {
        private int id;
        private string name;
        private int exit;

        protected Vehicle(int id, string name, int exit)
        {
            this.id = id;
            this.name = name;
            this.exit = exit;
        }

        public int ID => id;
        public string Name => name;
        public int Exit => exit;

        public override string ToString()
        {
            return $"VehicleId: {ID} VehicleName: {Name}";
        }
    }
}
