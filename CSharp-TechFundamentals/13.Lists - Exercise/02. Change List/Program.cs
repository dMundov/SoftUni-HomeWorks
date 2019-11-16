using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToList();
            string[] comand = new string[3];

            while(true)
            {

                string input = Console.ReadLine();
                if(input=="end")
                {
                    break;
                }
                else
                {
                    comand = input.Split(" ").ToArray();

                    if (comand[0]=="Insert")
                    {
                       int numberToAdd = int.Parse(comand[1]);
                       int position = int.Parse(comand[2]);

                        myList.Insert(position,numberToAdd);
                    }
                    if(comand[0] == "Delete")
                    {
                        myList.RemoveAll(item => item == int.Parse(comand[1]));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
