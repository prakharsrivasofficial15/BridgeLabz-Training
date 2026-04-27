using System;

class SubstringCount{
    static int CountOccurrences(string text, string sub){
        int count = 0;
        for (int i=0; i<=text.Length-sub.Length; i++){
            if(text.Substring(i, sub.Length) == sub)
                count++;
        }
        return count;
    }

    static void Main(){
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        Console.WriteLine("Occurrences: " + CountOccurrences(text, sub));
    }
}
