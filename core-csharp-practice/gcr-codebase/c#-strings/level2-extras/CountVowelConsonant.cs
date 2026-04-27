using System;

class CountVowelConsonant{
    static void Count(string input, out int vowels, out int consonants){
        vowels = consonants = 0;
        foreach(char ch in input.ToLower()){
            if(char.IsLetter(ch)){
                if("aeiou".Contains(ch)){
                    vowels++;
				}
                else{
                    consonants++;
				}
            }
        }
    }

    static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Count(input, out int v, out int c);
        Console.WriteLine($"Vowels: {v}, Consonants: {c}");
    }
}
