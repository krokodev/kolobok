// Robotango (c) 2015 Krokodev
// Robotango.Core
// Attribute.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Types.Domain.Attributes;

namespace Robotango.Core.Implements.Domain.Attributes
{
    public abstract class Attribute<T> : IAttribute
    {
        #region IAttribute

        IAttributeHolder IAttribute.Holder { get; set; }
        IAttribute IAttribute.Clone()
        {
            return Clone();
        }

        #endregion

        #region IResearchable

        string IResearchable.GetDump( int level )
        {
            return GetDump( level );
        }

        #endregion


        #region Overrides

        protected virtual string GetDump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0}=[{2}] <{1}>", typeof( T ).Name, typeof( Attribute< T > ).Name, GetContent() );
            return wr.ToString();
        }


        protected abstract IAttribute Clone();

        protected virtual string GetContent()
        {
            return "";
        }

        #endregion

    }
}