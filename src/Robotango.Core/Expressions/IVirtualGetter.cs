// Robotango (c) 2015 Krokodev
// Robotango.Core
// IVirtualGetter.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Virtual;

namespace Robotango.Core.Expressions
{
    public interface IVirtualGetter
    {
        Func< IAgent, IPosition > Position { get; }
    }
}