#nullable enable

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hopeful.Hyperlinq;

static partial class GeneratedExtensionMethods
{

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Hopeful.Hyperlinq.ValueReadOnlyCollectionExtensions.SkipTakeEnumerable<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType> Skip(this Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType> source, int count)
        => Hopeful.Hyperlinq.ValueReadOnlyListExtensions.Skip<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType>(source, count);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Hopeful.Hyperlinq.ValueReadOnlyCollectionExtensions.SkipTakeEnumerable<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType> Take(this Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType> source, int count)
        => Hopeful.Hyperlinq.ValueReadOnlyCollectionExtensions.Take<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType>(source, count);
}
