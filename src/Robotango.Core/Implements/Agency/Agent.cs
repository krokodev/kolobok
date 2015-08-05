// Robotango (c) 2015 Krokodev
// Robotango.Core
// Agent.cs

using System;
using System.Linq;
using MoreLinq;
using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Expressions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Implements.Agency
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
            Debug.Assert.That( IComposite.HasComponent< T >(), new MissedComponentException( typeof( T ) ) );
            return IComposite.GetComponent< T >();
        }

        bool IAgent.Is<T>()
        {
            return IComposite.HasComponent< T >();
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

        IReality IAgent.Reality
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
            get { return _name ?? Settings.Agents.Names.Default; }
            set { _name = value; }
        }

        uint IAgent.Depth
        {
            get { return _reality == null ? Settings.Depth.Basic : _reality.Depth; }
        }

        string IAgent.FullName
        {
            get
            {
                return _reality == null
                    ? IAgent.Name
                    : string.Format( Settings.Agents.Names.FullTemplate, _reality.FullName, IAgent.Name );
            }
        }

        bool IAgent.HasName()
        {
            return _name != null;
        }

        #endregion


        #region IExecuter

        IExecutor< IAgent > IAgent.IExecutor
        {
            get { return this; }
        }

        IExecutor< IAgent > IExecutor< IAgent >.Do( Action< IAgent > action )
        {
            action( this );
            return this;
        }

        TV IExecutor< IAgent >.Get<TV>( IPropertyAccessor< IAgent, TV > propertyAccessor )
        {
            return propertyAccessor.Get( this );
        }

        void IExecutor< IAgent >.Set<TV>( IPropertyAccessor< IAgent, TV > propertyAccessor, TV value )
        {
            propertyAccessor.Set( this, value );
        }

        bool IExecutor< IAgent >.Is( Func< IAgent, bool > predicate )
        {
            return predicate( this );
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
            wr.Line( "{0} <{1}>", IAgent.Name, typeof( Agent ).Name );
            Components.OfType< IResearchable >().ForEach( c => wr.Append( c.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion


        #region Ctor

        public Agent( params IAbility[] abilities )
            : base( abilities ) {}

        public Agent( string name, params IAbility[] abilities )
            : this( abilities )
        {
            IAgent.Name = name;
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "'{0}' {{{1}}}", IAgent.Name, IAgent.Id );
        }

        #endregion


        #region Fields

        private Guid _id = Guid.NewGuid();
        private IReality _reality;
        private string _name;

        #endregion
    }
}