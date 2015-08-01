// Robotango (c) 2015 Krokodev
// Robotango.Core
// Social.cs

using System;
using Robotango.Core.Implements.Communications;
using Robotango.Core.Types.Agents;
using Robotango.Core.Types.Communications;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Compositions;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Implements.Skills
{
    internal class Social : ISocial, IComponent
    {
        #region IComponent

        void IComponent.Init( IComposition composition )
        {
            IRational = composition.GetComponent< IRational >( nullable : true );
        }

        IComponent IComponent.Clone()
        {
            return new Social();
        }

        #endregion


        #region ISocial

        IQuestion< T > ISocial.Ask<T>( Func< IReality, T > theme )
        {
            return new Question< T > {
                Querist = this,
                Essense = theme
            };
        }

        IAnswer< T > ISocial.Reply<T>( IQuestion< T > question )
        {
            return new Answer< T > {
                Question = question,
                Respondent = this,
                Result = ComputeAnswerResult( question ),
            };
        }

        #endregion


        #region Fields

        private IRational IRational { get; set; }

        #endregion


        #region Routines

        private IAnswerResult< T > ComputeAnswerResult<T>( IQuestion< T > question )
        {
            var result = new AnswerResult< T >();
            try {
                result.Value = question.Essense.Invoke( GetWorldForAnswer() );
                result.IsVaild = true;
            }
            catch( Exception exception ) {
                result.IsVaild = false;
                result.Exception = exception;
            }

            return result;
        }

        private IReality GetWorldForAnswer()
        {
            return IRational == null ? null : IRational.Imaginary;
        }

        #endregion
    }
}