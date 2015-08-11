// Robotango (c) 2015 Krokodev
// Robotango.Core
// IActive.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Interfaces.Abilities
{
    public interface IActive : IAbility
    {
        IOperation CreateOperation<T>( Action< IAgent, T > action, IAgent operand, T arg );
    }
}