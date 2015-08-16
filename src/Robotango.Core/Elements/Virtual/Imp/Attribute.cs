// Robotango (c) 2015 Krokodev
// Robotango.Core
// Attribute.cs

using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;

namespace Robotango.Core.Elements.Virtual.Imp
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
            return OutlineWriter.Line(
                level,
                "{0}=[{2}] <{1}>",
                typeof( T ).Name,
                typeof( Attribute< T > ).Name,
                GetDumpContent() );
        }

        #endregion


        #region Overrides

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