using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class Utility
    {
        Appliances[] appliances = new Appliances[9];
        int count = 0;
        public void InputAppliances()
        {
            bool flag = true;
            if (count >= appliances.Length)
            {
                Console.WriteLine("Appliance limit reached.");
                return;
            }
            while (flag)
            {
                
                Console.WriteLine("Enter Type of appliances:");
                Console.WriteLine("1. AC");
                Console.WriteLine("2. Fan");
                Console.WriteLine("3. Light");
                Console.WriteLine("4. Exit");
                int typeChoice = Convert.ToInt32(Console.ReadLine());
                switch (typeChoice)
                {
                    case 1:
                        Console.WriteLine("Enter AC details: ID, Name, Location, Temperature Setting");
                        int id = Convert.ToInt32(Console.ReadLine());
                        string name = Console.ReadLine();
                        string location = Console.ReadLine();
                        int tempSetting = Convert.ToInt32(Console.ReadLine());
                        appliances[count++] = new AC(id, name, location, tempSetting);
                        break;
                    case 2:
                        Console.WriteLine("Enter Fan details: ID, Name, Location, Speed Level");
                        int fanId = Convert.ToInt32(Console.ReadLine());
                        string fanName = Console.ReadLine();
                        string fanLocation = Console.ReadLine();
                        int speedLevel = Convert.ToInt32(Console.ReadLine());
                        appliances[count++] = new Fan(fanId, fanName, fanLocation, speedLevel);
                        break;
                    case 3:
                        Console.WriteLine("Enter Light details: ID, Name, Location, Brightness Level");
                        int lightId = Convert.ToInt32(Console.ReadLine());
                        string lightName = Console.ReadLine();
                        string lightLocation = Console.ReadLine();
                        int brightnessLevel = Convert.ToInt32(Console.ReadLine());
                        appliances[count++] = new Light(lightId, lightName, lightLocation, brightnessLevel);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;

                }
            }
        }
        public void DisplayAppliances()
        {
            Console.WriteLine("Appliance Details:");
            foreach (var appliance in appliances)
            {
                if (appliance != null)
                {
                    Console.WriteLine(appliance.ToString());
                }
            }
        }

        public void ControlByLocation(string location)
        {
            Console.WriteLine($"Controlling appliance at {location}:");
            Console.WriteLine("1. Turn On");
            Console.WriteLine("2. Turn Off");
            int choice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i]!=null && appliances[i].ToString().Contains(location))
                {
                    if (appliances[i] is IControllable controllable)
                    {
                        switch (choice)
                        {
                            case 1:
                                controllable.TurnOn();
                                break;
                            case 2:
                                controllable.TurnOff();
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This appliance cannot be controlled.");
                    }
                }
            }
        }

        public void ControlByType(string type)
        {
            Console.WriteLine($"Controlling appliance of type {type}:");
            Console.WriteLine("1. Turn On");
            Console.WriteLine("2. Turn Off");
            int choice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] != null && appliances[i].ToString().Contains(type))
                {
                    if (appliances[i] is IControllable controllable)
                    {
                        switch (choice)
                        {
                            case 1:
                                controllable.TurnOn();
                                break;
                            case 2:
                                controllable.TurnOff();
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This appliance cannot be controlled.");
                    }
                }
            }
        }

        public void AddAppliance(Appliances appliance)
        {
            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] == null)
                {
                    appliances[i] = appliance;
                    Console.WriteLine("Appliance added.");
                    return;
                }
            }
            Console.WriteLine("Appliance added after resizing.");
        }

        public void RemoveAppliance(int applianceId)
        {
            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] != null && appliances[i].ToString().Contains("ID:"+ applianceId))
                {
                    appliances[i] = null;
                    Console.WriteLine("Appliance removed.");
                    return;
                }
            }

            Console.WriteLine("Appliance not found.");
        }
    }
}
