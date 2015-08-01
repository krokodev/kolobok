// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types;

namespace Robotango.Core.Implementations
{
    internal struct Question<T> : IQuestion< T >
    {
        public ISocial Querist { get; set; }
        public Func< IWorld, T > Essense { get; set; }
    }
}