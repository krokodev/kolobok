// Robotango (c) 2015 Krokodev
// Robotango.Core
// Attribute.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Types.Domain.Virtuals;

namespace Robotango.Core.Implements.Domain.Virtuals
{
    public abstract class Attribute<T> : IAttribute
        where T : IAttribute, new()
    {
        #region IAttribute

        IAttributeHolder IAttribute.Holder { get; set; }

        IAttribute IAttribute.Clone()
        {
            return Clone();
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return Dump( level );
        }

        #endregion


        #region Overrides

        protected virtual string Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "{0}=[{2}] <{1}>", typeof( T ).Name, typeof( Attribute< T > ).Name, GetDumpContent() );
            return wr.ToString();
        }

        protected virtual IAttribute Clone()
        {
            return new T();
        }

        protected virtual string GetDumpContent()
        {
            return "";
        }

        #endregion
    }
}