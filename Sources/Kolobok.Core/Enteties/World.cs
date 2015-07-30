// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// World.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using MoreLinq;

namespace Kolobok.Core.Enteties
{
    internal class World : IWorld, IComponent
    {
        #region IWorld

        private IWorld IWorld
        {
            get { return this; }
        }

        IAgent IWorld.Agent( IAgent agent )
        {
            try {
                return _agents.First( a => a.Id == agent.Id );
            }
            catch {
                throw new KolobokUnknownAgentException( "World {0} does not contain agent {1}", IWorld.Id, agent.Id );
            }
        }

        void IWorld.Contains( params IAgent[] agents )
        {
            agents.ForEach( AddAgent );
        }

        IWorld IWorld.Clone()
        {
            return new World {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        #endregion


        #region IComponent

        private IComponent IComponent
        {
            get { return this; }
        }

        void IComponent.Init( IComposition composition ) {}

        IComponent IComponent.Clone()
        {
            return IWorld.Clone() as IComponent;
        }

        #endregion


        #region IIdentifiable

        Guid IIdentifiable.Id
        {
            get { return _id; }
        }

        #endregion


        #region Fields

        private List< IAgent > _agents = new List< IAgent >();
        private Guid _id = Guid.NewGuid();

        #endregion


        #region Overrides

        public override string ToString()
        {
            return IWorld.Id.ToString();
        }

        #endregion


        #region Routines

        private void AddAgent( IAgent agent )
        {
            Assert.That( agent.World == null, "Agent [{0}] already belongs World [{1}]", agent, agent.World );

            _agents.Add( agent );
            agent.World = this;
        }

        #endregion
    }
}