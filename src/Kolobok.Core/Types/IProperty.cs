// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IProperty.cs

namespace Kolobok.Core.Types
{
    public interface IProperty
    {
        IProperty Clone();
        IOwner Owner { get; set; }
    }
}