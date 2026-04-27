using System;

class Reverse{
	static void Main(string[] args){
		
		int num = int.Parse(Console.ReadLine());
		int n = num;
		int count = 0;
		
		while(n != 0){
			count++;
			n = n/10;
		}
		
		int[] arr = new int[count];
		int index = 0;
		
		while(num != 0){
			arr[index] = num%10;
			index++;
			num = num / 10;
		}
		
		// Print reversed number
        Console.Write("Reversed number: ");
		for(int i=0; i<count; i++){
			Console.Write(arr[i]);
		}
	}
}
