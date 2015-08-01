// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Common;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Types.Components
{
    public interface IRational : IComponent, IVerifiable, IResearchable
    {
        void Think();
        void Believes( Action< IReality > belief );
        IReality Imaginary { get; }
    }
}