// Robotango (c) 2015 Krokodev
// Robotango.Core
// Ability.cs

using System;
using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Agency
{
    internal abstract class Ability<T> : Component< T >, IAbility
        where T : IAbility, new()
    {
        void IProceedable< IReality >.Proceed( IReality context )
        {
            throw new NotImplementedException();
        }

        string IResearchable.Dump( int level )
        {
            throw new NotImplementedException();
        }
    }
}