namespace BridgeLabz_Scenario.Hosptital_Management
{
    public abstract class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Doctor AssignedDoctor { get; set; }

        public abstract void DisplayInfo();
    }
}
