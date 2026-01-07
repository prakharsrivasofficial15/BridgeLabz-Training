using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

}
