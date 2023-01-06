using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace StringConcatenationComparisons.Demo;

[TestFixture]
public class StringConcatinationTests
{
    private const char CharToConcat = 'A';
    private const int BigNumberOfAppends = 20_000_000;

    [TestCaseSource(nameof(SmallTestData))]
    public void StringConcatenation_ShortData(int numberOfCharacters)
    {
        string result = string.Empty;
        for (int i = 0; i < numberOfCharacters; i++)
        {
            result += CharToConcat;
        }
    }

    [TestCaseSource(nameof(SmallTestData))]
    public void StringBuilderConcatenation_ShortData(int numberOfCharacters)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numberOfCharacters; i++)
        {
            result.Append(CharToConcat);
        }
    }

    [Test, Timeout(20000)]
    public void StringConcatenation_LongData()
    {
        string result = string.Empty;
        for (int i = 0; i < BigNumberOfAppends; i++)
        {
            result += CharToConcat;
        }
    }

    [Test]
    public void StringBuilderConcatenation_LongData()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < BigNumberOfAppends; i++)
        {
            result.Append(CharToConcat);
        }
    }

    private static IEnumerable<int> SmallTestData
    {
        get
        {
            yield return 5;

            yield return 10;

            yield return 50;

            yield return 100;

            yield return 500;

            yield return 1000;

            yield return 5000;
        }
    }
}