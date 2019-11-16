namespace _2.PointinRectangle
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] coordinates = Console.ReadLine().Split();
            int numChecks = int.Parse(Console.ReadLine());

            int topLeftX = int.Parse(coordinates[0]);
            int topLeftY = int.Parse(coordinates[1]);
            int bottomRightX = int.Parse(coordinates[2]);
            int bottomRightY = int.Parse(coordinates[3]);

            Point topLeftPoint = new Point(topLeftX, topLeftY);
            Point bottomRightPoint = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            for (int i = 0; i < numChecks; i++)
            {
                string[] pointInfo = Console.ReadLine().Split();

                int x = int.Parse(pointInfo[0]);
                int y = int.Parse(pointInfo[1]);

                Point point = new Point(x, y);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}