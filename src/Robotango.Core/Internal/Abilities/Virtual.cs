// Robotango (c) 2015 Krokodev
// Robotango.Core
// Virtual.cs

using System;
using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Virtual;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Internal.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Virtual : Ability, IVirtual
    {
        #region Fields

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
            return new Virtual {
                _attributes = _attributes.Select( p => p.Clone() ).ToList()
            };
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Virtual ).Name );
            _attributes.ForEach( a => wr.Append( a.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
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