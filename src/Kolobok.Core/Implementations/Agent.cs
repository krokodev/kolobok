// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Agent.cs

using System;
using System.Linq;
using System.Text;
using Kolobok.Core.Common;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using MoreLinq;

namespace Kolobok.Core.Implementations
{
    internal class Agent : Composition, IAgent
    {
        #region IAgent

        private IAgent IAgent
        {
            get { return this; }
        }

        T IAgent.As<T>()
        {
            return IComposition.GetComponent< T >();
        }

        IAgent IAgent.Clone()
        {
            var clone = new Agent {
                Components = CloneComponents(),
                _id = _id,
                _name = _name
            };
            clone.InitComponents();
            return clone;
        }

        IWorld IAgent.Reality
        {
            get { return _reality; }
            set
            {
                Debug.Assert.That( _reality == null, "Agent '{0}' can not be moved to new reality '{1}'", this, value );
                Debug.Assert.That( value.Contains( this ), "Reality '{0}' should contain agent '{1}'", value, this );
                _reality = value;
            }
        }

        string IAgent.Name
        {
            get { return _name ?? Constants.Agents.Names.Default; }
            set { _name = value; }
        }

        uint IAgent.Depth
        {
            get { return _reality == null ? Constants.Depth.Basic : _reality.Depth; }
        }

        string IAgent.FullName
        {
            get
            {
                return _reality == null
                    ? IAgent.Name
                    : string.Format( Constants.Agents.Names.FullTemplate, _reality.FullName, IAgent.Name );
            }
        }

        bool IAgent.HasName()
        {
            return _name != null;
        }

        #endregion


        #region IIdentifiable

        Guid IIdentifiable.Id
        {
            get { return _id; }
        }

        #endregion


        #region Ctor

        public Agent( params IComponent[] components )
            : base( components ) {}

        public Agent( string name, params IComponent[] components )
            : this( components )
        {
            IAgent.Name = name;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "{0} {{{1}}}", IAgent.Name, IAgent.Id );
        }

        #endregion


        #region IResearchable

        string IResearchable.GetDump()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}: {1}", typeof(Agent).Name, IAgent.Name );
            sb.AppendLine();
            Components.OfType< IResearchable >().ForEach( c => sb.AppendLine( c.GetDump() ));
            return sb.ToString();
        }

        #endregion


        #region Fields

        private Guid _id = Guid.NewGuid();
        private IWorld _reality;
        private string _name;

        #endregion
    }
}