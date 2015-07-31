// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Agent.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Common;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;

namespace Kolobok.Core.Enteties
{
    internal class Agent : IAgent, IComposition
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
            return new Agent( IAgent.Name ) {
                _components = _components.Select( c => c.Clone() ).ToList(),
                _id = new Guid( _id.ToString() ),
            };
        }

        IWorld IAgent.Reality
        {
            get { return _reality; }
            set
            {
                Debug.Assert.That( _reality == null, "Agent '{0}' can not be moved to new reality '{1}'", this, value );
                Debug.Assert.That( value.Contains( this ), "Reality '{0}' should contain agent '{1}'", value , this);
                _reality = value;
            }
        }

        string IAgent.Name { get; set; }

        uint IAgent.GetDepth()
        {
            return _reality == null ? Constants.Depth.Basic : _reality.GetDepth();
        }

        string IAgent.GetFullName()
        {
            return _reality == null 
                ? IAgent.Name
                : string.Format(Constants.Agents.Names.Template, _reality.GetFullName(), IAgent.Name);
        }

        #endregion


        #region IComposition

        private IComposition IComposition
        {
            get { return this; }
        }

        T IComposition.GetComponent<T>( bool nullable )
        {
            AssertComponentExists< T >( ignore : nullable );
            return _components.OfType< T >().FirstOrDefault();
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
        {
            AssertComponentsAreUnique( components );
            RegisterComponents( components );
            InitComponents();
        }

        public Agent( string name, params IComponent[] components )
            : this( components )
        {
            IAgent.Name = name ?? Constants.Agents.Names.Default;
        }

        #endregion


        #region Routines

        private void RegisterComponents( IEnumerable< IComponent > components )
        {
            _components = components.ToList();
        }

        private void InitComponents()
        {
            _components.ForEach( c => c.Init( this ) );
        }

        #endregion


        #region Asserts

        private void AssertComponentExists<T>( bool ignore = false )
        {
            if( ignore ) {
                return;
            }
            if( _components.Any( c => c is T ) ) {
                return;
            }
            throw new KolobokException( "Unknown components '{0}'", typeof( T ).Name );
        }

        private static void AssertComponentsAreUnique( IEnumerable< IComponent > components )
        {
            if( !components.Select( c => c.GetType() ).AreUnique() ) {
                throw new KolobokException( "Components are not unique" );
            }
        }

        #endregion


        #region Overrides

        public override string ToString()
        {
            return string.Format( "{0} {{{1}}}", IAgent.Name, IAgent.Id );
        }

        #endregion


        #region Fields

        private List< IComponent > _components;
        private Guid _id = Guid.NewGuid();
        private IWorld _reality;

        #endregion
    }
}