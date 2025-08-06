using System.Collections.Generic;
using Xunit;

namespace Hopeful.Hyperlinq;

public static partial class TestData
{
    public static TheoryData<int> Return =>
        new()
        {
            int.MinValue, 0, int.MaxValue
        };
}
