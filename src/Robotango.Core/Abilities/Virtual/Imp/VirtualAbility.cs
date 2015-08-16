// Robotango (c) 2015 Krokodev
// Robotango.Core
// Virtual.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Tools;

namespace Robotango.Core.Abilities.Virtual.Imp
{
    internal class VirtualAbility : Ability, IVirtual
    {
        #region Data

        private List< IAttribute > _attributes = new List< IAttribute >();

        #endregion


        #region Routines

        private T GetOrAdd<T>() where T : IAttribute, new()
        {
            return IAttributeHolder.HasAttribute< T >()
                ? IAttributeHolder.GetAttribute< T >()
                : IAttributeHolder.AddAttribute< T >();
        }

        #endregion


        #region Overrides

        protected override IComponent Clone()
        {
            return new VirtualAbility {
                _attributes = _attributes.Select( p => p.Clone() ).ToList()
            };
        }

        protected override void DumpAbilityContent( OutlineWriter wr )
        {
            _attributes.ForEach( a => wr.Append( a.Dump( wr.Level ) ) );
        }

        #endregion


        #region IAttributeHolder

        private IAttributeHolder IAttributeHolder
        {
            get { return this; }
        }

        IList< T > IAttributeHolder.All<T>()
        {
            return _attributes.OfType< T >().ToList();
        }

        void IAttributeHolder.AddAttribute( IAttribute attribute )
        {
            Debug.Assert.That( attribute.Holder == null, "Attribute already belongs to other holder" );
            _attributes.Add( attribute );
            attribute.Holder = this;
        }

        T IAttributeHolder.AddAttribute<T>()
        {
            var a = new T();
            IAttributeHolder.AddAttribute( a );
            return a;
        }

        T IAttributeHolder.GetAttribute<T>()
        {
            Debug.Assert.That( IAttributeHolder.HasAttribute< T >(), "Attribute '{0}' is not found", typeof( T ).Name );
            return _attributes.OfType< T >().First();
        }

        bool IAttributeHolder.HasAttribute<T>()
        {
            return _attributes.OfType< T >().Any();
        }

        void IAttributeHolder.SetAttributeTo<T, TV>( Action< T, TV > setter, TV value )
        {
            var attr = GetOrAdd< T >();
            setter( attr, value );
        }

        #endregion
    }
}