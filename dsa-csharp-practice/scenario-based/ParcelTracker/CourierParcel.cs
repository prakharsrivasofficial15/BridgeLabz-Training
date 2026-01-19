using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    class CourierParcel : Parcel
    {
        public CourierParcel(int id, string sender) : base(id, sender) { }
    }

}
