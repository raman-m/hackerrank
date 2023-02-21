global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Xunit;
global using RamanM.HackerRank;

namespace RamanM.HackerRank.Tests;

/// <summary>
/// Defines a root class in the root namespace.
/// </summary>
internal class Root { }

/// <summary>
/// Defines testing settings for MS Adapter: parallel or serial test execution.
/// </summary>
[Collection(nameof(Console))]
[CollectionDefinition(nameof(Console), DisableParallelization = true)]
public class ConsoleTestingSettings : ConsoleTest { }
