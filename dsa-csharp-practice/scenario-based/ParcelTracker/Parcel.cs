using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    abstract class Parcel
    {
        protected int parcelId;
        protected string sender;

        public Parcel(int id, string sender)
        {
            parcelId = id;
            this.sender = sender;
        }

        public int GetId() => parcelId;
        public string GetSender() => sender;

        public override string ToString()
        {
            return $"ID: {parcelId} Name: {sender}";
        }
    }
}
