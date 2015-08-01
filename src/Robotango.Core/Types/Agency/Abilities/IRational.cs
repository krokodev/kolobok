// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;
using Robotango.Common.Types.Properties;

namespace Robotango.Core.Types.Agency.Abilities
{
    public interface IRational : IAbility, IVerifiable, IResearchable
    {
        void Think();
        void Believes( Action< IReality > belief );
        IReality Imaginary { get; }
    }
}