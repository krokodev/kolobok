// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Domain.Communications
{
    public interface IQuestion<T>
    {
        IQuerist Querist { get; set; }
        Func< IReality, T > Essense { get; set; }
    }
}