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
using Robotango.Core.Elements.Purposeful;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Purposeful : IPurposeful, IResearchable
    {
        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Purposeful();
        }

        void IComponent.InitReferences( IComposite composition )
        {
            _agent = ( IAgent ) composition;
            _thinking = composition.GetComponent< IThinking >();
            Debug.Assert.That( _thinking != null, new MissedComponentException( typeof( IThinking ) ) );
        }

        #endregion


        #region IPurposeful

        IDesire IPurposeful.AddDesire( Func< IReality, bool > predicate, string name )
        {
            var desire = new Desire( _thinking.InnerReality, _agent, predicate, name );
            _desires.Add( desire );
            return desire;
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );
            wr.Line( "<{0}>", typeof( Purposeful ).Name );
            wr.Level ++;
            wr.Line( "Desires" );
            _desires.ForEach( i => wr.Append( i.Dump( wr.Level + 1 ) ) );
            return wr.ToString();
        }

        #endregion


        #region Fields

        private IThinking _thinking;
        private IAgent _agent;
        private readonly List< IDesire > _desires = new List< IDesire >();

        #endregion
    }
}