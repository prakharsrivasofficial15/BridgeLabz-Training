using System;

class CompareSubstring{
	static void Main(string[] args){
		
		//string user input
		Console.Write("Enter the string: ");
		string s = Console.ReadLine();
		
		int start = int.Parse(Console.ReadLine()); //enter starting index
		int end = int.Parse(Console.ReadLine());   //enter ending index
		
		//substring generation using method
		string res1 = CreateStringSubstring(s, start, end); 
		
		//substring generation using substring
		string res2 = s.Substring(start, end-start);
		
		Console.WriteLine("Substring using string[Index]: " + res1);
		
		Console.WriteLine("Substring using string.Substring: " + res2);
		
		//comparing both results
		Console.WriteLine("Comparing both Substrings: " + res1.Equals(res2));
		
	}
	public static string CreateStringSubstring(string s, int start, int end){
		string s1 = "";
		for(int int i=start; i<end; i++){
				s1 = s1 + s[i];
		}
		return s1;
	}
}