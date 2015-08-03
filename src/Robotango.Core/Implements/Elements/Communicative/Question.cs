// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Elements.Communicative;

namespace Robotango.Core.Implements.Elements.Communicative
{
    internal struct Question<T> : IQuestion< T >
    {
        public IQuerist Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}