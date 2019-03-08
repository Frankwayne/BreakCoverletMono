using BreakCoverletMono;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = Class1.DoSomething( System.Security.Cryptography.X509Certificates.StoreName.My);
            Assert.Null(expected);
        }
    }
}
