namespace RamanM.HackerRank.Tests;

public class TestCase
{
    private const string testCaseDir = "testcases";
    private readonly string basePath = string.Empty;

    private TestCase() { }

    public TestCase(string basePath)
    {
        if (!Directory.Exists(basePath))
            throw new DirectoryNotFoundException(basePath);

        var dir = Path.Combine(basePath, testCaseDir);
        if (!Directory.Exists(dir))
            throw new DirectoryNotFoundException(dir);

        this.basePath = basePath;
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

    public void Act(Action action) => action?.Invoke();


    public void ActInConsole(Action action)
    {
        try
        {
            using var writer = new StreamWriter(TestResultPath); // Attempt to open output file.
            using var reader = new StreamReader(InputPath);
            
            Console.SetOut(writer); // Redirect standard output from the console to the output file.                        
            Console.SetIn(reader); // Redirect standard input from the console to the input file.

            action?.Invoke(); // Act
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
            throw e;
        }
        finally
        {
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput); // Recover the standard output stream 
        }
    }
}
