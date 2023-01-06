using BenchmarkDotNet.Running;

namespace StringConcatenationComparisons.Benchmark;

public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<StringConcatenationComparison>();
    }
}