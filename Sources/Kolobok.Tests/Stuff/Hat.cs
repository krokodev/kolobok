// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Hat.cs

using Kolobok.Core.Types;

namespace Kolobok.Stuff
{
    public class Hat : IProperty, IHat
    {
        #region IHat

        public IHat IHat
        {
            get { return this; }
        }

        Colors IColored.Color { get; set; }

        #endregion



        #region IProperty

        IProperty IProperty.Clone()
        {
            var hat = new Hat();
            hat.IHat.Color = IHat.Color;
            return hat;
        }
    }

    #endregion
}