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
    public static Hopeful.Hyperlinq.ValueReadOnlyCollectionExtensions.WhereEnumerable<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType, Hopeful.Hyperlinq.FunctionWrapper<TestValueType, bool>> Where(this Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType> source, System.Func<TestValueType, bool> selector)
        => Hopeful.Hyperlinq.ValueReadOnlyListExtensions.Where<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType, Hopeful.Hyperlinq.FunctionWrapper<TestValueType, bool>>(source, selector);
}
