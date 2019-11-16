namespace Vehicles
{
    using System;
    using Vehicles.Core;
    using Vehicles.Models;

    public class StartUp
    {
        static void Main()
        {
            var engine = new Engine();
            engine.Run();
        }
    }
}
