using System; 

class Average
{
    static void Main()
    {
        // Read the number of values to be entered
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        // Calculate the average (casting sum to double for accurate division)
        double avg = (double)sum / n;

        Console.WriteLine(avg);
    }
}
