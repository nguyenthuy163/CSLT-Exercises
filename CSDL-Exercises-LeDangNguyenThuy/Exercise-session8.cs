using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDL_Exercises_LeDangNguyenThuy
{
    internal class Exercise_session8
    {
        private static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            PrintString(input);
            Console.WriteLine("Length of the string: " + StringLength(input));
            SeperateCharacters(input);
            PrintReverseCharacters(input);
            Console.WriteLine("total number of words:"+ CountWords(input));

            Console.WriteLine("Enter another string to compare:");
            string input2= Console.ReadLine();
            Console.WriteLine( Compare(input, input2));
            CountCharacterTypes(input);
            CountVowelsAndConsonants(input);

            Console.WriteLine("Enter a substring to search:");
            string substring = Console.ReadLine();
            Console.WriteLine(IsSubstringPresent(input, substring) ? "Substring is present" : "Substring is not present");
            int position = GetSubstringPosition(input, substring);
            Console.WriteLine(position == -1 ? "Substring not found" : $"Substring found at position: {position}");

            Console.WriteLine("Enter a character to check:");
            char charToCheck = Console.ReadKey().KeyChar;
            Console.WriteLine();
            CheckAlphabetAndCase(charToCheck);

            Console.WriteLine($"Substring '{substring}' appears {CountSubstringOccurrences(input, substring)} times.");

            Console.WriteLine("Enter a substring to insert:");
            string insertSub = Console.ReadLine();
            Console.WriteLine("Enter the target string where it should be inserted:");
            string target = Console.ReadLine();
            Console.WriteLine("Resulting string: " + InsertSubstring(input, insertSub, target));
        }
        static void PrintString(string input)
        {
            Console.WriteLine("String: " + input);
        }
        static int StringLength(string input)
        {
            int length = 0; 
            foreach (char c in input) length++;
            return length;

        }
        static void SeperateCharacters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
        static void PrintReverseCharacters(string input)
        {
            Console.WriteLine("Characters in reverse order:");
            for (int i=input.Length-1; i>=0; i--)
                Console.WriteLine(input[i]);
        }
        static int CountWords(string input)
        {
            int count = 0;
            //bo khoang trang thua co trong chuoi
            input=input.Trim();// bo khoang trang dau va cuoi
            while (input.IndexOf("  ") != -1)
                input = input.Replace("  ", " ");
            //dem
            foreach (char c in input) 
                if(c == ' ') count++;
            return count + 1;

        }
        static int Compare(string s1, string s2) // tra ve 0 neu s1 =s2, 1 neu s1>s2, -1 neu s1<s2
        {
            int min_len=s1.Length < s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < min_len;i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i])return -1;

            }
            return s1.Length > s2.Length ? 1 : s1.Length < s2.Length ? -1 : 0;

        }
        static void CountCharacterTypes(string input)
        {
            int alphabets = 0, digits = 0, specialChars = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specialChars++;

            }
            Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Special characters: {specialChars}");

        }
        static void CountVowelsAndConsonants(string input)
        {
            int vowels = 0, consonants = 0;
            foreach (char c in input)
            {
                char lower = char.ToLower(c);
                if ("aeiou".Contains(lower)) vowels++;
                else if (char.IsLetter(lower)) consonants++;
            }
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }
        static bool IsSubstringPresent(string input, string substring)
        {
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                    return true;
            }
            return false;
        }
        static int GetSubstringPosition(string input, string substring)
        {
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                    return i;
            }
            return -1;
        }
        static void CheckAlphabetAndCase(char c)
        {
            if (char.IsLetter(c))
            {
                Console.WriteLine($"'{c}' is an alphabet. It is " + (char.IsUpper(c) ? "uppercase." : "lowercase."));
            }
            else
            {
                Console.WriteLine($"'{c}' is not an alphabet.");
            }
        }
        static int CountSubstringOccurrences(string input, string substring)
        {
            int count = 0;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length) == substring)
                    count++;
            }
            return count;
        }
        static string InsertSubstring(string input, string insertSub, string target)
        {
            int position = input.IndexOf(target);
            if (position != -1)
            {
                return input.Substring(0, position) + insertSub + input.Substring(position);
            }
            return input; // Return original string if target not found
        }
    }
}
