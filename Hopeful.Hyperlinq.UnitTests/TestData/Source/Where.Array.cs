using System;
using System.Linq;
using Hopeful.Hyperlinq;

partial class TestsSource
{
    static void Where_ArraySegmentValueEnumerable()
    {
        _ = Array.Empty<TestValueType>()
            .AsValueEnumerable()
            .Where(_ => true);
    }
}
