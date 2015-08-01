// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Communications;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Implements.Communications
{
    internal struct Question<T> : IQuestion< T >
    {
        public ISocial Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}