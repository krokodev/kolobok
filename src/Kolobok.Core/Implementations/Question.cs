// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Question.cs

using System;
using Kolobok.Core.Types;

namespace Kolobok.Core.Implementations
{
    internal struct Question<T> : IQuestion< T >
    {
        public ISocial Querist { get; set; }
        public Func< IWorld, T > Essense { get; set; }
    }
}