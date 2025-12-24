using System;

class MultiToLinear{
	static void Main(String[] args){
		
		Console.WriteLine("Enter the number of rows: ");
		int m = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the number of columns: ");
		int n = int.Parse(Console.ReadLine());
		
		int[,] mat = new int[m,n];
		
		for(int i=0; i<m; i++){
			for(int j=0; j<n; j++){
				mat[i,j] = int.Parse(Console.ReadLine());
			}
		}
		
		// size of linear array
		int[] array = new int[m*n];
		int index = 0; //counter for the linear array
		
		//copying the elements
		for (int i = 0; i <m; i++){
            for (int j = 0; j<n; j++){
                array[index] = mat[i, j];
                index++;
            }
        }

        Console.WriteLine("Elements in 1D array:");
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
	}
}