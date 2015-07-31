// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// IAttribute.cs

namespace Kolobok.Core.Types
{
    public interface IAttribute
    {
        IAttribute Clone();
        IEntity Entity { get; set; }
    }
}