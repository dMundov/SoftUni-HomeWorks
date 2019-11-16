namespace BirthdayCelebrations
{
    using Commands;
    using Core;

    public class StartUp
    {
        public static void Main()
        {
            CommandParser commandParser = new CommandParser();
            Engine engine = new Engine(commandParser);

            engine.Run();
        }
    }
}