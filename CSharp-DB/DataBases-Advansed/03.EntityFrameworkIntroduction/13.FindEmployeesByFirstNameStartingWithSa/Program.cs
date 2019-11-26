namespace _13.FindEmployeesByFirstNameStartingWithSa
{
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var outputToPrint = GetEmployeesByFirstNameStartingWithSa(context);

                Console.WriteLine(outputToPrint);
            }
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            var outputToPrint = new StringBuilder();

            foreach (var emp in employees)
            {
                outputToPrint.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary:F2})");
            }

            return outputToPrint.ToString().TrimEnd();
        }
    }
}