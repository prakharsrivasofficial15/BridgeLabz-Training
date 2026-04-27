namespace BridgeLabz_Scenario.Hosptital_Management
{
    public class InPatient : Patient, IPayable
    {
        public int NumberOfDays { get; set; }
        public double DailyCharge { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\nIn-Patient Details:");
            Console.WriteLine($"ID: {PatientId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Days Admitted: {NumberOfDays}");
            Console.WriteLine($"Doctor: Dr. {AssignedDoctor?.Name}");
        }

        public double CalculateBill()
        {
            return NumberOfDays * DailyCharge;
        }
    }
}
