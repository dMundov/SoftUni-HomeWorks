using System;
using System.Linq;

namespace _04._array_rotation
{
    class program
    {
        static void Main()
        {
            int[] normalArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] rotateArray = new int[normalArray.Length];

            int numRotate = int.Parse(Console.ReadLine());

            int tempNum = normalArray[0];
            if (numRotate != 0)
            {
                for (int i = 0; i < numRotate; i++)
                {
                    for (int j = 0; j < normalArray.Length; j++)
                    {
                        if (j == normalArray.Length - 1)
                        {
                            rotateArray[j] = tempNum;
                        }
                        else
                        {
                            rotateArray[j] = normalArray[j + 1];
                        }
                    }

                    normalArray = rotateArray;
                    tempNum = normalArray[0];
                }

                Console.WriteLine(string.Join(" ", rotateArray));
            }
            else
            {
                Console.WriteLine(string.Join(" ", normalArray));
            }

           
        }
    }
}
//using System;
//using System.Linq;

//namespace _04._Array_Rotation
//{
//    class Program
//    {
//        static void Main()
//        {

//            int[] normalArray = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();
//            var numOfRotations = int.Parse(Console.ReadLine());
//            if (normalArray != null)
//                for (var i = 0; i < numOfRotations % normalArray.Length; i++)
//                {
//                    int tempNum = normalArray[0];
//                    for (int j = 1; j < normalArray.Length; j++)
//                    {
//                        normalArray[j - 1] = normalArray[j];
//                    }

//                    normalArray[normalArray.Length - 1] = tempNum;
//                }

//            Console.WriteLine(string.Join(" ", normalArray));

//        }

//    }
//}
