// Robotango (c) 2015 Krokodev
// Robotango.Core
// AnswerResult.cs

using System;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Implements.Domain.Communications
{
    internal class AnswerResult<T> : IAnswerResult< T >
    {
        public T Value { get; set; }
        public bool IsVaild { get; set; }
        public Exception Exception { get; set; }
    }
}