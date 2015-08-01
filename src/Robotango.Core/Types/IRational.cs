// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;

namespace Robotango.Core.Types
{
    public interface IRational : IAspect, IResearchable
    {
        void Think();
        void Believes( Action< IWorld > belief );
        IWorld Imaginary { get; }
    }
}