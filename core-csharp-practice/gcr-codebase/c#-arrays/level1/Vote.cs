using System;

class Vote{
	static void Main(string[] args){
		
		int[] age = new int[10];
		
		Console.WriteLine("Enter the age of each student: ");
		
		for(int i=0; i<age.Length; i++){
			age[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i=0; i<age.Length; i++){
			if(age[i] < 0){
				Console.WriteLine("Invalid age");	
			}
			else if(age[i] >= 18){
				Console.WriteLine("The student with the age " + age[i] + " can vote");
			}
			else{
				Console.WriteLine("The student with the age " + age[i] + " cannot vote");
			}
		}
	}
}