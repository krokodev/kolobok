// Robotango (c) 2015 Krokodev
// Robotango.Core
// IQuestion.cs

using System;

namespace Robotango.Core.Types
{
    public interface IQuestion<T>
    {
        ISocial Querist { get; set; }
        Func< IWorld, T > Essense { get; set; }
    }
}