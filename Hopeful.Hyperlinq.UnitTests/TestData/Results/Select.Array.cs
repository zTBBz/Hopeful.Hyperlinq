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
    public static Hopeful.Hyperlinq.ValueReadOnlyListExtensions.SelectEnumerable<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType, TestReferenceType, Hopeful.Hyperlinq.FunctionWrapper<TestValueType, TestReferenceType>> Select(this Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType> source, System.Func<TestValueType, TestReferenceType> selector)
        => Hopeful.Hyperlinq.ValueReadOnlyListExtensions.Select<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType, TestReferenceType>(source, selector);
}
