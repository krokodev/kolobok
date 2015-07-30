// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// AnswerResult.cs

using System;
using Kolobok.Core.Types;

namespace Kolobok.Core.Enteties
{
    internal class AnswerResult<T> : IAnswerResult< T >
    {
        public T Value { get; set; }
        public bool IsVaild { get; set; }
        public Exception Exception { get; set; }
    }
}