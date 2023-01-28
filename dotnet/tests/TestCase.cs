using System.Runtime.CompilerServices;

namespace RamanM.HackerRank.Tests;

public class TestCase : ConsoleTest
{
    private const string testCaseDir = "testcases";
    private string basePath = string.Empty;

    public string Setup(string code)
    {
        var rootNamespace = typeof(Root).Namespace;
        var relativePath = GetType().Namespace
            .Remove(0, rootNamespace.Length)
            .Remove(0, 1).Replace('.', '\\');
        var basePath = Path.Combine(Environment.CurrentDirectory, relativePath);

        if (!Directory.Exists(basePath))
            throw new DirectoryNotFoundException(basePath);

        var dir = Path.Combine(basePath, testCaseDir);
        if (!Directory.Exists(dir))
            throw new DirectoryNotFoundException(dir);

        this.basePath = basePath;

        InputPath = $"input\\input{code}.txt";
        OutputPath = $"output\\output{code}.txt";

        // Read expected value
        return File.ReadAllText(OutputPath);
    }

    private string _inputFile;
    public string InputPath
    {
        get => Path.Combine(basePath, testCaseDir, _inputFile);
        set
        {
            CheckFile(value);
            _inputFile = value;
        }
    }

    private string _outputFile;
    public string OutputPath
    {
        get => Path.Combine(basePath, testCaseDir, _outputFile);
        set
        {
            CheckFile(value);
            _outputFile = value;
        }
    }

    private void CheckFile(string fileName)
    {
        var file = Path.Combine(basePath, testCaseDir, fileName);
        if (!File.Exists(file))
            throw new FileNotFoundException(file);
    }

    private string _testResultPath;
    public string TestResultPath
    {
        get
        {
            if (string.IsNullOrEmpty(_testResultPath))
            {
                var testcasesDir = Directory.GetParent(OutputPath).Parent;
                var fileName = Path.GetFileNameWithoutExtension(OutputPath);
                var timeStamp = DateTime.Now.TimeOfDay.ToString().Replace(":", string.Empty);
                var file = $"{fileName}_actual_{timeStamp}.txt";
                _testResultPath = Path.Combine(testcasesDir.FullName, file);
            }
            return _testResultPath;
        }
        set => _testResultPath = value;
    }

    public FileStream Input()
    {
        return File.OpenRead(InputPath);
    }

    public FileStream Output()
    {
        return File.OpenRead(OutputPath);
    }

    /// <summary>
    /// Acts on the specified action and returns actual value from the test result file.
    /// </summary>
    /// <remarks>
    /// <see cref="Console"/> usage: input (overridden), output (overridden via Env variable)
    /// </remarks>
    /// <param name="action">SUT action</param>
    /// <returns>Expected value as string.</returns>
    public string Act(Action action, [CallerMemberName] string testName = null)
    {
        SetupOutput(TestResultPath, testName: testName);
        ActInConsole(action, InputPath);
        return Actual();
    }

    public string ActInConsole(Action action)
    {
        ActInConsole(action, InputPath, TestResultPath);
        return Actual();
    }

    private string Actual()
    {
        var text = File.ReadAllText(TestResultPath);
        return text.Trim(new char[] { '\t', '\n', '\r' });
    }
}
