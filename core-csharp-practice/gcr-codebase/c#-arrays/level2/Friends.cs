using System;

class Friends{
	static void Main(String[] args){
	
		int[] height = new int[3];
		int[] age = new int[3];
		
		for(int i=0; i<3; i++){
            height[i] = int.Parse(Console.ReadLine());
        }
		
        for (int i=0; i<3; i++){
			age[i] = int.Parse(Console.ReadLine());
        }
		
		int tallest = height[0];
		
		for(int i=1; i<height.Length; i++){
			if(height[i] > tallest){
				tallest = height[i];
			}
		}
		
		int youngest = age[0];
		
		for(int i=1; i<age.Length; i++){
			if(age[i] < youngest){
				youngest = age[i];
			}
		}
		Console.WriteLine("Youngest: " + youngest);
		Console.WriteLine("Tallest: " + tallest);
		
	}
}