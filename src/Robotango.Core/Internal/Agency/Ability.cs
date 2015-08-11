// Robotango (c) 2015 Krokodev
// Robotango.Core
// Ability.cs

using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;

// Here: Ability

namespace Robotango.Core.Internal.Agency
{
    internal abstract class Ability : Component, IAbility
    {
        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality context ) {}

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            return OutlineWriter.Line( level, "<{0}>", typeof( Ability ).Name );
        }

        #endregion
    }
}