using System;

class StringCompare{
    static int CompareStrings(string a, string b){
        int len = Math.Min(a.Length, b.Length);
        for (int i=0; i<len; i++){
            if (a[i] != b[i]){
                return a[i] - b[i];
			}
        }
        return a.Length - b.Length;
    }

    static void Main(){
        string s1 = "apple";
        string s2 = "banana";

        int result = CompareStrings(s1, s2);

        if(result < 0){
            Console.WriteLine($"{s1} comes before {s2}");
		}
        else if(result > 0){
            Console.WriteLine($"{s1} comes after {s2}");
		}
        else{
            Console.WriteLine("Both strings are equal");
		}
    }
}
