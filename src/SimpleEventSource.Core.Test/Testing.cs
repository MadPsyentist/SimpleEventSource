using System;
using Xunit;

using SimpleEventSource.Core;

namespace SimpleEventSource.Core.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Testing.Add(3, 1));
        }
    }
}
