// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// World.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;
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

        void IWorld.Add( params IAgent[] agents )
        {
            agents.ForEach( AddAgent );
        }

        IWorld IWorld.Clone()
        {
            return new World {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        bool IWorld.Contains( IAgent agent )
        {
            return _agents.Any( a => a.Id == agent.Id );
        }

        public void Clear()
        {
            _agents.Clear();
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


        #region IResearchable

        string IResearchable.GetDump()
        {
            var sb = new StringBuilder();
            _agents.ForEach( a => {
                sb.AppendFormat( "agent {0}", a.Id );
                sb.Append( "\n" );
            } );
            return sb.ToString();
        }

        #endregion


        #region IAspect

        void IAspect.Verify()
        {
            Assert.That( _agents.AreUniqueBy( a => a.Id ), "World's {0} agents are not unique", IWorld.Id );
        }

        #endregion


        #region Fields

        private List< IAgent > _agents = new List< IAgent >();
        private readonly Guid _id = Guid.NewGuid();

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
            Assert.That( agent.World == null, "Agent [{0}] already belongs to the World [{1}]", agent, agent.World );
            Assert.That( !IWorld.Contains( agent ), "World [{1}] already contains the clone of [{0}]", agent, IWorld );

            _agents.Add( agent );
            agent.World = this;
        }

        #endregion
    }
}