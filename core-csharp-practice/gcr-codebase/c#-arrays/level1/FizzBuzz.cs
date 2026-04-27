using System;

class FizzBuzz{
	static void Main(string[] args){
		
		int n = int.Parse(Console.ReadLine());
		
		string[] arr = new string[n];
		
		for (int i = 1; i <= n; i++){
            if (i % 3 == 0 && i % 5 == 0){
                arr[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                arr[i - 1] = "Fizz";
            }
            else if (i % 5 == 0){
                arr[i - 1] = "Buzz";
            }
            else{
                arr[i - 1] = i.ToString();
            }
        }
		
		for(int i=0; i<n; i++){
			Console.WriteLine("Positin "+(i+1)+" = " arr[i]);
		}
	}
}