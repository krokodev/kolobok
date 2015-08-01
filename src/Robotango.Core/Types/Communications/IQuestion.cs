// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Types.Communications
{
    public interface IQuestion<T>
    {
        ISocial Querist { get; set; }
        Func< IWorld, T > Essense { get; set; }
    }
}