using System;

class ReplaceWord{
    static string Replace(string sentence, string oldWord, string newWord){
        string[] words = sentence.Split(' ');
        for (int i=0; i<words.Length; i++){
            if (words[i] == oldWord){
                words[i] = newWord;
			}
        }
        return string.Join(" ", words);
    }

    static void Main(){
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("New word: ");
        string newWord = Console.ReadLine();

        Console.WriteLine("Modified Sentence: " +
            Replace(sentence, oldWord, newWord));
    }
}
