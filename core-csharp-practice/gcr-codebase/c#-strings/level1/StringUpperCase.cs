using System;

class StringUpperCase{
    static void Main(string[] args){
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
		
		int n = s.Length;
		
		string res1 = ToUpperCase(s, n);
		string res2 = s.ToUpper();
		
		Console.WriteLine("Compare results: " + res1.Equals(res2));
    }

    static string ToUpperCase(string s, int n){
        char[] result = new char[n];

        for (int i=0; i<n; i++){
            char ch = s[i];
            if (ch >= 'a' && ch <= 'z'){
                result[i] = (char)(ch - 32);
			}
            else{
                result[i] = ch;
			}
        }
        return new string(result);
    }
}
