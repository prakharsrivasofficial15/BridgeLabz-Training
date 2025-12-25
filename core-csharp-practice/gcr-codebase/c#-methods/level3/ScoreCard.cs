using System;

class ScoreCard{
    static void Main(string[] args){
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine());

        //generate random PCM scores
        int[,] pcmScores = GeneratePCMScores(students);

        //calculate total, average, percentage
        double[,] results = CalculateResults(pcmScores);

        //display scorecard
        DisplayScoreCard(pcmScores, results);
    }

    // b. Method to generate random 2-digit PCM scores
    public static int[,] GeneratePCMScores(int students){
        int[,] scores = new int[students, 3];
        Random random = new Random();

        for(int i = 0; i < students; i++){
            scores[i, 0] = random.Next(10, 100); // Physics
            scores[i, 1] = random.Next(10, 100); // Chemistry
            scores[i, 2] = random.Next(10, 100); // Maths
        }
        return scores;
    }

    //Method to calculate total, average, percentage
    public static double[,] CalculateResults(int[,] pcmScores){
        int students = pcmScores.GetLength(0);
        double[,] result = new double[students, 3];

        for(int i = 0; i < students; i++){
            int total = pcmScores[i, 0] + pcmScores[i, 1] + pcmScores[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            result[i, 0] = total;
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }
        return result;
    }

    public static void DisplayScoreCard(int[,] pcm, double[,] results){
        for(int i = 0; i < pcm.GetLength(0); i++){
            Console.WriteLine((i + 1) + "\t" + pcm[i, 0] + "\t" + pcm[i, 1] + "\t\t" + pcm[i, 2] + "\t" + results[i, 0] + "\t" + results[i, 1] + "\t" + results[i, 2]);
        }
    }
}
