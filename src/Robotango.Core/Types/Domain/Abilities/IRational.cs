// Robotango (c) 2015 Krokodev
// Robotango.Core
// IRational.cs

using System;
using Robotango.Common.Types.Properties;
using Robotango.Core.Types.Domain.Agency;

namespace Robotango.Core.Types.Domain.Abilities
{
    public interface IRational : IAbility, IVerifiable, IResearchable
    {
        void Think();
        void Believes( Action< IReality > belief );
        IReality Imaginary { get; }
    }
}