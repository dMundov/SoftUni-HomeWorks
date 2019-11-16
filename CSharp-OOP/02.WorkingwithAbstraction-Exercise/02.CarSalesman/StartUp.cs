namespace _02.CarSalesman
{
    public class Startup
    {
        public class StartUp
        {
            public static void Main(string[] args)
            {
                var engineFactory = new EngineFactory();
                var carFactory = new CarFactory();
                var carSalesman = new CarSalesman(engineFactory, carFactory);
                var runner = new Runner(carSalesman);

                runner.Start();
            }
        }
    }
}