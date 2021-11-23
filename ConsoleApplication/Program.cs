using System.Collections.Generic;
using System.Threading.Tasks;
using ConsoleApplication.Entities;
using ConsoleApplication.Services.Implementations;
using Core.Services.Implementations;

namespace ConsoleApplication
{
    internal static class Program
    {
        private static async Task Main()
        {
            var testsCreator = new TestsCreator();
            var testsGenerator = new TestsGenerator(testsCreator, new TestsGeneratorConfiguration(
                "C:\\Users\\Mark\\RiderProjects\\MPP-4\\Tests\\",
                5,
                5,
                5)
            );

            await testsGenerator.Generate(new List<string>
                {
                    "C:\\Users\\Mark\\RiderProjects\\MPP-4\\ConsoleApplication\\Program.cs",
                    "C:\\Users\\Mark\\RiderProjects\\MPP-4\\Core\\Services\\Implementations\\TestsCreator.cs"
                }
            );
        }
    }
}