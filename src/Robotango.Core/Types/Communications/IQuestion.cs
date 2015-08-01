// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Types.Communications
{
    public interface IQuestion<T>
    {
        ISocial Querist { get; set; }
        Func< IReality, T > Essense { get; set; }
    }
}