// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desire.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.System;

namespace Robotango.Core.Elements.Purposeful
{
    internal class Desire : IDesire
    {
        #region IDesire

        IReality IDesire.Context
        {
            get { return _context; }
        }

        bool IDesire.IsSatisfied()
        {
            return _predicate( _context );
        }

        IAgent IDesire.Holder
        {
            get { return _holder; }
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

        public Desire( IReality context, IAgent holder, Func< IReality, bool > predicate, string name )
        {
            _context = context;
            _holder = holder;
            _predicate = predicate;
            _name = name ?? Settings.Desires.Names.Default;
        }

        #endregion


        #region Fields

        private readonly IAgent _holder;
        private readonly Func< IReality, bool > _predicate;
        private readonly IReality _context;
        private readonly string _name;

        #endregion
    }
}