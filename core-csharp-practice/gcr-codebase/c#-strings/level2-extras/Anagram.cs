using System;

class Anagram{
    static bool AreAnagrams(string s1, string s2){
        if(s1.Length != s2.Length){
            return false;
		}
        int[] count = new int[256];
        foreach(char c in s1){
            count[c]++;
		}
        foreach(char c in s2){
            count[c]--;
		}
        foreach(int i in count){
            if(i != 0){
                return false;
			}
		}
        return true;
    }

    static void Main(){
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        Console.WriteLine(AreAnagrams(s1, s2)? "Anagrams": "Not Anagrams");
    }
}
