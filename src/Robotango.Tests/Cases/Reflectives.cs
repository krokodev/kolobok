// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Reflectives.cs

using NUnit.Framework;
using Robotango.Tests.Utils;

namespace Robotango.Tests.Cases
{
    [Ignore]
    [TestFixture]
    public class Reflectives : BaseCase
    {
        [Test]
        public void Wise_agent_can_solve_color_of_its_hat_during_conversation()
        {
            /*            const Colors aColor = Colors.White;
            const Colors bColor = Colors.Black;

            var w = Factory.CreateAgent< IWorld >();
            var a = Factory.CreateAgent< IRational, ISocial, IReflective, IOwner >();
            var b = Factory.CreateAgent< IRational, ISocial, IReflective, IOwner >();

            w.As< IWorld >().Contains( a, b );

            a.As< IOwner >().Has( new Hat() );
            b.As< IOwner >().Has( new Hat() );

            a.As< IOwner >().GetFirst< IHat >().Color = aColor;
            b.As< IOwner >().GetFirst< IHat >().Color = bColor;

            a.As< IRational >().Believes( world => world.Contains( a, b ) );
            a.As< IRational >().Believes( world => world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color = Colors.Unknown );
            a.As< IRational >().Believes( world => world.Agent( b ).As< IOwner >().GetFirst< IHat >().Color = bColor );

            b.As< IRational >().Believes( world => world.Contains( a, b ) );
            b.As< IRational >().Believes( world => world.Agent( b ).As< IOwner >().GetFirst< IHat >().Color = Colors.Unknown );
            b.As< IRational >().Believes( world => world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color = aColor );

            Assert.That(
                a.As< ISocial >()
                    .Replies< Colors >( world =>
                        world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color
                    )
                    == Colors.Unknown
                );

            // Some iterations
            foreach( var i in Enumerable.Range( 0, 10 ) ) {
                a.As< IRational >().Think();
                b.As< IRational >().Think();

                // a ask b about b's hat color
                a.As< IRational >().Believes( aWorld =>
                    aWorld.Agent( b ).As< IRational >().Believes( bWorld =>
                        bWorld.Agent( b ).As< IOwner >().GetFirst< IHat >().Color
                            = b.As< ISocial >()
                                .Replies< Colors >( world =>
                                    world.Agent( b ).As< IOwner >().GetFirst< IHat >().Color
                                )
                        )
                    );

                // ...
            }

            Assert.That(
                a.As< ISocial >()
                    .Replies< Colors >( world =>
                        world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color
                    )
                    == Colors.Black
                );*/
        }
    }
}