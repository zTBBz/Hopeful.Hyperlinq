using System;
using System.Reflection;

namespace Hopeful.Hyperlinq.SourceGenerator;

static class AttributeExtensions
{
    public static TAttribute GetCustomAttribute<TAttribute>(Assembly assembly) where TAttribute : Attribute
        => (TAttribute)Attribute.GetCustomAttribute(assembly, typeof(TAttribute));
}
