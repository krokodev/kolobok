// Robotango (c) 2015 Krokodev
// Robotango.Core
// IIdentifiable.cs

using System;

namespace Robotango.Core.Types.Common
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}