// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IRational.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IRational : IAspect
    {
        void Think();
        void Believes( Action< IWorld > belief );
        IWorld Imaginary { get; }
    }
}