using System;

class RemoveDuplicates{
    static string RemoveDuplicateChars(string s){
        string result = "";
        foreach(char ch in s){
            if(!result.Contains(ch))
                result += ch;
        }
        return result;
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Result: " + RemoveDuplicateChars(input));
    }
}
