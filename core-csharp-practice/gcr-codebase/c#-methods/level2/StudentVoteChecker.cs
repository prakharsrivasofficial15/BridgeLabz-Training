using System;

public class StudentVoteChecker{

    // Method
    public static bool CanStudentVote(int age){
        
        if(age < 0){
            return false;
		}
        if(age >= 18){
            return true;
		}
        else{
            return false;
		}
    }

    static void Main(string[] args){
        int[] ages = new int[10];
        Console.WriteLine("Enter the age of 10 students:");

        //user input and method calling
        for (int i = 0; i < ages.Length; i++){
            ages[i] = int.Parse(Console.ReadLine());

            bool canVote = CanStudentVote(ages[i]);

            if(canVote){
                Console.WriteLine("Student can vote: " + ages[i]);
			}
            else{
                Console.WriteLine("Student cannot vote: " + ages[i]);
			}
        }
    }
}
