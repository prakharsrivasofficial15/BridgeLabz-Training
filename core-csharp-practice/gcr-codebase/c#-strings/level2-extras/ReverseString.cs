using System;

class ReverseString{
    static string Reverse(string s){
        char[] result = new char[s.Length];
        int j=0;

        for(int i=s.Length-1; i>=0; i--){
            result[j++] = s[i];
		}
        return new string(result);
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + Reverse(input));
    }
}
