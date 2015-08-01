// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;

namespace Robotango.Core.Types.Skills
{
    public interface IRational : ISkill, IResearchable
    {
        void Think();
        void Believes( Action< IWorld > belief );
        IWorld Imaginary { get; }
    }
}