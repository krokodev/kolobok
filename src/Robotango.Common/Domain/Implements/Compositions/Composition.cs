// Robotango (c) 2015 Krokodev
// Robotango.Common
// Composition.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Extensions;

namespace Robotango.Common.Domain.Implements.Compositions
{
    public abstract class Composition : IComposite
    {
        #region IComposition

        protected IComposite IComposite
        {
            get { return this; }
        }

        T IComposite.GetComponent<T>()
        {
            try {
                return Components.OfType< T >().First();
            }
            catch {
                throw new MissedComponentException( typeof( T ) );
            }
        }

        public bool HasComponent<T>() where T : IComponent
        {
            return Components.Any( c => c is T );
        }

        #endregion


        #region Protected

        protected void InitComponents()
        {
            Components.ForEach( c => c.InitReferences( this ) );
        }

        protected List< IComponent > CloneComponents()
        {
            return Components.Select( CloneComponent ).ToList();
        }

        #endregion


        #region Ctor

        protected Composition( IComponent[] abilities )
        {
            AssertComponentsAreUnique( abilities );
            RegisterComponents( abilities );
            InitComponents();
        }

        #endregion


        #region Asserts

        private static void AssertComponentsAreUnique( IEnumerable< IComponent > components )
        {
            if( !components.Select( c => c.GetType() ).AreUnique() ) {
                throw new AssertException( "Components are not unique" );
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