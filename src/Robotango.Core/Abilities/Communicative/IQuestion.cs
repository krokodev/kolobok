// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Communicative
{
    public interface IQuestion<out T>
    {
        IQuerist Querist { get; }
        Func< IReality, T > Essense { get; }
    }
}