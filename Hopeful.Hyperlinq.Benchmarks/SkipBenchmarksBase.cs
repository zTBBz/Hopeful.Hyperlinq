using BenchmarkDotNet.Attributes;

namespace Hopeful.Hyperlinq.Benchmarks;

public abstract class SkipBenchmarksBase : CountBenchmarksBase
{
    [Params(100)]
    public int Skip { get; set; }
}
