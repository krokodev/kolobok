using System;
using Robotango.Core;
using Robotango.Core.Types.Agency;

namespace Robotango.Tests.Cases.Complex
{
    public interface IPurposeful : IAbility{
        IDesire  Desires( Func< IReality, bool > goal );
    }
}