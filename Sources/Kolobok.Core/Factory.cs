// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Factory.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolobok.Core
{
    public class Factory : IFactory
    {
        #region IFactory

        IAgent IFactory.CreateAgent( params IComponent[] components )
        {
            return new Agent( components.ToArray() );
        }

        IComponent IFactory.CreateComponent<T>()
        {
            AssertComponentIsRegisrtered( typeof( T ) );
            return doCreateComponent( typeof( T ) );
        }

        #endregion


        #region Routines

        private static Agent doCreateAgent( IEnumerable< Type > componentTypes )
        {
            var components = componentTypes.Select( doCreateComponent );
            return new Agent( components.ToArray() );
        }

        private static IComponent doCreateComponent( Type componentType )
        {
            return ComponentConstructors[ componentType ]();
        }

        #endregion


        #region Asserts

        private static void AssertComponentIsRegisrtered( Type componentType )
        {
            if( !ComponentConstructors.ContainsKey( componentType ) ) {
                throw new KolobokException( "Unexcpected type '{0}'", componentType.Name );
            }
        }

        #endregion


        #region Fields

        private static readonly Dictionary< Type, Func< IComponent > > ComponentConstructors = new Dictionary< Type, Func< IComponent > > {
            { typeof( IRational ), () => new Rational() },
            { typeof( ISocial ), () => new Social() },
        };

        #endregion
    }
}