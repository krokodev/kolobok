// Robotango (c) 2015 Krokodev
// Robotango.Core
// Active.cs

using System;
using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;
using Robotango.Core.Internal.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Active : Component< Active >, IActive, IResearchable
    {
        #region IActive

        IOperation IActive.CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg )
        {
            return new Operation< T >( (IAgent)IComponent.Holder, action, operand, arg );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level, "<{0}>", typeof( Active ).Name );
        }

        #endregion
    }
}