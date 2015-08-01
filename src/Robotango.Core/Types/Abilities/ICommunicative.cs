// Robotango (c) 2015 Krokodev
// Robotango.Core
// ICommunicative.cs

using Robotango.Core.Types.Agency;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Types.Abilities
{
    public interface ICommunicative : IAbility, IRespondent, IQuerist
    {
    }
}