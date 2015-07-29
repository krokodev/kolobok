using System;
using Kolobok.Core.Types;

namespace Kolobok.Stuff
{
    public class Hat : IComposition
    {
        public Colors Color { get; set; }

        public enum Colors
        {
            Unknown,
            Black,
            White,
            Red
        }

        public void Has( IComposition part )
        {
            throw new NotImplementedException();
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}