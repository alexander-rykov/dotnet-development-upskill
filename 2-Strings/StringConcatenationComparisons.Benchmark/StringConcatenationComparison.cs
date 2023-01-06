using System.Text;
using BenchmarkDotNet.Attributes;

namespace StringConcatenationComparisons.Benchmark;

[MemoryDiagnoser]
public class StringConcatenationComparison
{
    private const string StringToConcat = "Hello, World!";

    [Params(5, 10, 50, 100, 1000, 5000, 100_000)]
    public int Times { get; set; }

    [Benchmark]
    public string StringConcatenation()
    {
        return Concat(string.Empty, StringToConcat, Times);
    }

    [Benchmark]
    public string StringBuilderConcatenation()
    {
        return Concat(new StringBuilder(), StringToConcat, Times);
    }

    private static string Concat(string source, string stringToConcat, int times)
    {
        for (int i = 0; i < times; i++)
        {
            source = string.Concat(source, stringToConcat);
        }

        return source;
    }

    private static string Concat(StringBuilder source, string stringToConcat, int times)
    {
        for (int i = 0; i < times; i++)
        {
            source.Append(stringToConcat);
        }

        return source.ToString();
    }
}
