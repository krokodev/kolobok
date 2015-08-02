﻿// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Hat.cs

using Robotango.Common.Domain.Types.Enums;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Implements.Domain.Virtuals;
using Robotango.Core.Types.Domain.Virtuals;

namespace Robotango.Tests.Domain
{
    public class Hat : Attribute< Hat >, IHat
    {
        #region IHat

        public IHat IHat
        {
            get { return this; }
        }

        Colors IColored.Color { get; set; }

        #endregion


        #region Attribute

        protected override string GetDumpContent()
        {
            return string.Format( "Color:{0}", IHat.Color );
        }

        protected override IAttribute Clone()
        {
            var hat = new Hat();
            hat.IHat.Color = IHat.Color;
            return hat;
        }

        #endregion
    }
}