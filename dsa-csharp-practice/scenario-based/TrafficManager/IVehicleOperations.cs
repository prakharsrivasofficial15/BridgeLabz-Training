using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    internal interface IVehicleOperations
    {
        Vehicle AddVehicle();
        void Enter(int id);
        void Exit(int id);
        void PrintState();
    }
}
