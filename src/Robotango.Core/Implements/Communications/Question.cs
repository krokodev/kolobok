// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Agency.Abilities;
using Robotango.Core.Types.Communications;

namespace Robotango.Core.Implements.Communications
{
    internal struct Question<T> : IQuestion< T >
    {
        public ICommunicative Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}