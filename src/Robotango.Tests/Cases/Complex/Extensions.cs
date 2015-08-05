// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Extensions.cs

using System;
using NUnit.Framework;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex

{
    [TestFixture]
    public class Extensions : BaseTests
    {
        [Test]
        public void Alice_set_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            //alice.As< IVirtual >().Add( new Position( a ) );
            alice.Do( Set.Virtual.Position( a ) );
            alice.Do( Set.Virtual.Position( a ) );

            Assert.That( alice.As< IVirtual >().Get< IPosition >().Location, Is.EqualTo( a ) );
        }
    }

    public class Set
    {
        public static VirtulaProxy Virtual
        {
            get { return new VirtulaProxy( Convertors.Agent.As.Virtual ); }
        }
    }

    public static class Convertors
    {
        public static class Agent
        {
            public class As
            {
                public static readonly Func< IAgent, IVirtual > Virtual = agent => agent.As< IVirtual >();
            }
        }
    }

    public class VirtulaProxy
    {
        public VirtulaProxy( Func< IAgent, IVirtual > convertor )
        {
            AsVirtual = convertor;
        }

        private Func< IAgent, IVirtual > AsVirtual { get; set; }

        public Action< IAgent > Position( Location location )
        {
            return agent => AsVirtual( agent ).Add( new Position( location ) );
        }
    }
}