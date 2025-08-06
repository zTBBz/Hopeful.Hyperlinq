using System;
using System.Diagnostics.CodeAnalysis;

namespace Hopeful.Hyperlinq;

[ExcludeFromCodeCoverage]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, AllowMultiple = true)]
public sealed class GeneratorMappingAttribute 
    : Attribute
{
    public string From { get; }
    public string To { get; }
    public bool IsType { get; }

    public GeneratorMappingAttribute(string from, string to, bool isType = false)
        => (From, To, IsType) = (from, to , isType);
}