// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswerResult.cs

using System;

namespace Robotango.Core.Types.Elements.Communicative
{
    public interface IAnswerResult<T>
    {
        T Value { get; set; }
        bool IsVaild { get; set; }
        Exception Exception { get; set; }
    }
}