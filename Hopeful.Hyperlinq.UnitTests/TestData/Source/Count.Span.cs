using System;
using Hopeful.Hyperlinq;

partial class TestsSource
{
    static void Count_SpanValueEnumerable()
    {
#if !NOT_TESTING
        _ = Array.Empty<int>().AsSpan()
            .AsValueEnumerable()
            .Count(_ => true);
#endif
    }
}


