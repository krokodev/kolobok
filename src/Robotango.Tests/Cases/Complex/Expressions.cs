﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Expressions.cs

using NUnit.Framework;
using Robotango.Common.Domain.Types.Expressions;
using Robotango.Core.Expressions;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Elements.Virtual;
using Robotango.Tests.Utils.Bases;

namespace Robotango.Tests.Cases.Complex

{
    [TestFixture]
    public class Expressions : BaseTests
    {
        [Test]
        public void Set_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var p = new Position( a );

            alice.Set( Its.Virtual.Position, p );

            Assert.That( alice.As< IVirtual >().Get< IPosition >(), Is.EqualTo( p ) );
        }

        [Test]
        public void Get_agent_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var p = new Position( a );
            alice.Set( Its.Virtual.Position, p );

            var pos = alice.Get( Its.Virtual.Position );

            Assert.That( pos, Is.EqualTo( p ) );
        }

        [Test]
        public void Set_agent_location_directly()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location, a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Access_agent_location_via_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Position, new Position() );
            alice.Get( Its.Virtual.Position ).Location = a;

            Assert.That( alice.Get( Its.Virtual.Position ).Location, Is.EqualTo( a ) );
        }

        [Test]
        public void Access_agent_location_directly()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );

            alice.Set( Its.Virtual.Location, a );

            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Change_agent_location_deirectly()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            alice.Set( Its.Virtual.Location, b );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );

            alice.Set( Its.Virtual.Location, c );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( c ) );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            Log( world.Dump() );
        }

        [Test]
        public void Change_agent_location_via_position()
        {
            var world = Factory.CreateWorld();
            var alice = world.Reality.Introduce( Factory.CreateAgent< IVirtual >( "Alice" ) );
            var a = new Location( "A" );
            var b = new Location( "B" );
            var c = new Location( "C" );

            alice.Set( Its.Virtual.Location, a );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );

            alice.Set( Its.Virtual.Location, b );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( b ) );

            alice.Set( Its.Virtual.Location, c );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( c ) );

            alice.Get( Its.Virtual.Position ).Location = a;
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
            Assert.That( alice.Get( Its.Virtual.Location ), Is.EqualTo( a ) );
        }

        [Test]
        public void Alice_Introduce_Bob_()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );
            var bob = Factory.CreateAgent< IThinking >( "Bob" );

            alice.Do( As.Thinking.Introduce( bob ) );

            Assert.That( alice.As<IThinking>().Imagination.Contains( bob ) );
        }

        [Test]
        public void Alice_Introduce_Herself()
        {
            var alice = Factory.CreateAgent< IThinking >( "Alice" );

            alice.Do( As.Thinking.Introduce( Its.Self ) );

            Assert.That( alice.As<IThinking>().Imagination.Contains( alice ) );
        }

        [Test]
        public void Alice_Think()
        {
        }

        [Test]
        public void Alice_Believs()
        {
        }

        [Test]
        public void Alice_If_Knows()
        {
        }

        [Test]
        public void World_If_Contains()
        {
        }

    }
}
