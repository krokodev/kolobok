// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reality.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Extensions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Internal.Agency
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
                return _projections.First( a => a.Id == agent.Id );
            }
            catch( Exception exception ) {
                Debug.Log( exception );
                throw new UnknownAgentException( "Reality {0} does not contain agent {1}", IReality, agent );
            }
        }

        IAgent IReality.Introduce( IAgent agent )
        {
            return Project( agent );
        }

        IReality IReality.Clone( IAgent holder )
        {
            return new Reality( holder, _name ) {
                _projections = _projections.Select( a => a.Clone() ).ToList()
            };
        }

        bool IReality.Contains( IAgent agent )
        {
            return _projections.Any( a => a.Id == agent.Id );
        }

        void IReality.Clear()
        {
            _projections.Clear();
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
                    : string.Format( Settings.Reality.Names.FullTemplate, _holder.FullName, IReality.Name );
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
                    Settings.Reality.Names.FamilyTemplate,
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

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", IReality.Name, typeof( Reality ).Name );
            _projections.ForEach( a => wr.Append( a.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion


        #region IAspect

        void IVerifiable.Verify()
        {
            Debug.Assert.That( _projections.AreUniqueBy( a => a.Id ), "World's {0} agents are not unique", IReality.Id );
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "'{0}' {{{1}}}", IReality.Name, IReality.Id );
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


        #region Fields

        private List< IAgent > _projections = new List< IAgent >();
        private readonly Guid _id = Guid.NewGuid();
        private readonly string _name;
        private readonly IAgent _holder;

        #endregion


        #region Routines

        private IAgent Project( IAgent agent )
        {
            Debug.Assert.That( !IReality.Contains( agent ), "World [{1}] already contains the clone of [{0}]", agent, IReality );

            var projection = agent.Clone();

            _projections.Add( projection );
            projection.Reality = this;
            return projection;
        }

        private string GetDefaultName()
        {
            if( _holder != null && _holder.HasName() ) {
                return _holder.Name;
            }
            return Settings.Reality.Names.Default;
        }

        #endregion
    }
}