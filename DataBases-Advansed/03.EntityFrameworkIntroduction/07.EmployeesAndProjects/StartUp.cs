namespace _07.EmployeesAndProjects
{
    using SoftUni.Data;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var context = new SoftUniContext())
            {
                var output = GetEmployeesInPeriod(context);
                Console.WriteLine(output);
            }
        }


        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employeesToPrint = context.Employees
                .Where(e => e.EmployeesProjects
                .Any(p => p.Project.StartDate.Year >= 2001
                       && p.Project.StartDate.Year <= 2003))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                        .Select(p => p.Project)
                })
                .Take(10)
                .ToList();

            var outputToPrint = new StringBuilder();

            foreach (var empl in employeesToPrint)
            {
                var employeeName = empl.FirstName + " " + empl.LastName;
                var managerName = empl.ManagerFirstName + " " + empl.ManagerLastName;

                outputToPrint.AppendLine($"{employeeName} - Manager: {managerName}");


                foreach (var project in empl.Projects)
                {
                    var projectName = project.Name;
                    var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    var endDate = project.EndDate == null
                        ? "not finished"
                        : project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    outputToPrint.AppendLine($"--{projectName} - {startDate} - {endDate}");
                }
            }
            return outputToPrint.ToString();
        }
    }
}

