// Robotango (c) 2015 Krokodev
// Robotango.Core
// AnswerResult.cs

using System;
using Robotango.Core.Types;

namespace Robotango.Core.Implementations
{
    internal class AnswerResult<T> : IAnswerResult< T >
    {
        public T Value { get; set; }
        public bool IsVaild { get; set; }
        public Exception Exception { get; set; }
    }
}