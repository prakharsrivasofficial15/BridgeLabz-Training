using System;

class Conditions{
	static void Main(string[] args){
		
		int[] num = new int[5];
		
		for(int i=0; i<num.Length; i++){
			num[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i=0; i<num.Length; i++){
			if(num[i] > 0){
			    if(num[i] % 2 == 0){
			        Console.WriteLine("number is positive and even: " + num[i]);
			    }else{
			        Console.WriteLine("number is positive and odd: " + num[i]);
			    }
			}else if(num[i] == 0){
			    Console.WriteLine("number is zero");
			}else{
			    Console.WriteLine("number is negative: " + num[i]);
			}
		}
	}
}