// Robotango (c) 2015 Krokodev
// Robotango.Core
// Virtual.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Domain.Attributes;

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


        #region IAttributeHolder

        void IAttributeHolder.Add( IAttribute attribute )
        {
            Debug.Assert.That( attribute.Holder == null, "Attribute already belongs to other entity" );
            _attributes.Add( attribute );
            attribute.Holder = this;
        }

        T IAttributeHolder.Add<T>()
        {
            return new T();
        }

        T IAttributeHolder.GetFirst<T>()
        {
            return _attributes.OfType< T >().First();
        }

        #endregion


        #region Fields

        private List< IAttribute > _attributes = new List< IAttribute >();

        #endregion
    }
}