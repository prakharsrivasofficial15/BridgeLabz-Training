using System;

class StringToArray{
	static void Main(string[] args){
	
		//string user input
		Console.Write("Enter the string: ");
		string s = Console.ReadLine();
		
		int n = s.Length;
		
		char[] res = s.ToCharArray();
		
		char[] res1 = StringConvert(s, n);
		
		// Compare both arrays
        bool isSame = true;

        for(int i=0; i<n; i++){
            if (res[i] != res1[i]){
                isSame = false;
                break;
            }
        }

        if(isSame){
            Console.WriteLine("Match");
		}
        else{
            Console.WriteLine("Not Match");
		}
	}
	public static char[] StringConvert(string s, int n){
		
		char[] newArr = new char[n];
		for(int i=0; i<n; i++){
			newArr[i] = s[i];
		}
		return newArr;
	}
}