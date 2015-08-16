// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.System;

namespace Robotango.Core.Abilities.Communicative.Imp
{
    internal struct Question<T> : IQuestion< T >
    {
        public IQuerist Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}