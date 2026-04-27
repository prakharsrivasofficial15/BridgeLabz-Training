using System;

class RemoveCharacter{
    static string RemoveChar(string s, char c){
        string result = "";
        foreach(char ch in s){
            if (ch != c){
                result += ch;
			}
        }
        return result;
    }

    static void Main(){
        string input = "Hello World";
        char remove = 'l';
        Console.WriteLine("Modified String: " + RemoveChar(input, remove));
    }
}
