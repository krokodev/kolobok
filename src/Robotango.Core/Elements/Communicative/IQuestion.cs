// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Abilities;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Communicative
{
    public interface IQuestion<out T>
    {
        IQuerist Querist { get; }
        Func< IReality, T > Essense { get; }
    }
}