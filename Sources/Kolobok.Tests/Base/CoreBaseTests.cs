// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// CoreBaseTests.cs

using Kolobok.Core.Factory;
using Kolobok.Core.Types;
using NUnit.Framework;

namespace Kolobok.Base
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