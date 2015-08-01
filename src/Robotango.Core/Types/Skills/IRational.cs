// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;
using Robotango.Core.Types.Agents;

namespace Robotango.Core.Types.Skills
{
    public interface IRational : ISkill, IResearchable
    {
        void Think();
        void Believes( Action< IReality > belief );
        IReality Imaginary { get; }
    }
}