// Robotango (c) 2015 Krokodev
// Robotango.Core
// Virtual.cs

using System.Collections.Generic;
using System.Linq;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Elements.Virtual;

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

        private IAttributeHolder IAttributeHolder
        {
            get { return this; }
        }

        void IAttributeHolder.Add( IAttribute attribute )
        {
            Debug.Assert.That( attribute.Holder == null, "Attribute already belongs to other entity" );
            _attributes.Add( attribute );
            attribute.Holder = this;
        }

        T IAttributeHolder.Add<T>()
        {
            var a = new T();
            IAttributeHolder.Add( a );
            return a;
        }

        T IAttributeHolder.GetFirst<T>()
        {
            Debug.Assert.That( _attributes.OfType< T >().Any(), "Attribute '{0}' not found", typeof( T ).Name );
            return _attributes.OfType< T >().First();
        }

        #endregion


        #region Fields

        private List< IAttribute > _attributes = new List< IAttribute >();

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
    }
}