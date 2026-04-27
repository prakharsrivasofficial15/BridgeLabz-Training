namespace BridgeLabz_Scenario.Hosptital_Management
{
    public class OutPatient : Patient, IPayable
    {
        public double ConsultationFee { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\nOut-Patient Details:");
            Console.WriteLine($"ID: {PatientId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Doctor: Dr. {AssignedDoctor?.Name}");
        }

        public double CalculateBill()
        {
            return ConsultationFee;
        }
    }
}
