using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Adv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "End")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        listOfNumbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);

                        if (indexToInsert >= 0 && indexToInsert < listOfNumbers.Count)
                        {
                            listOfNumbers.Insert(indexToInsert, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                        
                        
                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);

                        if (indexToRemove < 0 || indexToRemove >= listOfNumbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        listOfNumbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":

                        if (commands[1] == "left")
                        {
                            int shiftLeft = int.Parse(commands[2]);

                            for (int i = 0; i < shiftLeft; i++)
                            {
                                int counterNumber = listOfNumbers[0];
                                listOfNumbers.Add(counterNumber);
                                listOfNumbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            int shiftright = int.Parse(commands[2]);

                            for (int i = 0; i < shiftright; i++)
                            {
                                int counterLastNumber = listOfNumbers[listOfNumbers.Count - 1];
                                listOfNumbers.Insert(0, counterLastNumber);
                                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', listOfNumbers));
        }
    }
}