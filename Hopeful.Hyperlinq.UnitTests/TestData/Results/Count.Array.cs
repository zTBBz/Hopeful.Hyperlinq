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
    public static int Count(this Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType> source, System.Func<TestValueType, bool> predicate)
        => Hopeful.Hyperlinq.ValueReadOnlyListExtensions.Count<Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>, Hopeful.Hyperlinq.ArrayExtensions.ArraySegmentValueEnumerable<TestValueType>.DisposableEnumerator, TestValueType, Hopeful.Hyperlinq.FunctionWrapper<TestValueType, bool>>(source, predicate);
}
