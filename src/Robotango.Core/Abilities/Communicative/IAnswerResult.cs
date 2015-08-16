// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswerResult.cs

using System;

namespace Robotango.Core.Abilities.Communicative
{
    public interface IAnswerResult<out T>
    {
        T Value { get; }
        bool IsVaild { get; }
        Exception Exception { get; }
    }
}