// Robotango (c) 2015 Krokodev
// Robotango.Common
// Composition.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Implements.Diagnostics;
using Robotango.Common.Implements.Extensions;
using Robotango.Common.Types.Compositions;

namespace Robotango.Common.Implements
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
            return Components.OfType< T >().FirstOrDefault();
        }

        public bool HasComponent<T>() where T : IComponent
        {
            return Components.Any( c => c is T );
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
                throw new RobotangoException( "Components are not unique" );
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