using System;
using Robotango.Core.Implements.Elements.Virtual;
using Robotango.Core.Types.Agency;

namespace Robotango.Core.Expressions
{
    public interface IVirtualExecutor {
        Action< IAgent > Position( Location location );
    }
}