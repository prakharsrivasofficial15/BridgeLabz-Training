using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    sealed class ParcelMenu
    {
        private IParcelService service = new ParcelServiceImpl();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Parcel Tracker");
                Console.WriteLine("1. Create Parcel");
                Console.WriteLine("2. Add Checkpoint");
                Console.WriteLine("3. Track Parcel");
                Console.WriteLine("4. Display All Parcels");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        service.CreateParcel(); 
                        break;

                    case 2: 
                        service.AddCheckpoint(); 
                        break;

                    case 3: 
                        service.TrackParcel(); 
                        break;

                    case 4: 
                        service.DisplayAll(); 
                        break;

                    case 5: 
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }

}
