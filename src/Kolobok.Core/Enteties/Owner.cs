// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Owner.cs

using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;

namespace Kolobok.Core.Enteties
{
    internal class Owner : IOwner, IComponent
    {
        #region IComponent

        void IComponent.Init( IComposition composition ) {}

        IComponent IComponent.Clone()
        {
            return new Owner {
                _properties = _properties.Select( p => p.Clone() ).ToList()
            };
        }

        #endregion


        #region IOwner

        private IOwner IOwner
        {
            get { return this; }
        }

        void IOwner.Has( IProperty property )
        {
            Debug.Assert.That( property.Owner == null, "Property already belongs to other owner" );
            _properties.Add( property );
            property.Owner = this;
        }

        T IOwner.GetFirst<T>()
        {
            return _properties.OfType< T >().First();
        }

        #endregion


        #region Fields

        private List< IProperty > _properties = new List< IProperty >();

        #endregion
    }
}