using System.Runtime.CompilerServices;

namespace RamanM.HackerRank.Tests;

public class ConsoleTest
{
    /// <summary>
    /// Returns the <see cref="Environment.NewLine"/> value.
    /// </summary>
    protected string nl = Environment.NewLine;

    /// <summary>
    /// Acts on the specified action using <see cref="Console"/> In/Out streams overriding.
    /// </summary>
    /// <remarks>
    /// <see cref="Console"/> usage: input (overridden via file), output (overridden via file environment variable)
    /// </remarks>
    /// <param name="action">'System Under Test' action.</param>
    /// <param name="inputPath">The file path to override input from.</param>
    /// <exception cref="FileNotFoundException">Input file does not exist.</exception>
    public void ActInConsole(Action action, string inputPath)
    {
        if (!File.Exists(inputPath))
            throw new FileNotFoundException(inputPath);

        using (var reader = new StreamReader(inputPath))
        {
            Console.SetIn(reader); // Redirect standard input from the console to the input stream.
            action?.Invoke(); // Act
        }
    }

    /// <summary>
    /// Acts on the specified action using <see cref="Console"/> In/Out streams overriding.
    /// </summary>
    /// <remarks>
    /// <see cref="Console"/> usage: input (overridden via file), output (overridden via file)
    /// </remarks>
    /// <param name="action">'System Under Test' action.</param>
    /// <param name="inputPath">The file path to override input from.</param>
    /// <param name="outputPath">The file path to override output to.</param>
    /// <exception cref="FileNotFoundException">Input file does not exist.</exception>
    public void ActInConsole(Action action, string inputPath, string outputPath)
    {
        if (!File.Exists(inputPath))
            throw new FileNotFoundException(inputPath);

        try
        {
            using var writer = new StreamWriter(outputPath); // Attempt to open output file.
            using var reader = new StreamReader(inputPath);

            Console.SetOut(writer); // Redirect standard output from the console to the output file.                        
            Console.SetIn(reader); // Redirect standard input from the console to the input file.

            action?.Invoke(); // Act
        }
        finally
        {
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput); // Recover the standard output stream 
        }
    }

    public virtual string Act(Action action, [CallerMemberName] string testName = null)
    {
        var outputPath = Setup(testName);
        using (var writer = new StreamWriter(outputPath))
        {
            try
            {
                Console.SetOut(writer); // Redirect standard output from the console to the output file.                        
                action?.Invoke(); // Act
            }
            finally
            {
                var standardOutput = new StreamWriter(Console.OpenStandardOutput());
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput); // Recover the standard output stream 
            }
        }
        return Actual(outputPath);
    }

    public virtual string Act(Action action, byte[] stdin, [CallerMemberName] string testName = null)
    {
        using var stream = new MemoryStream(stdin);
        using var reader = new StreamReader(stream);
        Console.SetIn(reader); // Redirect standard input from the console to the input stream.
        return Act(action, testName: testName);
    }

    public string ActOnOutput(Action action, string stdin, [CallerMemberName] string testName = null)
    {
        var outputPath = SetupOutputVariable(testName: testName);

        byte[] bytes = Encoding.ASCII.GetBytes(stdin);
        using var stream = new MemoryStream(bytes);
        using var reader = new StreamReader(stream);

        Console.SetIn(reader); // Redirect standard input from the console to the input stream.
        action?.Invoke(); // Act

        return Actual(outputPath);
    }

    /// <summary>
    /// Setups integration test and sets environment variable using file path of test result.
    /// </summary>
    /// <param name="envVarValue">Value of the environment variable.</param>
    /// <param name="environmentVar">Name of the environment variable.</param>
    /// <param name="testName">Method name of the running test.</param>
    /// <returns>Environment variable value, file path of output.</returns>
    public string SetupOutputVariable(string envVarValue = null, string environmentVar = "OUTPUT_PATH", [CallerMemberName] string testName = null)
    {
        if (string.IsNullOrEmpty(envVarValue))
        {
            envVarValue = GetTempFile(testName);
        }
        Environment.SetEnvironmentVariable(environmentVar, envVarValue);
        return envVarValue;
    }

    public virtual string Setup([CallerMemberName] string testName = null)
    {
        return GetTempFile(testName);
    }

    public virtual string Actual(string outputPath)
    {
        return File.ReadAllText(outputPath);
    }

    protected string GetTempFile(string testName)
    {
        var rootNamespace = typeof(ConsoleTest).Namespace;
        var relativePath = GetType().Namespace
            .Remove(0, rootNamespace.Length)
            .Remove(0, 1).Replace('.', Path.DirectorySeparatorChar);
        var basePath = Path.Combine(Environment.CurrentDirectory, relativePath);

        var timeStamp = DateTime.Now.TimeOfDay.ToString().Replace(":", string.Empty);
        var file = $"{testName}_{timeStamp}.txt";
        return Path.Combine(basePath, file);
    }
}
