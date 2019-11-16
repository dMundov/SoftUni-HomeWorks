namespace ClassBoxData
{
    using System;

    using ClassBoxData.Models;

    public class StartUp
    {
        static void Main()
        {

            try
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(lenght, width, height);

                Console.WriteLine(box.ToString());

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
