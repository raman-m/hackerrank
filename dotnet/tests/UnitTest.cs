namespace RamanM.HackerRank.Tests;

public class UnitTest
{
    public Stream GetStringStream(string text)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(text);
        return new MemoryStream(bytes);
    }

    public string ActInConsoleReader(Action action, string readFrom, string currentNamespace, string testName, string outputEnvVar = "OUTPUT_PATH")
    {
        var rootNamespace = typeof(UnitTest).Namespace;
        var relativePath = currentNamespace.Replace(rootNamespace, string.Empty)
            .Remove(0, 1).Replace('.', '\\');
        var basePath = Path.Combine(Environment.CurrentDirectory, relativePath);

        var timeStamp = DateTime.Now.TimeOfDay.ToString().Replace(":", string.Empty);
        var file = $"{testName}_{timeStamp}.txt";
        var outputEnvVarNewValue = Path.Combine(basePath, file);
        Environment.SetEnvironmentVariable(outputEnvVar, outputEnvVarNewValue);

        try
        {
            using var stream = GetStringStream(readFrom);
            using var reader = new StreamReader(stream);
            Console.SetIn(reader); // Redirect standard input from the console to the input stream.

            action?.Invoke(); // Act
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
            throw;
        }
        finally
        {
            //var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            //standardOutput.AutoFlush = true;
            //Console.SetOut(standardOutput); // Recover the standard output stream 
        }

        // Get actual result from the file
        return File.ReadAllText(outputEnvVarNewValue)
            .Trim(new char[] { '\t', '\n', '\r' });
    }
}
