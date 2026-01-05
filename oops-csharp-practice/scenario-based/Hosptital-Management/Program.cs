namespace BridgeLabz_Scenario.Hosptital_Management
{
    internal class Program
    {
        static Doctor SelectDoctor(Doctor[] doctors)
        {
            Console.WriteLine("\nAvailable Doctors:");
            for (int i = 0; i < doctors.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Dr. {doctors[i].Name} - {doctors[i].Specialization}");
            }

            Console.Write("Select Doctor (Enter number): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= doctors.Length)
            {
                return doctors[choice - 1];
            }

            Console.WriteLine("Invalid selection! Default doctor assigned.");
            return doctors[0];
        }

        static void Main(string[] args)
        {
            Patient inPatient = null;
            Patient outPatient = null;
            Bill bill = new Bill();

            Doctor[] doctors = new Doctor[]
            {
                new Doctor { DoctorId = 1, Name = "Sharma", Specialization = "General Physician" },
                new Doctor { DoctorId = 2, Name = "Mehta", Specialization = "Cardiologist" },
                new Doctor { DoctorId = 3, Name = "Rao", Specialization = "Orthopedic" }
            };


            while (true)
            {
                Console.WriteLine("\n===== Hospital Patient Management System =====");
                Console.WriteLine("1. Add In-Patient");
                Console.WriteLine("2. Add Out-Patient");
                Console.WriteLine("3. Display In-Patient Bill");
                Console.WriteLine("4. Display Out-Patient Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InPatient ip = new InPatient();

                        Console.Write("Patient ID: ");
                        ip.PatientId = int.Parse(Console.ReadLine());

                        Console.Write("Name: ");
                        ip.Name = Console.ReadLine();

                        Console.Write("Age: ");
                        ip.Age = int.Parse(Console.ReadLine());

                        Console.Write("Number of Days Admitted: ");
                        ip.NumberOfDays = int.Parse(Console.ReadLine());

                        Console.Write("Daily Charge: ");
                        ip.DailyCharge = double.Parse(Console.ReadLine());

                        // Doctor selection
                        ip.AssignedDoctor = SelectDoctor(doctors);

                        inPatient = ip;
                        Console.WriteLine("In-Patient Added Successfully!");
                        break;


                    case 2:
                        OutPatient op = new OutPatient();

                        Console.Write("Patient ID: ");
                        op.PatientId = int.Parse(Console.ReadLine());

                        Console.Write("Name: ");
                        op.Name = Console.ReadLine();

                        Console.Write("Age: ");
                        op.Age = int.Parse(Console.ReadLine());

                        Console.Write("Consultation Fee: ");
                        op.ConsultationFee = double.Parse(Console.ReadLine());

                        // Doctor selection
                        op.AssignedDoctor = SelectDoctor(doctors);

                        outPatient = op;
                        Console.WriteLine("Out-Patient Added Successfully!");
                        break;


                    case 3:
                        if (inPatient != null)
                        {
                            inPatient.DisplayInfo();
                            bill.PrintBill((IPayable)inPatient);
                        }
                        else
                        {
                            Console.WriteLine("No In-Patient record found.");
                        }
                        break;

                    case 4:
                        if (outPatient != null)
                        {
                            outPatient.DisplayInfo();
                            bill.PrintBill((IPayable)outPatient);
                        }
                        else
                        {
                            Console.WriteLine("No Out-Patient record found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thank you");
                        return;  

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
