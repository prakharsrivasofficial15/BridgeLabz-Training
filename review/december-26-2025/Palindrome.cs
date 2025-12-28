using System;

class Palindrome{
	static void Main(string[] args){
		
		//user input
		int n = int.Parse(Console.ReadLine());
		
		//stroing the original number in the temporary variable
		int m = n;
		int sum = 0;
		
		//reversing the number
		while(m>0){
			int rem = m%10;
			sum = sum*10 + rem;
			m = m/10;
		}
		
		//checking if the number is palindrome or not
		if(sum == n){
			Console.WriteLine("Number is palindrome");
		}
		else{
			Console.WriteLine("Number is not a palindrome");
		}
	}
}
			