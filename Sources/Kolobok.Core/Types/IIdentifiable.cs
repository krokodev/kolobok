// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IIdentifiable.cs

using System;

namespace Kolobok.Core.Types
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}