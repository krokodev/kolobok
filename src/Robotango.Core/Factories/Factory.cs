// Robotango (c) 2015 Krokodev
// Robotango.Core
// Factory.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Core.Diagnostics;
using Robotango.Core.Implements.Agents;
using Robotango.Core.Implements.Skills;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;
using Robotango.Core.Types.Systems;

namespace Robotango.Core.Factories
{
    public class Factory : IFactory
    {
        #region IFactory

        private IFactory IFactory
        {
            get { return this; }
        }

        IAgent IFactory.CreateAgent<T1>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4, T5>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >(),
                IFactory.CreateComponent< T5 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4, T5, T6>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >(),
                IFactory.CreateComponent< T5 >(),
                IFactory.CreateComponent< T6 >()
                );
        }

        IAgent IFactory.CreateAgent<T1, T2, T3, T4, T5, T6, T7>( string name )
        {
            return IFactory.CreateAgent( name,
                IFactory.CreateComponent< T1 >(),
                IFactory.CreateComponent< T2 >(),
                IFactory.CreateComponent< T3 >(),
                IFactory.CreateComponent< T4 >(),
                IFactory.CreateComponent< T5 >(),
                IFactory.CreateComponent< T6 >(),
                IFactory.CreateComponent< T7 >()
                );
        }

        IAgent IFactory.CreateAgent( params IComponent[] components )
        {
            return IFactory.CreateAgent( null, components );
        }

        IAgent IFactory.CreateAgent( string name, params IComponent[] components )
        {
            return new Agent( name, components );
        }

        IComponent IFactory.CreateComponent<T>()
        {
            Debug.Assert.That( typeof( T ).GetInterfaces().Any( t => t == typeof( IComponent ) ) );
            AssertComponentIsRegisrtered( typeof( T ) );
            return doCreateComponent( typeof( T ) );
        }

        IReality IFactory.CreateReality( string name )
        {
            return new Reality( name );
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
                throw new RobotangoException( "Unexcpected type '{0}'", componentType.Name );
            }
        }

        #endregion


        #region Static Fields

        private static readonly Dictionary< Type, Func< IComponent > >
            ComponentConstructors = new Dictionary< Type, Func< IComponent > > {
                { typeof( IRational ), () => new Rational() },
                { typeof( ISocial ), () => new Social() },
                { typeof( IEntity ), () => new Entity() },
            };

        #endregion
    }
}