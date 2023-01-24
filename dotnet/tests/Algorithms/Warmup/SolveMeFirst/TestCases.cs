using RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamanM.HackerRank.Tests.Algorithms.Warmup.SolveMeFirst
{
    public class TestCases
    {
        [Fact]
        public void Solution_SolveMeFirst_SampleTestCase0()
        {
            // Arrange
            var basePath = Path.Combine(Environment.CurrentDirectory, "Algorithms\\Warmup\\SolveMeFirst\\");
            var @case = new TestCase(basePath);
            @case.InputPath = "input\\input00.txt";
            @case.OutputPath = "output\\output00.txt";

            var expected = File.ReadAllText(@case.OutputPath);

            var path = Path.GetDirectoryName(@case.OutputPath);
            var fileName = Path.GetFileNameWithoutExtension(@case.OutputPath);
            var timeStamp = DateTime.Now.TimeOfDay.ToString("hhmmss");
            var file = $"{fileName}_actual_{timeStamp}.txt";
            var actualFile = Path.Combine(path, file);

            try
            {
                // Attempt to open output file.
                using (var writer = new StreamWriter(actualFile))
                {
                    using (var reader = new StreamReader(@case.InputPath))
                    {
                        Console.SetOut(writer); // Redirect standard output from the console to the output file.                        
                        Console.SetIn(reader); // Redirect standard input from the console to the input file.

                        // Act
                        Solution.Main(Array.Empty<string>());
                    }
                }
            }
            catch (IOException e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                throw e;
            }

            try
            {
                // Assert
                var actual = File.ReadAllText(actualFile).Trim(new char[] { '\t', '\n', '\r' });
                Assert.Equal(expected, actual);
            }
            finally
            {
                TearDown(nameof(Solution_SolveMeFirst_SampleTestCase0));
            }
        }

        private void TearDown(string testCaseName)
        {
            // Recover the standard output stream so that a completion message can be displayed.
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Console.WriteLine($"{nameof(TestCases)} has completed the running of the {testCaseName} test case.");
            Console.WriteLine($"{nameof(TearDown)} has succeeded.");
        }
    }
}
