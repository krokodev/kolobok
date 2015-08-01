// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Agency.Abilities;

namespace Robotango.Core.Types.Communications
{
    public interface IQuestion<T>
    {
        IQuerist Querist { get; set; }
        Func< IReality, T > Essense { get; set; }
    }
}