// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Communicative
{
    public interface IQuestion<T>
    {
        IQuerist Querist { get; set; }
        Func< IReality, T > Essense { get; set; }
    }
}