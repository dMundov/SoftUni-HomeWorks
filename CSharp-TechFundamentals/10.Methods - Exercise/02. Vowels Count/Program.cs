//using System;
//using System.Linq;

//namespace _02._Vowels_Count
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {  
//            VowelsCount();
//        }
//        static void VowelsCount()
//        {
//            string word= Console.ReadLine().ToLower();
//            string[] vowels = new string[] { "a", "i", "u", "o", "e", };
//            int counter = 0;

//            for (int i = 0; i < word.Length; i++)
//            {
//                for (int j = 0; j < vowels.Length; j++)
//                {
//                    if (word[i].ToString().Contains(vowels[j]))
//                    {
//                        counter++;
//                    }
//                }
//            }
//            Console.WriteLine(counter);

//        }
//    }
//}

using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)

        {
            string word = Console.ReadLine().ToLower();
            VowelsCount(word);
        }
        static void VowelsCount(string wordLetters)
        {
            char[] vowels = new char[] { 'a', 'i','u', 'o', 'e', };
            char[] wordChars = wordLetters.ToCharArray();
            int counter = 0;

            for (int i = 0; i < wordLetters.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (wordChars[i]==vowels[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
