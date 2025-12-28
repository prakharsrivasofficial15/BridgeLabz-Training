using System;

class MostFrequentCharacter{
    static char FindMostFrequent(string s){
        int[] freq = new int[256];
        foreach(char ch in s){
            freq[ch]++;
		}
        int max = 0;
        char result = s[0];

        foreach(char ch in s){
            if(freq[ch] > max){
                max = freq[ch];
                result = ch;
            }
        }
        return result;
    }

    static void Main(){
        string input = "success";
        Console.WriteLine("Most Frequent Character: " + FindMostFrequent(input));
    }
}
