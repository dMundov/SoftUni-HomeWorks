using System;
using System.Collections.Generic;
using System.Linq;
 
namespace _04._ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
 
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    string[] commands = command.Split();
                    switch (commands[0])
                    {
                        case "Add":
                            numbersList.Add(int.Parse(commands[1]));
                            break;

                        case "Remove":
                            if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= numbersList.Count)
                            {
                                Console.WriteLine("Invalid index");
                            }
                            else
                            {
                                numbersList.RemoveAt(int.Parse(commands[1]));
                            }
                            break;

                        case "Insert":
                            if (int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < numbersList.Count)
                            {
                                numbersList.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }

                            break;
                    }
                    switch (commands[1])
                    {
                        case "left":
                            ShiftLeft(numbersList, int.Parse(commands[2]));
                            break;
                        case "right":
                            ShiftRight(numbersList, int.Parse(commands[2]));
                            break;
                    }
                }
            }
            foreach (int index in numbersList)
            {
                Console.Write( index+" ");
            }
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}

//sing System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _7._List_Manipulation_Adv
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

//            while (true)
//            {
//                string[] commands = Console.ReadLine().Split();

//                if (commands[0] == "End")
//                {
//                    break;
//                }

//                switch (commands[0])
//                {
//                    case "Add":
//                        int numberToAdd = int.Parse(commands[1]);
//                        listOfNumbers.Add(numberToAdd);
//                        break;
//                    case "Insert":
//                        int numberToInsert = int.Parse(commands[1]);
//                        int indexToInsert = int.Parse(commands[2]);

//                        if (indexToInsert >= 0 && indexToInsert < listOfNumbers.Count)
//                        {
//                            listOfNumbers.Insert(indexToInsert, numberToInsert);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid index");
//                        }
//                        break;


//                    case "Remove":
//                        int indexToRemove = int.Parse(commands[1]);

//                        if (indexToRemove < 0 || indexToRemove >= listOfNumbers.Count)
//                        {
//                            Console.WriteLine("Invalid index");
//                            break;
//                        }

//                        listOfNumbers.RemoveAt(indexToRemove);
//                        break;
//                    case "Shift":

//                        if (commands[1] == "left")
//                        {
//                            int shiftLeft = int.Parse(commands[2]);

//                            for (int i = 0; i < shiftLeft; i++)
//                            {
//                                int counterNumber = listOfNumbers[0];
//                                listOfNumbers.Add(counterNumber);
//                                listOfNumbers.RemoveAt(0);
//                            }
//                        }
//                        else
//                        {
//                            int shiftright = int.Parse(commands[2]);

//                            for (int i = 0; i < shiftright; i++)
//                            {
//                                int counterLastNumber = listOfNumbers[listOfNumbers.Count - 1];
//                                listOfNumbers.Insert(0, counterLastNumber);
//                                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
//                            }
//                        }
//                        break;
//                }
//            }
//            Console.WriteLine(string.Join(' ', listOfNumbers));
//        }
//    }
//}