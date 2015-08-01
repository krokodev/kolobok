// Robotango (c) 2015 Krokodev
// Robotango.Common
// IIdentifiable.cs

using System;

namespace Robotango.Common.Domain.Types.Properties
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}