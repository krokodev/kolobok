// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAnswerResult.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IAnswerResult<T>
    {
        T Value { get; set; }
        bool IsVaild { get; set; }
        Exception Exception { get; set; }
    }
}