namespace _04.Hospital
{
    class StartUp
    {
        public class Startup
        {
            public static void Main()
            {
                var hospital = new Hospital();
                var engine = new Engine(hospital);

                engine.Run();
            }
        }
    }
}