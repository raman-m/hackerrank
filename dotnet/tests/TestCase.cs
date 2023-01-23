using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json.Linq;

namespace RamanM.HackerRank.Tests
{
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

        public Stream Input()
        {
            return File.OpenRead(InputPath);
        }

        public Stream Output()
        {
            return File.OpenRead(OutputPath);
        }
    }
}
