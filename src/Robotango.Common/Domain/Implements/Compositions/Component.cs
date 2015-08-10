// Robotango (c) 2015 Krokodev
// Robotango.Common
// Component.cs

using System.Collections.Generic;
using Robotango.Common.Domain.Types.Compositions;

namespace Robotango.Common.Domain.Implements.Compositions
{
    public abstract class Component<T> : IComponent
        where T : IComponent, new()
    {
        #region IComponent

        protected IComponent IComponent
        {
            get { return this; }
        }

        IComponent IComponent.Clone()
        {
            return Clone();
        }

        void IComponent.InitReferences( IComposite composition )
        {
            _holder = composition;
            MakeDependences();
        }

        IList< IComponent > IComponent.Dependences
        {
            get { return _dependences; }
        }

        IComposite IComponent.Holder
        {
            get { return _holder; }
        }

        #endregion


        #region Overrides

        protected virtual IComponent Clone()
        {
            return new T();
        }

        protected virtual void MakeDependences() {}

        #endregion


        #region Protected

        protected TC MakeDependenceIfAvailable<TC>() where TC : IComponent
        {
            if( !IComponent.Holder.HasComponent< TC >() ) {
                return default(TC);
            }

            return MakeDependence< TC >();
        }

        protected TC MakeDependence<TC>() where TC : IComponent
        {
            var component = IComponent.Holder.GetComponent< TC >();
            _dependences.Add( component );
            return component;
        }

        #endregion


        #region Fields

        private readonly IList< IComponent > _dependences = new List< IComponent >();
        private IComposite _holder;

        #endregion
    }
}