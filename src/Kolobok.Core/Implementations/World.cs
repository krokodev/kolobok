// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// World.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolobok.Core.Common;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;
using MoreLinq;

namespace Kolobok.Core.Implementations
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
                throw new KolobokUnknownAgentException( "World {0} does not contain agent {1}", IWorld, agent );
            }
        }

        void IWorld.Add( params IAgent[] agents )
        {
            agents.ForEach( AddAgent );
        }

        IWorld IWorld.Clone( IAgent holder )
        {
            return new World( holder, _name ) {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        bool IWorld.Contains( IAgent agent )
        {
            return _agents.Any( a => a.Id == agent.Id );
        }

        void IWorld.Clear()
        {
            _agents.Clear();
        }

        string IWorld.Name
        {
            get { return _name ?? GetDefaultName(); }
        }

        uint IWorld.Depth
        {
            get { return _holder == null ? Constants.Depth.Basic : _holder.Depth + 1; }
        }

        string IWorld.FullName
        {
            get
            {
                return _holder == null
                    ? IWorld.Name
                    : string.Format( Constants.Worlds.Names.FullTemplate, _holder.FullName, IWorld.Name );
            }
        }

        string IWorld.FamilyName
        {
            get
            {
                Debug.Assert.That( _holder != null, "World has no holder" );
                System.Diagnostics.Debug.Assert( _holder != null );
                return string.Format(
                    Constants.Worlds.Names.FamilyTemplate,
                    _holder.Name,
                    _holder.Depth,
                    IWorld.Name );
            }
        }

        IAgent IWorld.Holder
        {
            get { return _holder; }
        }

        IWorld IWorld.Superior
        {
            get { return _holder == null ? null : _holder.Reality; }
        }

        #endregion


        #region IComponent

        private IComponent IComponent
        {
            get { return this; }
        }

        void IComponent.Init( IComposition composition )
        {
            _composition = composition;
        }

        IComponent IComponent.Clone()
        {
            return ( IComponent ) IWorld.Clone();
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
            sb.AppendFormat( "{0}: {1}", typeof( World ).Name, IWorld.Name );
            sb.AppendLine();
            _agents.ForEach( a => sb.AppendLine( a.GetDump() ) );
            return sb.ToString();
        }

        #endregion


        #region IAspect

        void IAspect.Verify()
        {
            Debug.Assert.That( _agents.AreUniqueBy( a => a.Id ), "World's {0} agents are not unique", IWorld.Id );
        }

        #endregion


        #region Ctor

        public World( IAgent holder = null, string name = null )
        {
            _holder = holder;
            _name = name;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "{0} {{{1}}}", IWorld.Name, IWorld.Id );
        }

        #endregion


        #region Fields

        private List< IAgent > _agents = new List< IAgent >();
        private readonly Guid _id = Guid.NewGuid();
        private string _name;
        private readonly IAgent _holder;
        private IComposition _composition;

        #endregion


        #region Routines

        private void AddAgent( IAgent agent )
        {
            Debug.Assert.That( agent.Reality == null, "Agent [{0}] already belongs to the World [{1}]", agent, agent.Reality );
            Debug.Assert.That( !IWorld.Contains( agent ), "World [{1}] already contains the clone of [{0}]", agent, IWorld );

            _agents.Add( agent );
            agent.Reality = this;
        }

        private string GetDefaultName()
        {
            if( _holder != null && _holder.HasName() ) {
                return _holder.Name;
            }
            if( _composition is IAgent && ( _composition as IAgent ).HasName() ) {
                return ( _composition as IAgent ).Name;
            }
            return Constants.Worlds.Names.Default;
        }

        #endregion
    }
}