using System;
using System.Runtime.CompilerServices;

namespace Hopeful.Hyperlinq;

public static partial class ArrayExtensions
{

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MemoryValueEnumerable<TSource> AsValueEnumerable<TSource>(this Memory<TSource> source)
        => source.AsReadOnlyMemory().AsValueEnumerable();
}