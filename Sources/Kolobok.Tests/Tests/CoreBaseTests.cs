// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// CoreBaseTests.cs

using Kolobok.Core;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class CoreBaseTests
    {
        [SetUp]
        public void Init()
        {
            Factory = new Factory();
        }

        protected IFactory Factory { get; set; }
    }
}