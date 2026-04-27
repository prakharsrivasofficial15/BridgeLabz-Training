using System;

class Palindrome{
    static bool IsPalindrome(string s){
        int left=0, right=s.Length - 1;
        while(left<right){
            if(s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(IsPalindrome(input)? "Palindrome": "Not a Palindrome");
    }
}
