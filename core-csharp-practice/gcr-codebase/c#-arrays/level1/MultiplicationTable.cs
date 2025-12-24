using System;

class MultiplicationTable{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
		
		int[] table = new int[4];
		int index = 0;

        for (int i = 6; i <= 9; i++){
            table[index] = (num * i);
			index++;
        }
		
		for (int i = 0; i <= table.Length; i++){
            Console.WriteLine(table[i]);
        }
		
    }
}
