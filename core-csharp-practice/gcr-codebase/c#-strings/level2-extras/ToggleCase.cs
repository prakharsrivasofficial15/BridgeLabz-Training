using System;

class ToggleCase{
    static string Toggle(string s){
        char[] chars = s.ToCharArray();
        for (int i=0; i <chars.Length; i++){
            if(char.IsUpper(chars[i])){
                chars[i] = char.ToLower(chars[i]);
			}
            else if(char.IsLower(chars[i])){
                chars[i] = char.ToUpper(chars[i]);
			}
        }
        return new string(chars);
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Toggled String: " + Toggle(input));
    }
}
