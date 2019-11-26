namespace _08.AddressesByTown
{
   
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        static void Main()
        {
            using var context = new SoftUniContext();
            var outputAddresses = GetAddressesByTown(context);
            Console.WriteLine(outputAddresses);
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addressesToTake = context.Addresses
                .Select(a => new
                {
                    Text = a.AddressText,
                    TownName = a.Town.Name,
                    EmployeesCount = a.Employees.Count
                })
                .OrderByDescending(a => a.EmployeesCount)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.Text)
                .Take(10)
                .ToList();

            var outputAddresses = new StringBuilder();
            foreach (var address in addressesToTake)
            {
                outputAddresses.AppendLine($"{address.Text}, {address.TownName} - {address.EmployeesCount} employees");
            }
            return outputAddresses.ToString().TrimEnd();
        }
    }
}
