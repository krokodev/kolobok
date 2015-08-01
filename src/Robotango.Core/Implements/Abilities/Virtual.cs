// Robotango (c) 2015 Krokodev
// Robotango.Core
// Virtual.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Implements.Diagnostics;
using Robotango.Common.Types.Compositions;
using Robotango.Core.Types.Agency.Abilities;
using Robotango.Core.Types.Attributes;

namespace Robotango.Core.Implements.Abilities
{
    internal class Virtual : IVirtual
    {
        #region IComponent

        void IComponent.Init( IComposite composite ) {}

        IComponent IComponent.Clone()
        {
            return new Virtual {
                _attributes = _attributes.Select( p => p.Clone() ).ToList()
            };
        }

        #endregion


        #region IOwner

        void IVirtual.Add( IAttribute attribute )
        {
            Debug.Assert.That( attribute.Holder == null, "Attribute already belongs to other entity" );
            _attributes.Add( attribute );
            attribute.Holder = this;
        }

        T IVirtual.Add<T>()
        {
            return new T();
        }

        T IVirtual.GetFirst<T>()
        {
            return _attributes.OfType< T >().First();
        }

        #endregion


        #region Fields

        private List< IAttribute > _attributes = new List< IAttribute >();

        #endregion
    }
}