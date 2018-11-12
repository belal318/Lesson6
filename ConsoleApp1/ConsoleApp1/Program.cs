using System;

namespace ConsoleApp1
{
    class Program
    {
        ///Question 1
        static int Count_letter(string sentence, char letter)
        {
            int counter = 0;
            for (int i = 0; i < (sentence.Length); i++)
            {
                if (sentence[i] == letter)
                    counter++;
            }
            return counter;
        }
        // Question2
        //static bool FindSubSequence(string sequence, string sub)
        //{
        //    for (int i = 0; i <= sequence.Length-sub.Length; i++)
        //    {
        //        int j = 0;

        //        for (; j <= sub.Length; j++)
        //        {
        //            if (sequence[i + j] == sub[j])
        //            {
        //                break;
        //            }
        //        }
        //        if(j==sub.Length)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}

        ///Question3
        static string Reverse(string word)
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                str = word[i] + str;
            }
            return str;
        }
        static string Reverse2(string word)
        {
            string str = "";
            for (int i = (word.Length - 1); i >= 0; i--)
            {
                str += word[i];
            }
            return str;
        }
        //Question4
        static bool Palindrom(string word)
        {
            return Reverse(word) == word;

        }
        static bool Palindrom2(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if(word[i]!= word[word.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            char letter = 'l';
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            int num = Count_letter(sentence, letter);
            Console.WriteLine(num);
            //bool g = FindSubSequence("1234835548", "348");
            //Console.WriteLine(g);
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse2("hello"));
            Console.WriteLine(Palindrom("rotor"));
            Console.WriteLine(Palindrom2("rotor"));
        }
    }
}
