// Robotango (c) 2015 Krokodev
// Robotango.Core
// IAnswerResult.cs

using System;

namespace Robotango.Core.Types
{
    public interface IAnswerResult<T>
    {
        T Value { get; set; }
        bool IsVaild { get; set; }
        Exception Exception { get; set; }
    }
}