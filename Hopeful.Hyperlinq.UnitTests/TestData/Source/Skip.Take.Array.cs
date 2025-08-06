using System;
using System.Linq;
using Hopeful.Hyperlinq;

partial class TestsSource
{
    static void Skip_Take_ArraySegmentValueEnumerable()
    {
        _ = Array.Empty<TestValueType>()
            .AsValueEnumerable()
            .Skip(1)
            .Take(2);
    }
}
