// Robotango (c) 2015 Krokodev
// Robotango.Tests
// Location.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Implements.Domain.Attributes;

namespace Robotango.Tests.Utils.Stuff
{
    public class Location : Attribute< Location >, ILocation
    {
        #region ILocation

        public ILocation ILocation
        {
            get { return this; }
        }

        #endregion

        #region INamed

        private INamed INamed
        {
            get { return this; }
        }

        string INamed.Name { get; set; }

        #endregion


        #region Ctor

        public Location() {}

        public Location( string name )
        {
            INamed.Name = name;
        }

        #endregion


        #region Overrides

        protected override string GetContent()
        {
            return ILocation.Name;
        }

        #endregion
    }
}