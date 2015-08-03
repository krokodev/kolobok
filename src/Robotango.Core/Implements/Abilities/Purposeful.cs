// Robotango (c) 2015 Krokodev
// Robotango.Core
// Purposeful.cs

using System;
using System.Collections.Generic;
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
            IAgent = (IAgent)composition;
            IThinking = composition.GetComponent< IThinking >();
            Debug.Assert.That( IThinking != null, new MissedComponentException( typeof( IThinking ) ) );
        }

        #endregion


        #region IPurposeful

        IIntention IPurposeful.AddDesire( Func< IReality, bool > condition )
        {
            var desire = new Intention (IThinking.Imaginary, IAgent, condition);
            _desires.Add( desire );
            return desire;
        }

        #endregion


        #region Fields

        private IThinking IThinking { get; set; }
        private readonly List< IIntention > _desires = new List< IIntention >();
        private IAgent IAgent;

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Purposeful ).Name );
            _desires.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion
    }
}