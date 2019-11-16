namespace _01.RawData
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            CarCatalog cars = new CarCatalog();
            Runner runner = new Runner(cars);

            runner.Start();
        }
    }
}