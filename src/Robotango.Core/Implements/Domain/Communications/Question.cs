// Robotango (c) 2015 Krokodev
// Robotango.Core
// Question.cs

using System;
using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Implements.Domain.Communications
{
    internal struct Question<T> : IQuestion< T >
    {
        public IQuerist Querist { get; set; }
        public Func< IReality, T > Essense { get; set; }
    }
}