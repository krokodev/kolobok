// Robotango (c) 2015 Krokodev
// Robotango.Core
// Position.cs

using Robotango.Common.Domain.Types.Properties;
using Robotango.Core.Types.Domain.Virtuals;

namespace Robotango.Core.Implements.Domain.Virtuals
{
    public class Position : Attribute< Position >, IPosition
    {
        #region IPosition

        public IPosition IPosition
        {
            get { return this; }
        }

        ILocation IPosition.Location { get; set; }

        #endregion


        #region Ctor

        public Position( ILocation location )
        {
            IPosition.Location = location;
        }

        public Position() {}

        #endregion


        #region Overrides

        protected override string GetDumpContent()
        {
            return string.Format( "Location:{0}", IPosition.Location.Name );
        }

        #endregion
    }
}