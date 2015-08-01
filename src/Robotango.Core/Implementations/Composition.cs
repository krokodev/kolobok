// Robotango (c) 2015 Krokodev
// Robotango.Core
// Composition.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Core.Diagnostics;
using Robotango.Core.Types;
using Robotango.Core.Utils;

namespace Robotango.Core.Implementations
{
    internal abstract class Composition : IComposition
    {
        #region IComposition

        protected IComposition IComposition
        {
            get { return this; }
        }

        T IComposition.GetComponent<T>( bool nullable )
        {
            AssertComponentExists< T >( ignore : nullable );
            return Components.OfType< T >().FirstOrDefault();
        }

        #endregion


        #region Protected

        protected void InitComponents()
        {
            Components.ForEach( c => c.Init( this ) );
        }

        protected List< IComponent > CloneComponents()
        {
            return Components.Select( CloneComponent ).ToList();
        }

        #endregion


        #region Ctor

        protected Composition( IComponent[] components )
        {
            AssertComponentsAreUnique( components );
            RegisterComponents( components );
            InitComponents();
        }

        #endregion


        #region Asserts

        private void AssertComponentExists<T>( bool ignore = false )
        {
            if( ignore ) {
                return;
            }
            if( Components.Any( c => c is T ) ) {
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


        #region Fields

        protected List< IComponent > Components;

        #endregion


        #region Routines

        private void RegisterComponents( IEnumerable< IComponent > components )
        {
            Components = components.ToList();
        }

        private static IComponent CloneComponent( IComponent component )
        {
            var clone = component.Clone();
            return clone;
        }

        #endregion
    }
}