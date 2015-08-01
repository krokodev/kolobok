// Robotango (c) 2015 Krokodev
// Robotango.Core
// Entity.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Core.Diagnostics;
using Robotango.Core.Types.Common;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Implements.Skills
{
    internal class Entity : IEntity, IComponent
    {
        #region IComponent

        void IComponent.Init( IComposition composition ) {}

        IComponent IComponent.Clone()
        {
            return new Entity {
                _attributes = _attributes.Select( p => p.Clone() ).ToList()
            };
        }

        #endregion


        #region IOwner

        void IEntity.Add( IAttribute attribute )
        {
            Debug.Assert.That( attribute.Entity == null, "Attribute already belongs to other entity" );
            _attributes.Add( attribute );
            attribute.Entity = this;
        }

        T IEntity.Add<T>()
        {
            return new T();
        }

        T IEntity.GetFirst<T>()
        {
            return _attributes.OfType< T >().First();
        }

        #endregion


        #region Fields

        private List< IAttribute > _attributes = new List< IAttribute >();

        #endregion
    }
}