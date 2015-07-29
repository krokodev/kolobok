// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Factory.cs

using System;
using System.Collections.Generic;
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

        IAgent IFactory.CreateAgent<T1, T2>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4, T5>()
        {
            return IFactory.CreateAgent(
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >(),
                IFactory.CreateComponent< T5 >()
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


        #region Static Fields

        private static readonly Dictionary< Type, Func< IComponent > >
            ComponentConstructors = new Dictionary< Type, Func< IComponent > > {
                { typeof( IRational ), () => new Rational() },
                { typeof( ISocial ), () => new Social() },
            };

        #endregion
    }
}