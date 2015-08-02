// Robotango (c) 2015 Krokodev
// Robotango.Core
// IWorld.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Abilities;

namespace Robotango.Core.Types.Agency
{
    public interface IWorld : INamed, IResearchable
    {
        IReality Reality { get; }
        IRational Rational { get; }
    }
}