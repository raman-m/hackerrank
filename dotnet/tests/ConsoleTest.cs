using System.Runtime.CompilerServices;

namespace RamanM.HackerRank.Tests;

public class ConsoleTest
{
    /// <summary>
    /// Returns the <see cref="Environment.NewLine"/> value.
    /// </summary>
    protected string nl = Environment.NewLine;

    public Stream GetStringStream(string text)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(text);
        return new MemoryStream(bytes);
    }

    /// <summary>
    /// Acts on the specified action using <see cref="Console"/> In/Out streams overriding.
    /// </summary>
    /// <remarks>
    /// <see cref="Console"/> usage: input (overridden via a stream), output (overridden via file environment variable)
    /// </remarks>
    /// <param name="action">'System Under Test' action.</param>
    /// <param name="input">A stream to set to <see cref="Console.In"/>.</param>
    public void ActInConsole(Action action, Stream input)
    {
        using (var reader = new StreamReader(input))
        {
            Console.SetIn(reader); // Redirect standard input from the console to the input stream.
            action?.Invoke(); // Act
        }
    }

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

    /// <summary>
    /// Acts on the specified action using <see cref="Console"/> In/Out streams overriding.
    /// </summary>
    /// <remarks>
    /// <see cref="Console"/> usage: input (overridden via string stream), output (overridden via file environment variable)
    /// </remarks>
    /// <param name="action">'System Under Test' action.</param>
    /// <param name="stdin">String data for <see cref="Console.In"/>.</param>
    public virtual void Act(Action action, string stdin, [CallerMemberName] string testName = null)
    {
        using var stream = GetStringStream(stdin);
        ActInConsole(action, stream);
    }

    /// <summary>
    /// Setups integration test and sets environment variable using file path of test result.
    /// </summary>
    /// <param name="envVarValue">Value of the environment variable.</param>
    /// <param name="environmentVar">Name of the environment variable.</param>
    /// <param name="testName">Method name of the running test.</param>
    /// <returns>Environment variable value, file path of output.</returns>
    public string SetupOutput(string envVarValue = null, string environmentVar = "OUTPUT_PATH", [CallerMemberName] string testName = null)
    {
        if (string.IsNullOrEmpty(envVarValue))
        {
            var rootNamespace = typeof(ConsoleTest).Namespace;
            var relativePath = GetType().Namespace
                .Remove(0, rootNamespace.Length)
                .Remove(0, 1).Replace('.', '\\');
            var basePath = Path.Combine(Environment.CurrentDirectory, relativePath);

            var timeStamp = DateTime.Now.TimeOfDay.ToString().Replace(":", string.Empty);
            var file = $"{testName}_{timeStamp}.txt";
            envVarValue = Path.Combine(basePath, file);
        }
        Environment.SetEnvironmentVariable(environmentVar, envVarValue);
        return envVarValue;
    }

    public string Actual(string outputPath)
    {
        return File.ReadAllText(outputPath);
    }
}
