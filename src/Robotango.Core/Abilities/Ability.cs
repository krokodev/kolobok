// Robotango (c) 2015 Krokodev
// Robotango.Core
// Ability.cs

using MoreLinq;
using Robotango.Common.Types.Compositions.Imp;
using Robotango.Common.Types.Types;
using Robotango.Common.Utils.Tools;
using Robotango.Core.System;

// Here: Ability

namespace Robotango.Core.Abilities
{
    internal abstract class Ability : Component, IAbility
    {
        #region Protected

        protected void DumpDependences( OutlineWriter wr )
        {
            if( IComponent.Dependences.Count == 0 ) {
                return;
            }
            wr.Append( " use:" );
            IComponent.Dependences.ForEach( d => wr.Append( " <{0}>", d.GetType().Name ) );
        }

        #endregion


        #region Overrides

        protected virtual void DumpAbilityContent( OutlineWriter wr ) {}
        protected virtual void Proceed( IReality reality ) {}

        #endregion


        #region IProceedable

        void IProceedable< IReality >.Proceed( IReality context )
        {
            Proceed( context );
        }

        #endregion


        #region IResearchable

        string IResearchable.Dump( int level )
        {
            var wr = new OutlineWriter( level );

            wr.Indent();
            wr.Append( "<{0}>", GetType().Name );
            wr.Level++;
            DumpDependences( wr );
            wr.Line();
            DumpAbilityContent( wr );
            return wr.ToString();
        }

        #endregion
    }
}