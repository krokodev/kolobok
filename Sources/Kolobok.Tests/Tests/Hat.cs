using System;

namespace Kolobok.Tests
{
    public class Hat : IComposition
    {
        public Colors Color { get; set; }

        public enum Colors
        {
            Black,
            White,
            Unknown
        }

        public void Add( IComposition part )
        {
            throw new NotImplementedException();
        }

        public T Has<T>()
        {
            throw new NotImplementedException();
        }
    }
}