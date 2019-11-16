namespace MiniORM.App
{
    using System.Linq;
    using MiniORM.App.Data;
    using MiniORM.App.Data.Entities;

    public class StartUp
    {
        private static string connectionString = @"Server=DESKTOP-BVRRD2A\SQLEXPRESS;Database=MiniORM;Integrated Security=True";

        public static void Main(string[] args)
        {
            var context = new SoftUniDbContext(connectionString);
            var employee = context.Employees.Last();
            context.Employees.Remove(employee);                 
            context.SaveChanges();
        }
    }
}