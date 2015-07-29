// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Agent.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;

namespace Kolobok.Core.Items
{
    internal class Agent : IAgent
    {
        #region IAgent

        private IAgent IAgent
        {
            get { return this; }
        }

        T IAgent.GetComponent<T>()
        {
            AssertComponentExists<T>();
            return _components.OfType< T >().FirstOrDefault();
        }

        T IAgent.As<T>()
        {
            return IAgent.GetComponent< T >();
        }

        IAgent IAgent.Clone()
        {
            return new Agent {
                _components = _components.Select( c => c.Clone() ).ToList(),
                _id = new Guid( _id.ToString() )
            };
        }

        Guid IAgent.Id
        {
            get { return _id; }
        }

        #endregion


        #region Ctor

        public Agent( params IComponent[] components )
        {
            AssertComponentsAreUnique( components );
            RegisterComponents( components );
        }

        #endregion


        #region Routines

        private void RegisterComponents( IEnumerable< IComponent > components )
        {
            _components = components.ToList();
        }

        #endregion


        #region Asserts

        private void AssertComponentExists<T>()
        {
            if( _components.Any( c => c is T) ) {
                return;
            }
            throw new KolobokException( "Unknown components '{0}'", typeof(T).Name );
        }

        private static void AssertComponentsAreUnique( IEnumerable< IComponent > components )
        {
            if( !components.Select( c => c.GetType() ).IsUnique() ) {
                throw new KolobokException( "Components are not unique" );
            }
        }

        #endregion


        #region Fields

        private List< IComponent > _components;
        private Guid _id = Guid.NewGuid();

        #endregion
    }
}