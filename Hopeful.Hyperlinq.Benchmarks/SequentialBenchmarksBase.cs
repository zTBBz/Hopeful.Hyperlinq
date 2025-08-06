namespace Hopeful.Hyperlinq.Benchmarks;

public abstract class SequentialBenchmarksBase : CountBenchmarksBase
{
    public override void GlobalSetup()
        => Initialize(Utils.GetSequentialValues(Count));
}
