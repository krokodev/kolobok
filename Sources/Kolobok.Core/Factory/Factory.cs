// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Factory.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Items;
using Kolobok.Core.Types;
using Kolobok.Core.Utils;

namespace Kolobok.Core.Factory
{
    public class Factory : IFactory
    {
        #region IFactory

        private IFactory IFactory
        {
            get { return this; }
        }

        IAgent IFactory.CreateAgent<T1>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >()
                );
        }

        public IAgent CreateAgent<T1, T2>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >()
                );
        }

        IAgent IFactory.CreateAgent( params IComponent[] components )
        {
            return new Agent( components );
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