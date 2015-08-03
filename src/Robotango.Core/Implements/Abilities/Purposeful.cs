// Robotango (c) 2015 Krokodev
// Robotango.Core
// Purposeful.cs

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Implements.Elements.Purposeful;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Purposful;

namespace Robotango.Core.Implements.Abilities
{
    internal class Purposeful : IPurposeful, IResearchable
    {
        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Purposeful();
        }

        void IComponent.Init( IComposite composition )
        {
            _agent = ( IAgent ) composition;
            _thinking = composition.GetComponent< IThinking >();
            Debug.Assert.That( _thinking != null, new MissedComponentException( typeof( IThinking ) ) );
        }

        #endregion


        #region IPurposeful

        IIntention IPurposeful.AddIntention( Expression< Func< IReality, bool > > predicate )
        {
            var intention = new Intention( _thinking.Imagination, _agent, predicate );
            _intentions.Add( intention );
            return intention;
        }

        #endregion


        #region Fields

        private IThinking _thinking;
        private IAgent _agent;
        private readonly List< IIntention > _intentions = new List< IIntention >();

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Purposeful ).Name );
            _intentions.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion
    }
}