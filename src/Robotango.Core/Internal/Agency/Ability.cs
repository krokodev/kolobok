// Robotango (c) 2015 Krokodev
// Robotango.Core
// Ability.cs

using MoreLinq;
using Robotango.Common.Domain.Implements.Compositions;
using Robotango.Common.Domain.Types.Properties;
using Robotango.Common.Utils.Tools;
using Robotango.Core.Interfaces.Agency;

// Here: Ability

namespace Robotango.Core.Internal.Agency
{
    internal abstract class Ability : Component, IAbility
    {
        #region Protected

        protected void DumpDependences( OutlineWriter wr )
        {
            if( IComponent.Dependences.Count == 0 ) {
                return;
            }
            wr.Indent();
            wr.Append( "Dependences:", GetType().Name );
            IComponent.Dependences.ForEach( d => wr.Append( " <{0}>", d.GetType().Name ) );
            wr.Line();
        }

        #endregion


        #region Overrides

        protected virtual void DumpAbilityContent( OutlineWriter wr ) {}

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality context ) {}

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );

            wr.Line( "<{0}>", GetType().Name );
            wr.Level++;
            DumpDependences( wr );
            DumpAbilityContent( wr );
            return wr.ToString();
        }

        #endregion
    }
}