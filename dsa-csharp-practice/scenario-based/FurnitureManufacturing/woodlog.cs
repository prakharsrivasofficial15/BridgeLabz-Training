using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class WoodLog
    {
        public int Length { get; set; }
        public double Price { get; set; }
        public double Waste { get; set; }

        public WoodLog(int length, double price, double waste)
        {
            Length = length;
            Price = price;
            Waste = waste;
        }
    }
}
