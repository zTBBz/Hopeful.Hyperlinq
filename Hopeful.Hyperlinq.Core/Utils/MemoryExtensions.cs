using System;
using System.Runtime.CompilerServices;

namespace Hopeful.Hyperlinq;

static class MemoryExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlyMemory<T> AsReadOnlyMemory<T>(this Memory<T> source)
        => source;
}
