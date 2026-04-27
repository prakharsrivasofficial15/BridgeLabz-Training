using System;

class Grades{
    static void Main(string[] args){
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[,] marks = new int[n, 3];   // Physics, Chemistry, Maths
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i=0; i<n; i++){
		
            int phy = int.Parse(Console.ReadLine());    //Physics marks
            int chem = int.Parse(Console.ReadLine());   //Chemistry marks
            int maths = int.Parse(Console.ReadLine());  //Maths 

            if (phy<0 || chem<0 || maths<0){
                Console.WriteLine("Enter positive values");
                i--;
                continue;
            }

            marks[i, 0] = phy;
            marks[i, 1] = chem;
            marks[i, 2] = maths;
        }

        // Calculate percentage and grade
        for(int i=0; i<n; i++){
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = total / 3.0;

            if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 50)
                grade[i] = "D";
            else if (percentage[i] >= 40)
                grade[i] = "E";
            else
                grade[i] = "R";
        }

        for(int i = 0; i < n; i++){
            Console.WriteLine("Physics: " + marks[i, 0]);
            Console.WriteLine("Chemistry: " + marks[i, 1]);
            Console.WriteLine("Maths: " + marks[i, 2]);
            Console.WriteLine("Percentage: " + percentage[i]);
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
