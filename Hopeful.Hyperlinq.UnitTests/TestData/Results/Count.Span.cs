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
    public static int Count(this Hopeful.Hyperlinq.ArrayExtensions.SpanValueEnumerable<int> source, Func<int, bool> predicate) 
        => Hopeful.Hyperlinq.ArrayExtensions.Count(source.Span, predicate);
}
