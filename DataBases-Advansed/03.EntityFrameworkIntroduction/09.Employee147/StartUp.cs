
namespace _09.Employee147
{
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        static void Main()
        {
            using (var context = new SoftUniContext())
            {
                var output = GetEmployee147(context);
                Console.WriteLine(output);
            }
     
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee = context.Employees
             .Where(e => e.EmployeeId == 147)
             .Select(e => new
             {
                 e.FirstName,
                 e.LastName,
                 e.JobTitle,
                 Projects = e.EmployeesProjects
                        .Select(p => p.Project) 
                        .OrderBy(p => p)
             })
             .ToList();

            var outputInfo = new StringBuilder();

            foreach (var empl in employee)
            {
                outputInfo.AppendLine($"{empl.FirstName} {empl.LastName} - {empl.JobTitle}");

                foreach (var proj in empl.Projects)
                {
                    outputInfo.AppendLine($"{proj.Name}");
                }
            }

            return outputInfo.ToString().TrimEnd();
                
        }
    }
}
