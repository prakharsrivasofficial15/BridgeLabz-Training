using System;

class SentenceFormatter
{
    static void Main()
    {
        Console.Write("Enter paragraph: ");
        string para = Console.ReadLine();

        if (para == null || para.Trim().Length == 0)
        {
            Console.WriteLine("Empty paragraph!");
            return;
        }

        while (true)
        {
            Console.WriteLine("1. Format Paragraph");
            Console.WriteLine("2. Count Words");
            Console.WriteLine("3. Find Longest Word");
            Console.WriteLine("4. Replace Word");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    para = RemoveExtraSpaces(para);
                    para = SpaceAfterPunctuation(para);
                    para = CapitalizeSentence(para);
                    Console.WriteLine("Formatted Paragraph:\n" + para);
                    break;

                case 2:
                    Console.WriteLine("Word Count: " + CountWords(para));
                    break;

                case 3:
                    Console.WriteLine("Longest Word: " + LongestWord(para));
                    break;

                case 4:
                    Console.Write("Enter word to replace: ");
                    string oldWord = Console.ReadLine();

                    Console.Write("Enter new word: ");
                    string newWord = Console.ReadLine();

                    para = ReplaceWord(para, oldWord, newWord);
                    Console.WriteLine("Updated Paragraph:\n" + para);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    // Remove extra spaces
    static string RemoveExtraSpaces(string para)
    {
        char[] ch = para.ToCharArray();
        string res = "";

        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] != ' ')
            {
                res += ch[i];
            }
            else if (res.Length > 0 && res[res.Length - 1] != ' ')
            {
                res += ' ';
            }
        }
        return res.Trim();
    }

    // Add space after punctuation
    static string SpaceAfterPunctuation(string para)
    {
        char[] ch = para.ToCharArray();
        string res = "";

        for (int i = 0; i < ch.Length; i++)
        {
            res += ch[i];

            if (ch[i] == '.' || ch[i] == '?' || ch[i] == '!')
            {
                if (i + 1 < ch.Length && ch[i + 1] != ' ')
                {
                    res += ' ';
                }
            }
        }
        return res;
    }

    // Capitalize first letter of sentence
    static string CapitalizeSentence(string para)
    {
        char[] ch = para.ToCharArray();

        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] >= 'a' && ch[i] <= 'z')
            {
                if (i == 0 || ch[i - 1] == '.' || ch[i - 1] == '?' || ch[i - 1] == '!')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
            }
        }
        return new string(ch);
    }

    // Count words
    static int CountWords(string para)
    {
        int count = 0;
        bool word = false;

        for (int i = 0; i < para.Length; i++)
        {
            if (para[i] != ' ' && !word)
            {
                count++;
                word = true;
            }
            else if (para[i] == ' ')
            {
                word = false;
            }
        }
        return count;
    }

    // Find longest word
    static string LongestWord(string para)
    {
        string longest = "";
        string current = "";

        for (int i = 0; i < para.Length; i++)
        {
            if (para[i] != ' ')
            {
                current += para[i];
            }
            else
            {
                if (current.Length > longest.Length)
                {
                    longest = current;
                }
                current = "";
            }
        }

        if (current.Length > longest.Length)
        {
            longest = current;
        }

        return longest;
    }

    // Replace word (case-insensitive)
    static string ReplaceWord(string para, string oldWord, string newWord)
    {
        char[] ch = para.ToCharArray();
        string result = "";
        string temp = "";

        for (int i = 0; i <= ch.Length; i++)
        {
            if (i < ch.Length && ch[i] != ' ')
            {
                temp += ch[i];
            }
            else
            {
                if (temp.ToLower() == oldWord.ToLower())
                {
                    result += newWord;
                }
                else
                {
                    result += temp;
                }

                if (i < ch.Length)
                    result += ' ';

                temp = "";
            }
        }
        return result;
    }
}
