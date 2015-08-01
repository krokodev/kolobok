// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Domain.Attributes;

namespace Robotango.Tests.Utils.Stuff
{
    public class Hat : IAttribute, IHat
    {
        #region IHat

        public IHat IHat
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

        IAttributeHolder IAttribute.Holder { get; set; }
    }

    #endregion
}