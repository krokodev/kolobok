// Robotango (c) 2015 Krokodev
// Robotango.Core
// Purposeful.cs

using System;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Common.Utils.Diagnostics.Debug;
using Robotango.Common.Utils.Diagnostics.Exceptions;
using Robotango.Core.Implements.Elements.Purposeful;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Purposful;

namespace Robotango.Core.Implements.Abilities
{
    internal class Purposeful : IPurposeful
    {
        #region IComponent

        IComponent IComponent.Clone()
        {
            return new Purposeful();
        }

        void IComponent.Init( IComposite composition )
        {
            IRational = composition.GetComponent< IRational >();
            Debug.Assert.That( IRational != null, new MissedComponentException( typeof( IRational ) ) );
        }

        #endregion


        #region IPurposeful

        IDesire IPurposeful.AddDesire( Func< IReality, bool > goal )
        {
            return new Desire();
        }

        #endregion


        #region Fields

        private IRational IRational { get; set; }

        #endregion
    }
}