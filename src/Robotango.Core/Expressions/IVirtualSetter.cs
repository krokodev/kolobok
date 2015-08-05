// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtualSetter.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public interface IVirtualSetter
    {
        Action< IAgent > Position( ILocation location );
    }
}