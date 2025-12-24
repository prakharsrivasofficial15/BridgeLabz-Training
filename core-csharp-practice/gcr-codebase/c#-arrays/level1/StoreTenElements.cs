using System;

class StoreTenElements{
	static void Main(string[] args){
		
		double[] num = new double[10];
		double total = 0.0;
		int index = 0;
		
		while(true){
			double n = double.Parse(Console.ReadLine());
			if(n <= 0 || num.Length == 10){
				break;
			}
			
			// assigning the number to the array
			num[index] = n;
			i++;
		}
		
		//Show all the numbers as well as the sum of all numbers 
		Console.WriteLine("NUmbers entered: ");
		for(int i=0; i<index; i++){
			Console.WriteLine(num[i]);
			total += num[i];
		}
		
		Console.WriteLine("Total of array elements: " + total);
		
	}
}