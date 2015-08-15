// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desire.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Elements.Desirous
{
    internal class Desire : IDesire
    {
        #region IDesire

        bool IDesire.IsSatisfiedIn( IReality reality )
        {
            return _predicate( reality );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "'{0}' <{1}>",
                _name,
                typeof( Desire ).Name
                );
        }

        #endregion


        #region Ctor

        public Desire( Func< IReality, bool > predicate, string name )
        {
            _predicate = predicate;
            _name = name ?? Settings.Desires.Names.Default;
        }

        #endregion


        #region Data

        private readonly Func< IReality, bool > _predicate;
        private readonly string _name;

        #endregion
    }
}