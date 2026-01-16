using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    class VehicleNode : Vehicle
    {
        public VehicleNode Next;
        public int rotationCount = 0;
        public VehicleNode(int  id, string name, int exit): base(id, name, exit)
        {
            Next = null;
        }
    }
}
