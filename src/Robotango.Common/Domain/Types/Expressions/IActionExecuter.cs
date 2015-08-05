// Robotango (c) 2015 Krokodev
// Robotango.Common
// IActionExecuter.cs

using System;

namespace Robotango.Common.Domain.Types.Expressions
{
    public interface IActionExecuter<out T>
    {
        IActionExecuter< T > Do( Action< T > action );
    }
}