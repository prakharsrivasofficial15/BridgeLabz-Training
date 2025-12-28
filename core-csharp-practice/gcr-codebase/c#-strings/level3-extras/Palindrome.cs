using System;

class Palindrome{
    static bool IsPalindrome(string s){
        int i = 0, j = s.Length - 1;
        while i < j){
            if (s[i] != s[j]){
                return false;
			}
            i++; j--;
        }
        return true;
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not Palindrome");
    }
}
