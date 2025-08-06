using System;
using System.Runtime.CompilerServices;

namespace Hopeful.Hyperlinq;

public static partial class ArrayExtensions
{


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SpanValueEnumerable<TSource> AsValueEnumerable<TSource>(this Span<TSource> source)
        => source.AsReadOnlySpan().AsValueEnumerable();
}