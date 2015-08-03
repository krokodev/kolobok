// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Purposful;

namespace Robotango.Core.Implements.Elements.Purposeful
{
    internal class Intention : IIntention
    {
        #region IIntention

        IReality IIntention.Context
        {
            get { return _context; }
        }

        bool IIntention.IsSatisfied
        {
            get { return _predicate( _context ); }
        }

        IAgent IIntention.Holder
        {
            get { return _holder; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "[Holder:{0};Context:{1}] <{2}>",
                _holder.Name,
                _context.FamilyName,
                typeof( Intention ).Name
                );
        }

        #endregion


        #region Ctor

        public Intention( IReality context, IAgent holder, Func< IReality, bool > predicate )
        {
            _context = context;
            _holder = holder;
            _predicate = predicate;
        }

        #endregion


        #region Fields

        private readonly IAgent _holder;
        private readonly Func< IReality, bool > _predicate;
        private readonly IReality _context;

        #endregion
    }
}