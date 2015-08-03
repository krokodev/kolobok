// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using System;
using System.Linq.Expressions;
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
                "[{0}] <{1}>",
                _sources,
                typeof( Intention ).Name
                );
        }

        #endregion


        #region Ctor

        public Intention( IReality context, IAgent holder, Expression< Func< IReality, bool > > predicateExpression )
        {
            _context = context;
            _holder = holder;
            _predicate = predicateExpression.Compile();
            _sources = predicateExpression.Body.ToString();
        }

        #endregion


        #region Fields

        private readonly IAgent _holder;
        private readonly Func< IReality, bool > _predicate;
        private readonly IReality _context;
        private readonly string _sources;

        #endregion
    }
}