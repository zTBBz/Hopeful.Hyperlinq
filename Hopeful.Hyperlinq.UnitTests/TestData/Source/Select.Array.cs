using System;
using System.Linq;
using Hopeful.Hyperlinq;

partial class TestsSource
{
    static void Select_ArraySegmentValueEnumerable()
    {
        _ = Array.Empty<TestValueType>()
            .AsValueEnumerable()
            .Select(_ => new TestReferenceType());
    }
}
