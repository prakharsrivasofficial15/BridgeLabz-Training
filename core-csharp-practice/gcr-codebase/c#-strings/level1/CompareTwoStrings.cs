using System;

class CompareTwoStrings{
	static void Main(string[] args){
		
		Console.WriteLine("Enter string 1: ");
		string s1 = Console.ReadLine();
		
		Console.WriteLine("Enter string 2: ");
		string s2 = Console.ReadLine();
		
		bool isEqual = CompareStrings(s1, s2);
		
		if(isEqual){
			Console.WriteLine("Strings equal");
		}
		else{
			Console.WriteLine("Strings not equal");
		}
	}
	public static bool CompareStrings(string s1, string s2){
		if(s1.Length != s1.Length){
			return false;
		}
		for(int i=0; i<s1.Length; i++){
			if(s1[i] != s2.[i]){
				return false;
			}
		}
		return true;
	}
}		