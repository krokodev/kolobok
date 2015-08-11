// Robotango (c) 2015 Krokodev
// Robotango.Core
// Reality.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Internal.Agency
{
    internal class Reality : IReality
    {
        #region Ctor

        public Reality( string name = null )
        {
            _name = name;
        }

        #endregion


        #region Data

        private List< IAgent > _agents = new List< IAgent >();
        private List< IOperation > _operations = new List< IOperation >();
        private readonly Guid _id = Guid.NewGuid();
        private readonly string _name;

        #endregion


        #region Routines

        private IAgent Project( IAgent agent )
        {
            Debug.Assert.That( !IReality.Contains( agent ), "World [{1}] already contains the clone of [{0}]", agent, IReality );

            var projection = agent.Clone();

            _agents.Add( projection );
            return projection;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "'{0}' {{{1}}}", IReality.Name, IReality.Id );
        }

        #endregion


        #region IReality

        private IReality IReality
        {
            get { return this; }
        }

        IAgent IReality.GetAgent( IAgent agent )
        {
            try {
                return _agents.First( a => a.Id == agent.Id );
            }
            catch( Exception exception ) {
                Debug.Log( exception );
                throw new UnknownAgentException( "Reality {0} does not contain agent {1}", IReality, agent );
            }
        }

        IAgent IReality.AddAgent( IAgent agent )
        {
            return Project( agent );
        }

        IReality IReality.Clone()
        {
            return new Reality( _name ) {
                _agents = _agents.Select( a => a.Clone() ).ToList()
            };
        }

        bool IReality.Contains( IAgent agent )
        {
            return _agents.Any( a => a.Id == agent.Id );
        }

        string IReality.Name
        {
            get { return _name ?? Settings.Reality.Names.Default; }
        }

        IEnumerable< IAgent > IReality.Agents
        {
            get { return _agents; }
        }

        void IReality.AddOperation( IOperation operation )
        {
            _operations.Add( operation );
        }

        void IReality.Proceed()
        {
            _operations.ForEach( op=>op.Realize( this ) );
            _operations.Clear();
        }

        Guid IReality.Id
        {
            get { return _id; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", IReality.Name, typeof( Reality ).Name );
            _agents.ForEach( a => wr.Append( a.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion
    }
}