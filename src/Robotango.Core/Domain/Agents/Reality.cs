// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reality.cs

using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Robotango.Common.Implements.Diagnostics;
using Robotango.Common.Implements.Extensions;
using Robotango.Common.Implements.Tools;
using Robotango.Common.Types.Properties;
using Robotango.Core.Domain.System;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Core.Domain.Agents
{
    internal class Reality : IReality
    {
        #region IWorld

        private IReality IReality
        {
            get { return this; }
        }

        IAgent IReality.Agent( IAgent agent )
        {
            try {
                return _agents.First( a => a.Id == agent.Id );
            }
            catch {
                throw new UnknownAgentException( "World {0} does not contain agent {1}", IReality, agent );
            }
        }

        void IReality.Add( params IAgent[] agents )
        {
            agents.ForEach( AddAgent );
        }

        IReality IReality.Clone( IAgent holder )
        {
            return new Reality( holder, _name ) {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        bool IReality.Contains( IAgent agent )
        {
            return _agents.Any( a => a.Id == agent.Id );
        }

        void IReality.Clear()
        {
            _agents.Clear();
        }

        string IReality.Name
        {
            get { return _name ?? GetDefaultName(); }
        }

        uint IReality.Depth
        {
            get { return _holder == null ? Settings.Depth.Basic : _holder.Depth + 1; }
        }

        string IReality.FullName
        {
            get
            {
                return _holder == null
                    ? IReality.Name
                    : string.Format( Settings.Worlds.Names.FullTemplate, _holder.FullName, IReality.Name );
            }
        }

        string IReality.FamilyName
        {
            get
            {
                if( _holder == null ) {
                    return IReality.Name;
                }
                return string.Format(
                    Settings.Worlds.Names.FamilyTemplate,
                    _holder.Name,
                    _holder.Depth,
                    IReality.Name );
            }
        }

        IAgent IReality.Holder
        {
            get { return _holder; }
        }

        IReality IReality.Superior
        {
            get { return _holder == null ? null : _holder.Reality; }
        }

        #endregion


        #region IIdentifiable

        Guid IIdentifiable.Id
        {
            get { return _id; }
        }

        #endregion


        #region IResearchable

        string IResearchable.GetDump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", IReality.FamilyName, typeof( Reality ).Name );
            _agents.ForEach( a => wr.Append( a.GetDump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion


        #region IAspect

        void IVerifiable.Verify()
        {
            Debug.Assert.That( _agents.AreUniqueBy( a => a.Id ), "World's {0} agents are not unique", IReality.Id );
        }

        #endregion


        #region Ctor

        public Reality( string name = null )
        {
            _name = name;
        }

        public Reality( IAgent holder = null, string name = null )
            : this( name )
        {
            _holder = holder;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "{0} {{{1}}}", IReality.Name, IReality.Id );
        }

        #endregion


        #region Fields

        private List< IAgent > _agents = new List< IAgent >();
        private readonly Guid _id = Guid.NewGuid();
        private readonly string _name;
        private readonly IAgent _holder;

        #endregion


        #region Routines

        private void AddAgent( IAgent agent )
        {
            Debug.Assert.That( agent.Reality == null, "Agent [{0}] already belongs to the World [{1}]", agent, agent.Reality );
            Debug.Assert.That( !IReality.Contains( agent ), "World [{1}] already contains the clone of [{0}]", agent, IReality );

            _agents.Add( agent );
            agent.Reality = this;
        }

        private string GetDefaultName()
        {
            if( _holder != null && _holder.HasName() ) {
                return _holder.Name;
            }
            return Settings.Worlds.Names.Default;
        }

        #endregion
    }
}