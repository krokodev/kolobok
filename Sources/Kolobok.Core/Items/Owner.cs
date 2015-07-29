// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Owner.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Kolobok.Core.Types;

namespace Kolobok.Core.Items
{
    internal class Owner : IOwner, IComponent
    {
        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Owner {
                _properties = _properties.Select( p=>p.Clone() ).ToList()
            };
        }

        #endregion


        #region IOwner

        void IOwner.Has( IProperty property )
        {
            _properties.Add( property );
        }

        T IOwner.Get<T>()
        {
            return _properties.OfType<T>().First();
        }

        #endregion


        #region Fields

        private List< IProperty > _properties = new List< IProperty >();

        #endregion
    }
}