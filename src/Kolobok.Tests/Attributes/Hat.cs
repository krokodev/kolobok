// Kolobok (c) 2015 Krokodev
// Kolobok.Tests
// Hat.cs

using Kolobok.Core.Types;

namespace Kolobok.Attributes
{
    public class Hat : IAttribute, IHat
    {
        #region IHat

        private IHat IHat
        {
            get { return this; }
        }

        Colors IColored.Color { get; set; }

        #endregion


        #region IProperty

        IAttribute IAttribute.Clone()
        {
            var hat = new Hat();
            hat.IHat.Color = IHat.Color;
            return hat;
        }

        IEntity IAttribute.Entity { get; set; }
    }

    #endregion
}