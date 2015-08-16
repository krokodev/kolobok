// Robotango (c) 2015 Krokodev
// Robotango.Core
// Desire.cs

using Robotango.Common.Domain.Types;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Desirous.Imp
{
    public abstract class Desire<T> : IDesire
    {
        #region Data

        private readonly IDesireModel< T > _model;
        private readonly IAgent _subject;
        private readonly T _arg;

        #endregion


        #region Ctor

        protected Desire( IDesireModel< T > model, IAgent subject = null, T arg = default(T) )
        {
            _model = model;
            _subject = subject;
            _arg = arg;
        }

        #endregion


        #region IDesire

        bool IDesire.IsSatisfiedIn( IReality reality )
        {
            return _model.Predicate( reality, _subject, _arg );
        }

        IAgent IDesire.Subject
        {
            get { return _subject; }
        }

        object IDesire.Arg
        {
            get { return _arg; }
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level,
                "{0}({1},{2} {3}) <{4}>",
                _model.Name,
                _subject == null ? null : _subject.Name,
                typeof( T ).Name,
                _arg,
                GetType().Name
                );
        }

        #endregion
    }
}