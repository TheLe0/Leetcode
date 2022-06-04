using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using LeertCode.Algorithm;

namespace LeertCode.Performance.Test
{
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [RPlotExporter]
    public class Executor
    {
        [Params("babad", "cbbd")]
        public string? Input;

        [Benchmark]
        public void Execute()
        {
            new LongestPalindromicSubstring().LongestPalindrome(Input!);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Executor>();
        }
    }
}