// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types.Domain.Abilities;
using Robotango.Core.Types.Domain.Agency;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Domain.Communications
{
    internal struct Question<T> : IQuestion< T >
    {
        public ICommunicative Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}