// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Agent.cs

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
            return _components.OfType< T >().FirstOrDefault();
        }

        public T As<T>()
        {
            return IAgent.GetComponent< T >();
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

        private static void AssertComponentsAreUnique( IEnumerable< IComponent > components )
        {
            if( !components.Select( c => c.GetType() ).IsUnique() ) {
                throw new KolobokException( "Components are not unique" );
            }
        }

        #endregion


        #region Fields

        private List< IComponent > _components;

        #endregion
    }
}