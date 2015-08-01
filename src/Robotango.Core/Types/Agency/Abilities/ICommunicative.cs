// Robotango (c) 2015 Krokodev
// Robotango.Core
// ICommunicative.cs

using System;
using Robotango.Core.Types.Domain.Communications;

namespace Robotango.Core.Types.Agency.Abilities
{
    public interface ICommunicative : IAbility, IRespondent, IQuerist
    {
    }
}