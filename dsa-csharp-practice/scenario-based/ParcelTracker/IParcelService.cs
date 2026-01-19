using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    interface IParcelService
    {
        void CreateParcel();
        void AddCheckpoint();
        void TrackParcel();
        void DisplayAll();
    }

}
