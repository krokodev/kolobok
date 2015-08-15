// Robotango (c) 2015 Krokodev
// Robotango.Core
// IBelief.cs

using System;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Thinking
{
    public interface IBelief
    {
        Action< IReality > Essence { get; }
    }
}