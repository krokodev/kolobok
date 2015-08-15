// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Abilities;
using Robotango.Core.Agency;

namespace Robotango.Core.Elements.Communicative
{
    internal struct Question<T> : IQuestion< T >
    {
        public IQuerist Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}