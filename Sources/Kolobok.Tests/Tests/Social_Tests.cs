// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Social_Tests.cs

using System;
using Kolobok.Core.Types;
using Kolobok.Utils;
using NUnit.Framework;

namespace Kolobok.Tests
{
    [TestFixture]
    public class Social_Tests : BaseTests
    {
        [Test]
        public void Wise_agent_can_solve_color_of_its_hat_during_conversation()
        {
            var a1 = Factory.CreateAgent< IRational, ISocial, IReflective, IMaterial >();
            var a2 = Factory.CreateAgent< IRational, ISocial, IReflective, IMaterial >();

            a1.As< IMaterial >().Has( new Hat() );
            a2.As< IMaterial >().Has( new Hat() );

            a1.As< IMaterial >().Get< Hat >().Color = Hat.Colors.Black;
            a2.As< IMaterial >().Get< Hat >().Color = Hat.Colors.White;

            //a1.As< IRational >().Believes( ... );
        }
    }

    public class Hat : IMaterial
    {
        public void Has( IMaterial part )
        {
            throw new NotImplementedException();
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }

        public object Color { get; set; }

        public enum Colors {
            Black,
            White
        }
    }

    public interface IMaterial
    {
        void Has( IMaterial part );
        T Get<T>();
    }

    public interface IReflective {}
}