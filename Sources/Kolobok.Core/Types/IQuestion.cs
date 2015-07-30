// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IQuestion.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IQuestion<T> {
        ISocial Querist { get; set; }
        Func< IWorld, T > Essense { get; set; }
    }
}