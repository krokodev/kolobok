// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Core.Types.Domain.Communications
{
    public interface IQuestion<T>
    {
        ICommunicative Querist { get; set; }
        Func< IReality, T > Essense { get; set; }
    }
}