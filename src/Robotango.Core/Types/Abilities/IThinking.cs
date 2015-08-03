// Robotango (c) 2015 Krokodev
// Robotango.Core
// IThinking.cs

using System;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Types.Abilities
{
    public interface IThinking : IAbility, IVerifiable, IResearchable
    {
        void Think();
        void Believes( Action< IReality > belief );
        IReality Imaginary { get; }
    }
}