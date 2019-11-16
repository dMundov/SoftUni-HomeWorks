using System;


namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numLines = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < numLines; i++)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
            }
            Console.WriteLine(message);
        }
    }
}
