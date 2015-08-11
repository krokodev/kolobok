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
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;

// Here: Agent

namespace Robotango.Core.Internal.Agency
{
    internal class Agent : Composition, IAgent
    {
        #region Ctor

        public Agent( params IAbility[] abilities )
            // ReSharper disable once CoVariantArrayConversion
            : base( abilities ) {}

        public Agent( string name, params IAbility[] abilities )
            : this( abilities )
        {
            IAgent.Name = name;
        }

        #endregion


        #region Fields

        private Guid _id = Guid.NewGuid();
        private string _name;

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "'{0}' {{{1}}}", IAgent.Name, IAgent.Id );
        }

        #endregion


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

        Guid IAgent.Id
        {
            get { return _id; }
        }

        string IAgent.Name
        {
            get { return _name ?? Settings.Agents.Names.Default; }
            set { _name = value; }
        }

        bool IAgent.HasName()
        {
            return _name != null;
        }

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality reality )
        {
            Components.OfType< IProceedable< IReality > >().ForEach( c => c.Proceed( reality ) );
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


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0} <{1}>", IAgent.Name, typeof( Agent ).Name );
            Components.OfType< IResearchable >().ForEach( c => wr.Append( c.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion
    }
}