// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Puzzle_Tests.cs

using NUnit.Framework;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Units.Complex
{
    [Ignore]

    //[TestFixture]
    public class Puzzle_Tests : BaseTests
    {
        //[Test]
        public void Wise_agent_can_solve_color_of_its_hat_during_conversation()
        {
            /*            const Colors aColor = Colors.White;
            const Colors bColor = Colors.Black;

            var w = Factory.CreateAgent< IWorld >();
            var a = Factory.CreateAgent< IThinking, ISocial, IReflective, IOwner >();
            var b = Factory.CreateAgent< IThinking, ISocial, IReflective, IOwner >();

            w.As< IWorld >().Contains( a, b );

            a.As< IOwner >().Has( new Hat() );
            b.As< IOwner >().Has( new Hat() );

            a.As< IOwner >().GetFirst< IHat >().Color = aColor;
            b.As< IOwner >().GetFirst< IHat >().Color = bColor;

            a.As< IThinking >().Believes( world => world.Contains( a, b ) );
            a.As< IThinking >().Believes( world => world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color = Colors.Unknown );
            a.As< IThinking >().Believes( world => world.Agent( b ).As< IOwner >().GetFirst< IHat >().Color = bColor );

            b.As< IThinking >().Believes( world => world.Contains( a, b ) );
            b.As< IThinking >().Believes( world => world.Agent( b ).As< IOwner >().GetFirst< IHat >().Color = Colors.Unknown );
            b.As< IThinking >().Believes( world => world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color = aColor );

            Assert.That(
                a.As< ISocial >()
                    .Replies< Colors >( world =>
                        world.Agent( a ).As< IOwner >().GetFirst< IHat >().Color
                    )
                    == Colors.Unknown
                );

            // Some iterations
            foreach( var i in Enumerable.Range( 0, 10 ) ) {
                a.As< IThinking >().Think();
                b.As< IThinking >().Think();

                // a ask b about b's hat color
                a.As< IThinking >().Believes( aWorld =>
                    aWorld.Agent( b ).As< IThinking >().Believes( bWorld =>
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