// Kolobok (c) 2015 Krokodev
// Kolobok.Core
// Social.cs

using System;
using Kolobok.Core.Diagnostics;
using Kolobok.Core.Types;

namespace Kolobok.Core.Enteties
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

        IQuestion< T > ISocial.Ask<T>( Func< IWorld, T > theme )
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

        private IWorld GetWorldForAnswer()
        {
            return IRational == null ? null : IRational.Imaginary;
        }

        #endregion
    }
}