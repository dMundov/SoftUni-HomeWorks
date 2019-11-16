namespace _11.FindLatest10Projects
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var outputToPrint = GetLatestProjects(context);

                Console.WriteLine(outputToPrint);
            }
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var lastProjects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .Take(10)
                .OrderBy(p => p.Name)
                .ToList();

            var outputToPrint = new StringBuilder();

            foreach (var project in lastProjects)
            {
                outputToPrint.AppendLine(project.Name);
                outputToPrint.AppendLine(project.Description);
                outputToPrint.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return outputToPrint.ToString().TrimEnd();
        }
    }
}