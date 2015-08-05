// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtualGetter.cs

using System;
using Robotango.Common.Domain.Implements.Expressions;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public interface IVirtualAccessor
    {
        Common.Domain.Implements.Expressions.PropertyAccessor< IAgent, IPosition > Position { get; }
    }
}